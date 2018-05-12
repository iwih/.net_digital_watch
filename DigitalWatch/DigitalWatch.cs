using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigitalWatch.Properties;
using Microsoft.Win32;

namespace DigitalWatch
{
    public partial class DigitalWatch : Form
    {
        public DigitalWatch()
        {
            InitializeComponent();

            Icon = Resources.clock;
            appIcon.Icon = Resources.clock;

            (new FormMover(this, hoursMinutesLabel)).ActivateMover();

            Application.ApplicationExit += Application_ApplicationExit;
            SystemEvents.SessionEnded += SystemEvents_SessionEnded;
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

            SetDateToLabel();

            ShowTime();
            tikTokTimer.Start();

            Opacity = 100;

            base.OnLoad(e);
        }

        private void SetDateToLabel()
        {
            dateLabel.Text = DateTime.Now.ToString("ddd\r\n dd-MM \r\nyyyy").Replace(" ", string.Empty);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            hoursMinutesLabel.Font = new Font(Font.FontFamily, Font.Size * 2f);
            var smallFont = new Font(Font.FontFamily, Font.Size * 0.8f);
            secondsLabel.Font = smallFont;
            dateLabel.Font = smallFont;

            base.OnFontChanged(e);
        }

        private void tikTokTimer_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void ShowTime()
        {
            var hoursAndMinutes = DateTime.Now.ToString(HOURS_MINTUES_FORMAT);
            if (hoursMinutesLabel.Text != hoursAndMinutes)
                hoursMinutesLabel.Text = hoursAndMinutes;
            secondsLabel.Text = DateTime.Now.ToString(SECONDS_FORMAT);
        }

        private const string HOURS_MINTUES_FORMAT = "HH:mm";
        private const string SECONDS_FORMAT = "ss";

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

        private async void SystemEvents_SessionEnded(object sender, SessionEndedEventArgs e)
        {
            await SaveSettings();
        }

        private void hideDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideDateToolStripMenuItem.Checked = !hideDateToolStripMenuItem.Checked;

            if (hideDateToolStripMenuItem.Checked)
                dateLabel.Text = string.Empty;
            else
                SetDateToLabel();
        }
    }
}