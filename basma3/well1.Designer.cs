namespace basma3
{
    partial class well1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(well1));
            welcome = new Label();
            btn_signUp = new Button();
            btn_signIn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.BackColor = Color.Green;
            welcome.Font = new Font("Swis721 BlkEx BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcome.ForeColor = Color.Green;
            welcome.Location = new Point(241, 9);
            welcome.Name = "welcome";
            welcome.Size = new Size(351, 10);
            welcome.TabIndex = 6;
            welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_signUp
            // 
            btn_signUp.BackColor = Color.DarkGreen;
            btn_signUp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_signUp.ForeColor = Color.LightGray;
            btn_signUp.Location = new Point(183, 583);
            btn_signUp.Name = "btn_signUp";
            btn_signUp.Size = new Size(225, 52);
            btn_signUp.TabIndex = 4;
            btn_signUp.Text = "sign Up";
            btn_signUp.UseVisualStyleBackColor = false;
            btn_signUp.Click += btn_signUp_Click;
            // 
            // btn_signIn
            // 
            btn_signIn.BackColor = Color.DarkGreen;
            btn_signIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_signIn.ForeColor = Color.LightGray;
            btn_signIn.Location = new Point(509, 583);
            btn_signIn.Name = "btn_signIn";
            btn_signIn.Size = new Size(218, 52);
            btn_signIn.TabIndex = 8;
            btn_signIn.Text = "sign In";
            btn_signIn.UseVisualStyleBackColor = false;
            btn_signIn.Click += btn_signIn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(136, 43);
            label1.Name = "label1";
            label1.Size = new Size(602, 79);
            label1.TabIndex = 9;
            label1.Text = "wellcome to our app basma";
            // 
            // well1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(892, 715);
            Controls.Add(label1);
            Controls.Add(btn_signIn);
            Controls.Add(welcome);
            Controls.Add(btn_signUp);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "well1";
            Text = "well1";
            Load += well1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label welcome;
        private Button btn_signUp;
        private Button btn_signIn;
        private Label label1;
    }
}