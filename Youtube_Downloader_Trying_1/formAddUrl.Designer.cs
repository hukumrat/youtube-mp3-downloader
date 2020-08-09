namespace Youtube_Downloader_Trying_1
{
    partial class formAddUrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddUrl));
            this.txtUrl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAddToQueue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUrl.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUrl.ForeColor = System.Drawing.Color.White;
            this.txtUrl.HintForeColor = System.Drawing.Color.Empty;
            this.txtUrl.HintText = "";
            this.txtUrl.isPassword = false;
            this.txtUrl.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtUrl.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUrl.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtUrl.LineThickness = 3;
            this.txtUrl.Location = new System.Drawing.Point(101, 55);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(379, 33);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "URL";
            this.txtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // btnAddToQueue
            // 
            this.btnAddToQueue.ActiveBorderThickness = 1;
            this.btnAddToQueue.ActiveCornerRadius = 20;
            this.btnAddToQueue.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnAddToQueue.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddToQueue.ActiveLineColor = System.Drawing.Color.White;
            this.btnAddToQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAddToQueue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToQueue.BackgroundImage")));
            this.btnAddToQueue.ButtonText = "Add to queue";
            this.btnAddToQueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToQueue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToQueue.ForeColor = System.Drawing.Color.Black;
            this.btnAddToQueue.IdleBorderThickness = 1;
            this.btnAddToQueue.IdleCornerRadius = 20;
            this.btnAddToQueue.IdleFillColor = System.Drawing.Color.White;
            this.btnAddToQueue.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnAddToQueue.IdleLineColor = System.Drawing.Color.Gray;
            this.btnAddToQueue.Location = new System.Drawing.Point(101, 124);
            this.btnAddToQueue.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddToQueue.Name = "btnAddToQueue";
            this.btnAddToQueue.Size = new System.Drawing.Size(379, 41);
            this.btnAddToQueue.TabIndex = 5;
            this.btnAddToQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddToQueue.Click += new System.EventHandler(this.btnAddToQueue_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formAddUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(582, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddToQueue);
            this.Controls.Add(this.txtUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(598, 250);
            this.MinimumSize = new System.Drawing.Size(598, 250);
            this.Name = "formAddUrl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Url";
            this.Load += new System.EventHandler(this.formAddUrl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuMaterialTextbox txtUrl;
        public Bunifu.Framework.UI.BunifuThinButton2 btnAddToQueue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}