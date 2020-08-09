using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Youtube_Downloader_Trying_1
{
    public partial class formSettings : Form
    {
        public formSettings()
        {
            InitializeComponent();
        }
        private void dark_theme()
        {
            #region dark theme settings
            this.BackColor = Color.FromArgb(42, 42, 42);
            this.lblDir.ForeColor = Color.White;
            this.toggle.ForeColor = Color.White;
            this.btnBrowse.BackColor = Color.FromArgb(42, 42, 42);
            this.btnBrowse.Image = Properties.Resources.browse_light;
            this.txtPath.ForeColor = Color.White;
            this.txtPath.BackColor = Color.FromArgb(42, 42, 42);
            this.txtPath.LineFocusedColor = Color.Gray;
            this.txtPath.LineMouseHoverColor = Color.Gray;
            this.txtPath.LineIdleColor = Color.FromArgb(61, 61, 61);
            #endregion
        }
        private void light_theme()
        {
            #region light theme settings
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.lblDir.ForeColor = Color.Black;
            this.toggle.ForeColor = Color.Black;
            this.btnBrowse.BackColor = Color.FromArgb(240, 240, 240);
            this.btnBrowse.Image = Properties.Resources.browse_dark;
            this.txtPath.ForeColor = Color.Black;
            this.txtPath.BackColor = Color.FromArgb(240, 240, 240);
            this.txtPath.LineFocusedColor = Color.FromArgb(61, 61, 61);
            this.txtPath.LineMouseHoverColor = Color.FromArgb(61, 61, 61);
            this.txtPath.LineIdleColor = Color.Gray;
            #endregion
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            #region browse to get path
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.pathFolder = fbd.SelectedPath;
                Properties.Settings.Default.Save();
                txtPath.Text = Properties.Settings.Default.pathFolder;
            }
            else
            {
                txtPath.Text = Properties.Settings.Default.pathFolder;
            }
            #endregion
        }
        public void formaddurl_darktheme()
        {
            #region formAddUrl dark theme settings
            Properties.Settings.Default.color1 = Color.FromArgb(42, 42, 42);
            Properties.Settings.Default.color2 = Color.FromArgb(61, 61, 61);
            Properties.Settings.Default.color5 = Color.White;
            Properties.Settings.Default.color6 = Color.Black;
            Properties.Settings.Default.color7 = Color.Gray;
            Properties.Settings.Default.color9 = Color.Gray;
            Properties.Settings.Default.color10 = Color.FromArgb(61, 61, 61);
            Properties.Settings.Default.color11 = Color.White;
            Properties.Settings.Default.color12 = Color.Gray;
            Properties.Settings.Default.Save();
            #endregion
        }
        public void formaddurl_lighttheme()
        {
            #region formAddUrl light theme settings
            Properties.Settings.Default.color1 = Color.FromArgb(240, 240, 240);
            Properties.Settings.Default.color2 = Color.FromArgb(224, 224, 224);
            Properties.Settings.Default.color5 = Color.Black;
            Properties.Settings.Default.color6 = Color.Black;
            Properties.Settings.Default.color7 = Color.Gray;
            Properties.Settings.Default.color9 = Color.FromArgb(61, 61, 61);
            Properties.Settings.Default.color10 = Color.Black;
            Properties.Settings.Default.color11 = Color.FromArgb(240, 240, 240);
            Properties.Settings.Default.color12 = Color.FromArgb(61, 61, 61);
            Properties.Settings.Default.Save();
            #endregion
        }
        private void formSettings_Load(object sender, EventArgs e)
        {
            txtPath.Text = Properties.Settings.Default.pathFolder;
        }

        private void toggle_Toggled(object sender, EventArgs e)
        {
            #region changin' theme
            var formDownload = Application.OpenForms.OfType<formDownload>().Single();
            if (toggle.IsOn == true)//dark mode
            {
                dark_theme();
                formDownload.dark_theme();
                formaddurl_darktheme();
            }
            else//light mode
            {
                light_theme();
                formDownload.light_theme();
                formaddurl_lighttheme();
            }
            #endregion
        }
        private void txtPath_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void txtPath_DragDrop(object sender, DragEventArgs e)
        {
            #region drag&drop to get path
            var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && Directory.Exists(path))
            {
                txtPath.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                Properties.Settings.Default.pathFolder = txtPath.Text;
                Properties.Settings.Default.Save();
            }
            #endregion
        }
    }
}
