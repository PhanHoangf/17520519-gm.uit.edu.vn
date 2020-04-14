using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class SubjectDAO
    {
        private static SubjectDAO instance;
        public static int cbxwidth = 113;
        public static int cbxheight = 24;

        public static SubjectDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SubjectDAO();

                }
                return instance;
            }
            private set
            {
                SubjectDAO.instance = value;
            }
        }

        private  SubjectDAO() { }
        public List<Subjects> loadSubjects(string query)
        {
            List<Subjects> subjectslist = new List<Subjects>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Subjects subject = new Subjects(item);
                subjectslist.Add(subject);
            }
            return subjectslist;
        }
    }
}
