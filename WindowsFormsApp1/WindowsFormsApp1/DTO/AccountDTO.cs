using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class AccountDTO
    {
        private string tenTK;
        private string matKhau;
        private int quyen;
        private int trangThai;

        AccountDTO(string tentk, string matkhau, int quyen, int trangthai)
        {
            this.TenTK = tentk;
            this.MatKhau = matkhau;
            this.Quyen = quyen;
            this.TrangThai = trangthai;
        }
        
        public AccountDTO(DataRow row)
        {
            this.tenTK = row["Tentk"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.Quyen = (int)row["Quyen"];
            this.TrangThai = (int)row["TrangThai"];
        }
        
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int Quyen { get => quyen; set => quyen = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
