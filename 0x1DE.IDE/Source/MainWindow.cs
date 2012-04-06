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

namespace OxIDE.IDE
{
	/// <summary>
	/// The main window off the application.
	/// </summary>
	public partial class MainWindow : Form
	{
		#region Constructors

		/// <summary>
		/// Initializes the main window.
		/// </summary>
		public MainWindow()
		{
			InitializeComponent();
		}

		#endregion

		#region Event methods

		private void AddItemBtn_Click(object sender, EventArgs e)
		{

		}

		private void OpenFileBtn_Click(object sender, EventArgs e)
		{
			// Let the user choose a file to open.
			if (this.OpenFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				try
				{
					var filePath = this.OpenFileDialog.FileName;

					// Check the extension.
					var extension = Path.GetExtension(filePath);
					if (extension == ".hex" || extension == ".bin")
					{
						// The file is a program. Load it and show the disassembler.
						var program = OxIDE.DCPU.Program.LoadFrom(filePath);

						var disassembler = new DisassemblerDocument();
						disassembler.Text = Path.GetFileName(filePath);
						disassembler.LoadProgram(program);
						disassembler.Show(this.DockPanel, DockState.Document);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(this, "An error has occurred:" + Environment.NewLine + ex.Message, "An error has occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		#endregion
	}
}
