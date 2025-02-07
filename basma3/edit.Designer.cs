namespace basma3
{
    partial class edit
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
            btn_save = new Button();
            btn_back = new Button();
            label5 = new Label();
            txt_email = new TextBox();
            label2 = new Label();
            txt_lname = new TextBox();
            label1 = new Label();
            txt_fname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_confirmNewPass = new TextBox();
            txt_boxNewPass = new TextBox();
            txt_oldPassword = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            btn_showconfirm = new Button();
            btn_shownew = new Button();
            btn_showOld = new Button();
            txt_supervisor = new TextBox();
            txt_department = new TextBox();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Green;
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(411, 332);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(176, 37);
            btn_save.TabIndex = 23;
            btn_save.Text = "save changes";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Green;
            btn_back.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(411, 375);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(176, 34);
            btn_back.TabIndex = 22;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(74, 203);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 21;
            label5.Text = "email";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(140, 200);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(136, 23);
            txt_email.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(74, 146);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 15;
            label2.Text = "last name";
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(140, 143);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(136, 23);
            txt_lname.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(74, 78);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 13;
            label1.Text = "first name";
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(140, 75);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(136, 23);
            txt_fname.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(358, 96);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 17;
            label3.Text = "supervisor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(349, 146);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 19;
            label4.Text = "department";
            // 
            // txt_confirmNewPass
            // 
            txt_confirmNewPass.Location = new Point(137, 379);
            txt_confirmNewPass.Name = "txt_confirmNewPass";
            txt_confirmNewPass.PasswordChar = '*';
            txt_confirmNewPass.PlaceholderText = "confirm new password";
            txt_confirmNewPass.Size = new Size(139, 23);
            txt_confirmNewPass.TabIndex = 26;
            // 
            // txt_boxNewPass
            // 
            txt_boxNewPass.Location = new Point(137, 324);
            txt_boxNewPass.Name = "txt_boxNewPass";
            txt_boxNewPass.PasswordChar = '*';
            txt_boxNewPass.PlaceholderText = "enter new password";
            txt_boxNewPass.Size = new Size(139, 23);
            txt_boxNewPass.TabIndex = 27;
            // 
            // txt_oldPassword
            // 
            txt_oldPassword.Location = new Point(137, 259);
            txt_oldPassword.Name = "txt_oldPassword";
            txt_oldPassword.PasswordChar = '*';
            txt_oldPassword.PlaceholderText = "enter you old password";
            txt_oldPassword.Size = new Size(139, 23);
            txt_oldPassword.TabIndex = 28;
            txt_oldPassword.Leave += txt_oldPassword_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(23, 387);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 30;
            label6.Text = "confirm password :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(46, 262);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 31;
            label8.Text = "old password :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(34, 332);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 32;
            label7.Text = "new password :";
            // 
            // btn_showconfirm
            // 
            btn_showconfirm.Location = new Point(282, 383);
            btn_showconfirm.Name = "btn_showconfirm";
            btn_showconfirm.Size = new Size(50, 23);
            btn_showconfirm.TabIndex = 34;
            btn_showconfirm.Text = "show";
            btn_showconfirm.UseVisualStyleBackColor = true;
            btn_showconfirm.Click += btn_showconfirm_Click;
            // 
            // btn_shownew
            // 
            btn_shownew.Location = new Point(282, 321);
            btn_shownew.Name = "btn_shownew";
            btn_shownew.Size = new Size(50, 23);
            btn_shownew.TabIndex = 33;
            btn_shownew.Text = "show";
            btn_shownew.UseVisualStyleBackColor = true;
            btn_shownew.Click += btn_shownew_Click;
            // 
            // btn_showOld
            // 
            btn_showOld.Location = new Point(282, 259);
            btn_showOld.Name = "btn_showOld";
            btn_showOld.Size = new Size(50, 23);
            btn_showOld.TabIndex = 35;
            btn_showOld.Text = "show";
            btn_showOld.UseVisualStyleBackColor = true;
            btn_showOld.Click += btn_showOld_Click;
            // 
            // txt_supervisor
            // 
            txt_supervisor.Location = new Point(425, 93);
            txt_supervisor.Name = "txt_supervisor";
            txt_supervisor.ReadOnly = true;
            txt_supervisor.Size = new Size(119, 23);
            txt_supervisor.TabIndex = 36;
            // 
            // txt_department
            // 
            txt_department.Location = new Point(425, 143);
            txt_department.Name = "txt_department";
            txt_department.ReadOnly = true;
            txt_department.Size = new Size(119, 23);
            txt_department.TabIndex = 37;
            // 
            // edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 514);
            Controls.Add(txt_department);
            Controls.Add(txt_supervisor);
            Controls.Add(btn_showOld);
            Controls.Add(btn_showconfirm);
            Controls.Add(btn_shownew);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txt_oldPassword);
            Controls.Add(txt_boxNewPass);
            Controls.Add(txt_confirmNewPass);
            Controls.Add(btn_save);
            Controls.Add(btn_back);
            Controls.Add(label5);
            Controls.Add(txt_email);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_lname);
            Controls.Add(label1);
            Controls.Add(txt_fname);
            Name = "edit";
            Text = "                  ";
            Load += edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_save;
        private Button btn_back;
        private Label label5;
        private TextBox txt_email;
        private Label label2;
        private TextBox txt_lname;
        private Label label1;
        private TextBox txt_fname;
        private Label label3;
        private Label label4;
        private TextBox txt_confirmNewPass;
        private TextBox txt_boxNewPass;
        private TextBox txt_oldPassword;
        private Label label6;
        private Label label8;
        private Label label7;
        private Button btn_showconfirm;
        private Button btn_shownew;
        private Button btn_showOld;
        private TextBox txt_supervisor;
        private TextBox txt_department;
    }
}