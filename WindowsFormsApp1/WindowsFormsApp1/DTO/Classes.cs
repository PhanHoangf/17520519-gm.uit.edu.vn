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
        public Classes(string name,int id)
        {
            this.ID = id;
            this.TenLop = name;
            
        }
       
        public Classes(DataRow row)
        {
          this.ID = (int)row["iDlop"];
          this.TenLop = row["Tenlop"].ToString();
        }

        public string TenLop {
            get { return tenLop; }
            set
            {
                tenLop = value;
            }
        }

        public int ID { get => iD; set => iD = value; }
    }
}
