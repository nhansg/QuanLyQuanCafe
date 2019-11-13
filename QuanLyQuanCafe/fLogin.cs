using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyQuanCafe
{
    public partial class fLogin : MetroFramework.Forms.MetroForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

  

        bool Login(String tenTaiKhoan, String passWord)
        {
            return AccountDAO.Instance.Login(tenTaiKhoan, passWord);
        }
     
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)

            {
                e.Cancel = true;
            }
           
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txbTenDangNhap.Text;
            string passWord = txbPassWord.Text;
            if (Login(tenTaiKhoan, passWord))
            {
                Account loginAccount = AccountDAO.Instance.AccountByUser(tenTaiKhoan);
                fManager f = new fManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản và mật khẩu");
            }
        }
    }
}
