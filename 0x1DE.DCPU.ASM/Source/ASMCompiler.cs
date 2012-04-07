using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Irony.Parsing;

using OxIDE.DCPU;

namespace OxIDE.DCPU.ASM
{
	/// <summary>
	/// Used for compiling assembly code to a program.
	/// </summary>
	public class ASMCompiler
	{
		#region Constructors

		/// <summary>
		/// Creates a new instance of the compiler and initializes it.
		/// </summary>
		public ASMCompiler()
		{
			this.Grammar = new ASMGrammar();
			this.Language = new LanguageData(this.Grammar);
			this.Parser = new Parser(this.Language);
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the grammar.
		/// </summary>
		public Grammar Grammar
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets the language.
		/// </summary>
		public LanguageData Language
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets the parser.
		/// </summary>
		public Parser Parser
		{
			get;
			private set;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Compiles the given source into a program.
		/// </summary>
		/// <param name="source">The source code.</param>
		/// <param name="fileName">An optional file name to use for debugging.</param>
		/// <returns>The compiled program.</returns>
		public Program CompileProgram(string source, string fileName = "<source>")
		{
			// Create an empty program if no source given.
			if (String.IsNullOrWhiteSpace(source) == true)
			{
				return new Program(new ushort[0]);
			}

			// Parse the given source.
			var parseTree = this.Parser.Parse(source, fileName);

			return new Program(new ushort[0]);
		}

		#endregion
	}
}
