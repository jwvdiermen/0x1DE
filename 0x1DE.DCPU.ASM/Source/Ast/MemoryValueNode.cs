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
	/// The memory value AST node.
	/// </summary>
	public class MemoryValueNode : ValueNode
	{
		#region Properties
		#endregion

		#region Methods

		public override void Init(AstContext context, ParseTreeNode treeNode)
		{
			base.Init(context, treeNode);

			var node = treeNode.GetMappedChildNodes()[0];
			var valueNode = (ValueNode)node.AstNode;
			var value = valueNode.Value;

			if (value <= 0x07)
			{
				this.Value = this.OriginalValue = (ushort)(value + 0x08);
			}
			else if (value == 0x1F || (value >= 0x20 && value <= 0x3F))
			{
				this.Value = 0x1E;
				this.OriginalValue = this.NextWord = valueNode.OriginalValue;
			}
			else
			{
				throw new Exception("Invalid token '" + node.Token.Text + "'.");
			}
		}

		#endregion
	}
}
