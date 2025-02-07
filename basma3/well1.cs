using basma3;
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
    public partial class well1 : Form
    { 

        public well1()
        {
            InitializeComponent();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            register form = new register();
            form.Show();
            this.Hide();
        }



        private void btn_signIn_Click(object sender, EventArgs e)
        {
            sign_in form = new sign_in();
            form.Show();
            this.Hide();
        }

        private void well1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;

        }
    }
}
