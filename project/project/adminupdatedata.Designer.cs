namespace Project
{
    partial class adminupdatedata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminupdatedata));
            this.passwordsbutton = new System.Windows.Forms.Button();
            this.medicalstaffupdate = new System.Windows.Forms.Button();
            this.patientbutton = new System.Windows.Forms.Button();
            this.mangmentbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordsbutton
            // 
            this.passwordsbutton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.passwordsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.passwordsbutton.Location = new System.Drawing.Point(133, 498);
            this.passwordsbutton.Margin = new System.Windows.Forms.Padding(4);
            this.passwordsbutton.Name = "passwordsbutton";
            this.passwordsbutton.Size = new System.Drawing.Size(338, 120);
            this.passwordsbutton.TabIndex = 102;
            this.passwordsbutton.Text = "Usernames and Passwords";
            this.passwordsbutton.UseVisualStyleBackColor = false;
            this.passwordsbutton.Click += new System.EventHandler(this.passwordsbutton_Click);
            // 
            // medicalstaffupdate
            // 
            this.medicalstaffupdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.medicalstaffupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.medicalstaffupdate.Location = new System.Drawing.Point(133, 345);
            this.medicalstaffupdate.Margin = new System.Windows.Forms.Padding(4);
            this.medicalstaffupdate.Name = "medicalstaffupdate";
            this.medicalstaffupdate.Size = new System.Drawing.Size(338, 120);
            this.medicalstaffupdate.TabIndex = 101;
            this.medicalstaffupdate.Text = " Medical Staff";
            this.medicalstaffupdate.UseVisualStyleBackColor = false;
            this.medicalstaffupdate.Click += new System.EventHandler(this.medicalstaffupdate_Click);
            // 
            // patientbutton
            // 
            this.patientbutton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.patientbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.patientbutton.Location = new System.Drawing.Point(133, 199);
            this.patientbutton.Margin = new System.Windows.Forms.Padding(4);
            this.patientbutton.Name = "patientbutton";
            this.patientbutton.Size = new System.Drawing.Size(338, 120);
            this.patientbutton.TabIndex = 100;
            this.patientbutton.Text = " Patients And Relatives";
            this.patientbutton.UseVisualStyleBackColor = false;
            this.patientbutton.Click += new System.EventHandler(this.patientbutton_Click);
            // 
            // mangmentbutton
            // 
            this.mangmentbutton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.mangmentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mangmentbutton.Location = new System.Drawing.Point(133, 38);
            this.mangmentbutton.Margin = new System.Windows.Forms.Padding(4);
            this.mangmentbutton.Name = "mangmentbutton";
            this.mangmentbutton.Size = new System.Drawing.Size(338, 120);
            this.mangmentbutton.TabIndex = 99;
            this.mangmentbutton.Text = "Mangment Staff";
            this.mangmentbutton.UseVisualStyleBackColor = false;
            this.mangmentbutton.Click += new System.EventHandler(this.mangmentbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mangmentbutton);
            this.groupBox1.Controls.Add(this.passwordsbutton);
            this.groupBox1.Controls.Add(this.patientbutton);
            this.groupBox1.Controls.Add(this.medicalstaffupdate);
            this.groupBox1.Location = new System.Drawing.Point(471, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 642);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(1409, 758);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 98);
            this.button7.TabIndex = 221;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // adminupdatedata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.blur_hospital;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1535, 889);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Name = "adminupdatedata";
            this.Text = "adminupdatedata";
            this.Load += new System.EventHandler(this.adminupdatedata_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button passwordsbutton;
        private System.Windows.Forms.Button medicalstaffupdate;
        private System.Windows.Forms.Button patientbutton;
        private System.Windows.Forms.Button mangmentbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
    }
}