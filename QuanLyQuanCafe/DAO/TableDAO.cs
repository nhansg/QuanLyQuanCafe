using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        internal static TableDAO Instance
        {
            get {
                if (instance == null)
                    instance = new TableDAO();
                return TableDAO.instance; }
           private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 50;
        public static int TableHight = 60;
        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("GetTableList");

            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public bool InsertBanAn(string tenBan, string TrangThai, string khuVuc,string mieuTa)
        {
            string query = string.Format("INSERT dbo.BanAn(TenBan,TrangThai,KhuVuc,MieuTa) VALUES (N'{0}',N'{1}',N'{2}',N'{3}')", tenBan, TrangThai, khuVuc,mieuTa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateBanAn(int maBan,string tenBan, string TrangThai, string khuVuc, string mieuTa)
        {
            string query = string.Format("UPDATE dbo.BanAn SET TenBan = N'{0}',TrangThai =N'{1}',KhuVuc=N'{2}',MieuTa=N'{3}' WHERE MaBan={4}", tenBan, TrangThai, khuVuc, mieuTa,maBan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteBanAn(int maBan)
        {
            List<HoaDon> list = HoaDonDAO.Instance.LayMaHoaDonByBan(maBan);
            foreach(HoaDon item in list)
            {
                HoaDonChiTietDAO.Instance.DeleteBillInfoByMaHoaDon(item.MaHoaDon);
            }
            
            HoaDonDAO.Instance.DeleteBillByTable(maBan);
            string query = string.Format("DELETE dbo.BanAn WHERE maban = {0}",maBan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
