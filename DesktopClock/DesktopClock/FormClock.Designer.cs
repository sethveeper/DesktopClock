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
            this.panelClock = new System.Windows.Forms.Panel();
            this.labelClock = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.labelTimer = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonClock = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelClock.SuspendLayout();
            this.panelSettings.SuspendLayout();
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
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelSettings.Location = new System.Drawing.Point(0, 0);
            this.labelSettings.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(143, 37);
            this.labelSettings.TabIndex = 0;
            this.labelSettings.Text = "It Settings!";
            // 
            // panelSettings
            // 
            this.panelSettings.AutoSize = true;
            this.panelSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelSettings.Controls.Add(this.labelSettings);
            this.panelSettings.Location = new System.Drawing.Point(0, 124);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(149, 37);
            this.panelSettings.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.Controls.Add(this.panelTimer);
            this.panelMain.Controls.Add(this.panelClock);
            this.panelMain.Controls.Add(this.panelSettings);
            this.panelMain.Location = new System.Drawing.Point(148, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(155, 168);
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
            this.panelMenu.Size = new System.Drawing.Size(129, 164);
            this.panelMenu.TabIndex = 3;
            // 
            // buttonClock
            // 
            this.buttonClock.BackColor = System.Drawing.Color.Black;
            this.buttonClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClock.Location = new System.Drawing.Point(0, 0);
            this.buttonClock.Name = "buttonClock";
            this.buttonClock.Size = new System.Drawing.Size(126, 50);
            this.buttonClock.TabIndex = 2;
            this.buttonClock.Text = "Clock";
            this.buttonClock.UseVisualStyleBackColor = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(0, 112);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(126, 49);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonTimer
            // 
            this.buttonTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimer.Location = new System.Drawing.Point(0, 56);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(126, 50);
            this.buttonTimer.TabIndex = 2;
            this.buttonTimer.Text = "Timer";
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
            this.Name = "FormClock";
            this.Text = "FormClock";
            this.Load += new System.EventHandler(this.FormClock_Load);
            this.panelClock.ResumeLayout(false);
            this.panelClock.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
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
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonClock;
    }
}