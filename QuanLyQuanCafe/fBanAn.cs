using QuanLyQuanCafe.DAO;
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
    public partial class fBanAn : Form
    {
        BindingSource bindingTable = new BindingSource();
        public fBanAn()
        {
            InitializeComponent();
            LoadfBanAn();
     
        }
        void LoadfBanAn()
        {
            LoadListTalbe();
            BindingTalbe();
            
        }
        void LoadListTalbe()
        {
            bindingTable.DataSource = TableDAO.Instance.LoadTableList();
            dtgvBanAn.DataSource = bindingTable;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListTalbe();
        }
        void BindingTalbe()
        {
            txbMaBan.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "MaBan"));
            txbTenBan.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "TenBan"));
            nmKhuVuc.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "KhuVuc"));
            cmbTrangThai.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "TrangThai"));
            txbMieuTa.DataBindings.Add(new Binding("Text", dtgvBanAn.DataSource, "MieuTa"));

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenBan = txbTenBan.Text;
            string trangThai = cmbTrangThai.Text;
            string khuVuc = nmKhuVuc.Value.ToString();
            string mieuTa = txbMieuTa.Text;
            

            if (TableDAO.Instance.InsertBanAn(tenBan, trangThai, khuVuc, mieuTa))
            {
                MessageBox.Show("Thêm thành công");
                LoadListTalbe();
                if (insertTable != null)
                    insertTable(this, new EventArgs());
            }
            else
                MessageBox.Show("Thêm không thành công");

        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenBan = txbTenBan.Text;
            string trangThai = cmbTrangThai.Text;
            string khuVuc = nmKhuVuc.Text;
            string mieuTa = txbMieuTa.Text;
            int maBan = Convert.ToInt32(txbMaBan.Text);
            

            if (TableDAO.Instance.UpdateBanAn(maBan,tenBan, trangThai, khuVuc,mieuTa))
            {
                MessageBox.Show("Sửa thành công");
                LoadListTalbe();
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txbMaBan.Text != "")
            {
                int maBan = Convert.ToInt32(txbMaBan.Text);

                if (TableDAO.Instance.DeleteBanAn(maBan))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadListTalbe();
                    if (deleteTable != null)
                        deleteTable(this, new EventArgs());
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                MessageBox.Show("Không có bàn để xóa");
           
        }
        #region Pain
        private void VeHinh(Graphics g, Rectangle rect)
        {
            Image img = Properties.Resources.coffeeBaner;
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

         private void fBanAn_SizeChanged(object sender, EventArgs e)
        {
             Invalidate();
        }

        private void fBanAn_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, ClientRectangle.Width, 50);
            Rectangle rect1 = new Rectangle(0, 0, 200, 50);
            VeHinh(e.Graphics, rect);
            VeChu(e.Graphics, rect1);
        }
#endregion
        #region events
        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }
        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }
        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }
        #endregion

        
    






    }
        
}

