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
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.watchTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.hoursMinutesLabel = new System.Windows.Forms.Label();
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
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSelection = new System.Windows.Forms.FontDialog();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.hideDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTableLayout.SuspendLayout();
            this.watchTableLayout.SuspendLayout();
            this.appIconRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tikTokTimer
            // 
            this.tikTokTimer.Enabled = true;
            this.tikTokTimer.Interval = 1000;
            this.tikTokTimer.Tick += new System.EventHandler(this.tikTokTimer_Tick);
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.AutoSize = true;
            this.mainTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTableLayout.BackColor = System.Drawing.Color.Transparent;
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayout.Controls.Add(this.dateLabel, 1, 0);
            this.mainTableLayout.Controls.Add(this.watchTableLayout, 0, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 1;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayout.Size = new System.Drawing.Size(246, 58);
            this.mainTableLayout.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Location = new System.Drawing.Point(77, 2);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(167, 54);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "dateLabel";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // watchTableLayout
            // 
            this.watchTableLayout.AutoSize = true;
            this.watchTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.watchTableLayout.ColumnCount = 2;
            this.watchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.watchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.watchTableLayout.Controls.Add(this.secondsLabel, 0, 0);
            this.watchTableLayout.Controls.Add(this.hoursMinutesLabel, 0, 0);
            this.watchTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchTableLayout.Location = new System.Drawing.Point(0, 0);
            this.watchTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.watchTableLayout.Name = "watchTableLayout";
            this.watchTableLayout.RowCount = 1;
            this.watchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.watchTableLayout.Size = new System.Drawing.Size(77, 58);
            this.watchTableLayout.TabIndex = 1;
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.BackColor = System.Drawing.Color.Transparent;
            this.secondsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondsLabel.Location = new System.Drawing.Point(42, 0);
            this.secondsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(35, 58);
            this.secondsLabel.TabIndex = 2;
            this.secondsLabel.Text = "secs";
            this.secondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursMinutesLabel
            // 
            this.hoursMinutesLabel.AutoSize = true;
            this.hoursMinutesLabel.BackColor = System.Drawing.Color.Transparent;
            this.hoursMinutesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursMinutesLabel.Location = new System.Drawing.Point(0, 0);
            this.hoursMinutesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hoursMinutesLabel.Name = "hoursMinutesLabel";
            this.hoursMinutesLabel.Size = new System.Drawing.Size(42, 58);
            this.hoursMinutesLabel.TabIndex = 1;
            this.hoursMinutesLabel.Text = "HH:MM";
            this.hoursMinutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.hideDateToolStripMenuItem,
            this.toolStripSeparator1,
            this.hideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.appIconRightClickMenu.Name = "appIconRightClickMenu";
            this.appIconRightClickMenu.Size = new System.Drawing.Size(181, 186);
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
            this.borderStyleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
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
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // colorSelectionToolStripMenuItem
            // 
            this.colorSelectionToolStripMenuItem.Name = "colorSelectionToolStripMenuItem";
            this.colorSelectionToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.colorSelectionToolStripMenuItem.Text = "Color Selection";
            this.colorSelectionToolStripMenuItem.Click += new System.EventHandler(this.colorSelectionToolStripMenuItem_Click);
            // 
            // fontSelectionToolStripMenuItem
            // 
            this.fontSelectionToolStripMenuItem.Name = "fontSelectionToolStripMenuItem";
            this.fontSelectionToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fontSelectionToolStripMenuItem.Text = "Font Selection";
            this.fontSelectionToolStripMenuItem.Click += new System.EventHandler(this.fontSelectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // hideDateToolStripMenuItem
            // 
            this.hideDateToolStripMenuItem.Name = "hideDateToolStripMenuItem";
            this.hideDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hideDateToolStripMenuItem.Text = "Hide Date";
            this.hideDateToolStripMenuItem.Click += new System.EventHandler(this.hideDateToolStripMenuItem_Click);
            // 
            // DigitalWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(246, 58);
            this.ContextMenuStrip = this.appIconRightClickMenu;
            this.Controls.Add(this.mainTableLayout);
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
            this.mainTableLayout.ResumeLayout(false);
            this.mainTableLayout.PerformLayout();
            this.watchTableLayout.ResumeLayout(false);
            this.watchTableLayout.PerformLayout();
            this.appIconRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tikTokTimer;
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
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
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TableLayoutPanel watchTableLayout;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label hoursMinutesLabel;
        private System.Windows.Forms.ToolStripMenuItem hideDateToolStripMenuItem;
    }
}

