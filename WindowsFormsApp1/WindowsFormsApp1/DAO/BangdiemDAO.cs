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

        public List<Bangdiem> Loadlistbangdiem()
        {
            List<Bangdiem> Listbangdiem = new List<Bangdiem>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT *FROM BangDiemMon");
            foreach(DataRow item in data.Rows)
            {
                Bangdiem bangdiem = new Bangdiem(item);
                Listbangdiem.Add(bangdiem);
            }
            return Listbangdiem;
        }

        public bool updateBangDiem(int idhocsinh, int idmon, float? diem15p,float? diem1t,float? diemhk , int hocki,int diemdat)
        {
            string query = "USP_Update @idhocsinh , @idmonhoc , @diem15p , @diem1t , @hk , @hocki , @diemdat ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idhocsinh,idmon,diem15p,diem1t,diemhk,hocki,diemdat });
            return result > 0;
        }

        public bool insertBangDiem(int idhocsinh,int idmon, int idlop, float? diem15p, float? diem1t, float? diemhk, int hocki,int diemdat)
        {
            string query = " USP_Insert @idhocsinh , @idmonhoc , @idlop , @diem15p , @diem1t , @hk , @hocki , @diemdat ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idhocsinh, idmon, idlop, diem15p, diem1t, diemhk, hocki,diemdat });
            return result > 0;
        }

        public bool deleteBangDiem(int idhocsinh)
        {
            string query = "DELETE FROM BangDiemMon WHERE iDhocsinh = " + idhocsinh + "";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idhocsinh });
            return result > 0;
        }

      
    }
}
