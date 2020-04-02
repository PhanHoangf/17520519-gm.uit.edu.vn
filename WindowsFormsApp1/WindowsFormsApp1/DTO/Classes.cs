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
        private string tenLop;
        public Classes(string name)
        {
            this.TenLop = name;
        }
       
        public Classes(DataRow row)
        {
            this.TenLop = row["TenLop"].ToString();
        }

        public string TenLop {
            get { return tenLop; }
            set
            {
                tenLop = value;
            }
        }
       
    }
}
