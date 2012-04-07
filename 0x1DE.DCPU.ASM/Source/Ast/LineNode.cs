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
	/// The line AST node.
	/// </summary>
	public class LineNode : DefaultNode
	{
		#region Properties

		/// <summary>
		/// Gets the label associated with the line.
		/// </summary>
		public string Label
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets the label instruction with the line.
		/// </summary>
		public InstructionNode Instruction
		{
			get;
			private set;
		}

		#endregion

		#region Methods

		public override void Init(AstContext context, ParseTreeNode treeNode)
		{
			base.Init(context, treeNode);

			var nodes = treeNode.GetMappedChildNodes();
			var astNode = nodes[0].AstNode as IContainsLabelAndInstruction;
			AddChild(String.Empty, nodes[0]);

			this.Label = astNode.Label;
			this.Instruction = astNode.Instruction;

			// Make a nice display name.
			this.AsString = "Line";
			if (ChildNodes.Count == 0)
			{
				this.AsString += " (Empty)";
			}
		}

		#endregion
	}
}
