namespace basma3
{
    partial class recordsEmp
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
            btn_home = new Button();
            btn_show = new Button();
            dgv_report = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_report).BeginInit();
            SuspendLayout();
            // 
            // btn_home
            // 
            btn_home.Location = new Point(337, 357);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(145, 33);
            btn_home.TabIndex = 18;
            btn_home.Text = "home";
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // btn_show
            // 
            btn_show.Location = new Point(337, 314);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(145, 33);
            btn_show.TabIndex = 20;
            btn_show.Text = "show";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // dgv_report
            // 
            dgv_report.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_report.Location = new Point(65, 60);
            dgv_report.Name = "dgv_report";
            dgv_report.Size = new Size(628, 229);
            dgv_report.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 27);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 22;
            label1.Text = "my records";
            // 
            // recordsEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 418);
            Controls.Add(label1);
            Controls.Add(dgv_report);
            Controls.Add(btn_show);
            Controls.Add(btn_home);
            Name = "recordsEmp";
            Text = "homePage";
            Load += homePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_report).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_home;
        private Button btn_show;
        private DataGridView dgv_report;
        private Label label1;
    }
}