using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi.QuanLy_forms
{
    public partial class LapHoaDon_form : Form
    {
        public LapHoaDon_form()
        {
            InitializeComponent();
        }
        DatabaseHelper conn = new DatabaseHelper();
        SqlConnection sCon;
        SqlCommand cm;
        DataSet ds;
        SqlDataAdapter ap;

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }
        private void loadDBComBox()
        {
            String[] ds = BUS.BUS_LapHoaDon.getDanhSachMTC();
            comboBox1.Items.AddRange(ds);
        }
        private void LapHoaDon_form_Load(object sender, EventArgs e)
        {
            loadDBComBox();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            cm = new SqlComm
                and("SELECT TEN_CHU_RE,TEN_CO_DAU,SDT FROM KHACH_HANG  where TIEC_CUOI.MA_KHACH_HANG=KHACH_HANG.MA_KHACH_HANG MA_TIEC_CUOI='" + comboBox1.Text + "';");
            //sCon.Open;
            SqlDataReader dr;
            dr = cm.ExecuteReader();
                while(dr.Read())
            {
                string tx_CR = (string)dr["TEN_CHU_RE"].ToString();
                string tx_CD = (string)dr["TEN_CO_DAU"].ToString();
                string tx_SDT = (string)dr["SDT"].ToString();


            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
