namespace SYDEFinalProject
{
    partial class frmHomeScreen
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegisterNewAdmin = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(78, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegisterNewAdmin
            // 
            this.btnRegisterNewAdmin.Location = new System.Drawing.Point(78, 119);
            this.btnRegisterNewAdmin.Name = "btnRegisterNewAdmin";
            this.btnRegisterNewAdmin.Size = new System.Drawing.Size(128, 23);
            this.btnRegisterNewAdmin.TabIndex = 4;
            this.btnRegisterNewAdmin.Text = "Register New Admin";
            this.btnRegisterNewAdmin.UseVisualStyleBackColor = true;
            this.btnRegisterNewAdmin.Click += new System.EventHandler(this.btnRegisterNewAdmin_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(78, 90);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(128, 23);
            this.btnAdminLogin.TabIndex = 3;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // frmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegisterNewAdmin);
            this.Controls.Add(this.btnAdminLogin);
            this.Name = "frmHomeScreen";
            this.Text = "Home Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegisterNewAdmin;
        private System.Windows.Forms.Button btnAdminLogin;
    }
}

