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
	/// The instruction and label AST node.
	/// </summary>
	public class InstructionWithLabelNode : DefaultNode, IContainsLabelAndInstruction
	{
		#region Properties
		#endregion

		#region Methods

		public override void Init(AstContext context, ParseTreeNode treeNode)
		{
			base.Init(context, treeNode);

			// Retrieve the necessary AST nodes.
			var nodes = treeNode.GetMappedChildNodes();
			this.Label = ((LabelNode)nodes[0].AstNode).Label;
			this.Instruction = (InstructionNode)nodes[1].AstNode;

			// Ensure the instruction node is in the AST tree.
			AddChild(String.Empty, nodes[1]);

			// Make a nice display name.
			this.AsString = "Label: " + this.Label + ", Instruction: " + this.Instruction.Opcode;
		}

		#endregion

		#region IContainsLabelAndInstruction Members

		public string Label
		{
			get;
			private set;
		}

		public InstructionNode Instruction
		{
			get;
			private set;
		}

		#endregion
	}
}
