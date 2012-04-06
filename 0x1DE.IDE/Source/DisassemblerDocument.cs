using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;
using FastColoredTextBoxNS;

using OxIDE.DCPU;
using OxIDE.Support;

namespace OxIDE.IDE
{
	/// <summary>
	/// A document panel used for showing the disassembled code of a loaded program.
	/// </summary>
	public partial class DisassemblerDocument : DockContent
	{
		#region Constructors

		/// <summary>
		/// Creates a new instances of the document and initializes it.
		/// </summary>
		public DisassemblerDocument()
		{
			InitializeComponent();
		}

		#endregion

		#region Fields

		private TextStyle m_locationStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
		private TextStyle m_opcodeStyle = new TextStyle(Brushes.Black, null, FontStyle.Bold);
		private TextStyle m_valueStyle = new TextStyle(Brushes.Black, null, FontStyle.Regular);
		private TextStyle m_commentStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);

		#endregion

		#region Properties

		/// <summary>
		/// Gets the disassembled program currently displayed.
		/// </summary>
		public Disassemble Disassemble
		{
			get;
			private set;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Loads the given program into the disassembler.
		/// </summary>
		/// <param name="program">The program to load.</param>
		public void LoadProgram(OxIDE.DCPU.Program program)
		{
			// Disassemble the program.
			this.Disassemble = Disassemble.Create(program);

			// Populate the content box.
			this.ContentBox.Clear();
			this.ContentBox.BeginUpdate();

			foreach (var instruction in this.Disassemble.Instructions)
			{				
				this.ContentBox.InsertText(String.Format("{0:x4}: ", instruction.Location), m_locationStyle);

				if (instruction.BasicOpcode == BasicOpcodes.NonBasic)
				{
					this.ContentBox.InsertText(String.Format("{0,-3} ", instruction.ExtendedOpcode), m_opcodeStyle);
					this.ContentBox.InsertText(instruction.Left.ToString(), m_valueStyle);
				}
				else
				{
					this.ContentBox.InsertText(String.Format("{0,-3} ", instruction.BasicOpcode), m_opcodeStyle);
					this.ContentBox.InsertText(instruction.Left.ToString() + ", " + instruction.Right.ToString(), m_valueStyle);
				}

				var length = instruction.ToString().Length;
				var comment = "; " + String.Join(" ", instruction.OriginalCode.Select(e => String.Format("{0:x4}", e)));

				this.ContentBox.InsertText(" ".Repeat(40 - length) + comment, m_commentStyle);
				this.ContentBox.InsertText(Environment.NewLine);
			}

			this.ContentBox.EndUpdate();
		}

		#endregion
	}
}
