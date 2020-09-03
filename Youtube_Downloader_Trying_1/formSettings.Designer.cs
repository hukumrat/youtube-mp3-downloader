namespace Youtube_Downloader_Trying_1
{
    partial class formSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSettings));
            this.lblDir = new System.Windows.Forms.Label();
            this.txtPath = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.toggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnBrowse = new Bunifu.Framework.UI.BunifuImageButton();
            this.kbpsComboBox = new MetroFramework.Controls.MetroComboBox();
            this.lblKbps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toggle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.ForeColor = System.Drawing.Color.White;
            this.lblDir.Location = new System.Drawing.Point(115, 178);
            this.lblDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(125, 18);
            this.lblDir.TabIndex = 0;
            this.lblDir.Text = "Current Directory:";
            // 
            // txtPath
            // 
            this.txtPath.AllowDrop = true;
            this.txtPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPath.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPath.ForeColor = System.Drawing.Color.White;
            this.txtPath.HintForeColor = System.Drawing.Color.Empty;
            this.txtPath.HintText = "";
            this.txtPath.isPassword = false;
            this.txtPath.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtPath.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtPath.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtPath.LineThickness = 3;
            this.txtPath.Location = new System.Drawing.Point(248, 168);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.MaxLength = 32767;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(379, 33);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "null";
            this.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtPath_DragDrop);
            this.txtPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtPath_DragEnter);
            // 
            // toggle
            // 
            this.toggle.EditValue = true;
            this.toggle.Location = new System.Drawing.Point(118, 360);
            this.toggle.Name = "toggle";
            this.toggle.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.toggle.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.toggle.Properties.Appearance.Options.UseFont = true;
            this.toggle.Properties.Appearance.Options.UseForeColor = true;
            this.toggle.Properties.OffText = "Light Mode";
            this.toggle.Properties.OnText = "Dark Mode";
            this.toggle.Size = new System.Drawing.Size(133, 21);
            this.toggle.TabIndex = 4;
            this.toggle.Toggled += new System.EventHandler(this.toggle_Toggled);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Image = global::Youtube_Downloader_Trying_1.Properties.Resources.browse_light;
            this.btnBrowse.ImageActive = null;
            this.btnBrowse.Location = new System.Drawing.Point(634, 170);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(40, 40);
            this.btnBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.Zoom = 10;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // kbpsComboBox
            // 
            this.kbpsComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.kbpsComboBox.FormattingEnabled = true;
            this.kbpsComboBox.ItemHeight = 19;
            this.kbpsComboBox.Items.AddRange(new object[] {
            "124",
            "192",
            "320"});
            this.kbpsComboBox.Location = new System.Drawing.Point(248, 269);
            this.kbpsComboBox.Name = "kbpsComboBox";
            this.kbpsComboBox.Size = new System.Drawing.Size(121, 25);
            this.kbpsComboBox.Style = MetroFramework.MetroColorStyle.Blue;
            this.kbpsComboBox.TabIndex = 5;
            this.kbpsComboBox.UseSelectable = true;
            this.kbpsComboBox.SelectedIndexChanged += new System.EventHandler(this.kbpsComboBox_SelectedIndexChanged);
            // 
            // lblKbps
            // 
            this.lblKbps.AutoSize = true;
            this.lblKbps.ForeColor = System.Drawing.Color.White;
            this.lblKbps.Location = new System.Drawing.Point(115, 272);
            this.lblKbps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKbps.Name = "lblKbps";
            this.lblKbps.Size = new System.Drawing.Size(95, 18);
            this.lblKbps.TabIndex = 6;
            this.lblKbps.Text = "Audio Bitrate:";
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(895, 682);
            this.Controls.Add(this.lblKbps);
            this.Controls.Add(this.kbpsComboBox);
            this.Controls.Add(this.toggle);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblDir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formSettings";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.formSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toggle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDir;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPath;
        private Bunifu.Framework.UI.BunifuImageButton btnBrowse;
        public DevExpress.XtraEditors.ToggleSwitch toggle;
        private MetroFramework.Controls.MetroComboBox kbpsComboBox;
        private System.Windows.Forms.Label lblKbps;
    }
}