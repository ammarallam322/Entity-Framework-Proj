using basma2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basma3
{
    public partial class register : Form
    {
        //obj from basmacontext
        basma2Context db;

         string emaill;
        string passwordd;
        string confirmPassword;
        string fullName;
        int did;
        int age;
        string passPattern;
         string emailPattern;
        public register()
        {
            InitializeComponent();
            db = new basma2Context();




            emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            passPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d@$!%*?&]{8,}$";

            emaill = passwordd = "";

            txt_name.Focus();

            // geting departments 

            cb_department.DataSource=db.Department.ToList();
            cb_department.DisplayMember = "Name";
            cb_department.ValueMember = "Id";





        }
        private void register_Load(object sender, EventArgs e)
        {
            txt_confirmpass.PasswordChar = txt_password.PasswordChar = '*';

            this.ActiveControl = null;


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            well1 well1form = new well1();
            well1form.Show();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            try
            {



                // getting data from controls
                fullName = txt_name.Text + " " + txt_lastname.Text;

                passwordd = txt_password.Text;
                confirmPassword = txt_confirmpass.Text;

                emaill = txt_email.Text;
                age = int.Parse(txt_age.Text);

                did = Convert.ToInt32(cb_department.SelectedValue);

             
            }


            catch (Exception ex) { MessageBox.Show("enter your data in valid format"); }



            var checkEmail = db.Employees.Where(e => e.Email == emaill).Count();

            if (checkEmail == 0 && passwordd== confirmPassword)
            {
                // create new obj from employee 
                Employee emp = new Employee(fullName, emaill, passwordd,did,age);
                db.Add(emp);

                db.SaveChanges();
                MessageBox.Show("user is added successfully");

                //clearing felds
                txt_age.Text = txt_name.Text = txt_password.Text = txt_confirmpass.Text = txt_email.Text = txt_lastname.Text="";
                
            }

            else { MessageBox.Show($"this email{emaill} is used before try another one"); };


          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_Leave(object sender, EventArgs e)
        {  /*email pattern cjeck*/

            emaill=txt_email.Text;
            if (!Regex.IsMatch(emaill, emailPattern))
            {
                MessageBox.Show("email is not in valid format \n try one lik this format example23@example.com");
            }

        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            /* paswwordPattern =*/
            passwordd = txt_password.Text;
            if (!Regex.IsMatch(passwordd, passPattern)) {
                MessageBox.Show("password is not in valid  \n at least one letter and one number  ");

            }

        }

        private void txt_confirmpass_Leave(object sender, EventArgs e)
        {
            /*check equality of pass*/

           if (confirmPassword != passwordd) { MessageBox.Show("passwords not matched"); }

        }

        //togle
        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar = '\0';

                btn_show.Text = "Hide";
            }
            else   // case 2
            {
                txt_password.PasswordChar = '*';

                btn_show.Text = "Show";
            }

        }

        //togle
        private void btn_showconf_Click(object sender, EventArgs e)
        {
            if (txt_confirmpass.PasswordChar == '*')
            {
                txt_confirmpass.PasswordChar = '\0';

                btn_showconf.Text = "Hide";
            }
            else   // case 2
            {
                txt_confirmpass.PasswordChar = '*';

                btn_showconf.Text = "Show";
            }
            
        }
    }
}
