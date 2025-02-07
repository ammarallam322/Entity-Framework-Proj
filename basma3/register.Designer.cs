namespace basma3
{
    partial class register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_confirmpass = new TextBox();
            txt_email = new TextBox();
            cb_department = new ComboBox();
            btn_confirm = new Button();
            btn_back = new Button();
            txt_password = new TextBox();
            txt_name = new TextBox();
            txt_lastname = new TextBox();
            btn_show = new Button();
            btn_showconf = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_age = new TextBox();
            SuspendLayout();
            // 
            // txt_confirmpass
            // 
            txt_confirmpass.Location = new Point(285, 312);
            txt_confirmpass.Multiline = true;
            txt_confirmpass.Name = "txt_confirmpass";
            txt_confirmpass.PasswordChar = '*';
            txt_confirmpass.PlaceholderText = "confirm password";
            txt_confirmpass.Size = new Size(291, 46);
            txt_confirmpass.TabIndex = 5;
            txt_confirmpass.Leave += txt_confirmpass_Leave;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(285, 160);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "enter your email";
            txt_email.Size = new Size(291, 46);
            txt_email.TabIndex = 7;
            txt_email.Leave += txt_email_Leave;
            // 
            // cb_department
            // 
            cb_department.FormattingEnabled = true;
            cb_department.Location = new Point(285, 456);
            cb_department.Name = "cb_department";
            cb_department.Size = new Size(291, 23);
            cb_department.TabIndex = 8;
            cb_department.Text = "select department";
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.Green;
            btn_confirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_confirm.ForeColor = Color.White;
            btn_confirm.Location = new Point(314, 548);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(179, 39);
            btn_confirm.TabIndex = 9;
            btn_confirm.Text = "confirm";
            btn_confirm.UseVisualStyleBackColor = false;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Green;
            btn_back.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(314, 590);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(179, 39);
            btn_back.TabIndex = 10;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(285, 243);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "enter a password at least 8(upper/lower/special)chars";
            txt_password.Size = new Size(291, 42);
            txt_password.TabIndex = 11;
            txt_password.TextChanged += textBox1_TextChanged;
            txt_password.Leave += txt_password_Leave;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(285, 51);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "enter your  first name";
            txt_name.Size = new Size(291, 37);
            txt_name.TabIndex = 12;
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(285, 103);
            txt_lastname.Multiline = true;
            txt_lastname.Name = "txt_lastname";
            txt_lastname.PlaceholderText = "enter your  last name";
            txt_lastname.Size = new Size(291, 37);
            txt_lastname.TabIndex = 13;
            // 
            // btn_show
            // 
            btn_show.Location = new Point(552, 262);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(50, 23);
            btn_show.TabIndex = 14;
            btn_show.Text = "show";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // btn_showconf
            // 
            btn_showconf.Location = new Point(552, 335);
            btn_showconf.Name = "btn_showconf";
            btn_showconf.Size = new Size(50, 23);
            btn_showconf.TabIndex = 15;
            btn_showconf.Text = "show";
            btn_showconf.UseVisualStyleBackColor = true;
            btn_showconf.Click += btn_showconf_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(163, 49);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 16;
            label1.Text = "first name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(163, 101);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 17;
            label2.Text = "last name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(194, 160);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 18;
            label3.Text = "email : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(168, 243);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 19;
            label4.Text = "password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(104, 321);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 20;
            label5.Text = "confirm password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(149, 454);
            label6.Name = "label6";
            label6.Size = new Size(109, 21);
            label6.TabIndex = 21;
            label6.Text = "daepartment";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(208, 390);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 23;
            label7.Text = "age : ";
            // 
            // txt_age
            // 
            txt_age.Location = new Point(285, 375);
            txt_age.Multiline = true;
            txt_age.Name = "txt_age";
            txt_age.PlaceholderText = "enter your age as a number";
            txt_age.Size = new Size(291, 46);
            txt_age.TabIndex = 22;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(771, 640);
            Controls.Add(label7);
            Controls.Add(txt_age);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_showconf);
            Controls.Add(btn_show);
            Controls.Add(txt_lastname);
            Controls.Add(txt_name);
            Controls.Add(txt_password);
            Controls.Add(btn_back);
            Controls.Add(btn_confirm);
            Controls.Add(cb_department);
            Controls.Add(txt_email);
            Controls.Add(txt_confirmpass);
            Name = "register";
            Text = "regiterform";
            Load += register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private TextBox txt_password;
        private TextBox txt_name;
        private Label password;
        private TextBox txt_confirmpass;
        private Label passwordconfirm;
        private TextBox txt_email;
        private ComboBox cb_department;
        private Button btn_confirm;
        private Button btn_back;
        private Label email;
        private TextBox txt_lastname;
        private Button btn_show;
        private Button btn_showconf;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_age;
    }
}