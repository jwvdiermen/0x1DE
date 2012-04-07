using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

using Irony.Parsing;
using Irony.Interpreter.Ast;
using Irony.Interpreter;
using Irony.Ast;

namespace OxIDE.DCPU.ASM
{
	/// <summary>
	/// The grammar of the DCPU-ASM language.
	/// </summary>
	[Language("DCPU-ASM", "1.1", "Assembly grammar for the DCPU-16")]
	public class ASMGrammar : Irony.Parsing.Grammar
	{
		#region Constructors

		public ASMGrammar()
		{
			this.LanguageFlags = LanguageFlags.CreateAst;

			#region Lexical structure

			// Comments
			var comment = new CommentTerminal("Comment", ";", "\r", "\n", "\u2085", "\u2028", "\u2029");
			this.NonGrammarTerminals.Add(comment);

			// Literals
			var stringLiteral = new StringLiteral("StringLiteral", "\"", StringOptions.AllowsAllEscapes);

			var numberLiteral = new NumberLiteral("NumberLiteral");
			numberLiteral.AddPrefix("0x", NumberOptions.Hex);

			var identifier = new IdentifierTerminal("Label");
			identifier.StartCharCategories.AddRange(new UnicodeCategory[] 
			{
				UnicodeCategory.UppercaseLetter, 
				UnicodeCategory.LowercaseLetter
			});
			identifier.CharCategories.AddRange(identifier.StartCharCategories);
			identifier.CharCategories.AddRange(new UnicodeCategory[] 
			{
				UnicodeCategory.DecimalDigitNumber
			});

			// Symbols
			var colon = ToTerm(":", "colon");
			var comma = ToTerm(",", "comma");
			var plus = ToTerm("+", "plus");

			var bracketLeft = ToTerm("[", "BracketLeft");
			var bracketRight = ToTerm("]", "BracketRight");

			MarkPunctuation(colon, comma, plus, bracketLeft, bracketRight);

			#endregion

			#region Non-terminals

			var lines = new NonTerminal("Lines", typeof(Ast.LinesNode));
			var line = new NonTerminal("Line", typeof(Ast.LineNode));
			var label = new NonTerminal("Label", typeof(Ast.LabelNode));
			var instruction = new NonTerminal("Instruction", typeof(Ast.InstructionNode));
			var instructionWithLabel = new NonTerminal("InstructionWithLabel", typeof(Ast.InstructionWithLabelNode));
			var opcode = new NonTerminal("OpCode", typeof(Ast.DefaultNode));
			var values = new NonTerminal("Values", typeof(Ast.DefaultNode));
			var value = new NonTerminal("Value");
			var simpleValue = new NonTerminal("SimpleValue", typeof(Ast.SimpleValueNode));
			var memoryValue = new NonTerminal("MemoryValue", typeof(Ast.MemoryValueNode));
			var memoryOffsetValue = new NonTerminal("MemoryOffsetValue", typeof(Ast.MemoryOffsetValueNode));
			var labelValue = new NonTerminal("LabelValue", typeof(Ast.LabelValueNode));

			var register = new NonTerminal("Register", typeof(Ast.DefaultNode));
			var misc = new NonTerminal("Misc", typeof(Ast.DefaultNode));

			#endregion

			lines.Rule = MakeListRule(lines, null, line, TermListOptions.PlusList);
			line.Rule = label + Eos | instruction + Eos | instructionWithLabel + Eos;
			label.Rule = colon + identifier;
			instructionWithLabel.Rule = label + instruction;
			instruction.Rule = opcode + values;
			opcode.Rule = identifier;
			values.Rule = MakeListRule(values, comma, value, TermListOptions.PlusList);
			value.Rule = simpleValue | memoryValue | memoryOffsetValue | labelValue;
			simpleValue.Rule = stringLiteral | numberLiteral | register | misc;
			memoryValue.Rule = bracketLeft + simpleValue + bracketRight;
			memoryOffsetValue.Rule = bracketLeft + numberLiteral + plus + register + bracketRight;
			labelValue.Rule = identifier;

			register.Rule = ToTerm("A") | "B" | "C" | "X" | "Y" | "Z" | "I" | "J";
			misc.Rule = ToTerm("SP") | "PC" | "O" | "POP" | "PEEK" | "PUSH";

			// Set the grammar root.
			this.Root = lines;

			MarkTransient(value, register, misc);
		}

		#endregion

		#region Methods

		public override void CreateTokenFilters(LanguageData language, TokenFilterList filters)
		{
			var outlineFilter = new CodeOutlineFilter(language.GrammarData, OutlineOptions.None, null);
			filters.Add(outlineFilter);
		}

		public override void BuildAst(LanguageData language, ParseTree parseTree)
		{
			var opHandler = new OperatorHandler(language.Grammar.CaseSensitive);
			Util.Check(!parseTree.HasErrors(), "ParseTree has errors, cannot build AST.");
			var astContext = new InterpreterAstContext(language, opHandler);
			var astBuilder = new AstBuilder(astContext);
			astBuilder.BuildAst(parseTree);
		}

		#endregion
	}
}
