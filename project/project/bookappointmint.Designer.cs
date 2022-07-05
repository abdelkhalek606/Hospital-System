namespace Project
{
    partial class bookappointmint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookappointmint));
            this.bookbutton = new System.Windows.Forms.Button();
            this.doctorcomboBox = new System.Windows.Forms.ComboBox();
            this.departmentcombobox = new System.Windows.Forms.ComboBox();
            this.appointmentcomboBox = new System.Windows.Forms.ComboBox();
            this.daycomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookbutton
            // 
            this.bookbutton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bookbutton.Location = new System.Drawing.Point(180, 466);
            this.bookbutton.Name = "bookbutton";
            this.bookbutton.Size = new System.Drawing.Size(201, 81);
            this.bookbutton.TabIndex = 22;
            this.bookbutton.Text = "book ";
            this.bookbutton.UseVisualStyleBackColor = false;
            this.bookbutton.Click += new System.EventHandler(this.bookbutton_Click);
            // 
            // doctorcomboBox
            // 
            this.doctorcomboBox.FormattingEnabled = true;
            this.doctorcomboBox.Location = new System.Drawing.Point(341, 213);
            this.doctorcomboBox.Name = "doctorcomboBox";
            this.doctorcomboBox.Size = new System.Drawing.Size(209, 24);
            this.doctorcomboBox.TabIndex = 19;
            this.doctorcomboBox.SelectedIndexChanged += new System.EventHandler(this.doctorcomboBox_SelectedIndexChanged);
            // 
            // departmentcombobox
            // 
            this.departmentcombobox.FormattingEnabled = true;
            this.departmentcombobox.Location = new System.Drawing.Point(341, 134);
            this.departmentcombobox.Name = "departmentcombobox";
            this.departmentcombobox.Size = new System.Drawing.Size(209, 24);
            this.departmentcombobox.TabIndex = 18;
            this.departmentcombobox.SelectedIndexChanged += new System.EventHandler(this.departmentcombobox_SelectedIndexChanged);
            // 
            // appointmentcomboBox
            // 
            this.appointmentcomboBox.FormattingEnabled = true;
            this.appointmentcomboBox.Location = new System.Drawing.Point(341, 361);
            this.appointmentcomboBox.Name = "appointmentcomboBox";
            this.appointmentcomboBox.Size = new System.Drawing.Size(209, 24);
            this.appointmentcomboBox.TabIndex = 17;
            this.appointmentcomboBox.SelectedIndexChanged += new System.EventHandler(this.appointmentcomboBox_SelectedIndexChanged);
            // 
            // daycomboBox
            // 
            this.daycomboBox.FormattingEnabled = true;
            this.daycomboBox.Location = new System.Drawing.Point(341, 284);
            this.daycomboBox.Name = "daycomboBox";
            this.daycomboBox.Size = new System.Drawing.Size(209, 24);
            this.daycomboBox.TabIndex = 16;
            this.daycomboBox.SelectedIndexChanged += new System.EventHandler(this.daycomboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bookbutton);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.departmentcombobox);
            this.groupBox1.Controls.Add(this.doctorcomboBox);
            this.groupBox1.Controls.Add(this.daycomboBox);
            this.groupBox1.Controls.Add(this.appointmentcomboBox);
            this.groupBox1.Location = new System.Drawing.Point(426, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 637);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(40, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 190;
            this.label7.Text = "Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 22);
            this.label2.TabIndex = 189;
            this.label2.Text = "Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 188;
            this.label1.Text = "Doctor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 22);
            this.label10.TabIndex = 187;
            this.label10.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(174, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 33);
            this.label9.TabIndex = 109;
            this.label9.Text = "Book Appointment";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(1374, 773);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 98);
            this.button7.TabIndex = 26;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // bookappointmint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Project.Properties.Resources.DD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1504, 884);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Name = "bookappointmint";
            this.Text = "bookappointmint";
            this.Load += new System.EventHandler(this.bookappointmint_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bookbutton;
        private System.Windows.Forms.ComboBox doctorcomboBox;
        private System.Windows.Forms.ComboBox departmentcombobox;
        private System.Windows.Forms.ComboBox appointmentcomboBox;
        private System.Windows.Forms.ComboBox daycomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
    }
}