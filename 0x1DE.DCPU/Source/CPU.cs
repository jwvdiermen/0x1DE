using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OxIDE.DCPU
{
	/// <summary>
	/// An representation of the DCPU.
	/// </summary>
	public class CPU
	{
		#region Fields

		internal ushort m_registerA;
		internal ushort m_registerB;
		internal ushort m_registerC;
		internal ushort m_registerX;
		internal ushort m_registerY;
		internal ushort m_registerZ;
		internal ushort m_registerI;
		internal ushort m_registerJ;

		internal ushort m_stackPointer;
		internal ushort m_programCounter;
		internal ushort m_overflow;

		internal ushort[] m_memory = new ushort[0x10000];

		#endregion

		#region Properties

		/// <summary>
		/// Gets the A register.
		/// </summary>
		public ushort A
		{
			get { return m_registerA; }
		}

		/// <summary>
		/// Gets the B register.
		/// </summary>
		public ushort B
		{
			get { return m_registerA; }
		}

		/// <summary>
		/// Gets the C register.
		/// </summary>
		public ushort C
		{
			get { return m_registerA; }
		}

		/// <summary>
		/// Gets the X register.
		/// </summary>
		public ushort X
		{
			get { return m_registerA; }
		}

		/// <summary>
		/// Gets the Y register.
		/// </summary>
		public ushort Y
		{
			get { return m_registerA; }
		}

		/// <summary>
		/// Gets the Z register.
		/// </summary>
		public ushort Z
		{
			get { return m_registerA; }
		}

		/// <summary>
		/// Gets the I register.
		/// </summary>
		public ushort I
		{
			get { return m_registerA; }
		}

		/// <summary>
		/// Gets the J register.
		/// </summary>
		public ushort J
		{
			get { return m_registerA; }
		}

		/// <summary>
		/// Gets the stack pointer.
		/// </summary>
		public ushort StackPointer
		{
			get { return m_stackPointer; }
		}

		/// <summary>
		/// Gets the program counter.
		/// </summary>
		public ushort ProgramCounter
		{
			get { return m_programCounter; }
		}

		/// <summary>
		/// Gets the overflow.
		/// </summary>
		public ushort Overflow
		{
			get { return m_overflow; }
		}

		/// <summary>
		/// Gets if the CPU has been halted.
		/// </summary>
		public bool Halted
		{
			get;
			private set;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Returns the word at the given offset in memory.
		/// </summary>
		/// <param name="offset">The offset.</param>
		/// <returns>The word at the given offset in memory.</returns>
		public ushort ReadMemory(int offset)
		{
			return m_memory[offset];
		}

		/// <summary>
		/// Returns a range of words from the memory.
		/// </summary>
		/// <param name="offset">The offset in memory.</param>
		/// <param name="length">The number of words the read.</param>
		/// <returns>An array containing the words in memory.</returns>
		public ushort[] ReadMemory(int offset, int length)
		{
			if (offset + length >= m_memory.Length)
			{
				throw new ArgumentOutOfRangeException("The given offset and length are out of range.");
			}

			var buffer = new ushort[length];
			Array.Copy(m_memory, offset, buffer, 0, length);

			return buffer;
		}

		/// <summary>
		/// Reads a range of words from the memory into the supplied buffer.
		/// </summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="offset">The offset in memory.</param>
		/// <param name="length">The number of words the read.</param>
		public void ReadMemory(ushort[] buffer, int offset, int length)
		{
			if (length > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("The given length is longer than the supplied buffer.");
			}
			if (offset + length >= m_memory.Length)
			{
				throw new ArgumentOutOfRangeException("The given offset and length are out of range.");
			}

			Array.Copy(m_memory, offset, buffer, 0, length);
		}

		/// <summary>
		/// Reads a range of words from the memory into the supplied buffer.
		/// </summary>
		/// <param name="buffer">The buffer.</param>
		/// <param name="targetOffset">The offset in the buffer at which copying begins.</param>
		/// <param name="sourceOffset">The offset in memory at which copying begins.</param>
		/// <param name="length">The number of words to read.</param>
		public void ReadMemory(ushort[] buffer, int targetOffset, int sourceOffset, int length)
		{
			if (targetOffset + length > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("The given target offset and length is longer than the supplied buffer.");
			}
			if (sourceOffset + length >= m_memory.Length)
			{
				throw new ArgumentOutOfRangeException("The given source offset and length are out of range.");
			}

			Array.Copy(m_memory, sourceOffset, buffer, targetOffset, length);
		}

		/// <summary>
		/// Signals the CPU to halt operations.
		/// </summary>
		public void Halt()
		{
			this.Halted = true;
		}

		public override string ToString()
		{
			return ToString(false);
		}

		/// <summary>
		/// Returns a string that contains all the states of the CPU.
		/// </summary>
		/// <param name="printHeader">True to print the header.</param>
		/// <returns>A string that contains all the states of the CPU.</returns>
		public string ToString(bool printHeader)
		{
			var sb = new StringBuilder();
			if (printHeader)
			{
				sb.AppendLine("PC   SP   OV   A    B    C    X    Y    Z    I    J");
				sb.AppendLine("---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ----");
			}
			sb.AppendFormat("{0:x4} {1:x4} {2:x4} {3:x4} {4:x4} {5:x4} {6:x4} {7:x4} {8:x4} {9:x4} {10:x4}",
				ProgramCounter, StackPointer, Overflow, A, B, C, X, Y, Z, I, J);

			return sb.ToString();
		}

		#endregion
	}
}
