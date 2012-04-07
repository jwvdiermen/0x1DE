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
	public class MemoryOffsetValueNode : ValueNode
	{
		#region Fields

		private static Dictionary<string, ushort> ms_valueLookup = new Dictionary<string, ushort>()
		{
			{ "A", 0x10 },
			{ "B", 0x11 },
			{ "C", 0x12 },
			{ "X", 0x13 },
			{ "Y", 0x14 },
			{ "Z", 0x15 },
			{ "I", 0x16 },
			{ "J", 0x17 }
		};

		#endregion

		#region Methods

		public override void Init(AstContext context, ParseTreeNode treeNode)
		{
			base.Init(context, treeNode);

			var nodes = treeNode.GetMappedChildNodes();
			var numberNode = nodes[0];
			var registerNode = nodes[1];

			this.Value = ms_valueLookup[registerNode.Token.ValueString];
			this.NextWord = Convert.ToUInt16(numberNode.Token.Value);
		}

		#endregion
	}
}
