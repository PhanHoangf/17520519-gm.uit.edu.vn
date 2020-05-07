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
        
        public bool updateSubject(int id,string tenmon, float diemdat)
        {
            string query = "UPDATE MonHoc SET Tenmon = @Tenmon , DiemDat = @DiemDat WHERE iDmonhoc = @iDmonhoc ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenmon,diemdat,id });
            return result > 0;
        }

        public bool insertSubject(string tenmon, float diemdat)
        {
            string query = "INSERT INTO MonHoc (Tenmon,DiemDat) VALUES ( @Tenmon , @DiemDat )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenmon, diemdat });
            return result > 0;
        }

        public bool deleteSubject(int id)
        {
            string query = " DELETE FROM MonHoc WHERE iDmonhoc = @iDmonhoc ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
    }
}
