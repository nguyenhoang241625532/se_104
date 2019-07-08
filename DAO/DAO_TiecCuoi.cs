using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DAO
{
    public static class DAO_TiecCuoi
    {
        public static String[] getDanhSachMTC()
        {
            String cm = @"Select MA_TIEC_CUOI from TIEC_CUOI";
            DataTable ds = DatabaseHelper.GetData(cm);
            List<String> result = new List<string>();
            foreach (DataRow row in ds.Rows)
            {
                result.Add(row[0].ToString().Trim());
            }
            return result.ToArray();
        }
       
    }
}
