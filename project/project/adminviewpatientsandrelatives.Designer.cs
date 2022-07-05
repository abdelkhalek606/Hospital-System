namespace Project
{
    partial class adminviewpatientsandrelatives
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminviewpatientsandrelatives));
            this.patientgridbutt = new System.Windows.Forms.Button();
            this.relativegridbutt = new System.Windows.Forms.Button();
            this.patGridView = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientgridbutt
            // 
            this.patientgridbutt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.patientgridbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.patientgridbutt.Location = new System.Drawing.Point(251, 575);
            this.patientgridbutt.Margin = new System.Windows.Forms.Padding(4);
            this.patientgridbutt.Name = "patientgridbutt";
            this.patientgridbutt.Size = new System.Drawing.Size(229, 74);
            this.patientgridbutt.TabIndex = 21;
            this.patientgridbutt.Text = "display patients";
            this.patientgridbutt.UseVisualStyleBackColor = false;
            this.patientgridbutt.Click += new System.EventHandler(this.patientgridbutt_Click);
            // 
            // relativegridbutt
            // 
            this.relativegridbutt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.relativegridbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.relativegridbutt.Location = new System.Drawing.Point(786, 575);
            this.relativegridbutt.Margin = new System.Windows.Forms.Padding(4);
            this.relativegridbutt.Name = "relativegridbutt";
            this.relativegridbutt.Size = new System.Drawing.Size(229, 74);
            this.relativegridbutt.TabIndex = 20;
            this.relativegridbutt.Text = "Display Relatives";
            this.relativegridbutt.UseVisualStyleBackColor = false;
            this.relativegridbutt.Click += new System.EventHandler(this.relativegridbutt_Click);
            // 
            // patGridView
            // 
            this.patGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patGridView.Location = new System.Drawing.Point(167, 53);
            this.patGridView.Margin = new System.Windows.Forms.Padding(4);
            this.patGridView.Name = "patGridView";
            this.patGridView.RowHeadersWidth = 51;
            this.patGridView.Size = new System.Drawing.Size(936, 496);
            this.patGridView.TabIndex = 18;
            this.patGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patGridView_CellContentClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(1162, 645);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 98);
            this.button7.TabIndex = 110;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // adminviewpatientsandrelatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.blur_hospital;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 766);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.patientgridbutt);
            this.Controls.Add(this.relativegridbutt);
            this.Controls.Add(this.patGridView);
            this.Name = "adminviewpatientsandrelatives";
            this.Text = "adminviewpatientsandrelatives";
            this.Load += new System.EventHandler(this.adminviewpatientsandrelatives_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button patientgridbutt;
        private System.Windows.Forms.Button relativegridbutt;
        private System.Windows.Forms.DataGridView patGridView;
        private System.Windows.Forms.Button button7;
    }
}