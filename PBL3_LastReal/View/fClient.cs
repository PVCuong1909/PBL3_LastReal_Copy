using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_LastReal.View
{
    public partial class fClient : Form
    {
        public string ID_May;
        public fClient()
        {
            InitializeComponent();
        }
        private void fClient_Load(object sender, EventArgs e)
        {
            label2.Text = "Máy " + ID_May;
        }
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            
            this.Hide();
            var query = db.Histories.Where(p => p.ID_Computer == Convert.ToInt32(ID_May)).FirstOrDefault();
            query.Computer.State = 0;
            query.TimeEnd = DateTime.Now;
            db.SubmitChanges();
            fLogin f = new fLogin();
            f.ShowDialog();
            this.Close();
        }

        private void btn_MatKhau_Click(object sender, EventArgs e)
        {
            fClientPassword f = new fClientPassword();
            //f.ID_May += ID_May;
            f.ShowDialog();
        }
    }
}
