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
    public partial class fMain : MetroFramework.Forms.MetroForm
    {
       

        bool _logout;
        static fMain _instance;
        
        public fMain()
        {
            InitializeComponent();
        }

      

   

        public static fMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new fMain();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return mpTKB; }
            set { mpTKB = value; }
        }

        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return mlback; }
            set { mlback = value; }
        }

       

        private void fMain_Load(object sender, EventArgs e)
        {
           mlback.Visible = false;
           _instance = this;
           uChinh uc = new uChinh();
           uc.Dock = DockStyle.Fill;
           mpTKB.Controls.Add(uc);
        }

        private void mlback_Click(object sender, EventArgs e)
        {
            mpTKB.Controls["uChinh"].BringToFront();
            mlback.Visible = false;
        }

        private void linkLogout_Click(object sender, EventArgs e)
        {
            _logout = true;
            this.Hide();
            fLogin frm = new fLogin();
            frm.Show();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
            
        }

        private void btnLapTKB_Click(object sender, EventArgs e)
        {
            
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
