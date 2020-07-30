using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class Account
    {
        private static Account instance;

        public static Account Instance
        {
            get
            {
                if (instance == null)
                    instance = new Account();
                return Account.instance;
            }
            private set { Account.instance = value; }
        }
        private Account() { }

        public string encoding(string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }

        public bool Login(string userName,string passWord)
        {

            string hasPass = encoding(passWord);

            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] {userName,hasPass});

            return result.Rows.Count > 0;
        }

        public List<AccountDTO> loadDSAccount()
        {
            List<AccountDTO> AccountList = new List<AccountDTO>();
            string query = "select *from TK";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                AccountList.Add(account);
            }
            return AccountList;
        }

        public bool insertTaiKhoan(string tentk, string matkhau, int quyen)
        {
            string hasPass = encoding(matkhau);
            string query = "INSERT INTO TK (Tentk, MatKhau, Quyen) VALUES ( @Tentk , @MatKhau , @Quyen ) ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tentk, hasPass, quyen });
            return result > 0;
        }

        public bool updateTaiKhoan(string tentk, string matkhau, int quyen)
        {
            string query = "UPDATE TK  SET MatKhau = @MatKhau , Quyen = @Quyen WHERE Tentk = @Tentk ";
            string hasPass = encoding(matkhau);
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {  hasPass, quyen , tentk });
            return result > 0;
        }
        public bool deleteTaiKhoan(string tentk)
        {
            string query = "DELETE FROM TK WHERE Tentk = @Tentk ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tentk });
            return result > 0;
        }
        public bool changePassWord(string tentk,string mkhientai,string kiemtramk,string matkhaumoi)
        {
            string query = "USP_DoiMatKhau @tentaikhoan , @matkhauhientai , @checkmatkhauhientai , @matkhaumoi ";
            string hasPass = encoding(mkhientai);
            string newHasPass = encoding(matkhaumoi);
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tentk, hasPass, kiemtramk, newHasPass });
            return result > 0;
        }
    }
}
