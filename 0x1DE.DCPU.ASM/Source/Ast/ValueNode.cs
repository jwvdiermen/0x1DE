using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Irony.Ast;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace OxIDE.DCPU.ASM.Ast
{
	/// <summary>
	/// The value AST node.
	/// </summary>
	public abstract class ValueNode : DefaultNode
	{
		#region Properties
		
		/// <summary>
		/// Gets the original value for use with the DAT instruction.
		/// </summary>
		public ushort OriginalValue
		{
			get;
			protected set;
		}

		/// <summary>
		/// Gets the value as used with instructions.
		/// </summary>
		public ushort Value
		{
			get;
			protected set;
		}

		/// <summary>
		/// Gets the "next word" value.
		/// </summary>
		public ushort NextWord
		{
			get;
			protected set;
		}

		/// <summary>
		/// Gets the value as a string for use with the DAT instruction.
		/// </summary>
		public string String
		{
			get;
			protected set;
		}

		/// <summary>
		/// Gets the label that will determine the value.
		/// </summary>
		public string Label
		{
			get;
			protected set;
		}

		#endregion
	}
}
