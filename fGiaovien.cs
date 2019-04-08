using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKB_THCS
{
    public partial class fGiaovien : MetroFramework.Forms.MetroForm
    {
        public fGiaovien( GiaoVien obj)
        {
            InitializeComponent();
            bindingSourceGiaovien.DataSource = obj;
            if (ckbNam.CheckState == CheckState.Checked)
                ckbNam.Text = "Nam";
            else if (ckbNam.CheckState == CheckState.Unchecked)
                ckbNam.Text = "Nữ";
            else
                ckbNam.Text = "???";
        }

        public GiaoVien Capnhatgiaovien { get { return bindingSourceGiaovien.Current as GiaoVien; } }

        private void fGiaovien_Load(object sender, EventArgs e)
        {
            cbxChuyenmon.DisplayMember = "Ten";
            cbxChuyenmon.ValueMember = "IDMon";
            using (DbEntities db = new DbEntities())
            {
                cbxChuyenmon.DataSource = db.MonHocs.ToList();
            
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bindingSourceGiaovien.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void ckbNam_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbNam.CheckState == CheckState.Checked)
                ckbNam.Text = "Nam";
            else if (ckbNam.CheckState == CheckState.Unchecked)
                ckbNam.Text = "Nữ";
            else
                ckbNam.Text = "???";
        }

        private void cbxKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
