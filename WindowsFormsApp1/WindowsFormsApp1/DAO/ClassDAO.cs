using System.Collections.Generic;
using System.Data;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class ClassDAO
    {
        private static ClassDAO instance;
        public static int btnWidth = 145;
        public static int btnHeight = 50;
        public static ClassDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClassDAO();
                return ClassDAO.instance;
            }
            private set { ClassDAO.instance = value; }
        }
        private ClassDAO() { }

        public List<Classes> LoadClassList(string query)
        {
            List<Classes> classesList = new List<Classes>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Classes classes = new Classes(item);
                classesList.Add(classes);
            }
            return classesList;
        }
        public bool UpdateClassList(int idlop, string tenlop, int siso)
        {
            string query = "UPDATE Lop SET Tenlop = @Tenlop , Siso = @Siso where iDlop = @iDlop ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenlop, siso, idlop });
            return result > 0;
        }
        public bool InsertClass(string tenlop,int siso)
        {
            string query = "INSERT INTO Lop (Tenlop, Siso) VALUES ( @Tenlop , @Siso )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {tenlop, siso});
            return result > 0;
        }
        public bool DeleteClass(int idlop)
        {
            string query = "DELETE FROM Lop WHERE iDlop = @iDlop ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idlop });
            return result > 0;
        }
    }
}
