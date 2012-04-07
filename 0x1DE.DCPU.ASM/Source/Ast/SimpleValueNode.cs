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
	/// The simple value AST node.
	/// </summary>
	public class SimpleValueNode : ValueNode
	{
		#region Fields

		private static Dictionary<string, ushort> ms_valueLookup = new Dictionary<string, ushort>()
		{
			{ "A", 0x00 },
			{ "B", 0x01 },
			{ "C", 0x02 },
			{ "X", 0x03 },
			{ "Y", 0x04 },
			{ "Z", 0x05 },
			{ "I", 0x06 },
			{ "J", 0x07 },
			{ "POP", 0x18 },
			{ "PEEK", 0x19 },
			{ "PUSH", 0x1A },
			{ "SP", 0x1B },
			{ "PC", 0x1C },
			{ "O", 0x1D }
		};

		#endregion

		#region Methods

		public override void Init(AstContext context, ParseTreeNode treeNode)
		{
			base.Init(context, treeNode);

			var node = treeNode.GetMappedChildNodes()[0];
			if (node.Term.Name == "NumberLiteral")
			{
				var value = Convert.ToInt32(node.Token.Value);

				this.OriginalValue = (ushort)value;
				if (value <= 0x3F)
				{
					this.Value = (ushort)(value + 0x20);
				}
				else
				{
					this.Value = 0x1F;
					this.NextWord = (ushort)value;
				}
			}
			else if (node.Term.Name == "StringLiteral")
			{
				this.String = node.Token.ValueString;
			}
			else
			{
				this.OriginalValue = this.Value = ms_valueLookup[node.Term.Name.ToUpper()];
			}
		}

		#endregion
	}
}
