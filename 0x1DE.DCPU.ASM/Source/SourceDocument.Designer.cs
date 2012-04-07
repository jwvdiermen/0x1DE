namespace OxIDE.DCPU.ASM
{
	partial class SourceDocument
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SourceDocument));
			this.ContentEditor = new FastColoredTextBoxNS.FastColoredTextBox();
			this.SuspendLayout();
			// 
			// ContentEditor
			// 
			this.ContentEditor.AutoScrollMinSize = new System.Drawing.Size(158, 15);
			this.ContentEditor.BackBrush = null;
			this.ContentEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ContentEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.ContentEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContentEditor.Location = new System.Drawing.Point(0, 0);
			this.ContentEditor.Name = "ContentEditor";
			this.ContentEditor.Paddings = new System.Windows.Forms.Padding(0);
			this.ContentEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.ContentEditor.Size = new System.Drawing.Size(784, 562);
			this.ContentEditor.TabIndex = 0;
			this.ContentEditor.Text = "fastColoredTextBox1";
			this.ContentEditor.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.ContentEditor_TextChangedDelayed);
			this.ContentEditor.Enter += new System.EventHandler(this.ContentEditor_Enter);
			this.ContentEditor.Leave += new System.EventHandler(this.ContentEditor_Leave);
			// 
			// SourceDocument
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.ContentEditor);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SourceDocument";
			this.Text = "SourceDocument";
			this.ResumeLayout(false);

		}

		#endregion

		private FastColoredTextBoxNS.FastColoredTextBox ContentEditor;
	}
}