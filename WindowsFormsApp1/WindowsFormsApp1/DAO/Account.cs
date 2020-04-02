using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    class Account
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

        public bool Login(string userName,string passWord)
        {
            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] {userName,passWord});

            return result.Rows.Count > 0;
        }
    }
}
