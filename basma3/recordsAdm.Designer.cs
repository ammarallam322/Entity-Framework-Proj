namespace basma3
{
    partial class recordsAdm
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
            cb_records = new ComboBox();
            dgv_record = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_record).BeginInit();
            SuspendLayout();
            // 
            // cb_records
            // 
            cb_records.FormattingEnabled = true;
            cb_records.Location = new Point(296, 70);
            cb_records.Name = "cb_records";
            cb_records.Size = new Size(121, 23);
            cb_records.TabIndex = 8;
            cb_records.Text = "type of report";
            cb_records.SelectedIndexChanged += cb_records_SelectedIndexChanged;
            // 
            // dgv_record
            // 
            dgv_record.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_record.Location = new Point(40, 128);
            dgv_record.Name = "dgv_record";
            dgv_record.Size = new Size(628, 150);
            dgv_record.TabIndex = 9;
            dgv_record.CellContentClick += dgv_record_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 46);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 11;
            label1.Text = "choose type of report";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(281, 296);
            button1.Name = "button1";
            button1.Size = new Size(104, 43);
            button1.TabIndex = 12;
            button1.Text = "home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // recordsAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 374);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dgv_record);
            Controls.Add(cb_records);
            Name = "recordsAdm";
            Text = "records";
            Load += records_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_record).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_records;
        private DataGridView dgv_record;
        private Label label1;
        private Button button1;
    }
}