using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE7RenderChecker
{
    public partial class MainForm : Form
    {
        Dictionary<string, int> ieModes = new Dictionary<string, int>()
        {
            {"IE7", 7000},
            {"IE8", 8000},
            {"IE8 standard", 8888},
            {"IE9", 9000},
            {"IE9 standard", 9999},
            {"IE10", 10000},
            {"IE10 standard", 10001},
            {"IE11", 11000},
            {"IE11 edge", 11001},
        };

        const String browserEmulationSubKey = @"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
        const String settingsSubKey = @"SOFTWARE\Kanetech\IE7RenderChecker";

        public MainForm()
        {
            InitializeComponent();
            ieComboBox.Items.AddRange(ieModes.Keys.ToArray<string>());
            urlTextBox.Text = GetRegValue(@"url") as String;
            webBrowser.Navigate(urlTextBox.Text);
            var intervalObject = GetRegValue(@"interval");
            if (intervalObject == null)
            {
                reloadInterval.Value = 5;
                timer1.Interval = 5000;
            }
            else
            {
                int interval = (int)intervalObject;
                if (interval <= 0)
                    interval = 5;
                reloadInterval.Value = interval;
                timer1.Interval = interval * 1000;
            }

            int currentCode = (int)GetRegValue(exe, browserEmulationSubKey);
            if(currentCode == 0)
            {
                currentCode = 7000;
                SetRegValue(exe, currentCode, browserEmulationSubKey);
            }
            int i = 0;
            foreach (var mode in ieModes)
            {
                if (mode.Value == currentCode)
                {
                    ieComboBox.SelectedIndex = i;
                    Text += " - " + mode.Key;
                    break;
                }
                i++;
            }
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            urlTextBox.Text = webBrowser.Url.ToString();
        }

        private void urlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                webBrowser.Navigate(urlTextBox.Text);
            }

        }

        private void prevButton_MouseClick(object sender, MouseEventArgs e)
        {
            webBrowser.GoBack();
        }

        private void nextButton_MouseClick(object sender, MouseEventArgs e)
        {
            webBrowser.GoForward();
        }

        private void reloadButton_MouseClick(object sender, MouseEventArgs e)
        {
            webBrowser.Refresh();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(urlTextBox.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("");
            if (reloadCheckbox.Checked == false)
                return;

            webBrowser.Refresh();
        }

        private string exe {
            get {
                var path = System.Windows.Forms.Application.ExecutablePath;
                var exe = System.IO.Path.GetFileName(path);
                return exe;
            }
        }

        private void ieComboBox_DropDownClosed(object sender, EventArgs e)
        {
            int code = ieModes[ieComboBox.SelectedItem.ToString()];
            int currentCode = (int)GetRegValue(exe, browserEmulationSubKey);

            if (currentCode != code)
            {
                SetRegValue(exe, code, browserEmulationSubKey);
                var result = MessageBox.Show("IEモードを変更するため、アプリケーションを再起動します。", "モード変更", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("変更は次回起動時に適用されます。", "モード変更", MessageBoxButtons.OK);
                }
            }
        }

        private void SetRegValue(String value, object data, String subKey = settingsSubKey)
        {
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
            regKey.SetValue(value, data);
            regKey.Close();
        }

        private object GetRegValue(String value, String subKey = settingsSubKey)
        {
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
            object ret = 0;
            try
            {
                ret = regKey.GetValue(value);
            }
            catch (Exception ex) { }

            regKey.Close();
            if (ret == null)
                ret = 0;
            return ret;
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            SetRegValue(@"url", urlTextBox.Text);
        }

        private void reloadInterval_ValueChanged(object sender, EventArgs e)
        {
            int interval = (int)reloadInterval.Value;
            if (interval <= 0)
                interval = 1;
            SetRegValue(@"interval", interval);
            timer1.Interval = interval * 1000;
        }

        private void reloadCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (reloadCheckbox.Checked)
                timer1.Start();
            else
                timer1.Stop();
        }
    }
}
