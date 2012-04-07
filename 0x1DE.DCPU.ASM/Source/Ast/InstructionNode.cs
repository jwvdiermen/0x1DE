using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Irony.Ast;
using Irony.Parsing;

namespace OxIDE.DCPU.ASM.Ast
{
	/// <summary>
	/// The instruction AST node.
	/// </summary>
	public class InstructionNode : DefaultNode, IContainsLabelAndInstruction
	{
		#region Properties

		/// <summary>
		/// Gets the opcode represented as a string.
		/// </summary>
		public string Opcode
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets the values contained by this node.
		/// </summary>
		public IEnumerable<ValueNode> Values
		{
			get { return this.ChildNodes.Select(e => (ValueNode)e); }
		}

		#endregion

		#region Methods

		public override void Init(AstContext context, ParseTreeNode treeNode)
		{
			base.Init(context, treeNode);

			var nodes = treeNode.GetMappedChildNodes();
			this.Opcode = nodes[0].FindTokenAndGetText().ToUpper();

			foreach (var node in nodes[1].ChildNodes.Where(e => e.AstNode is ValueNode))
			{
				AddChild(String.Empty, node);
			}

			// Make a nice display name.
			this.AsString = "Instruction: " + this.Opcode;
		}

		#endregion

		#region IContainsLabelAndInstruction Members

		public string Label
		{
			get { return null; }
		}

		public InstructionNode Instruction
		{
			get { return this; }
		}

		#endregion
	}
}
