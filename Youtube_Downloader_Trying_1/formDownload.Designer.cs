namespace Youtube_Downloader_Trying_1
{
    partial class formDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDownload));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.bnfbtnAddDownload2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblOutputFilename = new System.Windows.Forms.Label();
            this.lblaudioPath = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.circleProgressbar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerTheme = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelHeader.Controls.Add(this.bnfbtnAddDownload2);
            this.panelHeader.Controls.Add(this.lblOutputFilename);
            this.panelHeader.Controls.Add(this.lblaudioPath);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(895, 129);
            this.panelHeader.TabIndex = 0;
            // 
            // bnfbtnAddDownload2
            // 
            this.bnfbtnAddDownload2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.bnfbtnAddDownload2.color = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.bnfbtnAddDownload2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bnfbtnAddDownload2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfbtnAddDownload2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bnfbtnAddDownload2.ForeColor = System.Drawing.Color.White;
            this.bnfbtnAddDownload2.Image = global::Youtube_Downloader_Trying_1.Properties.Resources.link_light;
            this.bnfbtnAddDownload2.ImagePosition = 0;
            this.bnfbtnAddDownload2.ImageZoom = 100;
            this.bnfbtnAddDownload2.LabelPosition = 0;
            this.bnfbtnAddDownload2.LabelText = "Tile 1";
            this.bnfbtnAddDownload2.Location = new System.Drawing.Point(46, 31);
            this.bnfbtnAddDownload2.Margin = new System.Windows.Forms.Padding(6);
            this.bnfbtnAddDownload2.Name = "bnfbtnAddDownload2";
            this.bnfbtnAddDownload2.Size = new System.Drawing.Size(50, 50);
            this.bnfbtnAddDownload2.TabIndex = 2;
            this.bnfbtnAddDownload2.Click += new System.EventHandler(this.bnfbtnAddDownload2_Click);
            // 
            // lblOutputFilename
            // 
            this.lblOutputFilename.AutoSize = true;
            this.lblOutputFilename.ForeColor = System.Drawing.Color.White;
            this.lblOutputFilename.Location = new System.Drawing.Point(754, 52);
            this.lblOutputFilename.Name = "lblOutputFilename";
            this.lblOutputFilename.Size = new System.Drawing.Size(49, 18);
            this.lblOutputFilename.TabIndex = 2;
            this.lblOutputFilename.Text = "output";
            this.lblOutputFilename.Visible = false;
            // 
            // lblaudioPath
            // 
            this.lblaudioPath.AutoSize = true;
            this.lblaudioPath.ForeColor = System.Drawing.Color.White;
            this.lblaudioPath.Location = new System.Drawing.Point(754, 21);
            this.lblaudioPath.Name = "lblaudioPath";
            this.lblaudioPath.Size = new System.Drawing.Size(39, 18);
            this.lblaudioPath.TabIndex = 1;
            this.lblaudioPath.Text = "input";
            this.lblaudioPath.Visible = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelFooter.Controls.Add(this.circleProgressbar2);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 544);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(895, 138);
            this.panelFooter.TabIndex = 0;
            // 
            // circleProgressbar2
            // 
            this.circleProgressbar2.animated = false;
            this.circleProgressbar2.animationIterval = 5;
            this.circleProgressbar2.animationSpeed = 300;
            this.circleProgressbar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.circleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleProgressbar2.BackgroundImage")));
            this.circleProgressbar2.Dock = System.Windows.Forms.DockStyle.Right;
            this.circleProgressbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.circleProgressbar2.ForeColor = System.Drawing.Color.White;
            this.circleProgressbar2.LabelVisible = true;
            this.circleProgressbar2.LineProgressThickness = 8;
            this.circleProgressbar2.LineThickness = 5;
            this.circleProgressbar2.Location = new System.Drawing.Point(757, 0);
            this.circleProgressbar2.Margin = new System.Windows.Forms.Padding(7);
            this.circleProgressbar2.MaxValue = 100;
            this.circleProgressbar2.Name = "circleProgressbar2";
            this.circleProgressbar2.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleProgressbar2.ProgressColor = System.Drawing.Color.SeaGreen;
            this.circleProgressbar2.Size = new System.Drawing.Size(138, 138);
            this.circleProgressbar2.TabIndex = 3;
            this.circleProgressbar2.Value = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelGrid.Controls.Add(this.metroGrid);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 129);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(4);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(895, 415);
            this.panelGrid.TabIndex = 0;
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToAddRows = false;
            this.metroGrid.AllowUserToDeleteRows = false;
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmSize,
            this.clmStatus,
            this.clmDuration,
            this.clmPath});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.White;
            this.metroGrid.Location = new System.Drawing.Point(0, 0);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.ReadOnly = true;
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(895, 415);
            this.metroGrid.TabIndex = 1;
            this.metroGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellDoubleClick);
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmSize
            // 
            this.clmSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSize.HeaderText = "Size";
            this.clmSize.Name = "clmSize";
            this.clmSize.ReadOnly = true;
            this.clmSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmStatus
            // 
            this.clmStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmDuration
            // 
            this.clmDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDuration.HeaderText = "Duration";
            this.clmDuration.Name = "clmDuration";
            this.clmDuration.ReadOnly = true;
            // 
            // clmPath
            // 
            this.clmPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPath.HeaderText = "Path";
            this.clmPath.Name = "clmPath";
            this.clmPath.ReadOnly = true;
            this.clmPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // formDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(895, 682);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDownload";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.formDownload_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelGrid;
        //private Bunifu.Framework.UI.BunifuTileButton bnfbtnAddDownload;
        private MetroFramework.Controls.MetroGrid metroGrid;
        //private Bunifu.Framework.UI.BunifuCircleProgressbar circleProgressbar;
        private System.Windows.Forms.Label lblaudioPath;
        private System.Windows.Forms.Label lblOutputFilename;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerTheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPath;
        //private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bnfbtnAddDownload2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleProgressbar2;
    }
}