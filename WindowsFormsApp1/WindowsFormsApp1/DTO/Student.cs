using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Student
    {
        private int iDhocsinh;
        private int iDlop;
        private string hoten;
        private DateTime? ngaysinh;
        private string diachi;
        private string email;
        private float tBHKI;
        private float tBHKII;

        public Student(int idhocsinh, int idlop,string hoten,DateTime? ngaysinh,string diachi,string email,float tbhkI,float tbhkII)
        {
            this.IDhocsinh = idhocsinh;
            this.IDlop = idlop;
            this.Hoten = hoten;
            this.Ngaysinh = ngaysinh;
            this.Diachi = diachi;
            this.Email = email;
            this.TBHKI = tbhkI;
            this.TBHKII = tbhkII;
        }

        public Student(DataRow row)
        {
            this.IDhocsinh = (int)row["iDhocsinh"];
            this.IDlop = (int)row["iDlop"];
            this.Hoten = row["Hoten"].ToString();
            this.ngaysinh = (DateTime?)row["Ngaysinh"];
            this.Diachi = row["Diachi"].ToString();
            this.Email = row["Email"].ToString();
            this.TBHKI = (float)row["TBHKI"];
            this.TBHKII = (float)row["TBHKII"];
        }
        public int IDhocsinh { get => iDhocsinh; set => iDhocsinh = value; }
        public int IDlop { get => iDlop; set => iDlop = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime? Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public float TBHKII { get => tBHKII; set => tBHKII = value; }
        public float TBHKI { get => tBHKI; set => tBHKI = value; }
    }
}
