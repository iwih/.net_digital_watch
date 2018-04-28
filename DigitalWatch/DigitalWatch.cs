using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigitalWatch.Properties;

namespace DigitalWatch
{
    public partial class DigitalWatch : Form
    {
        public DigitalWatch()
        {
            InitializeComponent();

            Icon = Resources.clock;
            appIcon.Icon = Resources.clock;

            (new FormMover(this, watchLabel)).ActivateMover();

            Application.ApplicationExit += Application_ApplicationExit;
        }

        protected override async void OnLoad(EventArgs e)
        {
            var settings = await Settings.ReadSettings();

            if (settings != null)
            {
                ForeColor = settings.ForeColor;
                BackColor = settings.BackColor;
                Font = new Font(settings.FontFamily, settings.FontSize);
                _borderStyle = settings.BorderStyle;
                DesktopLocation = settings.Location;
            }

            ShowTime();
            tikTokTimer.Start();

            Opacity = 100;

            base.OnLoad(e);
        }

        private void tikTokTimer_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }

        private bool _flicker;

        private void ShowTime()
        {
            var timeFormat = TimeFormat;

            watchLabel.Text = DateTime.Now.ToString(timeFormat);
            var supposedSize =
                new Size(
                    watchLabel.Width + watchLabel.Margin.All + 4,
                    watchLabel.Height + watchLabel.Margin.All + 4);

            if (!Size.Equals(supposedSize))
                Size = supposedSize;
        }

        private const string COLONED_FORMAT = "dddd dd-MM-yyyy\r\nHH:mm:ss";
        public const string NONCOLONED_FORMAT = "dddd dd-MM-yyyy\r\nHH:mm ss";

        private string TimeFormat
        {
            get
            {
                var timeFormat = _flicker ? COLONED_FORMAT : NONCOLONED_FORMAT;
                _flicker = !_flicker;
                return timeFormat;
            }
        }

        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Dashed;

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, ForeColor, _borderStyle);
            base.OnPaint(e);
        }

        private void fontSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontSelection.Font = Font;
            fontSelection.ShowDialog();

            if (!Font.Equals(fontSelection.Font))
                Font = fontSelection.Font;
        }

        private void dottedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _borderStyle = ButtonBorderStyle.Dotted;
        }

        private void dashedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _borderStyle = ButtonBorderStyle.Dashed;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _borderStyle = ButtonBorderStyle.Solid;
        }

        private void noBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _borderStyle = ButtonBorderStyle.None;
        }

        private void outsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _borderStyle = ButtonBorderStyle.Outset;
        }

        private void insetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _borderStyle = ButtonBorderStyle.Inset;
        }

        private void colorSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorPicker.Color = ForeColor;
            colorPicker.ShowDialog();
            if (!ForeColor.Equals(colorPicker.Color))
                ForeColor = colorPicker.Color;
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorPicker.Color = BackColor;
            colorPicker.ShowDialog();
            if (!BackColor.Equals(colorPicker.Color))
                BackColor = colorPicker.Color;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override async void OnClosing(CancelEventArgs e)
        {
            await SaveSettings();

            base.OnClosing(e);
        }

        private async Task SaveSettings()
        {
            await Settings.WriteSettings(ForeColor, BackColor, _borderStyle, Font, DesktopLocation);
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hideToolStripMenuItem.Checked)
            {
                Show();
                hideToolStripMenuItem.Checked = false;
            }
            else
            {
                Hide();
                hideToolStripMenuItem.Checked = true;
            }
        }

        private async void Application_ApplicationExit(object sender, EventArgs e)
        {
            await SaveSettings();
        }
    }
}