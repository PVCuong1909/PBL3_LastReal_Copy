using PBL3_LastReal.BLL;
using PBL3_LastReal.View;
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

namespace PBL3_LastReal
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            QuanLyNetDataContext db = new QuanLyNetDataContext();
            string TaiKhoan = tb_username.Text;
            string MatKhau = QuanLyTaiKhoan.MD5Hash(tb_password.Text);
            var query1 = db.Accounts.Where(p => p.Username == TaiKhoan && p.Password == MatKhau && p.Type != null).FirstOrDefault();
            if (tb_username.Text == "" || tb_password.Text == "" || (tb_username.Text == "" && tb_password.Text == ""))
            {
                MessageBox.Show("Vui longf nhaap day du!");
            }
            else
            {
                try
                {
                    if (query1.Username == TaiKhoan && query1.Password == MatKhau)
                    {
                        if (query1.Type == 0)
                        {
                            this.Hide();
                            fAdmin form = new fAdmin();
                            form.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            QuanLyTaiKhoan tk = new QuanLyTaiKhoan();
                            if (tk.CheckTienTaiKhoan((int)query1.Money) == true)
                            {
                                this.Hide();
                                fChooseComputer fcc = new fChooseComputer();
                                fcc.ID_TaiKhoan = query1.ID_Account;
                                fcc.ShowDialog();
                                this.Close();
                                
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản không đủ tiền!");
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                }
            }    
        }
    }
}

