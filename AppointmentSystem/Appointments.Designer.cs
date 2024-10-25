namespace AppointmentSystem
{
    partial class Appointments
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(10, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(1771, 812);
            dataGridView1.TabIndex = 1;

            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(560, 851);
            button1.Name = "button1";
            button1.Size = new Size(228, 52);
            button1.TabIndex = 2;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AcceptButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(845, 851);
            button2.Name = "button2";
            button2.Size = new Size(228, 52);
            button2.TabIndex = 3;
            button2.Text = "Decline";
            button2.UseVisualStyleBackColor = false;
            button2.Click += DeclineButton_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Font = new Font("Microsoft Sans Serif", 13.8F);
            button3.Location = new Point(1125, 851);
            button3.Name = "button3";
            button3.Size = new Size(228, 52);
            button3.TabIndex = 4;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += BackButton_Click;
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 884);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Name = "Appointments";
            Text = "Appointments";
            WindowState = FormWindowState.Maximized;
            Load += Appointments_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
