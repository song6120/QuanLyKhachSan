namespace QuanLyKhachSan
{
    partial class DatDichVu
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
            this.lbPhong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGoiDichVu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DataThongTinDichVu = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lbNgayTra = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNgayThue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNhanPhong = new System.Windows.Forms.Panel();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panelthanhToan = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.DataPhong = new System.Windows.Forms.DataGridView();
            this.dataMaDatPhong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelGoiDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataThongTinDichVu)).BeginInit();
            this.panelNhanPhong.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelthanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaDatPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPhong
            // 
            this.lbPhong.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhong.Location = new System.Drawing.Point(514, 24);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(182, 73);
            this.lbPhong.TabIndex = 0;
            this.lbPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panelGoiDichVu);
            this.panel1.Controls.Add(this.lbNgayTra);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbNgayThue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbKhachHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DataThongTinDichVu);
            this.panel1.Controls.Add(this.DataPhong);
            this.panel1.Controls.Add(this.dataMaDatPhong);
            this.panel1.Location = new System.Drawing.Point(13, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 550);
            this.panel1.TabIndex = 1;
            // 
            // panelGoiDichVu
            // 
            this.panelGoiDichVu.BackColor = System.Drawing.Color.White;
            this.panelGoiDichVu.Controls.Add(this.button1);
            this.panelGoiDichVu.Location = new System.Drawing.Point(969, 457);
            this.panelGoiDichVu.Name = "panelGoiDichVu";
            this.panelGoiDichVu.Size = new System.Drawing.Size(190, 62);
            this.panelGoiDichVu.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gọi dịch vụ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataThongTinDichVu
            // 
            this.DataThongTinDichVu.AllowUserToAddRows = false;
            this.DataThongTinDichVu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.DataThongTinDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataThongTinDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataThongTinDichVu.BackgroundColor = System.Drawing.Color.White;
            this.DataThongTinDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataThongTinDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataThongTinDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataThongTinDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataThongTinDichVu.ColumnHeadersHeight = 40;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataThongTinDichVu.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataThongTinDichVu.DoubleBuffered = true;
            this.DataThongTinDichVu.EnableHeadersVisualStyles = false;
            this.DataThongTinDichVu.GridColor = System.Drawing.Color.White;
            this.DataThongTinDichVu.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.DataThongTinDichVu.HeaderForeColor = System.Drawing.Color.White;
            this.DataThongTinDichVu.Location = new System.Drawing.Point(24, 93);
            this.DataThongTinDichVu.Name = "DataThongTinDichVu";
            this.DataThongTinDichVu.ReadOnly = true;
            this.DataThongTinDichVu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataThongTinDichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataThongTinDichVu.RowHeadersVisible = false;
            this.DataThongTinDichVu.RowHeadersWidth = 51;
            this.DataThongTinDichVu.RowTemplate.DividerHeight = 1;
            this.DataThongTinDichVu.RowTemplate.Height = 30;
            this.DataThongTinDichVu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataThongTinDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataThongTinDichVu.Size = new System.Drawing.Size(1170, 349);
            this.DataThongTinDichVu.TabIndex = 8;
            // 
            // lbNgayTra
            // 
            this.lbNgayTra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTra.ForeColor = System.Drawing.Color.Black;
            this.lbNgayTra.Location = new System.Drawing.Point(805, 24);
            this.lbNgayTra.Name = "lbNgayTra";
            this.lbNgayTra.Size = new System.Drawing.Size(302, 32);
            this.lbNgayTra.TabIndex = 7;
            this.lbNgayTra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(713, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày trả: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNgayThue
            // 
            this.lbNgayThue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThue.ForeColor = System.Drawing.Color.Black;
            this.lbNgayThue.Location = new System.Drawing.Point(430, 24);
            this.lbNgayThue.Name = "lbNgayThue";
            this.lbNgayThue.Size = new System.Drawing.Size(277, 32);
            this.lbNgayThue.TabIndex = 5;
            this.lbNgayThue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(327, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày thuê: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachHang.ForeColor = System.Drawing.Color.Black;
            this.lbKhachHang.Location = new System.Drawing.Point(137, 24);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(194, 32);
            this.lbKhachHang.TabIndex = 3;
            this.lbKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khách hàng: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNhanPhong
            // 
            this.panelNhanPhong.BackColor = System.Drawing.Color.White;
            this.panelNhanPhong.Controls.Add(this.btnNhanPhong);
            this.panelNhanPhong.Location = new System.Drawing.Point(490, 678);
            this.panelNhanPhong.Name = "panelNhanPhong";
            this.panelNhanPhong.Size = new System.Drawing.Size(190, 62);
            this.panelNhanPhong.TabIndex = 2;
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhanPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNhanPhong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanPhong.ForeColor = System.Drawing.Color.White;
            this.btnNhanPhong.Location = new System.Drawing.Point(0, 0);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(190, 62);
            this.btnNhanPhong.TabIndex = 3;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = false;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Location = new System.Drawing.Point(1064, 678);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 62);
            this.panel4.TabIndex = 5;
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
            // panelthanhToan
            // 
            this.panelthanhToan.BackColor = System.Drawing.Color.White;
            this.panelthanhToan.Controls.Add(this.btnThanhToan);
            this.panelthanhToan.Location = new System.Drawing.Point(541, 678);
            this.panelthanhToan.Name = "panelthanhToan";
            this.panelthanhToan.Size = new System.Drawing.Size(169, 62);
            this.panelthanhToan.TabIndex = 4;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 0);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(169, 62);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // DataPhong
            // 
            this.DataPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPhong.Location = new System.Drawing.Point(517, 218);
            this.DataPhong.Name = "DataPhong";
            this.DataPhong.RowHeadersWidth = 51;
            this.DataPhong.RowTemplate.Height = 24;
            this.DataPhong.Size = new System.Drawing.Size(166, 111);
            this.DataPhong.TabIndex = 9;
            // 
            // dataMaDatPhong
            // 
            this.dataMaDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMaDatPhong.Location = new System.Drawing.Point(115, 169);
            this.dataMaDatPhong.Name = "dataMaDatPhong";
            this.dataMaDatPhong.RowHeadersWidth = 51;
            this.dataMaDatPhong.RowTemplate.Height = 24;
            this.dataMaDatPhong.Size = new System.Drawing.Size(161, 119);
            this.dataMaDatPhong.TabIndex = 10;
            // 
            // DatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 763);
            this.Controls.Add(this.panelthanhToan);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelNhanPhong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatDichVu";
            this.Load += new System.EventHandler(this.DatDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panelGoiDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataThongTinDichVu)).EndInit();
            this.panelNhanPhong.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelthanhToan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaDatPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNgayTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNgayThue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelNhanPhong;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThoat;
        public Bunifu.Framework.UI.BunifuCustomDataGrid DataThongTinDichVu;
        private System.Windows.Forms.Panel panelthanhToan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panelGoiDichVu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataPhong;
        private System.Windows.Forms.DataGridView dataMaDatPhong;
    }
}