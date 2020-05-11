using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    class TongKetMonDAO
    {
        private static TongKetMonDAO instance;

        internal static TongKetMonDAO Instance {
            get
            {
                if (instance == null)
                    instance = new TongKetMonDAO();
                return instance;
            }
            private set
            {
                TongKetMonDAO.instance = value;
            }
        }
        private TongKetMonDAO() { }

        public List<TongKetMon> loadTongKetMonList()
        {
            List<TongKetMon> tongKets = new List<TongKetMon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select *form TongKetMon");
            foreach(DataRow item in data.Rows)
            {
                TongKetMon tongKet = new TongKetMon(item);
                tongKets.Add(tongKet);

            }
            return tongKets;
        }
        public DataTable loadTongKetMonbyID(int idlop, int idmonhoc)
        {
            string query = "EXEC USP_TongKetMon @idlop , @idmonhoc ";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query,new object[] { idlop , idmonhoc });
            return data;
        }
        public DataTable loadTongKetMon()
        {
            string query = "SELECT *FROM TongKetMon";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public int countHsDat(int idmon, int idlop)
        {
            string query = "select COUNT(*) from TongKetMon where [Ghi chú] = N'Đạt' and [ID môn học] = " + idmon + " and [ID Lớp] = " + idlop + " ";
            object a = DataProvider.Instance.ExecuteScalar(query);
            int b = (int)a;
            return b;
        }
    }
}
