namespace basma3
{
    partial class home
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
            btn_showProfile = new Button();
            btn_editProfile = new Button();
            label1 = new Label();
            ch_out = new CheckBox();
            ch_in = new CheckBox();
            txt_out = new TextBox();
            txt_in = new TextBox();
            btn_logOut = new Button();
            btn_reports = new Button();
            SuspendLayout();
            // 
            // btn_showProfile
            // 
            btn_showProfile.BackColor = Color.Green;
            btn_showProfile.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_showProfile.ForeColor = Color.White;
            btn_showProfile.Location = new Point(381, 54);
            btn_showProfile.Name = "btn_showProfile";
            btn_showProfile.Size = new Size(118, 32);
            btn_showProfile.TabIndex = 0;
            btn_showProfile.Text = "show profile";
            btn_showProfile.UseVisualStyleBackColor = false;
            btn_showProfile.Click += btn_showProfile_Click;
            // 
            // btn_editProfile
            // 
            btn_editProfile.BackColor = Color.Green;
            btn_editProfile.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_editProfile.ForeColor = Color.White;
            btn_editProfile.Location = new Point(381, 96);
            btn_editProfile.Name = "btn_editProfile";
            btn_editProfile.Size = new Size(118, 32);
            btn_editProfile.TabIndex = 1;
            btn_editProfile.Text = "edit profile";
            btn_editProfile.UseVisualStyleBackColor = false;
            btn_editProfile.Click += btn_editProfile_Click;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 56);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 2;
            label1.Text = "record of day";
            // 
            // ch_out
            // 
            ch_out.AutoSize = true;
            ch_out.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ch_out.Location = new Point(21, 141);
            ch_out.Name = "ch_out";
            ch_out.Size = new Size(103, 25);
            ch_out.TabIndex = 3;
            ch_out.Text = "check out";
            ch_out.UseVisualStyleBackColor = true;
            ch_out.CheckedChanged += ch_out_CheckedChanged;
            // 
            // ch_in
            // 
            ch_in.AutoSize = true;
            ch_in.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ch_in.Location = new Point(21, 96);
            ch_in.Name = "ch_in";
            ch_in.Size = new Size(92, 25);
            ch_in.TabIndex = 4;
            ch_in.Text = "check In";
            ch_in.UseVisualStyleBackColor = true;
            ch_in.CheckedChanged += ch_in_CheckedChanged;
            // 
            // txt_out
            // 
            txt_out.Location = new Point(119, 141);
            txt_out.Name = "txt_out";
            txt_out.ReadOnly = true;
            txt_out.Size = new Size(170, 23);
            txt_out.TabIndex = 5;
            // 
            // txt_in
            // 
            txt_in.Location = new Point(119, 98);
            txt_in.Name = "txt_in";
            txt_in.ReadOnly = true;
            txt_in.Size = new Size(170, 23);
            txt_in.TabIndex = 6;
            // 
            // btn_logOut
            // 
            btn_logOut.BackColor = Color.Green;
            btn_logOut.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_logOut.ForeColor = Color.White;
            btn_logOut.Location = new Point(381, 184);
            btn_logOut.Name = "btn_logOut";
            btn_logOut.Size = new Size(118, 32);
            btn_logOut.TabIndex = 7;
            btn_logOut.Text = "log out";
            btn_logOut.UseVisualStyleBackColor = false;
            btn_logOut.Click += btn_logOut_Click;
            // 
            // btn_reports
            // 
            btn_reports.BackColor = Color.Green;
            btn_reports.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_reports.ForeColor = Color.White;
            btn_reports.Location = new Point(381, 140);
            btn_reports.Name = "btn_reports";
            btn_reports.Size = new Size(118, 32);
            btn_reports.TabIndex = 8;
            btn_reports.Text = "reports";
            btn_reports.UseVisualStyleBackColor = false;
            btn_reports.Click += btn_reports_Click;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 333);
            Controls.Add(btn_reports);
            Controls.Add(btn_logOut);
            Controls.Add(txt_in);
            Controls.Add(txt_out);
            Controls.Add(ch_in);
            Controls.Add(ch_out);
            Controls.Add(label1);
            Controls.Add(btn_editProfile);
            Controls.Add(btn_showProfile);
            Name = "home";
            Text = "home";
            Load += home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_showProfile;
        private Button btn_editProfile;
        private Label label1;
        private Button btn_specify;
        private Button btn_myRecord;
        private CheckBox ch_out;
        private CheckBox ch_in;
        private TextBox txt_out;
        private TextBox txt_in;
        private Button btn_logOut;
        private Button btn_reports;
    }
}