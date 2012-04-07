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
	/// The label value AST node.
	/// </summary>
	public class LabelValueNode : ValueNode
	{
		#region Methods

		public override void Init(AstContext context, ParseTreeNode treeNode)
		{
			base.Init(context, treeNode);

			var node = treeNode.GetMappedChildNodes()[0];
			this.Label = node.Token.ValueString;
		}

		#endregion
	}
}
