namespace DigitalWatch
{
    partial class DigitalWatch
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
            this.components = new System.ComponentModel.Container();
            this.tikTokTimer = new System.Windows.Forms.Timer(this.components);
            this.watchLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.appIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.appIconRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borderStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dottedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.noBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSelection = new System.Windows.Forms.FontDialog();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.appIconRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tikTokTimer
            // 
            this.tikTokTimer.Enabled = true;
            this.tikTokTimer.Interval = 1000;
            this.tikTokTimer.Tick += new System.EventHandler(this.tikTokTimer_Tick);
            // 
            // watchLabel
            // 
            this.watchLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.watchLabel.AutoSize = true;
            this.watchLabel.Location = new System.Drawing.Point(84, 5);
            this.watchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.watchLabel.Name = "watchLabel";
            this.watchLabel.Size = new System.Drawing.Size(77, 14);
            this.watchLabel.TabIndex = 0;
            this.watchLabel.Text = "watchLabel";
            this.watchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.watchLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 24);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // appIcon
            // 
            this.appIcon.ContextMenuStrip = this.appIconRightClickMenu;
            this.appIcon.Text = "Digital Watch";
            this.appIcon.Visible = true;
            // 
            // appIconRightClickMenu
            // 
            this.appIconRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borderStyleToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.colorSelectionToolStripMenuItem,
            this.fontSelectionToolStripMenuItem,
            this.toolStripSeparator1,
            this.hideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.appIconRightClickMenu.Name = "appIconRightClickMenu";
            this.appIconRightClickMenu.Size = new System.Drawing.Size(181, 164);
            // 
            // borderStyleToolStripMenuItem
            // 
            this.borderStyleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dottedToolStripMenuItem,
            this.dashedToolStripMenuItem,
            this.insetToolStripMenuItem,
            this.solidToolStripMenuItem,
            this.outsetToolStripMenuItem,
            this.toolStripSeparator2,
            this.noBorderToolStripMenuItem});
            this.borderStyleToolStripMenuItem.Name = "borderStyleToolStripMenuItem";
            this.borderStyleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borderStyleToolStripMenuItem.Text = "Border Style";
            // 
            // dottedToolStripMenuItem
            // 
            this.dottedToolStripMenuItem.Name = "dottedToolStripMenuItem";
            this.dottedToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.dottedToolStripMenuItem.Text = "Dotted";
            this.dottedToolStripMenuItem.Click += new System.EventHandler(this.dottedToolStripMenuItem_Click);
            // 
            // dashedToolStripMenuItem
            // 
            this.dashedToolStripMenuItem.Name = "dashedToolStripMenuItem";
            this.dashedToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.dashedToolStripMenuItem.Text = "Dashed";
            this.dashedToolStripMenuItem.Click += new System.EventHandler(this.dashedToolStripMenuItem_Click);
            // 
            // insetToolStripMenuItem
            // 
            this.insetToolStripMenuItem.Name = "insetToolStripMenuItem";
            this.insetToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.insetToolStripMenuItem.Text = "Inset";
            this.insetToolStripMenuItem.Click += new System.EventHandler(this.insetToolStripMenuItem_Click);
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // outsetToolStripMenuItem
            // 
            this.outsetToolStripMenuItem.Name = "outsetToolStripMenuItem";
            this.outsetToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.outsetToolStripMenuItem.Text = "Outset";
            this.outsetToolStripMenuItem.Click += new System.EventHandler(this.outsetToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // noBorderToolStripMenuItem
            // 
            this.noBorderToolStripMenuItem.Name = "noBorderToolStripMenuItem";
            this.noBorderToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.noBorderToolStripMenuItem.Text = "No Border";
            this.noBorderToolStripMenuItem.Click += new System.EventHandler(this.noBorderToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // colorSelectionToolStripMenuItem
            // 
            this.colorSelectionToolStripMenuItem.Name = "colorSelectionToolStripMenuItem";
            this.colorSelectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorSelectionToolStripMenuItem.Text = "Color Selection";
            this.colorSelectionToolStripMenuItem.Click += new System.EventHandler(this.colorSelectionToolStripMenuItem_Click);
            // 
            // fontSelectionToolStripMenuItem
            // 
            this.fontSelectionToolStripMenuItem.Name = "fontSelectionToolStripMenuItem";
            this.fontSelectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontSelectionToolStripMenuItem.Text = "Font Selection";
            this.fontSelectionToolStripMenuItem.Click += new System.EventHandler(this.fontSelectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // DigitalWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(246, 24);
            this.ContextMenuStrip = this.appIconRightClickMenu;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Digital-7 Mono", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DigitalWatch";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigitalWatch";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.appIconRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tikTokTimer;
        private System.Windows.Forms.Label watchLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NotifyIcon appIcon;
        private System.Windows.Forms.ContextMenuStrip appIconRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem fontSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dottedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontSelection;
        private System.Windows.Forms.ToolStripMenuItem insetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem colorSelectionToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
    }
}

