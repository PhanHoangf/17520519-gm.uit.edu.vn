using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
