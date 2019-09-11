using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace System_Time_Viewer
{
    public partial class MainForm : Form
    {
        #region Data      

        private string _dateTimeFormat;
        private TimeZoneInfo _selectedTimeZone;
        private DateTime _currentDateTime;
        private DateTime _markedDateTime;
        readonly string _timeSpanFormat = @"hh\:mm\:ss";

        #endregion

        #region Helper Method

        private void PopupError(string message, string caption = "Error")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, _selectedTimeZone);
                textBoxCurrentTime.Text = _currentDateTime.ToString(_dateTimeFormat);
                textBoxTimeSpan.Text = (_currentDateTime - _markedDateTime).ToString(_timeSpanFormat);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        #endregion

        #region ctor      

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(265, 75);
            this.MaximumSize = new Size(325, 195);
            var location = new Point
            {
                X = Screen.PrimaryScreen.Bounds.Size.Width - this.Size.Width - 5,
                Y = Screen.PrimaryScreen.Bounds.Size.Height - this.Size.Height - 40
            };
            this.Location = location;
            this.Text = this.ProductName + " v" + Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                var zones = TimeZoneInfo.GetSystemTimeZones();
                _selectedTimeZone = zones.FirstOrDefault(z => z.Id == TimeZoneInfo.Local.Id);               
                comboBoxTimeZone.DataSource = zones;
                comboBoxTimeZone.SelectedIndex = zones.IndexOf(_selectedTimeZone);
                _dateTimeFormat = textBoxDateTimeFormat.Text;
                _currentDateTime = _markedDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, _selectedTimeZone);
                textBoxCurrentTime.Text = _currentDateTime.ToString(_dateTimeFormat);
                textBoxMarkedTime.Text = _markedDateTime.ToString(_dateTimeFormat);
                textBoxTimeSpan.Text = (_currentDateTime - _markedDateTime).ToString(_timeSpanFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region From Events  

        private void ButtonCopyCurrentTime_Click(object sender, EventArgs e)
        {
            try
            {
                _currentDateTime = _markedDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, _selectedTimeZone);
                textBoxMarkedTime.Text = _markedDateTime.ToString(_dateTimeFormat);
                textBoxTimeSpan.Text = (_currentDateTime - _markedDateTime).ToString(_timeSpanFormat);
                Clipboard.SetText(textBoxMarkedTime.Text);
            }
            catch (Exception ex)
            {
                PopupError(ex.Message);
            }
        }

        private void ButtonCopyMarkedTime_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxMarkedTime.Text);
            }
            catch (Exception ex)
            {
                PopupError(ex.Message);
            }
        }

        private void ButtonCopyTimeSpan_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBoxTimeSpan.Text);
            }
            catch (Exception ex)
            {
                PopupError(ex.Message);
            }
        }

        private void ButtonSetFormat_Click(object sender, EventArgs e)
        {
            try
            {
                var formatstr = textBoxDateTimeFormat.Text;
                _currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, _selectedTimeZone);
                textBoxCurrentTime.Text = _currentDateTime.ToString(formatstr);
                textBoxMarkedTime.Text = _markedDateTime.ToString(formatstr);
                textBoxTimeSpan.Text = (_currentDateTime - _markedDateTime).ToString(_timeSpanFormat);
                _dateTimeFormat = formatstr;
            }
            catch (Exception ex)
            {
                PopupError(ex.Message);
            }
        }

        private void ButtonSetTimeZone_Click(object sender, EventArgs e)
        {
            try
            {
                var zoneName = comboBoxTimeZone.Text;
                var selectedTimeZone = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(z => z.DisplayName == zoneName);
                _currentDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, selectedTimeZone);
                textBoxCurrentTime.Text = _currentDateTime.ToString(_dateTimeFormat);
                _selectedTimeZone = selectedTimeZone;
            }
            catch (Exception ex)
            {
                PopupError(ex.Message);
            }
        }

        #endregion
    }
}
