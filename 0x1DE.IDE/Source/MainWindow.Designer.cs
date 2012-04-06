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
			WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
			WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
			WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
			WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.MenuFileBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuNewButton = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.DockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
			this.StandardToolbar = new System.Windows.Forms.ToolStrip();
			this.AddItemBtn = new System.Windows.Forms.ToolStripButton();
			this.OpenFileBtn = new System.Windows.Forms.ToolStripButton();
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.MenuOpenBtn});
			this.MenuFileBtn.Name = "MenuFileBtn";
			this.MenuFileBtn.Size = new System.Drawing.Size(37, 20);
			this.MenuFileBtn.Text = "&File";
			// 
			// MenuNewButton
			// 
			this.MenuNewButton.Name = "MenuNewButton";
			this.MenuNewButton.Size = new System.Drawing.Size(103, 22);
			this.MenuNewButton.Text = "&New";
			// 
			// MenuOpenBtn
			// 
			this.MenuOpenBtn.Name = "MenuOpenBtn";
			this.MenuOpenBtn.Size = new System.Drawing.Size(103, 22);
			this.MenuOpenBtn.Text = "&Open";
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
			dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
			dockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight;
			autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
			tabGradient1.EndColor = System.Drawing.SystemColors.Control;
			tabGradient1.StartColor = System.Drawing.SystemColors.Control;
			tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
			autoHideStripSkin1.TabGradient = tabGradient1;
			autoHideStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
			dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
			tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
			tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
			tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
			dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
			dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
			dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
			dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
			tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
			tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
			tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
			dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
			dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
			dockPaneStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
			tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
			tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
			tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
			dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
			tabGradient5.EndColor = System.Drawing.SystemColors.Control;
			tabGradient5.StartColor = System.Drawing.SystemColors.Control;
			tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
			dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
			dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
			dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
			dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
			tabGradient6.EndColor = System.Drawing.SystemColors.InactiveCaption;
			tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
			tabGradient6.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
			dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
			tabGradient7.EndColor = System.Drawing.Color.Transparent;
			tabGradient7.StartColor = System.Drawing.Color.Transparent;
			tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
			dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
			dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
			dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
			this.DockPanel.Skin = dockPanelSkin1;
			this.DockPanel.TabIndex = 0;
			// 
			// StandardToolbar
			// 
			this.StandardToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItemBtn,
            this.OpenFileBtn});
			this.StandardToolbar.Location = new System.Drawing.Point(0, 24);
			this.StandardToolbar.Name = "StandardToolbar";
			this.StandardToolbar.Size = new System.Drawing.Size(1264, 25);
			this.StandardToolbar.TabIndex = 7;
			// 
			// AddItemBtn
			// 
			this.AddItemBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.AddItemBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddItemBtn.Image")));
			this.AddItemBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AddItemBtn.Name = "AddItemBtn";
			this.AddItemBtn.Size = new System.Drawing.Size(23, 22);
			this.AddItemBtn.Text = "Add item";
			this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
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
			this.OpenFileDialog.Filter = "Hex file|*.hex|Binary file|*.bin";
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
		private System.Windows.Forms.ToolStripButton AddItemBtn;
		private WeifenLuo.WinFormsUI.Docking.DockPanel DockPanel;
		private System.Windows.Forms.ToolStripButton OpenFileBtn;
		private System.Windows.Forms.OpenFileDialog OpenFileDialog;
	}
}