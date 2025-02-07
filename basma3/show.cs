using basma2.models;
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
    public partial class show : Form
    {
        basma2Context db;

        int id = 5;

        //forms
        home homeForm;
        edit editform;

        public show(int id)
        {
            InitializeComponent();

            db = new basma2Context();
            this.id = id;
            //forms

             homeForm = new home(id);
            editform = new edit(id);



            btn_back.Enabled = true;
            btn_edit.Enabled = true;



        }

        private void show_Load(object sender, EventArgs e)
        {

          



            var currentUser = (from emp in db.Employees
                               join s in db.Employees on emp.superId equals s.Id into supervisorGroup
                               //act as left outer join
                               from supervisor in supervisorGroup.DefaultIfEmpty()

                               join dept in db.Department on emp.did equals dept.Id into departmentGroup
                               //act as left outer join
                               from department in departmentGroup.DefaultIfEmpty()


                               where emp.Id == id
                               select new
                               {
                                   Employee = emp,
                                   SupervisorName = supervisor.Name ?? "has no supervisor",
                                   departmentName = department.Name ?? "hasn't been assigned to any department yet"

                               }).FirstOrDefault();

            if (currentUser != null)
            {
                // spilting full name into first and last
                txt_fname.Text = currentUser.Employee.Name.Split(" ")[0];
                txt_lname.Text = currentUser.Employee.Name.Split(" ")[1];

                txt_email.Text = currentUser.Employee.Email;

                txt_superviser.Text = currentUser.SupervisorName;

                txt_department.Text = currentUser.departmentName;
            }
            else
            {
                MessageBox.Show("User not found!");
            }






        }

        private void btn_back_Click(object sender, EventArgs e)
        {
           
            homeForm.Show();
            this.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            editform.Show();
            this.Close();

        }
    }
}
