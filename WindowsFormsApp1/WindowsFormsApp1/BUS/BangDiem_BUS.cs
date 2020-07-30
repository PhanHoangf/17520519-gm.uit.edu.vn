using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.BUS
{
    class BangDiem_BUS
    {
        private static BangDiem_BUS instance;

        public static BangDiem_BUS Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new BangDiem_BUS();
                }
                return BangDiem_BUS.instance;
            }
            private set => BangDiem_BUS.instance = value;
        }
        private BangDiem_BUS() { }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\,?[0-9]+$");
            return regex.IsMatch(pText);
        }
        public int SoLuongMon()
        {
            string query = "SELECT *FROM MonHoc";
            List<Subjects> subjectList = SubjectDAO.Instance.loadSubjects(query);
            int count = 0;
            foreach (Subjects item in subjectList)
            {
                count++;
            }
            return count;
        }

    }
}
