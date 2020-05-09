using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class TongKetMon
    {
        private int iDhocsinh;
        private int iDlop;
        private int iDmonhoc;
        private float diemtbm;
        private string ghichu;
        private int hocki;
        private int sTT;

        public TongKetMon(int stt,int idhocsinh,int idlop,int idmonhoc,float diemtbm,string ghichu,int hocki)
        {
            this.STT = stt;
            this.IDhocsinh = idhocsinh;
            this.IDlop = idlop;
            this.IDmonhoc = idmonhoc;
            this.Diemtbm = diemtbm;
            this.Ghichu = ghichu;
            this.Hocki = hocki;
        }
        public TongKetMon(DataRow row)
        {
            this.STT = (int)row["STT"];
            this.iDhocsinh = (int)row["ID Học Sinh"];
            this.IDlop = (int)row["ID Lớp"];
            this.IDmonhoc = (int)row["ID môn học"];
            this.Diemtbm = (float)row["Điểm tb môn"];
            this.Ghichu = row["Ghi chú"].ToString();
            this.Hocki = (int)row["Học kì"];
        }

        public int IDhocsinh { get => iDhocsinh; set => iDhocsinh = value; }
        public int IDlop { get => iDlop; set => iDlop = value; }
        public int IDmonhoc { get => iDmonhoc; set => iDmonhoc = value; }
        public float Diemtbm { get => diemtbm; set => diemtbm = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public int Hocki { get => hocki; set => hocki = value; }
        public int STT { get => sTT; set => sTT = value; }
    }
}
