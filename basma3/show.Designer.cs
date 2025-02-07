namespace basma3
{
    partial class show
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
            txt_fname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_lname = new TextBox();
            label3 = new Label();
            txt_superviser = new TextBox();
            label4 = new Label();
            txt_department = new TextBox();
            label5 = new Label();
            txt_email = new TextBox();
            btn_back = new Button();
            btn_edit = new Button();
            SuspendLayout();
            // 
            // txt_fname
            // 
            txt_fname.Enabled = false;
            txt_fname.Location = new Point(268, 51);
            txt_fname.Name = "txt_fname";
            txt_fname.ReadOnly = true;
            txt_fname.Size = new Size(184, 23);
            txt_fname.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(171, 49);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 1;
            label1.Text = "first name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(171, 117);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 3;
            label2.Text = "last name";
            // 
            // txt_lname
            // 
            txt_lname.Enabled = false;
            txt_lname.Location = new Point(268, 119);
            txt_lname.Name = "txt_lname";
            txt_lname.ReadOnly = true;
            txt_lname.Size = new Size(184, 23);
            txt_lname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(171, 222);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 5;
            label3.Text = "supervisor";
            // 
            // txt_superviser
            // 
            txt_superviser.Enabled = false;
            txt_superviser.Location = new Point(268, 219);
            txt_superviser.Name = "txt_superviser";
            txt_superviser.ReadOnly = true;
            txt_superviser.Size = new Size(184, 23);
            txt_superviser.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(162, 272);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 7;
            label4.Text = "department";
            // 
            // txt_department
            // 
            txt_department.Enabled = false;
            txt_department.Location = new Point(268, 274);
            txt_department.Name = "txt_department";
            txt_department.ReadOnly = true;
            txt_department.Size = new Size(184, 23);
            txt_department.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(171, 174);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 9;
            label5.Text = "email";
            // 
            // txt_email
            // 
            txt_email.Enabled = false;
            txt_email.Location = new Point(268, 176);
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            txt_email.Size = new Size(184, 23);
            txt_email.TabIndex = 8;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Green;
            btn_back.Enabled = false;
            btn_back.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_back.ForeColor = Color.LightGray;
            btn_back.Location = new Point(268, 361);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(155, 37);
            btn_back.TabIndex = 10;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.Green;
            btn_edit.Enabled = false;
            btn_edit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_edit.ForeColor = Color.LightGray;
            btn_edit.Location = new Point(268, 320);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(155, 37);
            btn_edit.TabIndex = 11;
            btn_edit.Text = "edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // show
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(660, 450);
            Controls.Add(btn_edit);
            Controls.Add(btn_back);
            Controls.Add(label5);
            Controls.Add(txt_email);
            Controls.Add(label4);
            Controls.Add(txt_department);
            Controls.Add(label3);
            Controls.Add(txt_superviser);
            Controls.Add(label2);
            Controls.Add(txt_lname);
            Controls.Add(label1);
            Controls.Add(txt_fname);
            Name = "show";
            Text = "show";
            Load += show_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_fname;
        private Label label1;
        private Label label2;
        private TextBox txt_lname;
        private Label label3;
        private TextBox txt_superviser;
        private Label label4;
        private TextBox txt_department;
        private Label label5;
        private TextBox txt_email;
        private Button btn_back;
        private Button btn_edit;
    }
}