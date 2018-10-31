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
    public partial class ReminderForm : Form
    {
        
        SqlConnection con;
        SqlDataAdapter da;

        public ReminderForm()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.Refresh();
            dataGridView1.DataSource = GetReminderDetails();
        }
        private DataTable GetReminderDetails()
        {
           con = new SqlConnection ("Data Source=(local);Initial Catalog=reminder_db;Integrated Security=True");
            con.Open();
           da = new SqlDataAdapter("SELECT * FROM tbl_reminder_dtls ", con);



            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tb_title.Text == "")
            {
                MessageBox.Show("Fill the event title");
            }
            else if(Tb_dsr.Text == "")
            {
                MessageBox.Show("Fill the event Desereption");
            }
            else
            {


                con = new SqlConnection("Data Source=(local);Initial Catalog=reminder_db;Integrated Security=True");

                try
                {

                    con.Open();
                    string query = "INSERT INTO tbl_reminder_dtls(Reminder_Title,Rm_Date,Reminder_Message)";
                    query += "VALUES(@EventTitle, @EventDate, @EventDescr)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@EventTitle", this.Tb_title.Text);
                    cmd.Parameters.AddWithValue("@EventDate", this.TaskDate.Value);
                    cmd.Parameters.AddWithValue("@EventDescr", this.Tb_dsr.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("inserted");
                }
                finally
                {
                    con.Close();
                }



            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

          
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form2 settingsForm = new Form2();

            // Show the settings form
            settingsForm.Show();


            //updateFrm.show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
