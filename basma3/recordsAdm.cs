using basma2.models;
using basma3.models;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace basma3
{
    public partial class recordsAdm : Form
    {

        //using dapper
        SqlConnection con;
        int myId;

        DateTime durationStart;

        string sql;

        List<mappingReport>? Query;



        public recordsAdm(int id)
        {
            InitializeComponent();



            con = new SqlConnection("Server=DESKTOP-PQBVQ61\\SQLEXPRESS;Database=basma3;Trusted_Connection=True;Trust Server Certificate= True");


            Query = new List<mappingReport>();

            this.myId = id;

        }

        private void btn_records_Click(object sender, EventArgs e)
        {

        }





        private void cb_records_SelectedIndexChanged(object sender, EventArgs e)
        {








            string option = cb_records.SelectedItem.ToString();

            switch (option)

            {
                case "my record":
                    {
                        sql = "SELECT r.* , e.Name FROM Records r  INNER JOIN Employees e ON r.empId = e.Id WHERE empId = @iid ";
                        Query = con.Query<mappingReport>(sql, new { iid = myId }).ToList();
                        break;
                    }


                case "all I supervise":
                    {

                        sql = "SELECT r.* , e.Name  FROM Records r  INNER JOIN Employees e ON r.empId = e.Id WHERE e.superId = @superId";
                        Query = con.Query<mappingReport>(sql, new { superId = myId }).ToList();
                        break;
                    }

                default:
                    MessageBox.Show("Invalid selection!");
                    break;
            }





            dgv_record.DataSource = Query;

            dgv_record.Columns[0].Visible = false;





        }

        private void records_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            //options of combo box
            cb_records.Items.Add("my record");
            cb_records.Items.Add("all I supervise");





        }


        private void button1_Click(object sender, EventArgs e)
        {
            home homeForm = new home(myId);
            homeForm.Show();
            this.Close();
        }

        private void dgv_record_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
