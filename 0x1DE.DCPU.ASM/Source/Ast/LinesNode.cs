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
	/// The lines AST node.
	/// </summary>
	public class LinesNode : DefaultNode
	{
		#region Properties

		/// <summary>
		/// Gets the lines contained by this node.
		/// </summary>
		public IEnumerable<LineNode> Lines
		{
			get { return this.ChildNodes.Select(e => (LineNode)e); }
		}

		#endregion

		#region Methods

		public override void Init(AstContext context, ParseTreeNode treeNode)
		{
			base.Init(context, treeNode);

			var nodes = treeNode.GetMappedChildNodes();
			foreach (var node in nodes.Where(e => e.AstNode is LineNode))
			{
				AddChild(String.Empty, node);
			}

			// Make a nice display name.
			this.AsString = "Lines";
		}

		#endregion
	}
}
