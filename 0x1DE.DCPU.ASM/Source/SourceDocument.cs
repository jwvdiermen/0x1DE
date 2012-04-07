using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using WeifenLuo.WinFormsUI.Docking;
using FastColoredTextBoxNS;

using Irony.Parsing;
using Irony.Highlighter.Highlighter;

using OxIDE.Support;

namespace OxIDE.DCPU.ASM
{
	/// <summary>
	/// Represents a document used for editing assembly code.
	/// </summary>
	public partial class SourceDocument : DockContent, ISavableDocument
	{
		#region Constructors

		/// <summary>
		/// Creates and initializes a new source document with the given compiler.
		/// </summary>
		public SourceDocument(ASMCompiler compiler)
		{
			this.Compiler = compiler;

			InitializeComponent();

			// Setup the highlighter.
			m_highlighter = new FastColoredTextBoxHighlighter(this.ContentEditor, this.Compiler.Language);
		}

		#endregion

		#region Fields

		private FastColoredTextBoxHighlighter m_highlighter;
		private string m_originalText;

		#endregion

		#region Properties

		/// <summary>
		/// Gets the compiler responsible for this source document.
		/// </summary>
		public ASMCompiler Compiler
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets the path of the file currently edited.
		/// </summary>
		public string FilePath
		{
			get;
			private set;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Loads the given file.
		/// </summary>
		/// <param name="filePath">The file to load.</param>
		public void LoadFile(string filePath)
		{
			this.FilePath = filePath;

			// Prepare the content editor with the contents of the file.
			var content = File.ReadAllText(filePath);
			this.ContentEditor.Text = content;
			this.ContentEditor.ClearUndo();

			// Store the original text.
			m_originalText = this.ContentEditor.Text;

			// Set the title.
			this.Text = Path.GetFileName(filePath);
		}

		private void CheckDirty()
		{
			if (this.IsDirty == true && this.Text.EndsWith("*") == false)
			{
				this.Text += "*";
			}
			else if (this.IsDirty == false && this.Text.EndsWith("*") == true)
			{
				this.Text = this.Text.Remove(this.Text.Length - 1);
			}
		}

		#endregion

		#region Event methods

		private void ContentEditor_Enter(object sender, EventArgs e)
		{
			m_highlighter.Adapter.Activate();
		}

		private void ContentEditor_Leave(object sender, EventArgs e)
		{
			m_highlighter.Adapter.Stop();
		}

		private void ContentEditor_TextChangedDelayed(object sender, TextChangedEventArgs e)
		{
			CheckDirty();
		}

		#endregion

		#region ISavableDocument Members

		public bool IsDirty
		{			
			get { return m_originalText != this.ContentEditor.Text; }
		}

		public void Save()
		{
			if (this.IsDirty == true)
			{
				// Write all the contents to the file.
				var contents = this.ContentEditor.Text;
				File.WriteAllText(this.FilePath, contents);

				// Reset the dirty state.
				m_originalText = contents;
				CheckDirty();
			}
		}

		#endregion
	}
}
