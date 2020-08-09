namespace Youtube_Downloader_Trying_1
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.bunifuTileSettings = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileDownload = new Bunifu.Framework.UI.BunifuTileButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelLeftSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.AutoScroll = true;
            this.panelLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelLeftSide.Controls.Add(this.bunifuTileSettings);
            this.panelLeftSide.Controls.Add(this.bunifuTileDownload);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(54, 760);
            this.panelLeftSide.TabIndex = 0;
            // 
            // bunifuTileSettings
            // 
            this.bunifuTileSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTileSettings.AutoSize = true;
            this.bunifuTileSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuTileSettings.color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuTileSettings.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.bunifuTileSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTileSettings.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileSettings.ForeColor = System.Drawing.Color.White;
            this.bunifuTileSettings.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileSettings.Image")));
            this.bunifuTileSettings.ImagePosition = 7;
            this.bunifuTileSettings.ImageZoom = 70;
            this.bunifuTileSettings.LabelPosition = 0;
            this.bunifuTileSettings.LabelText = "";
            this.bunifuTileSettings.Location = new System.Drawing.Point(0, 387);
            this.bunifuTileSettings.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileSettings.Name = "bunifuTileSettings";
            this.bunifuTileSettings.Size = new System.Drawing.Size(54, 54);
            this.bunifuTileSettings.TabIndex = 1;
            this.bunifuTileSettings.Click += new System.EventHandler(this.bunifuTileSettings_Click);
            // 
            // bunifuTileDownload
            // 
            this.bunifuTileDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTileDownload.AutoSize = true;
            this.bunifuTileDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuTileDownload.color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuTileDownload.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bunifuTileDownload.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTileDownload.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileDownload.ForeColor = System.Drawing.Color.White;
            this.bunifuTileDownload.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileDownload.Image")));
            this.bunifuTileDownload.ImagePosition = 7;
            this.bunifuTileDownload.ImageZoom = 70;
            this.bunifuTileDownload.LabelPosition = 0;
            this.bunifuTileDownload.LabelText = "";
            this.bunifuTileDownload.Location = new System.Drawing.Point(0, 321);
            this.bunifuTileDownload.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileDownload.Name = "bunifuTileDownload";
            this.bunifuTileDownload.Size = new System.Drawing.Size(54, 54);
            this.bunifuTileDownload.TabIndex = 0;
            this.bunifuTileDownload.Click += new System.EventHandler(this.bunifuTileDownload_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(54, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(927, 760);
            this.panelChildForm.TabIndex = 1;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(981, 760);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelLeftSide);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(981, 760);
            this.Name = "formMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeftSide.ResumeLayout(false);
            this.panelLeftSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSide;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileDownload;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileSettings;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

