using basma2.models;
using basma3.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basma3
{
    public partial class recordsEmp : Form
    {
        basma2Context db;

     
        int id;


        //course

        List<mappingReport> source=new List<mappingReport>();


        public recordsEmp(int id)
        {
            InitializeComponent();

            this.id = id;

            db = new basma2Context();
        }

        private void homePage_Load(object sender, EventArgs e)
        {


            //
            dgv_report.Visible = false;
            //
             source = db.Records.Where(r => r.empId == id).Join(db.Employees, r => r.empId, em => em.Id, (r, em) => new mappingReport()
            {
                recordId = r.recordId,
                Attendence = r.Attendence,
                departure = r.departure,
                day = r.day,
                name = em.Name,
                empId = r.empId,

            }).ToList();

            dgv_report.DataSource = source;
            //hide
            dgv_report.Columns[0].Visible = false;
         //   dgv_report.Columns[4].Visible = false;




        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            home homeForm = new home(id);
            homeForm.Show();
            this.Hide();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            dgv_report.Visible = !dgv_report.Visible;

            label1.Visible = !label1.Visible;

            dgv_report.DataSource = source;
            //hide
            dgv_report.Columns[0].Visible = false;
        }
    }
}
