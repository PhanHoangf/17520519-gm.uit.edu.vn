using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1.BUS
{
    class Student_BUS
    {
        private static Student_BUS Instance;
 
       public static Student_BUS Instance1 {

            get
            {
                if (Instance == null)
                {
                    Instance = new Student_BUS();
                }
                return Student_BUS.Instance;
            }

            private set => Student_BUS.Instance = value; 
        }

        public bool checkEmail( string email )
        {

            Regex rx = new Regex(
             @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            
            if ( rx.IsMatch( email ) == true ) 
                return true;
            else return false;

        }

        public bool checkAge( int NamSinh )
        {
            int dt = DateTime.Now.Year;

            if ( 15 <= ( dt - NamSinh ) && ( dt-NamSinh ) <= 18 )
            {
                return true;
            }

            return false;
        }
    }
}
