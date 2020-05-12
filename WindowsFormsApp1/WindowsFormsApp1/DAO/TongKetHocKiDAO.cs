
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    class TongKetHocKiDAO
    {
        private static TongKetHocKiDAO instance;

        internal static TongKetHocKiDAO Instance {
            get
            {
                if (instance == null)
                    instance = new TongKetHocKiDAO();
                return instance;
            }
            private set { TongKetHocKiDAO.instance = value; }
        }

        private TongKetHocKiDAO() { }

        public DataTable loadTongKetHocKi(int idlop, int hocki)
        {
            DataTable data;
            string query = "EXEC USP_TongKetHocKi @idlop , @hocki ";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { idlop, hocki });
            return data;
        }
    }
}
