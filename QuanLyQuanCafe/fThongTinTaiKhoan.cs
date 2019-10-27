using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class fThongTinTaiKhoan : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fThongTinTaiKhoan(Account acc)
        {
            InitializeComponent();
            loginAccount = acc;
            LoadAccountList();
        }
        #region Account
        void ChangeAccount(Account acc)
        {
            
        }
        #endregion
        #region Pain
        private void VeHinh(Graphics g, Rectangle rect)
        {
            Image img = Image.FromFile(@"D:\coffeeBaner.jpg");
            g.DrawImage(img, rect);
        }
        private void VeChu(Graphics g, Rectangle rect)
        {
            Font font = new Font("Arial", 15);
            Color color = Color.Honeydew;
            SolidBrush br = new SolidBrush(color);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Near;
            g.DrawString(this.Text, font, br, rect, format);
        }
       
        private void fThongTinTaiKhoan_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, ClientRectangle.Width,50);
            Rectangle rect1 = new Rectangle(0, 0, 200,50);
            VeHinh(e.Graphics, rect);
            VeChu(e.Graphics, rect1);
        }

        private void fThongTinTaiKhoan_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
  
        #endregion
        BindingSource bindingAccount = new BindingSource();

        void LoadAccountList()
        {
            LoadAccount();
            BindingAccount();
        }

        void LoadAccount()
        {
            bindingAccount.DataSource = AccountDAO.Instance.Account();
            dtgvAccount.DataSource = bindingAccount;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        void BindingAccount()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "IDAccount"));
            txbHienThi.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "TenHienThi"));
            txbPass.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "PassWord"));
            nmType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "LoaiTaiKhoan"));
            txbTen.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "TenTaiKhoan"));

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txbTen.Text;
            string tenHienThi = txbHienThi.Text;
            int type = (int)nmType.Value;
            if (AccountDAO.Instance.InsertAccount(tenTaiKhoan,tenHienThi,type))
            {
                MessageBox.Show("Thêm thành công");
                LoadAccount();
            }
            else
                MessageBox.Show("Thêm không thành công");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txbTen.Text;
            string tenHienThi = txbHienThi.Text;
            string pass = txbPass.Text;
            int type = (int)nmType.Value;
            
            int id = Convert.ToInt32(txbID.Text);


            if (AccountDAO.Instance.UpdateListAccount(id,tenTaiKhoan,tenHienThi,pass,type))
            {
                MessageBox.Show("Sửa thành công");
                LoadAccount();
            }
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbID.Text);
            DeleteAccount(id);
        }

        void DeleteAccount(int id)
        {
            if(loginAccount.IdAccount.Equals(id))
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(id))
            {
                MessageBox.Show("Xóa thành công");
                LoadAccount();
            }
            else
                MessageBox.Show("Xóa không thành công");
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

 
    }
}
