namespace SYDEFinalProject
{
    partial class frmMainScreen
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
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnPhysicians = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnSupplies = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatients
            // 
            this.btnPatients.Location = new System.Drawing.Point(68, 41);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(140, 23);
            this.btnPatients.TabIndex = 0;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnPhysicians
            // 
            this.btnPhysicians.Location = new System.Drawing.Point(68, 70);
            this.btnPhysicians.Name = "btnPhysicians";
            this.btnPhysicians.Size = new System.Drawing.Size(140, 23);
            this.btnPhysicians.TabIndex = 1;
            this.btnPhysicians.Text = "Physicians";
            this.btnPhysicians.UseVisualStyleBackColor = true;
            this.btnPhysicians.Click += new System.EventHandler(this.btnPhysicians_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(68, 99);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(140, 23);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(68, 128);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(140, 23);
            this.btnRooms.TabIndex = 3;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnSupplies
            // 
            this.btnSupplies.Location = new System.Drawing.Point(68, 157);
            this.btnSupplies.Name = "btnSupplies";
            this.btnSupplies.Size = new System.Drawing.Size(140, 23);
            this.btnSupplies.TabIndex = 4;
            this.btnSupplies.Text = "Supplies";
            this.btnSupplies.UseVisualStyleBackColor = true;
            this.btnSupplies.Click += new System.EventHandler(this.btnSupplies_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(68, 186);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSupplies);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnPhysicians);
            this.Controls.Add(this.btnPatients);
            this.Name = "frmMainScreen";
            this.Text = "Main Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnPhysicians;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnSupplies;
        private System.Windows.Forms.Button btnLogout;
    }
}