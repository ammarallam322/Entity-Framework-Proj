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
    public partial class edit : Form
    {
        basma2Context db;
        int id;
        string oldPassword;
        home homeForm;


        public edit(int id)
        {
            InitializeComponent();
            db = new basma2Context();

            this.id = id;
            homeForm = new home(id);


        }

        private void edit_Load(object sender, EventArgs e)
        {



            //get current user info 
            var currentUser = (from emp in db.Employees
                               join s in db.Employees on emp.superId equals s.Id into supervisorGroup
                               // left outer join
                               from supervisor in supervisorGroup.DefaultIfEmpty()

                               join dept in db.Department on emp.did equals dept.Id into departmentGroup
                               // left outer join
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

                txt_supervisor.Text = currentUser.SupervisorName;

                txt_department.Text = currentUser.departmentName;


                oldPassword = currentUser.Employee.Password;

            }
            else
            {
                MessageBox.Show("User not found!");
            }

            // button save changes disabled 

            btn_save.Enabled = false;






        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            this.Hide();
        }

        #region three toggles buttons
        private void btn_showOld_Click(object sender, EventArgs e)
        {
            if (btn_showOld.Text == "show")
            {
                txt_oldPassword.PasswordChar = '\0';
                btn_showOld.Text = "hide";
            }
            else
            {
                txt_oldPassword.PasswordChar = '*';
                btn_showOld.Text = "show";

            }




        }
        private void btn_shownew_Click(object sender, EventArgs e)
        {
            if (btn_showOld.Text == "show")
            {

                txt_boxNewPass.PasswordChar = '\0';
                btn_shownew.Text = "hide";
            }
            else
            {
                txt_boxNewPass.PasswordChar = '*';
                btn_shownew.Text = "show";

            }

        }
        private void btn_showconfirm_Click(object sender, EventArgs e)
        {
            if (btn_showconfirm.Text == "show")
            {
                txt_confirmNewPass.PasswordChar = '\0';
                btn_showconfirm.Text = "hide";
            }
            else
            {
                txt_confirmNewPass.PasswordChar = '*';
                btn_showconfirm.Text = "show";

            }

        }

        #endregion

        private void btn_save_Click(object sender, EventArgs e)
        {
            //
            var currentuser = db.Employees.Where(e => e.Id == id).FirstOrDefault();

            if (currentuser.Password == txt_oldPassword.Text)
            {

                //getting data from fields 
                currentuser.Name = txt_fname.Text + " " + txt_lname.Text;
                currentuser.Email = txt_email.Text;

                //check before changing passwords
                currentuser.Password =
                    (txt_boxNewPass.Text == txt_confirmNewPass.Text && txt_confirmNewPass.Text != "")
                    ? txt_boxNewPass.Text : currentuser.Password;



                // update info 
                db.SaveChanges();
                //load the form 
                edit newForm = new edit(id);
                newForm.Show();

            }



            else MessageBox.Show("enter your password to save chenges");




        }

        private void txt_oldPassword_Leave(object sender, EventArgs e)
        {
            if (txt_oldPassword.Text == oldPassword) btn_save.Enabled = true;
            else MessageBox.Show("password isn't correct");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
