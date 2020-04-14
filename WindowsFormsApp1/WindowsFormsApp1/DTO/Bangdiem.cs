using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Bangdiem
    {
        private int iDhocsinh;
        private int iDdmonhoc;
        private float diem15p;
        private float diem1t;
        private float diemhocki;
        private float diemtbm;
        private int sTT;

        public Bangdiem(int stt,int idhocsinh,int idmonhoc,float diem15p,float diem1t,float diemhocki,float diemtbm)
        {
            this.STT = stt;
            this.IDhocsinh = idhocsinh;
            this.IDdmonhoc = idmonhoc;
            this.Diem15p = diem15p;
            this.Diem1t = diem1t;
            this.Diemhocki = diemhocki;
            this.Diemtbm = diemtbm;
        }

        public Bangdiem(DataRow row)
        {
            this.STT = (int)row["STT"];
            this.IDhocsinh = (int)row["iDhocsinh"];
            this.IDdmonhoc = (int)row["idmonhoc"];
            this.diem15p = (float)row["Diem15p"];
            this.diem1t = (float)row["Diem1t"];
            this.Diemhocki = (float)row["HK"];
            this.Diemtbm = (float)row["Diemtbm"];
        }

        public float Diem15p { get => diem15p; set => diem15p = value; }
        public float Diem1t { get => diem1t; set => diem1t = value; }
        public float Diemhocki { get => diemhocki; set => diemhocki = value; }
        public float Diemtbm { get => diemtbm; set => diemtbm = value; }
        public int IDhocsinh { get => iDhocsinh; set => iDhocsinh = value; }
        public int IDdmonhoc { get => iDdmonhoc; set => iDdmonhoc = value; }
        public int STT { get => sTT; set => sTT = value; }
    }
}
