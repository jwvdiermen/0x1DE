using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OxIDE.DCPU
{
	/// <summary>
	/// Represents a disassembled <see cref="Program" />.
	/// </summary>
	public class Disassembler
	{
		#region Nested types

		/// <summary>
		/// Represents a single instruction.
		/// </summary>
		public struct Instruction
		{
			#region Fields

			/// <summary>
			/// The location in the program.
			/// </summary>
			public ushort Location;

			/// <summary>
			/// The basic opcode.
			/// </summary>
			public BasicOpcodes BasicOpcode;

			/// <summary>
			/// The extended opcode if applicable.
			/// </summary>
			public ExtendedOpcodes ExtendedOpcode;

			/// <summary>
			/// The left value.
			/// </summary>
			public Value Left;

			/// <summary>
			/// The right value.
			/// </summary>
			public Value Right;

			/// <summary>
			/// The original code.
			/// </summary>
			public ushort[] OriginalCode;

			#endregion

			#region Methods

			public override string ToString()
			{
				if (BasicOpcode == BasicOpcodes.NonBasic)
				{
					return String.Format("{0:x4}: {1,-3} {2}", Location, ExtendedOpcode, Left);
				}
				else
				{
					return String.Format("{0:x4}: {1,-3} {2}, {3}", Location, BasicOpcode, Left, Right);
				}
			}

			#endregion
		}

		/// <summary>
		/// Represents a value.
		/// </summary>
		public struct Value
		{
			#region Fields

			/// <summary>
			/// The value.
			/// </summary>
			public ushort Code;

			/// <summary>
			/// The next word if applicable.
			/// </summary>
			public ushort NextWord;

			#endregion

			#region Methods

			public override string ToString()
			{
				switch (Code)
				{
					case 0x00: return "A";
					case 0x01: return "B";
					case 0x02: return "C";
					case 0x03: return "X";
					case 0x04: return "Y";
					case 0x05: return "Z";
					case 0x06: return "I";
					case 0x07: return "J";

					case 0x08: return "[A]";
					case 0x09: return "[B]";
					case 0x0A: return "[C]";
					case 0x0B: return "[X]";
					case 0x0C: return "[Y]";
					case 0x0D: return "[Z]";
					case 0x0E: return "[I]";
					case 0x0F: return "[J]";

					case 0x10: return String.Format("[0x{0:x4} + A]", NextWord);
					case 0x11: return String.Format("[0x{0:x4} + B]", NextWord);
					case 0x12: return String.Format("[0x{0:x4} + C]", NextWord);
					case 0x13: return String.Format("[0x{0:x4} + X]", NextWord);
					case 0x14: return String.Format("[0x{0:x4} + Y]", NextWord);
					case 0x15: return String.Format("[0x{0:x4} + Z]", NextWord);
					case 0x16: return String.Format("[0x{0:x4} + I]", NextWord);
					case 0x17: return String.Format("[0x{0:x4} + J]", NextWord);

					case 0x18: return "POP";
					case 0x19: return "PEEK";
					case 0x1A: return "PUSH";
					case 0x1B: return "SP";
					case 0x1C: return "PC";
					case 0x1D: return "O";

					case 0x1E: return String.Format("[0x{0:x4}]", NextWord);
					case 0x1F: return String.Format("0x{0:x4}", NextWord);
					default: return String.Format("0x{0:x4}", Code - 0x20);
				}
			}

			#endregion
		}

		#endregion

		#region Constructors

		private Disassembler(List<Instruction> instructionList)
		{
			m_instructionList = instructionList;
		}

		#endregion

		#region Fields

		private List<Instruction> m_instructionList;

		#endregion

		#region Properties
		
		/// <summary>
		/// Gets an enumerable containing the instructions.
		/// </summary>
		public IEnumerable<Instruction> Instructions
		{
			get { return m_instructionList; }
		}

		#endregion

		#region Methods

		/// <summary>
		/// Disassembles the given program and returns the result.
		/// </summary>
		/// <param name="program">The program.</param>
		/// <returns>The disassembled program.</returns>
		public static Disassembler Create(Program program)
		{
			var instructions = new List<Instruction>();
			var buffer = program.Buffer;

			// Loop through all the code like the VM does.
			int counter = 0;
			while (counter < buffer.Length)
			{
				ushort location = (ushort)counter;

				int firstWord = buffer[counter++];
				if (firstWord == 0x0000) break;

				var basicOpcode = (BasicOpcodes)(firstWord & 0xF);

				var originalCode = new List<ushort>();
				originalCode.Add((ushort)firstWord);

				if (basicOpcode == BasicOpcodes.NonBasic)
				{
					var extendedOpcode = (ExtendedOpcodes)((firstWord >> 4) & 0x3F);

					int value = firstWord >> 10;
					ushort nextWord;
					ReadNextWord(buffer, value, out nextWord, originalCode, ref counter);

					instructions.Add(new Instruction
					{
						Location = location,
						BasicOpcode = basicOpcode,
						ExtendedOpcode = extendedOpcode,
						Left = new Value { Code = (ushort)value, NextWord = nextWord },
						OriginalCode = originalCode.ToArray()
					});
				}
				else
				{
					int leftValue = (firstWord >> 4) & 0x3F;
					ushort leftNextWord;
					ReadNextWord(buffer, leftValue, out leftNextWord, originalCode, ref counter);

					int rightValue = firstWord >> 10;
					ushort rightNextWord;
					ReadNextWord(buffer, rightValue, out rightNextWord, originalCode, ref counter);

					instructions.Add(new Instruction
					{
						Location = location,
						BasicOpcode = basicOpcode,
						Left = new Value { Code = (ushort)leftValue, NextWord = leftNextWord },
						Right = new Value { Code = (ushort)rightValue, NextWord = rightNextWord },
						OriginalCode = originalCode.ToArray()
					});
				}
			}

			return new Disassembler(instructions);
		}

		private static void ReadNextWord(ushort[] buffer, int value, out ushort nextWord, List<ushort> originalCode, ref int counter)
		{
			nextWord = 0;

			if ((value >= 0x10 && value <= 0x17) ||
				value == 0x1E || value == 0x1F)
			{
				nextWord = buffer[counter++];
				originalCode.Add(nextWord);
			}
		}

		#endregion
	}
}
