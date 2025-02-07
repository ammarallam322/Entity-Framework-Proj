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
    public partial class home : Form
    {
        basma2Context db = new basma2Context();

        string fullName;
        string email;
        string passord;
        int id;

        // vars for record
        DateTime? checkin = null;
        DateTime? checkOut = null;

        //var of employee records 
        Records? currentDayRow;


        // two static variables to make check boxes works one time
        static int inCount = 0;
        static int outCount = 0;



        public home()
        {
            InitializeComponent();
            db = new basma2Context();
            currentDayRow = new Records();

        }
        public home(int id)
        {

            InitializeComponent();
            db = new basma2Context();
            this.id = id;
            currentDayRow = new Records();

        }
        public home(string name, string email, string password, int id)
        {
            InitializeComponent();
            db = new basma2Context();
            currentDayRow = new Records();

            this.fullName = name;
            this.email = email;
            this.passord = password;
            this.id = id;



            try
            {



                //getting  row of current day for current admin if null create one
                currentDayRow = db.Records.FirstOrDefault(n => n.empId == id && n.day.Date == DateTime.Now.Date);

                if (currentDayRow == null)
                {
                    var thisday = DateTime.Now.Date;
                    currentDayRow = new Records(thisday, id);
                    db.Records.Add(currentDayRow);
                    db.SaveChanges();
                    MessageBox.Show("row for current day is added");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



        }

        private void btn_showProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            show form = new show(id);
            form.Show();


        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            edit profile = new edit(id);
            profile.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {
            label1.Text = $"Hello {this.fullName}";





        }
        
        private void ch_in_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (inCount == 0)
                {
                    //getting date and time 

                    checkin = DateTime.Now;

                    txt_in.Text = checkin.ToString();

                    // update data base employee records table

                    currentDayRow.Attendence = checkin;
                    db.SaveChanges();
                    inCount++;
                     ch_in.Enabled = false;

                }


                else MessageBox.Show($"only your first checkin @{checkin} is considered ");
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ch_out_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (outCount == 0)
                {
                    if (currentDayRow != null)
                    {
                        checkOut = DateTime.Now;
                        txt_out.Text = checkOut.ToString();

                        currentDayRow.departure = checkOut;
                        db.SaveChanges();
                        outCount++;
                        ch_out.Enabled = false; 
                    }
                    else
                    {
                        MessageBox.Show("No record found for today's attendance.");
                    }
                }
                else
                {
                    MessageBox.Show($"only your first checkout @{checkOut} is considered ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        
        }
    



        private void btn_logOut_Click(object sender, EventArgs e)
        {
            sign_in sign_In = new sign_in();
            sign_In.Show();
            this.Close();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            //if role == admin or user open th right form  with id

            string? role = db.Employees.Where(n => n.Id == id).Select(n => n.Role).FirstOrDefault();
            if (role != null && role != "admin")
            {//user

                recordsEmp form = new recordsEmp(id);
                form.Show();
                this.Hide();

            }
            else
            {
                recordsAdm form = new recordsAdm(id);
                form.Show();
                this.Hide();

            }
        }
    }
}
