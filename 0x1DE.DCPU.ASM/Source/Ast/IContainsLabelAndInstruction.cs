using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OxIDE.DCPU.ASM.Ast
{
	/// <summary>
	/// Used on the Label, Instruction and InstructionWithLabel nodes to expose
	/// their contents.
	/// </summary>
	public interface IContainsLabelAndInstruction
	{
		#region Properties

		/// <summary>
		/// Gets the label associated with the line.
		/// </summary>
		string Label
		{
			get;
		}

		/// <summary>
		/// Gets the label instruction with the line.
		/// </summary>
		InstructionNode Instruction
		{
			get;
		}

		#endregion
	}
}
