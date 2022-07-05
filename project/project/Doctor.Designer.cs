namespace Project
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.delet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.answermessege = new System.Windows.Forms.Button();
            this.showschedule = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delet
            // 
            this.delet.BackColor = System.Drawing.Color.Transparent;
            this.delet.BackgroundImage = global::Project.Properties.Resources.delete;
            this.delet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delet.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.delet.Location = new System.Drawing.Point(60, 711);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(131, 125);
            this.delet.TabIndex = 5;
            this.delet.UseVisualStyleBackColor = false;
            this.delet.Click += new System.EventHandler(this.delet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(46, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "View Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Show Schedule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Answer Mesage";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Project.Properties.Resources.user2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(60, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 125);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Project.Properties.Resources.emergency;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Location = new System.Drawing.Point(60, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 125);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answermessege
            // 
            this.answermessege.BackColor = System.Drawing.Color.Transparent;
            this.answermessege.BackgroundImage = global::Project.Properties.Resources.faqs;
            this.answermessege.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answermessege.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.answermessege.Location = new System.Drawing.Point(60, 371);
            this.answermessege.Name = "answermessege";
            this.answermessege.Size = new System.Drawing.Size(131, 125);
            this.answermessege.TabIndex = 3;
            this.answermessege.UseVisualStyleBackColor = false;
            this.answermessege.Click += new System.EventHandler(this.answermessege_Click);
            // 
            // showschedule
            // 
            this.showschedule.BackColor = System.Drawing.Color.Transparent;
            this.showschedule.BackgroundImage = global::Project.Properties.Resources.calendar;
            this.showschedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showschedule.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showschedule.Location = new System.Drawing.Point(60, 197);
            this.showschedule.Name = "showschedule";
            this.showschedule.Size = new System.Drawing.Size(131, 125);
            this.showschedule.TabIndex = 2;
            this.showschedule.UseVisualStyleBackColor = false;
            this.showschedule.Click += new System.EventHandler(this.showschedule_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 659);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Emergenct Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 849);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Delete Appointment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(470, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(533, 91);
            this.label6.TabIndex = 12;
            this.label6.Text = "Doctor Profile";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button9.Location = new System.Drawing.Point(1376, 792);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 98);
            this.button9.TabIndex = 112;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.DD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1486, 903);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answermessege);
            this.Controls.Add(this.showschedule);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showschedule;
        private System.Windows.Forms.Button answermessege;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
    }
}