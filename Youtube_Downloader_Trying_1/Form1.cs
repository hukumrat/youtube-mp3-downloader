using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_Downloader_Trying_1
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void showForm<MiForm>() where MiForm : Form, new()
        {
            Form form;
            form = panelChildForm.Controls.OfType<MiForm>().FirstOrDefault();
            if (form == null)
            {
                form = new MiForm();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(form);
                panelChildForm.Tag = form;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.BringToFront();
            }
        }
        private void bunifuTileDownload_Click(object sender, EventArgs e)
        {
            showForm<formDownload>();
            //childForm(new formDownload());
            bunifuTileDownload.color = Color.FromArgb(61, 61, 61);
            bunifuTileSettings.color = Color.FromArgb(50, 50, 50);
        }

        private void bunifuTileSettings_Click(object sender, EventArgs e)
        {
            showForm<formSettings>();
            //childForm(new formSettings());
            bunifuTileSettings.color = Color.FromArgb(61, 61, 61);
            bunifuTileDownload.color = Color.FromArgb(50, 50, 50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelLeftSide.BackColor = Color.FromArgb(50, 50, 50);
            showForm<formDownload>();
            //childForm(new formDownload());
            bunifuTileDownload.color = Color.FromArgb(61, 61, 61);
        }
    }
}
