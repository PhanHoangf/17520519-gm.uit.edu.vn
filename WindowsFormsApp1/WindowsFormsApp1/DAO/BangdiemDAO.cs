using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class BangdiemDAO
    {
        private static BangdiemDAO instance;

        internal static BangdiemDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BangdiemDAO();
                return instance;
            }
            private set
            {
                BangdiemDAO.instance = value;
            }
        }
        private BangdiemDAO() { }

        public List<Bangdiem> Loadlistbangdiem(int idmonhoc,int idlop)
        {
            List<Bangdiem> Listbangdiem = new List<Bangdiem>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Diem1t,bd.HK,bd.Diemtbm from BangDiemMon as bd, DSHocSinh as hs where bd.idlop=" + idlop + " and bd.iDhocsinh=hs.iDhocsinh and bd.idmonhoc=" + idmonhoc + "");
            foreach(DataRow item in data.Rows)
            {
                Bangdiem bangdiem = new Bangdiem(item);
                Listbangdiem.Add(bangdiem);
            }

            return Listbangdiem;
        }
    }
}
