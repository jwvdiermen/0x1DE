namespace OxIDE.IDE
{
	partial class MainWindow
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
			WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin2 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
			WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin2 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
			WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient4 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient8 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin2 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
			WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient9 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient5 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient10 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient11 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient12 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient6 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient13 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient14 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.MenuFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuNewButton = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuOpenFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MenuExitBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.DockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
			this.StandardToolbar = new System.Windows.Forms.ToolStrip();
			this.AddNewItemBtn = new System.Windows.Forms.ToolStripButton();
			this.OpenFileBtn = new System.Windows.Forms.ToolStripButton();
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.MenuNewASMFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveBtn = new System.Windows.Forms.ToolStripButton();
			this.SaveAllBtn = new System.Windows.Forms.ToolStripButton();
			this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.MainMenu.SuspendLayout();
			this.MainStatusStrip.SuspendLayout();
			this.StandardToolbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileBtn});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(1264, 24);
			this.MainMenu.TabIndex = 6;
			this.MainMenu.Text = "Main menu";
			// 
			// MenuFileBtn
			// 
			this.MenuFileBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewButton,
            this.MenuOpenBtn,
            this.toolStripSeparator1,
            this.MenuExitBtn});
			this.MenuFileBtn.Name = "MenuFileBtn";
			this.MenuFileBtn.Size = new System.Drawing.Size(37, 20);
			this.MenuFileBtn.Text = "&File";
			// 
			// MenuNewButton
			// 
			this.MenuNewButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewASMFileBtn});
			this.MenuNewButton.Name = "MenuNewButton";
			this.MenuNewButton.Size = new System.Drawing.Size(152, 22);
			this.MenuNewButton.Text = "&New";
			// 
			// MenuOpenBtn
			// 
			this.MenuOpenBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpenFileBtn});
			this.MenuOpenBtn.Name = "MenuOpenBtn";
			this.MenuOpenBtn.Size = new System.Drawing.Size(152, 22);
			this.MenuOpenBtn.Text = "&Open";
			// 
			// MenuOpenFileBtn
			// 
			this.MenuOpenFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("MenuOpenFileBtn.Image")));
			this.MenuOpenFileBtn.Name = "MenuOpenFileBtn";
			this.MenuOpenFileBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.MenuOpenFileBtn.Size = new System.Drawing.Size(144, 22);
			this.MenuOpenFileBtn.Text = "&File...";
			this.MenuOpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// MenuExitBtn
			// 
			this.MenuExitBtn.Name = "MenuExitBtn";
			this.MenuExitBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.MenuExitBtn.Size = new System.Drawing.Size(152, 22);
			this.MenuExitBtn.Text = "E&xit";
			// 
			// MainStatusStrip
			// 
			this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
			this.MainStatusStrip.Location = new System.Drawing.Point(0, 660);
			this.MainStatusStrip.Name = "MainStatusStrip";
			this.MainStatusStrip.Size = new System.Drawing.Size(1264, 22);
			this.MainStatusStrip.TabIndex = 4;
			this.MainStatusStrip.Text = "statusStrip1";
			// 
			// StatusLabel
			// 
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(39, 17);
			this.StatusLabel.Text = "Ready";
			// 
			// DockPanel
			// 
			this.DockPanel.ActiveAutoHideContent = null;
			this.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DockPanel.DockBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.DockPanel.DockBottomPortion = 150D;
			this.DockPanel.DockLeftPortion = 200D;
			this.DockPanel.DockRightPortion = 200D;
			this.DockPanel.DockTopPortion = 150D;
			this.DockPanel.Location = new System.Drawing.Point(0, 49);
			this.DockPanel.Name = "DockPanel";
			this.DockPanel.RightToLeftLayout = true;
			this.DockPanel.ShowDocumentIcon = true;
			this.DockPanel.Size = new System.Drawing.Size(1264, 611);
			dockPanelGradient4.EndColor = System.Drawing.SystemColors.ControlLight;
			dockPanelGradient4.StartColor = System.Drawing.SystemColors.ControlLight;
			autoHideStripSkin2.DockStripGradient = dockPanelGradient4;
			tabGradient8.EndColor = System.Drawing.SystemColors.Control;
			tabGradient8.StartColor = System.Drawing.SystemColors.Control;
			tabGradient8.TextColor = System.Drawing.SystemColors.ControlDarkDark;
			autoHideStripSkin2.TabGradient = tabGradient8;
			autoHideStripSkin2.TextFont = new System.Drawing.Font("Segoe UI", 9F);
			dockPanelSkin2.AutoHideStripSkin = autoHideStripSkin2;
			tabGradient9.EndColor = System.Drawing.SystemColors.ControlLightLight;
			tabGradient9.StartColor = System.Drawing.SystemColors.ControlLightLight;
			tabGradient9.TextColor = System.Drawing.SystemColors.ControlText;
			dockPaneStripGradient2.ActiveTabGradient = tabGradient9;
			dockPanelGradient5.EndColor = System.Drawing.SystemColors.Control;
			dockPanelGradient5.StartColor = System.Drawing.SystemColors.Control;
			dockPaneStripGradient2.DockStripGradient = dockPanelGradient5;
			tabGradient10.EndColor = System.Drawing.SystemColors.ControlLight;
			tabGradient10.StartColor = System.Drawing.SystemColors.ControlLight;
			tabGradient10.TextColor = System.Drawing.SystemColors.ControlText;
			dockPaneStripGradient2.InactiveTabGradient = tabGradient10;
			dockPaneStripSkin2.DocumentGradient = dockPaneStripGradient2;
			dockPaneStripSkin2.TextFont = new System.Drawing.Font("Segoe UI", 9F);
			tabGradient11.EndColor = System.Drawing.SystemColors.ActiveCaption;
			tabGradient11.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			tabGradient11.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
			tabGradient11.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
			dockPaneStripToolWindowGradient2.ActiveCaptionGradient = tabGradient11;
			tabGradient12.EndColor = System.Drawing.SystemColors.Control;
			tabGradient12.StartColor = System.Drawing.SystemColors.Control;
			tabGradient12.TextColor = System.Drawing.SystemColors.ControlText;
			dockPaneStripToolWindowGradient2.ActiveTabGradient = tabGradient12;
			dockPanelGradient6.EndColor = System.Drawing.SystemColors.ControlLight;
			dockPanelGradient6.StartColor = System.Drawing.SystemColors.ControlLight;
			dockPaneStripToolWindowGradient2.DockStripGradient = dockPanelGradient6;
			tabGradient13.EndColor = System.Drawing.SystemColors.InactiveCaption;
			tabGradient13.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			tabGradient13.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
			tabGradient13.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
			dockPaneStripToolWindowGradient2.InactiveCaptionGradient = tabGradient13;
			tabGradient14.EndColor = System.Drawing.Color.Transparent;
			tabGradient14.StartColor = System.Drawing.Color.Transparent;
			tabGradient14.TextColor = System.Drawing.SystemColors.ControlDarkDark;
			dockPaneStripToolWindowGradient2.InactiveTabGradient = tabGradient14;
			dockPaneStripSkin2.ToolWindowGradient = dockPaneStripToolWindowGradient2;
			dockPanelSkin2.DockPaneStripSkin = dockPaneStripSkin2;
			this.DockPanel.Skin = dockPanelSkin2;
			this.DockPanel.TabIndex = 0;
			// 
			// StandardToolbar
			// 
			this.StandardToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewItemBtn,
            this.OpenFileBtn,
            this.SaveBtn,
            this.SaveAllBtn});
			this.StandardToolbar.Location = new System.Drawing.Point(0, 24);
			this.StandardToolbar.Name = "StandardToolbar";
			this.StandardToolbar.Size = new System.Drawing.Size(1264, 25);
			this.StandardToolbar.TabIndex = 7;
			// 
			// AddNewItemBtn
			// 
			this.AddNewItemBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.AddNewItemBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddNewItemBtn.Image")));
			this.AddNewItemBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AddNewItemBtn.Name = "AddNewItemBtn";
			this.AddNewItemBtn.Size = new System.Drawing.Size(23, 22);
			this.AddNewItemBtn.Text = "Add new item...";
			this.AddNewItemBtn.Click += new System.EventHandler(this.AddNewItemBtn_Click);
			// 
			// OpenFileBtn
			// 
			this.OpenFileBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.OpenFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileBtn.Image")));
			this.OpenFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenFileBtn.Name = "OpenFileBtn";
			this.OpenFileBtn.Size = new System.Drawing.Size(23, 22);
			this.OpenFileBtn.Text = "Open file...";
			this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
			// 
			// OpenFileDialog
			// 
			this.OpenFileDialog.Filter = "ASM file|*.asm|HEX file|*.hex|Binary file|*.bin";
			this.OpenFileDialog.Title = "Open File";
			// 
			// MenuNewASMFileBtn
			// 
			this.MenuNewASMFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("MenuNewASMFileBtn.Image")));
			this.MenuNewASMFileBtn.Name = "MenuNewASMFileBtn";
			this.MenuNewASMFileBtn.Size = new System.Drawing.Size(152, 22);
			this.MenuNewASMFileBtn.Text = "&ASM file";
			this.MenuNewASMFileBtn.Click += new System.EventHandler(this.MenuNewASMFileBtn_Click);
			// 
			// SaveBtn
			// 
			this.SaveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
			this.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(23, 22);
			this.SaveBtn.Text = "Save";
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// SaveAllBtn
			// 
			this.SaveAllBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SaveAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveAllBtn.Image")));
			this.SaveAllBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SaveAllBtn.Name = "SaveAllBtn";
			this.SaveAllBtn.Size = new System.Drawing.Size(23, 22);
			this.SaveAllBtn.Text = "Save All";
			this.SaveAllBtn.Click += new System.EventHandler(this.SaveAllBtn_Click);
			// 
			// SaveFileDialog
			// 
			this.SaveFileDialog.Title = "Save File";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 682);
			this.Controls.Add(this.DockPanel);
			this.Controls.Add(this.StandardToolbar);
			this.Controls.Add(this.MainMenu);
			this.Controls.Add(this.MainStatusStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.MainMenu;
			this.Name = "MainWindow";
			this.Text = "0x1DE - 0x10c IDE";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.MainStatusStrip.ResumeLayout(false);
			this.MainStatusStrip.PerformLayout();
			this.StandardToolbar.ResumeLayout(false);
			this.StandardToolbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem MenuFileBtn;
		private System.Windows.Forms.ToolStripMenuItem MenuNewButton;
		private System.Windows.Forms.ToolStripMenuItem MenuOpenBtn;
		private System.Windows.Forms.StatusStrip MainStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
		private System.Windows.Forms.ToolStrip StandardToolbar;
		private System.Windows.Forms.ToolStripButton AddNewItemBtn;
		private WeifenLuo.WinFormsUI.Docking.DockPanel DockPanel;
		private System.Windows.Forms.ToolStripButton OpenFileBtn;
		private System.Windows.Forms.OpenFileDialog OpenFileDialog;
		private System.Windows.Forms.ToolStripMenuItem MenuOpenFileBtn;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem MenuExitBtn;
		private System.Windows.Forms.ToolStripMenuItem MenuNewASMFileBtn;
		private System.Windows.Forms.ToolStripButton SaveBtn;
		private System.Windows.Forms.ToolStripButton SaveAllBtn;
		private System.Windows.Forms.SaveFileDialog SaveFileDialog;
	}
}