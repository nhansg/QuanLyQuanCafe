using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }
        public List<Account> Account()
        {
            List<Account> listAccount = new List<Account>();
            string query = "SELECT * FROM dbo.Account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                listAccount.Add(account);
            }

            return listAccount;
        }
        public bool Login(string tenTaiKhoan, string passWord)
        {
            string query = "Login @tenTaiKhoan , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[]{tenTaiKhoan,passWord});
            return result.Rows.Count > 0;

        }
        public Account AccountByUser(string tenTaiKhoan)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE TenTaiKhoan='"+tenTaiKhoan+ "'");
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public bool UpdateAccount(string tenTaiKhoan,string tenHienThi,string passWord,string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC UpdateAccount @tenTaiKhoan , @tenHienThi , @passWord , @newPassWord ", new object[] { tenTaiKhoan, tenHienThi, passWord, newPass });
            return result > 0;
        }
        public bool InsertAccount(string tenTaiKhoan, string tenHienThi, int type)
        {
            string query = string.Format("INSERT dbo.Account(TenTaiKhoan,TenHienThi,LoaiTaiKhoan) VALUES (N'{0}',N'{1}',N'{2}')", tenTaiKhoan, tenHienThi, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateListAccount(int id,string tenTaiKhoan, string tenHienThi,string pass, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET TenTaiKhoan = N'{0}',TenHienThi =N'{1}',LoaiTaiKhoan={2}, PassWord=N'{3}' WHERE IDAccount={4}", tenTaiKhoan, tenHienThi, type,pass,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteAccount(int id)
        {

            string query = string.Format("DELETE dbo.Account WHERE IDAccount = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
