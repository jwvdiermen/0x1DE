namespace OxIDE.IDE
{
	partial class DisassemblerDocument
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisassemblerDocument));
			this.ContentBox = new FastColoredTextBoxNS.FastColoredTextBox();
			this.SuspendLayout();
			// 
			// ContentBox
			// 
			this.ContentBox.AcceptsReturn = false;
			this.ContentBox.AcceptsTab = false;
			this.ContentBox.AutoIndent = false;
			this.ContentBox.AutoScrollMinSize = new System.Drawing.Size(135, 15);
			this.ContentBox.BackBrush = null;
			this.ContentBox.CommentPrefix = ";";
			this.ContentBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ContentBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.ContentBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContentBox.Location = new System.Drawing.Point(0, 0);
			this.ContentBox.Name = "ContentBox";
			this.ContentBox.Paddings = new System.Windows.Forms.Padding(0);
			this.ContentBox.ReadOnly = true;
			this.ContentBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.ContentBox.ShowLineNumbers = false;
			this.ContentBox.Size = new System.Drawing.Size(784, 562);
			this.ContentBox.TabIndex = 0;
			this.ContentBox.Text = "fastColoredTextBox1";
			// 
			// DisassemblerDocument
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.ContentBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DisassemblerDocument";
			this.Text = "DisassemblerDocument";
			this.ResumeLayout(false);

		}

		#endregion

		private FastColoredTextBoxNS.FastColoredTextBox ContentBox;
	}
}