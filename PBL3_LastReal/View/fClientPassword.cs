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
    public partial class fClientPassword : Form
    {
        public int ID_TK;
        public fClientPassword()
        {
            InitializeComponent();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            //var query = db.Histories.Where(p => p.ID_Computer == Convert.ToInt32(ID_May)).FirstOrDefault();
        }
    }
}
