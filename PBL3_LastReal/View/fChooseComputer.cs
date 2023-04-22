using PBL3_LastReal.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBL3_LastReal.View
{
    public partial class fChooseComputer : Form
    {
        public string ID_TaiKhoan;
        public fChooseComputer()
        {
            InitializeComponent();
            GetCBB();
        }
        public void GetCBB()
        {
            QuanLyTaiKhoan tk = new QuanLyTaiKhoan();
            cbb_ChooseComp.Items.AddRange(tk.GetID_May().ToArray());
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            var query = db.Computers.Where(p => p.ID_Computer == Convert.ToInt32(cbb_ChooseComp.Text)).FirstOrDefault();
            if(cbb_ChooseComp.Text == "")
            {
                MessageBox.Show("Chọn máy mà bạn muốn sử dụng!");
            }    
            else
            {
                if (query.State == 0)
                {
                    this.Hide();
                    query.State = 1;
                    fClient f = new fClient();
                    f.ID_May += cbb_ChooseComp.Text;
                    db.SubmitChanges();
                    History his = new History
                    {
                        ID_Account = ID_TaiKhoan,
                        ID_Computer = Convert.ToInt32(cbb_ChooseComp.Text),
                        TimeBegin = DateTime.Now
                    };
                    db.Histories.InsertOnSubmit(his);
                    db.SubmitChanges();
                    f.ShowDialog();
                    this.Close();
                }
                else if (query.State == 1)
                {
                    MessageBox.Show("Máy đã có người dùng!");
                }
                else if (query.State == 2)
                {
                    MessageBox.Show("Máy hiện tại đang hỏng!");
                }
            }
        }
    }
}
