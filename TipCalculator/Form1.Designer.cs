namespace TipCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Total_Bill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.TextBox();
            this.Tip_decrement = new System.Windows.Forms.Button();
            this.Tip_increment = new System.Windows.Forms.Button();
            this.No_of_people_decrement = new System.Windows.Forms.Button();
            this.No_of_people_increment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Tip_Count = new System.Windows.Forms.Label();
            this.Bill_per_person = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.No_of_people = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close_btn = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // Total_Bill
            // 
            this.Total_Bill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Total_Bill.Location = new System.Drawing.Point(32, 87);
            this.Total_Bill.MaxLength = 7;
            this.Total_Bill.Name = "Total_Bill";
            this.Total_Bill.Size = new System.Drawing.Size(251, 34);
            this.Total_Bill.TabIndex = 1;
            this.Total_Bill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total_Bill.TextChanged += new System.EventHandler(this.Totalbill_changed);
            this.Total_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip %";
            // 
            // Tip
            // 
            this.Tip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tip.Location = new System.Drawing.Point(74, 160);
            this.Tip.MaxLength = 3;
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(167, 34);
            this.Tip.TabIndex = 3;
            this.Tip.Text = "0";
            this.Tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tip.TextChanged += new System.EventHandler(this.TipPer_TextChanged);
            this.Tip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitPress);
            // 
            // Tip_decrement
            // 
            this.Tip_decrement.Location = new System.Drawing.Point(32, 157);
            this.Tip_decrement.Name = "Tip_decrement";
            this.Tip_decrement.Size = new System.Drawing.Size(43, 39);
            this.Tip_decrement.TabIndex = 4;
            this.Tip_decrement.Text = "-";
            this.Tip_decrement.UseVisualStyleBackColor = true;
            this.Tip_decrement.Click += new System.EventHandler(this.Tip_decrement_Click);
            // 
            // Tip_increment
            // 
            this.Tip_increment.Location = new System.Drawing.Point(240, 157);
            this.Tip_increment.Name = "Tip_increment";
            this.Tip_increment.Size = new System.Drawing.Size(43, 39);
            this.Tip_increment.TabIndex = 5;
            this.Tip_increment.Text = "+";
            this.Tip_increment.UseVisualStyleBackColor = true;
            this.Tip_increment.Click += new System.EventHandler(this.Tip_Increment_Click);
            // 
            // No_of_people_decrement
            // 
            this.No_of_people_decrement.Location = new System.Drawing.Point(32, 235);
            this.No_of_people_decrement.Name = "No_of_people_decrement";
            this.No_of_people_decrement.Size = new System.Drawing.Size(43, 37);
            this.No_of_people_decrement.TabIndex = 6;
            this.No_of_people_decrement.Text = "-";
            this.No_of_people_decrement.UseVisualStyleBackColor = true;
            this.No_of_people_decrement.Click += new System.EventHandler(this.No_of_people_decrement_Clic);
            // 
            // No_of_people_increment
            // 
            this.No_of_people_increment.Location = new System.Drawing.Point(240, 235);
            this.No_of_people_increment.Name = "No_of_people_increment";
            this.No_of_people_increment.Size = new System.Drawing.Size(43, 38);
            this.No_of_people_increment.TabIndex = 7;
            this.No_of_people_increment.Text = "+";
            this.No_of_people_increment.UseVisualStyleBackColor = true;
            this.No_of_people_increment.Click += new System.EventHandler(this.No_of_people_increment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of people";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "per person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(33, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 41);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "per person";
            // 
            // Tip_Count
            // 
            this.Tip_Count.AutoSize = true;
            this.Tip_Count.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tip_Count.Location = new System.Drawing.Point(189, 113);
            this.Tip_Count.Name = "Tip_Count";
            this.Tip_Count.Size = new System.Drawing.Size(93, 41);
            this.Tip_Count.TabIndex = 16;
            this.Tip_Count.Text = "00.00";
            // 
            // Bill_per_person
            // 
            this.Bill_per_person.AutoSize = true;
            this.Bill_per_person.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bill_per_person.Location = new System.Drawing.Point(189, 198);
            this.Bill_per_person.Name = "Bill_per_person";
            this.Bill_per_person.Size = new System.Drawing.Size(106, 37);
            this.Bill_per_person.TabIndex = 17;
            this.Bill_per_person.Text = "00.00";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.No_of_people);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Total_Bill);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Tip_decrement);
            this.panel1.Controls.Add(this.Tip);
            this.panel1.Controls.Add(this.Tip_increment);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.No_of_people_decrement);
            this.panel1.Controls.Add(this.No_of_people_increment);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 347);
            this.panel1.TabIndex = 18;
            // 
            // No_of_people
            // 
            this.No_of_people.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.No_of_people.Location = new System.Drawing.Point(74, 237);
            this.No_of_people.MaxLength = 3;
            this.No_of_people.Name = "No_of_people";
            this.No_of_people.Size = new System.Drawing.Size(167, 34);
            this.No_of_people.TabIndex = 11;
            this.No_of_people.Text = "1";
            this.No_of_people.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.No_of_people.TextChanged += new System.EventHandler(this.No_of_people_TextChanged);
            this.No_of_people.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitPress);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Close_btn);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Bill_per_person);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Tip_Count);
            this.panel2.Location = new System.Drawing.Point(329, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 347);
            this.panel2.TabIndex = 19;
            // 
            // Close_btn
            // 
            this.Close_btn.AutoSize = true;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Close_btn.Location = new System.Drawing.Point(356, 0);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(29, 31);
            this.Close_btn.TabIndex = 21;
            this.Close_btn.Text = "X";
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_event);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(159, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 37);
            this.label9.TabIndex = 19;
            this.label9.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(162, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 41);
            this.label6.TabIndex = 18;
            this.label6.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(727, 340);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        //private TextBox textBox1;
        private Label label2;
        private TextBox Tip;
        private Button Tip_decrement;
        private Button Tip_increment;
        private Button No_of_people_decrement;
        private Button No_of_people_increment;
        private TextBox No_of_people;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Panel panel2;
        private TextBox Total_Bill;
        private Label Tip_Count;
        private Label label6;
        private Label label9;
        private Label Bill_per_person;
        private Label Close_btn;
        // private TextBox Txt_Total_Bill;
        // private TextBox Total_Bill;
    }
}