namespace DesktopClock
{
    partial class FormClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClock));
            this.panelClock = new System.Windows.Forms.Panel();
            this.labelClock = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.UpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.checkAlwaysTop = new System.Windows.Forms.CheckBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.labelTimer = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonClock = new System.Windows.Forms.Button();
            this.imageListButtons = new System.Windows.Forms.ImageList(this.components);
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelClock.SuspendLayout();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownFontSize)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelTimer.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClock
            // 
            this.panelClock.AutoSize = true;
            this.panelClock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelClock.BackColor = System.Drawing.Color.Transparent;
            this.panelClock.Controls.Add(this.labelClock);
            this.panelClock.Location = new System.Drawing.Point(2, 4);
            this.panelClock.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(112, 37);
            this.panelClock.TabIndex = 0;
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Location = new System.Drawing.Point(0, 0);
            this.labelClock.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(106, 37);
            this.labelClock.TabIndex = 0;
            this.labelClock.Text = "It Tiem!";
            // 
            // panelSettings
            // 
            this.panelSettings.AutoSize = true;
            this.panelSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelSettings.Controls.Add(this.button1);
            this.panelSettings.Controls.Add(this.UpDownFontSize);
            this.panelSettings.Controls.Add(this.checkAlwaysTop);
            this.panelSettings.Location = new System.Drawing.Point(136, 4);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(328, 186);
            this.panelSettings.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(102, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change Font Size";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpDownFontSize
            // 
            this.UpDownFontSize.BackColor = System.Drawing.Color.Black;
            this.UpDownFontSize.ForeColor = System.Drawing.Color.White;
            this.UpDownFontSize.Location = new System.Drawing.Point(21, 108);
            this.UpDownFontSize.Name = "UpDownFontSize";
            this.UpDownFontSize.Size = new System.Drawing.Size(75, 43);
            this.UpDownFontSize.TabIndex = 2;
            this.UpDownFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkAlwaysTop
            // 
            this.checkAlwaysTop.AutoSize = true;
            this.checkAlwaysTop.Location = new System.Drawing.Point(21, 33);
            this.checkAlwaysTop.Name = "checkAlwaysTop";
            this.checkAlwaysTop.Size = new System.Drawing.Size(210, 41);
            this.checkAlwaysTop.TabIndex = 1;
            this.checkAlwaysTop.Text = "Always On Top";
            this.checkAlwaysTop.UseVisualStyleBackColor = true;
            this.checkAlwaysTop.CheckedChanged += new System.EventHandler(this.checkAlwaysTop_CheckedChanged);
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.Controls.Add(this.panelTimer);
            this.panelMain.Controls.Add(this.panelClock);
            this.panelMain.Controls.Add(this.panelSettings);
            this.panelMain.Location = new System.Drawing.Point(12, 76);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(470, 197);
            this.panelMain.TabIndex = 2;
            // 
            // panelTimer
            // 
            this.panelTimer.AutoSize = true;
            this.panelTimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTimer.BackColor = System.Drawing.Color.Transparent;
            this.panelTimer.Controls.Add(this.labelTimer);
            this.panelTimer.Location = new System.Drawing.Point(3, 66);
            this.panelTimer.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(121, 37);
            this.panelTimer.TabIndex = 0;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(0, 0);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(115, 37);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "It Timer!";
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.Controls.Add(this.buttonClock);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonTimer);
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(189, 61);
            this.panelMenu.TabIndex = 3;
            // 
            // buttonClock
            // 
            this.buttonClock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClock.BackColor = System.Drawing.Color.Black;
            this.buttonClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClock.ImageIndex = 0;
            this.buttonClock.ImageList = this.imageListButtons;
            this.buttonClock.Location = new System.Drawing.Point(0, 0);
            this.buttonClock.Name = "buttonClock";
            this.buttonClock.Size = new System.Drawing.Size(58, 58);
            this.buttonClock.TabIndex = 2;
            this.buttonClock.UseVisualStyleBackColor = false;
            // 
            // imageListButtons
            // 
            this.imageListButtons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtons.ImageStream")));
            this.imageListButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtons.Images.SetKeyName(0, "stopwatch.png");
            this.imageListButtons.Images.SetKeyName(1, "duration.png");
            this.imageListButtons.Images.SetKeyName(2, "cog.png");
            // 
            // buttonSettings
            // 
            this.buttonSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ImageIndex = 2;
            this.buttonSettings.ImageList = this.imageListButtons;
            this.buttonSettings.Location = new System.Drawing.Point(128, 0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(58, 58);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonTimer
            // 
            this.buttonTimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimer.ImageIndex = 1;
            this.buttonTimer.ImageList = this.imageListButtons;
            this.buttonTimer.Location = new System.Drawing.Point(64, 0);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(58, 58);
            this.buttonTimer.TabIndex = 2;
            this.buttonTimer.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(627, 297);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "FormClock";
            this.Text = "FormClock";
            this.Load += new System.EventHandler(this.FormClock_Load);
            this.panelClock.ResumeLayout(false);
            this.panelClock.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownFontSize)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelClock;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonClock;
        private System.Windows.Forms.CheckBox checkAlwaysTop;

        private System.Windows.Forms.NumericUpDown UpDownFontSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageListButtons;
    }
}