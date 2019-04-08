namespace TKB_THCS
{
    partial class fGiaovien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGiaovien));
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnLuu = new MetroFramework.Controls.MetroButton();
            this.cbxChuyenmon = new MetroFramework.Controls.MetroComboBox();
            this.bindingSourceGiaovien = new System.Windows.Forms.BindingSource(this.components);
            this.ckbNam = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.txtDT = new MetroFramework.Controls.MetroTextBox();
            this.txtTiettuan = new MetroFramework.Controls.MetroTextBox();
            this.txtDC = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtNgaysinh = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtHoten = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbKhoi = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiaovien)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(35, 198);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(60, 19);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Giới tính:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(579, 231);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseSelectable = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbxChuyenmon
            // 
            this.cbxChuyenmon.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceGiaovien, "IDMon", true));
            this.cbxChuyenmon.FormattingEnabled = true;
            this.cbxChuyenmon.ItemHeight = 23;
            this.cbxChuyenmon.Location = new System.Drawing.Point(126, 133);
            this.cbxChuyenmon.Name = "cbxChuyenmon";
            this.cbxChuyenmon.Size = new System.Drawing.Size(201, 29);
            this.cbxChuyenmon.TabIndex = 3;
            this.cbxChuyenmon.UseSelectable = true;
            // 
            // bindingSourceGiaovien
            // 
            this.bindingSourceGiaovien.DataSource = typeof(TKB_THCS.GiaoVien);
            // 
            // ckbNam
            // 
            this.ckbNam.AutoSize = true;
            this.ckbNam.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceGiaovien, "GioiTinh", true));
            this.ckbNam.Location = new System.Drawing.Point(127, 202);
            this.ckbNam.Name = "ckbNam";
            this.ckbNam.Size = new System.Drawing.Size(28, 15);
            this.ckbNam.TabIndex = 5;
            this.ckbNam.Text = "?";
            this.ckbNam.UseSelectable = true;
            this.ckbNam.CheckStateChanged += new System.EventHandler(this.ckbNam_CheckStateChanged);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(121, 2);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceGiaovien, "DiaChi", true));
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(451, 133);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Multiline = true;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(203, 84);
            this.metroTextBox3.TabIndex = 8;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDT
            // 
            // 
            // 
            // 
            this.txtDT.CustomButton.Image = null;
            this.txtDT.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtDT.CustomButton.Name = "";
            this.txtDT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDT.CustomButton.TabIndex = 1;
            this.txtDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDT.CustomButton.UseSelectable = true;
            this.txtDT.CustomButton.Visible = false;
            this.txtDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceGiaovien, "SoDT", true));
            this.txtDT.Lines = new string[0];
            this.txtDT.Location = new System.Drawing.Point(451, 104);
            this.txtDT.MaxLength = 32767;
            this.txtDT.Name = "txtDT";
            this.txtDT.PasswordChar = '\0';
            this.txtDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDT.SelectedText = "";
            this.txtDT.SelectionLength = 0;
            this.txtDT.SelectionStart = 0;
            this.txtDT.ShortcutsEnabled = true;
            this.txtDT.Size = new System.Drawing.Size(203, 23);
            this.txtDT.TabIndex = 7;
            this.txtDT.UseSelectable = true;
            this.txtDT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTiettuan
            // 
            // 
            // 
            // 
            this.txtTiettuan.CustomButton.Image = null;
            this.txtTiettuan.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtTiettuan.CustomButton.Name = "";
            this.txtTiettuan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTiettuan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTiettuan.CustomButton.TabIndex = 1;
            this.txtTiettuan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTiettuan.CustomButton.UseSelectable = true;
            this.txtTiettuan.CustomButton.Visible = false;
            this.txtTiettuan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceGiaovien, "SoTiet", true));
            this.txtTiettuan.Lines = new string[0];
            this.txtTiettuan.Location = new System.Drawing.Point(451, 75);
            this.txtTiettuan.MaxLength = 32767;
            this.txtTiettuan.Name = "txtTiettuan";
            this.txtTiettuan.PasswordChar = '\0';
            this.txtTiettuan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTiettuan.SelectedText = "";
            this.txtTiettuan.SelectionLength = 0;
            this.txtTiettuan.SelectionStart = 0;
            this.txtTiettuan.ShortcutsEnabled = true;
            this.txtTiettuan.Size = new System.Drawing.Size(203, 23);
            this.txtTiettuan.TabIndex = 6;
            this.txtTiettuan.UseSelectable = true;
            this.txtTiettuan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTiettuan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDC
            // 
            this.txtDC.AutoSize = true;
            this.txtDC.Location = new System.Drawing.Point(361, 133);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(51, 19);
            this.txtDC.TabIndex = 0;
            this.txtDC.Text = "Địa chỉ:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(361, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Số điện thoại:";
            // 
            // txtNgaysinh
            // 
            // 
            // 
            // 
            this.txtNgaysinh.CustomButton.Image = null;
            this.txtNgaysinh.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtNgaysinh.CustomButton.Name = "";
            this.txtNgaysinh.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNgaysinh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNgaysinh.CustomButton.TabIndex = 1;
            this.txtNgaysinh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNgaysinh.CustomButton.UseSelectable = true;
            this.txtNgaysinh.CustomButton.Visible = false;
            this.txtNgaysinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceGiaovien, "NamSinh", true));
            this.txtNgaysinh.Lines = new string[0];
            this.txtNgaysinh.Location = new System.Drawing.Point(126, 104);
            this.txtNgaysinh.MaxLength = 32767;
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.PasswordChar = '\0';
            this.txtNgaysinh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNgaysinh.SelectedText = "";
            this.txtNgaysinh.SelectionLength = 0;
            this.txtNgaysinh.SelectionStart = 0;
            this.txtNgaysinh.ShortcutsEnabled = true;
            this.txtNgaysinh.Size = new System.Drawing.Size(201, 23);
            this.txtNgaysinh.TabIndex = 2;
            this.txtNgaysinh.UseSelectable = true;
            this.txtNgaysinh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNgaysinh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(361, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Số tiết / tuần:";
            // 
            // txtHoten
            // 
            // 
            // 
            // 
            this.txtHoten.CustomButton.Image = null;
            this.txtHoten.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtHoten.CustomButton.Name = "";
            this.txtHoten.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHoten.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoten.CustomButton.TabIndex = 1;
            this.txtHoten.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoten.CustomButton.UseSelectable = true;
            this.txtHoten.CustomButton.Visible = false;
            this.txtHoten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceGiaovien, "TenGV", true));
            this.txtHoten.Lines = new string[0];
            this.txtHoten.Location = new System.Drawing.Point(126, 75);
            this.txtHoten.MaxLength = 32767;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.PasswordChar = '\0';
            this.txtHoten.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoten.SelectedText = "";
            this.txtHoten.SelectionLength = 0;
            this.txtHoten.SelectionStart = 0;
            this.txtHoten.ShortcutsEnabled = true;
            this.txtHoten.Size = new System.Drawing.Size(201, 23);
            this.txtHoten.TabIndex = 1;
            this.txtHoten.UseSelectable = true;
            this.txtHoten.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoten.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(36, 168);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Khối dạy:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(35, 133);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(86, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Chuyên môn:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(36, 104);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Ngày sinh:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(36, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Họ và tên:";
            // 
            // cbKhoi
            // 
            this.cbKhoi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceGiaovien, "ChuyenKhoi", true));
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.ItemHeight = 23;
            this.cbKhoi.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9"});
            this.cbKhoi.Location = new System.Drawing.Point(126, 168);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(201, 29);
            this.cbKhoi.TabIndex = 4;
            this.cbKhoi.UseSelectable = true;
            // 
            // fGiaovien
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 266);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbKhoi);
            this.Controls.Add(this.cbxChuyenmon);
            this.Controls.Add(this.ckbNam);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtTiettuan);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNgaysinh);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fGiaovien";
            this.Resizable = false;
            this.Text = "Cập nhật giáo viên";
            this.Load += new System.EventHandler(this.fGiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGiaovien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnLuu;
        private MetroFramework.Controls.MetroComboBox cbxChuyenmon;
        private MetroFramework.Controls.MetroCheckBox ckbNam;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox txtDT;
        private MetroFramework.Controls.MetroTextBox txtTiettuan;
        private MetroFramework.Controls.MetroLabel txtDC;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtNgaysinh;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtHoten;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.BindingSource bindingSourceGiaovien;
        private MetroFramework.Controls.MetroComboBox cbKhoi;
    }
}