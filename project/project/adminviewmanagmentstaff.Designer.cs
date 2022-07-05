namespace Project
{
    partial class adminviewmanagmentstaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminviewmanagmentstaff));
            this.recepgridbutt = new System.Windows.Forms.Button();
            this.admingridbutt = new System.Windows.Forms.Button();
            this.adminGridView = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recepgridbutt
            // 
            this.recepgridbutt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.recepgridbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.recepgridbutt.Location = new System.Drawing.Point(575, 736);
            this.recepgridbutt.Margin = new System.Windows.Forms.Padding(4);
            this.recepgridbutt.Name = "recepgridbutt";
            this.recepgridbutt.Size = new System.Drawing.Size(273, 83);
            this.recepgridbutt.TabIndex = 20;
            this.recepgridbutt.Text = "Display Receptionsts";
            this.recepgridbutt.UseVisualStyleBackColor = false;
            this.recepgridbutt.Click += new System.EventHandler(this.recepgridbutt_Click);
            // 
            // admingridbutt
            // 
            this.admingridbutt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.admingridbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.admingridbutt.Location = new System.Drawing.Point(231, 736);
            this.admingridbutt.Margin = new System.Windows.Forms.Padding(4);
            this.admingridbutt.Name = "admingridbutt";
            this.admingridbutt.Size = new System.Drawing.Size(273, 83);
            this.admingridbutt.TabIndex = 19;
            this.admingridbutt.Text = "Display Admins";
            this.admingridbutt.UseVisualStyleBackColor = false;
            this.admingridbutt.Click += new System.EventHandler(this.admingridbutt_Click);
            // 
            // adminGridView
            // 
            this.adminGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminGridView.Location = new System.Drawing.Point(89, 86);
            this.adminGridView.Margin = new System.Windows.Forms.Padding(4);
            this.adminGridView.Name = "adminGridView";
            this.adminGridView.RowHeadersWidth = 51;
            this.adminGridView.Size = new System.Drawing.Size(936, 552);
            this.adminGridView.TabIndex = 18;
            this.adminGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminGridView_CellContentClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(1378, 736);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 98);
            this.button7.TabIndex = 108;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // adminviewmanagmentstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.blur_hospital;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1528, 892);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.recepgridbutt);
            this.Controls.Add(this.admingridbutt);
            this.Controls.Add(this.adminGridView);
            this.Name = "adminviewmanagmentstaff";
            this.Text = "adminviewmanagmentstaff";
            this.Load += new System.EventHandler(this.adminviewmanagmentstaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recepgridbutt;
        private System.Windows.Forms.Button admingridbutt;
        private System.Windows.Forms.DataGridView adminGridView;
        private System.Windows.Forms.Button button7;
    }
}