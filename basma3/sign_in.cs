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
    public partial class sign_in : Form
    {


        basma2Context db= new basma2Context();

        string email;
        string password;
        Employee? emp;

        home form =new home();

        public sign_in()
        {
            InitializeComponent();



        }

        private void sign_in_Load(object sender, EventArgs e)
        {
            
            //

            //socusing on email field
            txt_email.Focus();

            //hide pass charss
            txt_password.PasswordChar = '*';
            btn_togle.Visible = true;


            emp=null;

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {


                //getting data from fields
                email = txt_email.Text.Trim();
            password = txt_password.Text.Trim();


                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("fields must be filled with proper data");
                    return;
                }



                emp = db.Employees.Where(e => e.Email == email).FirstOrDefault();

                if (emp != null)
                {
                    string storedPassword = emp.Password;
                    string storedEmail = emp.Email;
                    string fullName = emp.Name;
                    int id = emp.Id;

                    //check user
                    if (storedEmail == email && storedPassword == password)
                    {
                        //  user wellcome form  have two button show profile and edit profile

                        this.Hide();
                        form = new home(fullName, storedEmail, storedPassword, id);

                        form.Show();

                    }

                }

                else
                {
                    MessageBox.Show("sorry! email or password isn't correct ");
                    return;
                }
            }


            catch (Exception ex) { MessageBox.Show(ex.Message); }


          



        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            well1 form = new well1();
            form.Show();
        }

        private void btn_togle_Click(object sender, EventArgs e)
        {
            //case one if pass is hiden then show pass chars and toggle button text to hide
            if (txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar = '\0';

                btn_togle.Text = "Hide";
            }
            else   // case 2
            {
                txt_password.PasswordChar = '*';

                btn_togle.Text = "Show";
            }
        }
    }
}
