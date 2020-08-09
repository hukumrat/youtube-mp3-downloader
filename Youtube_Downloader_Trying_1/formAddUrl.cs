using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Youtube_Downloader_Trying_1
{
    public partial class formAddUrl : Form
    {
        public formAddUrl()
        {
            InitializeComponent();
        }
        Regex r = new Regex(@"^((?:https?:)?\/\/)?((?:www|m)\.)?((?:youtube\.com|youtu.be))(\/(?:[\w\-]+\?v=|embed\/|v\/)?)([\w\-]+)(\S+)?$");
        public string getUrl
        {
            get { return txtUrl.Text; }
        }
        public void theme()
        {
            #region theme checkin'
            this.BackColor = Properties.Settings.Default.color1;
            btnAddToQueue.BackColor = Properties.Settings.Default.color1;
            txtUrl.BackColor = Properties.Settings.Default.color1;
            btnAddToQueue.ActiveFillColor = Properties.Settings.Default.color2;
            btnAddToQueue.IdleForecolor = Properties.Settings.Default.color10;
            btnAddToQueue.ActiveForecolor = Properties.Settings.Default.color5;
            btnAddToQueue.ActiveLineColor = Properties.Settings.Default.color5;
            btnAddToQueue.IdleFillColor = Properties.Settings.Default.color11;
            txtUrl.ForeColor = Properties.Settings.Default.color5;
            btnAddToQueue.ForeColor = Properties.Settings.Default.color6;
            btnAddToQueue.IdleLineColor = Properties.Settings.Default.color7;
            txtUrl.LineFocusedColor = Properties.Settings.Default.color9;
            txtUrl.LineIdleColor = Properties.Settings.Default.color7;
            txtUrl.LineMouseHoverColor = Properties.Settings.Default.color9;
            #endregion  
        }
        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            if (r.IsMatch(txtUrl.Text))
                button1.PerformClick();
        }

        private void formAddUrl_Load(object sender, EventArgs e)
        {
            theme();
            txtUrl.Text = Clipboard.GetText().Trim();
            if (!r.IsMatch(txtUrl.Text))
                txtUrl.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && r.IsMatch(txtUrl.Text))
                button1.PerformClick();
        }
    }
}
