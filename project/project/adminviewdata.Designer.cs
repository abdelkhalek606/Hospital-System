namespace Project
{
    partial class adminviewdata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminviewdata));
            this.medicalstaffview = new System.Windows.Forms.Button();
            this.patientbutton = new System.Windows.Forms.Button();
            this.mangmentbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // medicalstaffview
            // 
            this.medicalstaffview.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.medicalstaffview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.medicalstaffview.Location = new System.Drawing.Point(122, 346);
            this.medicalstaffview.Margin = new System.Windows.Forms.Padding(4);
            this.medicalstaffview.Name = "medicalstaffview";
            this.medicalstaffview.Size = new System.Drawing.Size(262, 66);
            this.medicalstaffview.TabIndex = 99;
            this.medicalstaffview.Text = "Medical Staff";
            this.medicalstaffview.UseVisualStyleBackColor = false;
            this.medicalstaffview.Click += new System.EventHandler(this.medicalstaffview_Click);
            // 
            // patientbutton
            // 
            this.patientbutton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.patientbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.patientbutton.Location = new System.Drawing.Point(122, 222);
            this.patientbutton.Margin = new System.Windows.Forms.Padding(4);
            this.patientbutton.Name = "patientbutton";
            this.patientbutton.Size = new System.Drawing.Size(262, 66);
            this.patientbutton.TabIndex = 98;
            this.patientbutton.Text = "Patients And Relatives";
            this.patientbutton.UseVisualStyleBackColor = false;
            this.patientbutton.Click += new System.EventHandler(this.patientbutton_Click);
            // 
            // mangmentbutton
            // 
            this.mangmentbutton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.mangmentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mangmentbutton.Location = new System.Drawing.Point(122, 88);
            this.mangmentbutton.Margin = new System.Windows.Forms.Padding(4);
            this.mangmentbutton.Name = "mangmentbutton";
            this.mangmentbutton.Size = new System.Drawing.Size(262, 66);
            this.mangmentbutton.TabIndex = 97;
            this.mangmentbutton.Text = " Mangment Staff";
            this.mangmentbutton.UseVisualStyleBackColor = false;
            this.mangmentbutton.Click += new System.EventHandler(this.mangmentbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mangmentbutton);
            this.groupBox1.Controls.Add(this.medicalstaffview);
            this.groupBox1.Controls.Add(this.patientbutton);
            this.groupBox1.Location = new System.Drawing.Point(539, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 511);
            this.groupBox1.TabIndex = 100;
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
            this.button7.Location = new System.Drawing.Point(1417, 747);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 98);
            this.button7.TabIndex = 223;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // adminviewdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.blur_hospital;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1536, 876);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Name = "adminviewdata";
            this.Text = "adminviewdata";
            this.Load += new System.EventHandler(this.adminviewdata_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button medicalstaffview;
        private System.Windows.Forms.Button patientbutton;
        private System.Windows.Forms.Button mangmentbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
    }
}