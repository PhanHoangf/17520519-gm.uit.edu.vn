using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Classes
    {
        private int iD;
        private string tenLop;
        private int siSo;
        public Classes(string name,int id, int siso)
        {
            this.ID = id;
            this.TenLop = name;
            this.SiSo = siso;
        }
       
        public Classes(DataRow row)
        {
          this.ID = (int)row["iDlop"];
          this.TenLop = row["Tenlop"].ToString();
          this.SiSo = (int)row["Siso"];
        }

        public string TenLop {
            get { return tenLop; }
            set
            {
                tenLop = value;
            }
        }

        public int ID { get => iD; set => iD = value; }
        public int SiSo { get => siSo; set => siSo = value; }
    }
}
