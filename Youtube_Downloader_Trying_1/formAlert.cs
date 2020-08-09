using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Youtube_Downloader_Trying_1.Properties;

namespace Youtube_Downloader_Trying_1
{
    public partial class formAlert : Form
    {
        public formAlert()
        {
            InitializeComponent();
        }
        public enum enmAction
        {
            wait, start, close
        }
        public enum enmType
        {
            success, warning, info, error
        }
        private enmAction action;
        public int x, y;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            this.action = formAlert.enmAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    this.action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1)
                        {
                            action = formAlert.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i = 1; i < 13; i++)
            {
                fname = "alert" + i.ToString();
                formAlert frmalrt = (formAlert)Application.OpenForms[fname];
                if (frmalrt == null)
                {
                    this.Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                    y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(x, y);
                    this.lblMsg.Text = msg;
                    timer1.Start();
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 11;
            switch (type)
            {
                case enmType.success:
                    this.BackColor = Color.SeaGreen;
                    this.pictureBox2.Image = Resources.success;
                    break;
                case enmType.warning:
                    this.BackColor = Color.OrangeRed;
                    this.pictureBox2.Image = Resources.warning;
                    break;
                case enmType.info:
                    this.BackColor = Color.FromArgb(0, 122, 204);
                    this.pictureBox2.Image = Resources.info;
                    break;
                case enmType.error:
                    this.BackColor = Color.Red;
                    this.pictureBox2.Image = Resources.error;
                    break;
                default:
                    break;
            }
            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
