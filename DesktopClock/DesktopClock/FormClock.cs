using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopClock
{
    public partial class FormClock : Form
    {
        Panel[] panelList;
        Button[] buttonList;

        public FormClock()
        {
            InitializeComponent();
            panelList = new Panel[] { panelClock, panelTimer, panelSettings };
            buttonList = new Button[] { buttonClock, buttonTimer, buttonSettings };
        }
        // End of Form Clock constructor

        private void FormClock_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < buttonList.Length; i++)
            {
                buttonList[i].Tag = i;
                buttonList[i].Click += new EventHandler(MenuButton_Click);
            }
            GetPanel(0);

            panelClock.Font = new Font(this.Font.FontFamily, 150);
        }
        // End of For Clock Load event

        private void GetPanel(int index)
        {
            foreach (Panel panel in panelList)
            {
                panel.Visible = false;
                panel.Location = new Point(0, 0);
            }

            panelList[index].Visible = true;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Button sent = sender as Button;
            GetPanel((int)sent.Tag);
        }
        // End of MenuButton Click event

        private void timer_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToShortTimeString();
        }
        // End of Timer Tick event

    }
    // End of Form Clock partial class
}
// End of namespace