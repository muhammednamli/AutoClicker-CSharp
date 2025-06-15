namespace AutoClicker
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblButton = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblHotkey = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStartStop = new Guna.UI2.WinForms.Guna2Button();
            this.cmbButton = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nudInterval = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtHotkey = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkHotkey = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labelActive = new System.Windows.Forms.Label();
            this.nudClickLimit = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblStats = new System.Windows.Forms.Label();
            this.guna2ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlatDurdurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClickLimit)).BeginInit();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.Location = new System.Drawing.Point(125, 72);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(74, 13);
            this.lblButton.TabIndex = 0;
            this.lblButton.Text = "Tıklama Tuşu:";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(93, 118);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(100, 13);
            this.lblInterval.TabIndex = 2;
            this.lblInterval.Text = "Tıklama Aralığı (ms):";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(61, 165);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(132, 13);
            this.lblLimit.TabIndex = 4;
            this.lblLimit.Text = "Tıklama Limiti (0 = Sınırsız):";
            // 
            // lblHotkey
            // 
            this.lblHotkey.AutoSize = true;
            this.lblHotkey.Location = new System.Drawing.Point(127, 200);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(70, 13);
            this.lblHotkey.TabIndex = 6;
            this.lblHotkey.Text = "Kısayol Tuşu:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(220, 289);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Durum: Hazır";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStartStop
            // 
            this.btnStartStop.BorderRadius = 10;
            this.btnStartStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartStop.FillColor = System.Drawing.Color.LimeGreen;
            this.btnStartStop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Location = new System.Drawing.Point(205, 235);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(128, 35);
            this.btnStartStop.TabIndex = 11;
            this.btnStartStop.Text = "Başlat";
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click_1);
            // 
            // cmbButton
            // 
            this.cmbButton.BackColor = System.Drawing.Color.Transparent;
            this.cmbButton.BorderColor = System.Drawing.Color.LimeGreen;
            this.cmbButton.BorderRadius = 10;
            this.cmbButton.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbButton.FocusedColor = System.Drawing.Color.LimeGreen;
            this.cmbButton.FocusedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.cmbButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbButton.ForeColor = System.Drawing.Color.Black;
            this.cmbButton.ItemHeight = 30;
            this.cmbButton.Items.AddRange(new object[] {
            "Sol Tık",
            "Sağ Tık"});
            this.cmbButton.Location = new System.Drawing.Point(205, 63);
            this.cmbButton.Name = "cmbButton";
            this.cmbButton.Size = new System.Drawing.Size(128, 36);
            this.cmbButton.StartIndex = 0;
            this.cmbButton.TabIndex = 12;
            // 
            // nudInterval
            // 
            this.nudInterval.BackColor = System.Drawing.Color.Transparent;
            this.nudInterval.BorderColor = System.Drawing.Color.LimeGreen;
            this.nudInterval.BorderRadius = 10;
            this.nudInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudInterval.Location = new System.Drawing.Point(205, 105);
            this.nudInterval.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(128, 36);
            this.nudInterval.TabIndex = 13;
            this.nudInterval.UpDownButtonFillColor = System.Drawing.Color.White;
            this.nudInterval.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.nudInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtHotkey
            // 
            this.txtHotkey.BorderColor = System.Drawing.Color.LimeGreen;
            this.txtHotkey.BorderRadius = 10;
            this.txtHotkey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHotkey.DefaultText = "";
            this.txtHotkey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHotkey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHotkey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHotkey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHotkey.FocusedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.txtHotkey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHotkey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHotkey.Location = new System.Drawing.Point(205, 193);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.PlaceholderText = "";
            this.txtHotkey.ReadOnly = true;
            this.txtHotkey.SelectedText = "";
            this.txtHotkey.Size = new System.Drawing.Size(128, 36);
            this.txtHotkey.TabIndex = 14;
            // 
            // chkHotkey
            // 
            this.chkHotkey.BackColor = System.Drawing.Color.Transparent;
            this.chkHotkey.CheckedState.BorderColor = System.Drawing.Color.LimeGreen;
            this.chkHotkey.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.chkHotkey.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chkHotkey.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chkHotkey.Location = new System.Drawing.Point(343, 193);
            this.chkHotkey.Name = "chkHotkey";
            this.chkHotkey.Size = new System.Drawing.Size(40, 20);
            this.chkHotkey.TabIndex = 15;
            this.chkHotkey.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHotkey.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkHotkey.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chkHotkey.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Location = new System.Drawing.Point(340, 216);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(83, 13);
            this.labelActive.TabIndex = 16;
            this.labelActive.Text = "Kısayolu Aktif Et";
            // 
            // nudClickLimit
            // 
            this.nudClickLimit.BackColor = System.Drawing.Color.Transparent;
            this.nudClickLimit.BorderColor = System.Drawing.Color.LimeGreen;
            this.nudClickLimit.BorderRadius = 10;
            this.nudClickLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudClickLimit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudClickLimit.Location = new System.Drawing.Point(205, 151);
            this.nudClickLimit.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudClickLimit.Name = "nudClickLimit";
            this.nudClickLimit.Size = new System.Drawing.Size(128, 36);
            this.nudClickLimit.TabIndex = 17;
            this.nudClickLimit.UpDownButtonFillColor = System.Drawing.Color.White;
            this.nudClickLimit.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(33, 245);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(0, 13);
            this.lblStats.TabIndex = 18;
            // 
            // guna2ControlBoxClose
            // 
            this.guna2ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxClose.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBoxClose.IconColor = System.Drawing.Color.White;
            this.guna2ControlBoxClose.Location = new System.Drawing.Point(442, -1);
            this.guna2ControlBoxClose.Name = "guna2ControlBoxClose";
            this.guna2ControlBoxClose.Size = new System.Drawing.Size(59, 29);
            this.guna2ControlBoxClose.TabIndex = 19;
            // 
            // guna2ControlBoxMinimize
            // 
            this.guna2ControlBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBoxMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBoxMinimize.IconColor = System.Drawing.Color.White;
            this.guna2ControlBoxMinimize.Location = new System.Drawing.Point(377, -1);
            this.guna2ControlBoxMinimize.Name = "guna2ControlBoxMinimize";
            this.guna2ControlBoxMinimize.Size = new System.Drawing.Size(59, 29);
            this.guna2ControlBoxMinimize.TabIndex = 20;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Auto Clicker - Aktif";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.başlatDurdurToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(154, 70);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click_1);
            // 
            // başlatDurdurToolStripMenuItem
            // 
            this.başlatDurdurToolStripMenuItem.Name = "başlatDurdurToolStripMenuItem";
            this.başlatDurdurToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.başlatDurdurToolStripMenuItem.Text = "Başlat / Durdur";
            this.başlatDurdurToolStripMenuItem.Click += new System.EventHandler(this.başlatDurdurToolStripMenuItem_Click_1);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 362);
            this.Controls.Add(this.guna2ControlBoxMinimize);
            this.Controls.Add(this.guna2ControlBoxClose);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.nudClickLimit);
            this.Controls.Add(this.labelActive);
            this.Controls.Add(this.chkHotkey);
            this.Controls.Add(this.txtHotkey);
            this.Controls.Add(this.nudInterval);
            this.Controls.Add(this.cmbButton);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHotkey);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClickLimit)).EndInit();
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblHotkey;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnStartStop;
        private Guna.UI2.WinForms.Guna2ComboBox cmbButton;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudInterval;
        private Guna.UI2.WinForms.Guna2TextBox txtHotkey;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chkHotkey;
        private System.Windows.Forms.Label labelActive;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudClickLimit;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblStats;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxClose;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMinimize;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlatDurdurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

