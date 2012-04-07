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
	/// The label AST node.
	/// </summary>
	public class LabelNode : DefaultNode, IContainsLabelAndInstruction
	{
		#region Properties
		#endregion

		#region Methods

		public override void Init(AstContext context, ParseTreeNode treeNode)
		{
			base.Init(context, treeNode);

			var nodes = treeNode.GetMappedChildNodes();
			this.Label = nodes[0].FindTokenAndGetText();

			// Make a nice display name.
			this.AsString = "Label: " + this.Label;
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
			get { return null; }
		}

		#endregion
	}
}
