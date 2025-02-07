namespace basma3
{
    partial class sign_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_in));
            btn_togle = new Button();
            btn_back = new Button();
            btn_confirm = new Button();
            txt_password = new TextBox();
            txt_email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_togle
            // 
            btn_togle.BackColor = Color.Green;
            btn_togle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_togle.ForeColor = Color.LightGray;
            btn_togle.Location = new Point(930, 171);
            btn_togle.Margin = new Padding(4, 4, 4, 4);
            btn_togle.Name = "btn_togle";
            btn_togle.Size = new Size(63, 32);
            btn_togle.TabIndex = 0;
            btn_togle.Text = "show";
            btn_togle.UseVisualStyleBackColor = false;
            btn_togle.Click += btn_togle_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Green;
            btn_back.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_back.ForeColor = Color.LightGray;
            btn_back.Location = new Point(752, 333);
            btn_back.Margin = new Padding(4, 4, 4, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(193, 52);
            btn_back.TabIndex = 1;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.Green;
            btn_confirm.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_confirm.ForeColor = Color.LightGray;
            btn_confirm.Location = new Point(752, 263);
            btn_confirm.Margin = new Padding(4, 4, 4, 4);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(193, 49);
            btn_confirm.TabIndex = 2;
            btn_confirm.Text = "confirm";
            btn_confirm.UseVisualStyleBackColor = false;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txt_password.Location = new Point(705, 104);
            txt_password.Margin = new Padding(4, 4, 4, 4);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "enter your password";
            txt_password.Size = new Size(287, 57);
            txt_password.TabIndex = 3;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txt_email.Location = new Point(705, 36);
            txt_email.Margin = new Padding(4, 4, 4, 4);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "enter you email";
            txt_email.Size = new Size(287, 57);
            txt_email.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(606, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 5;
            label1.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(596, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 6;
            label2.Text = "password:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -1);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 458);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // sign_in
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1018, 452);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_email);
            Controls.Add(txt_password);
            Controls.Add(btn_confirm);
            Controls.Add(btn_back);
            Controls.Add(btn_togle);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "sign_in";
            Text = "sign_in";
            Load += sign_in_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_togle;
        private Button btn_back;
        private Button btn_confirm;
        private TextBox txt_password;
        private TextBox txt_email;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}