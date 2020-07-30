using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.BUS
{
     class TongKetMon_BUS
    {
        private static TongKetMon_BUS instance;

        internal static TongKetMon_BUS Instance 
        {
            get
            {
                if (instance == null)
                    instance = new TongKetMon_BUS();
                return instance;
            } 
            private set
            {
                TongKetMon_BUS.instance = value;
            }
        }
        private TongKetMon_BUS() {}

      


    }
}
