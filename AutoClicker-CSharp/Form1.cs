using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {

        // GLOBAL DEĞİŞKENLER
        int clickCount = 0;
        bool isRunning = false;
        Keys userHotkey = Keys.F6;

        Stopwatch sw = new Stopwatch();

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int MOD_NONE = 0x0000;
        private const int HOTKEY_ID = 9000;

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Font = new Font("Calibri", 10F);
            this.BackColor = Color.FromArgb(245, 245, 255);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = true;

            lblStats.Text = "Tıklama: 0  Süre: 00:00";


            btnStartStop.HoverState.FillColor = Color.Green; // Neon mavi
            btnStartStop.HoverState.BorderColor = Color.LimeGreen;
            btnStartStop.HoverState.ForeColor = Color.White;
            btnStartStop.HoverState.Font = new Font("Calibri", 10F, FontStyle.Bold);
            btnStartStop.Animated = true;

            btnStartStop.ShadowDecoration.Enabled = true;
            btnStartStop.ShadowDecoration.BorderRadius = 10;
            btnStartStop.ShadowDecoration.Color = Color.Cyan;
            btnStartStop.ShadowDecoration.Shadow = new Padding(3);


            new Guna2ShadowForm(this); // gölge verir

            guna2ControlBoxClose.ShadowDecoration.Enabled = true;
            guna2ControlBoxClose.ShadowDecoration.BorderRadius = 5;
            guna2ControlBoxClose.ShadowDecoration.Color = Color.Red;
            guna2ControlBoxClose.ShadowDecoration.Depth = 10;
            guna2ControlBoxClose.ShadowDecoration.Shadow = new Padding(5);
            guna2ControlBoxClose.HoverState.FillColor = Color.FromArgb(255, 30, 30);

            // Minimize butonu ışık efekti
            guna2ControlBoxMinimize.ShadowDecoration.Enabled = true;
            guna2ControlBoxMinimize.ShadowDecoration.BorderRadius = 5;
            guna2ControlBoxMinimize.ShadowDecoration.Color = Color.Gray;
            guna2ControlBoxMinimize.ShadowDecoration.Depth = 10;
            guna2ControlBoxMinimize.ShadowDecoration.Shadow = new Padding(5);
            guna2ControlBoxMinimize.HoverState.FillColor = Color.Gray;

            Guna2Elipse elipse = new Guna2Elipse();
            elipse.BorderRadius = 20;  // yuvarlak köşe
            elipse.TargetControl = this;


            cmbButton.Items.Clear();
            cmbButton.Items.Add("Sol Tık");
            cmbButton.Items.Add("Sağ Tık");
            cmbButton.SelectedIndex = 0;

            nudInterval.Minimum = 1;
            nudInterval.Maximum = 10000;
            nudInterval.Value = 100;

            nudClickLimit.Minimum = 0;
            nudClickLimit.Value = 0;

            txtHotkey.ReadOnly = true;
            txtHotkey.Text = "F6";
            this.KeyPreview = true;
            txtHotkey.KeyDown += txtHotkey_KeyDown;

            lblStatus.Text = "Durum: Hazır";

            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Auto Clicker - Arka Planda";
            notifyIcon1.ContextMenuStrip = trayMenu;


            btnStartStop.BorderRadius = 10;
            btnStartStop.FillColor = Color.LimeGreen;
            btnStartStop.Font = new Font("Calibri", 10F, FontStyle.Bold);
            btnStartStop.Text = "Başlat";

            new Guna2ShadowForm(this); // Gölge efekti

            // Ayarları yükle
            if (Properties.Settings.Default.IntervalValue > 0)
                nudInterval.Value = Properties.Settings.Default.IntervalValue;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.SelectedButton))
                cmbButton.SelectedItem = Properties.Settings.Default.SelectedButton;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.HotkeyValue))
            {
                txtHotkey.Text = Properties.Settings.Default.HotkeyValue;
                userHotkey = (Keys)Enum.Parse(typeof(Keys), Properties.Settings.Default.HotkeyValue);
            }


            RegisterHotKey(this.Handle, HOTKEY_ID, MOD_NONE, (int)userHotkey);
        }

        private void txtHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            userHotkey = e.KeyCode;
            txtHotkey.Text = e.KeyCode.ToString();
            e.SuppressKeyPress = true;
            RegisterNewHotkey(userHotkey);
        }

        private void RegisterNewHotkey(Keys newKey)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            RegisterHotKey(this.Handle, HOTKEY_ID, MOD_NONE, (int)newKey);
        }

        private void ToggleClicker()
        {
            if (!isRunning)
            {
                sw.Restart();
                clickCount = 0;
                timer1.Interval = (int)nudInterval.Value;
                isRunning = true;
                timer1.Start();

                btnStartStop.Text = "Durdur";
                btnStartStop.FillColor = Color.LightCoral;
                lblStatus.Text = "Durum: Çalışıyor...";
            }
            else
            {
                sw.Stop(); // önce durdur

                TimeSpan elapsed = sw.Elapsed; // süreyi al
                lblStats.Text = $"Tıklama: {clickCount}  Süre: {elapsed:mm\\:ss}";

                timer1.Stop();
                isRunning = false;

                btnStartStop.Text = "Başlat";
                btnStartStop.FillColor = Color.LimeGreen;
                lblStatus.Text = "Durum: Durduruldu";

                // Ayarları kaydet
                Properties.Settings.Default.IntervalValue = (int)nudInterval.Value;
                Properties.Settings.Default.SelectedButton = cmbButton.SelectedItem.ToString();
                Properties.Settings.Default.HotkeyValue = txtHotkey.Text;
                Properties.Settings.Default.Save();


            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan elapsed = sw.Elapsed;
            lblStats.Text = $"Tıklama: {clickCount}  Süre: {elapsed:mm\\:ss}";


            string selectedButton = cmbButton.SelectedItem.ToString();
            string clickType = selectedButton == "Sol Tık" ? "sol" : "sağ";

            MouseClicker.Click(clickType);
            clickCount++;

            if (nudClickLimit.Value > 0 && clickCount >= nudClickLimit.Value)
            {
                ToggleClicker();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (chkHotkey.Checked && keyData == userHotkey)
            {
                ToggleClicker();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                ToggleClicker();
            }
            base.WndProc(ref m);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
        }

        public static class MouseClicker
        {
            [DllImport("user32.dll")]
            private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

            private const uint LEFT_DOWN = 0x02;
            private const uint LEFT_UP = 0x04;
            private const uint RIGHT_DOWN = 0x08;
            private const uint RIGHT_UP = 0x10;

            public static void Click(string button)
            {
                uint X = (uint)Cursor.Position.X;
                uint Y = (uint)Cursor.Position.Y;

                if (button == "sol")
                    mouse_event(LEFT_DOWN | LEFT_UP, X, Y, 0, 0);
                else if (button == "sağ")
                    mouse_event(RIGHT_DOWN | RIGHT_UP, X, Y, 0, 0);
            }
        }

        private void btnStartStop_Click_1(object sender, EventArgs e)
        {
            ToggleClicker();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void gösterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void başlatDurdurToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToggleClicker();
        }

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }

    }
}
