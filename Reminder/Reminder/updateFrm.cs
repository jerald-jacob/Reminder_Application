using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Reminder
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            FillCombobox();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=reminder_db;Integrated Security=True");

            string selectSql = "select * from tbl_reminder_dtls where Reminder_Title='"+search.Text+"'";
         SqlCommand com = new SqlCommand(selectSql, conn);

            try
            {
                conn.Open();
              SqlCommand cmd = new SqlCommand(selectSql, conn);
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        TaskDate.Text = (read["Rm_Date"].ToString());
                      Tb_title.Text = (read["Reminder_Title"].ToString());
                        Tb_dsr.Text = (read["Reminder_Message"].ToString());
                    }
                }
            }
            finally
            {
                conn.Close();
            }





        }
        protected void FillCombobox()
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=reminder_db;Integrated Security=True");

            DataSet ds = new DataSet();

            string Sql = "select * from tbl_reminder_dtls";
        
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                search.Items.Add(DR[1]);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=(local);Initial Catalog=reminder_db;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();

                string sql = "UPDATE tbl_reminder_dtls SET Reminder_Title = @EventTitle , Rm_Date = @EventDate, Reminder_Message = @EventDescr Where Reminder_Title  = '" + search.Text + "'";


                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new SqlParameter("@EventTitle", this.Tb_title.Text));
                   
                    cmd.Parameters.Add(new SqlParameter("@EventDescr", this.Tb_dsr.Text));
                    cmd.Parameters.Add(new SqlParameter("@EventDate", SqlDbType.DateTime));
                    cmd.Parameters["@EventDate"].Value = TaskDate.Value;

                    int rowsInserted = cmd.ExecuteNonQuery();
                    MessageBox.Show("Done!");
                   
                }
                conn.Close();
               this.Close();
            }
            
        }
    }

}
