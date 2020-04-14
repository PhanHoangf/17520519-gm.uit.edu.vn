using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Subjects
    {
        private string tenMon;
        private int iD;
        public Subjects(int id,string tenmon)
        {
            this.ID = id;
            this.TenMon = tenMon;
        }
        public Subjects(DataRow row)
        {
            this.ID = (int)row["iDmonhoc"];
            this.TenMon = row["Tenmon"].ToString();
        }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
