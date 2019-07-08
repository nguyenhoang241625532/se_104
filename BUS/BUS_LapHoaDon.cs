using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    public static class BUS_LapHoaDon
    {
        public static String[] getDanhSachMTC()
        {
            return DAO.DAO_TiecCuoi.getDanhSachMTC();
        }
        /*public static string[] getThongTinKH()
        {
            return DAO.
        }*/
    }
}
