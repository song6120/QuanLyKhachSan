namespace QuanLyKhachSan
{
    partial class GoiDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoaiDichVu = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataDichVu = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.DataDichVuDaChon = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Them = new System.Windows.Forms.DataGridViewImageColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDichVuDaChon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Location = new System.Drawing.Point(1226, 696);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 62);
            this.panel4.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(0, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(169, 62);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.bunifuCustomLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(1418, 69);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Thêm dịch vụ";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.DataDichVuDaChon);
            this.panel1.Controls.Add(this.DataDichVu);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbPhong);
            this.panel1.Location = new System.Drawing.Point(9, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1397, 598);
            this.panel1.TabIndex = 8;
            // 
            // lbPhong
            // 
            this.lbPhong.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhong.Location = new System.Drawing.Point(279, 44);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(182, 62);
            this.lbPhong.TabIndex = 1;
            this.lbPhong.Text = "Dịch vụ";
            this.lbPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPhong.Click += new System.EventHandler(this.lbPhong_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(912, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dịch vụ đã chọn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbLoaiDichVu
            // 
            this.cbLoaiDichVu.FormattingEnabled = true;
            this.cbLoaiDichVu.Location = new System.Drawing.Point(0, 21);
            this.cbLoaiDichVu.Name = "cbLoaiDichVu";
            this.cbLoaiDichVu.Size = new System.Drawing.Size(200, 24);
            this.cbLoaiDichVu.TabIndex = 3;
            this.cbLoaiDichVu.SelectedIndexChanged += new System.EventHandler(this.cbLoaiDichVu_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLoaiDichVu);
            this.groupBox1.Location = new System.Drawing.Point(36, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại dịch vụ";
            // 
            // DataDichVu
            // 
            this.DataDichVu.AllowUserToAddRows = false;
            this.DataDichVu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.DataDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataDichVu.BackgroundColor = System.Drawing.Color.White;
            this.DataDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataDichVu.ColumnHeadersHeight = 40;
            this.DataDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Them});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataDichVu.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataDichVu.DoubleBuffered = true;
            this.DataDichVu.EnableHeadersVisualStyles = false;
            this.DataDichVu.GridColor = System.Drawing.Color.White;
            this.DataDichVu.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.DataDichVu.HeaderForeColor = System.Drawing.Color.White;
            this.DataDichVu.Location = new System.Drawing.Point(36, 203);
            this.DataDichVu.Name = "DataDichVu";
            this.DataDichVu.ReadOnly = true;
            this.DataDichVu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataDichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataDichVu.RowHeadersVisible = false;
            this.DataDichVu.RowHeadersWidth = 51;
            this.DataDichVu.RowTemplate.DividerHeight = 1;
            this.DataDichVu.RowTemplate.Height = 30;
            this.DataDichVu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataDichVu.Size = new System.Drawing.Size(610, 282);
            this.DataDichVu.TabIndex = 9;
            this.DataDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDichVu_CellContentClick);
            // 
            // DataDichVuDaChon
            // 
            this.DataDichVuDaChon.AllowUserToAddRows = false;
            this.DataDichVuDaChon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.DataDichVuDaChon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DataDichVuDaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataDichVuDaChon.BackgroundColor = System.Drawing.Color.White;
            this.DataDichVuDaChon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataDichVuDaChon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataDichVuDaChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataDichVuDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DataDichVuDaChon.ColumnHeadersHeight = 40;
            this.DataDichVuDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xoa});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataDichVuDaChon.DefaultCellStyle = dataGridViewCellStyle15;
            this.DataDichVuDaChon.DoubleBuffered = true;
            this.DataDichVuDaChon.EnableHeadersVisualStyles = false;
            this.DataDichVuDaChon.GridColor = System.Drawing.Color.White;
            this.DataDichVuDaChon.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.DataDichVuDaChon.HeaderForeColor = System.Drawing.Color.White;
            this.DataDichVuDaChon.Location = new System.Drawing.Point(723, 203);
            this.DataDichVuDaChon.Name = "DataDichVuDaChon";
            this.DataDichVuDaChon.ReadOnly = true;
            this.DataDichVuDaChon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataDichVuDaChon.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DataDichVuDaChon.RowHeadersVisible = false;
            this.DataDichVuDaChon.RowHeadersWidth = 51;
            this.DataDichVuDaChon.RowTemplate.DividerHeight = 1;
            this.DataDichVuDaChon.RowTemplate.Height = 30;
            this.DataDichVuDaChon.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataDichVuDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataDichVuDaChon.Size = new System.Drawing.Size(631, 282);
            this.DataDichVuDaChon.TabIndex = 10;
            this.DataDichVuDaChon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDichVuDaChon_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Thêm";
            this.dataGridViewImageColumn1.Image = global::QuanLyKhachSan.Properties.Resources.icons8_macos_maximize_602;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 610;
            // 
            // Them
            // 
            this.Them.HeaderText = "Thêm";
            this.Them.Image = global::QuanLyKhachSan.Properties.Resources.icons8_macos_maximize_602;
            this.Them.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Them.MinimumWidth = 6;
            this.Them.Name = "Them";
            this.Them.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Image = global::QuanLyKhachSan.Properties.Resources.icons8_remove_60;
            this.Xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            // 
            // GoiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 765);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoiDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoiDichVu";
            this.Load += new System.EventHandler(this.GoiDichVu_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDichVuDaChon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThoat;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLoaiDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPhong;
        public Bunifu.Framework.UI.BunifuCustomDataGrid DataDichVuDaChon;
        public Bunifu.Framework.UI.BunifuCustomDataGrid DataDichVu;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Xoa;
        private System.Windows.Forms.DataGridViewImageColumn Them;
    }
}