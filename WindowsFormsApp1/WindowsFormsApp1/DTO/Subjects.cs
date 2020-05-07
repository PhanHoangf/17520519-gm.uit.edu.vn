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
        private int diemDat;
        public Subjects(int id,string tenmon, int diemdat)
        {
            this.ID = id;
            this.TenMon = tenmon;
            this.DiemDat = diemdat;
        }
        public Subjects(DataRow row)
        {
            this.ID = (int)row["iDmonhoc"];
            this.TenMon = row["Tenmon"].ToString();
            this.DiemDat = (int)row["DiemDat"];
        }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public int ID { get => iD; set => iD = value; }
        public int DiemDat { get => diemDat; set => diemDat = value; }
    }
}
