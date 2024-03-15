namespace ApartmentManagement.Applications
{
    partial class AddManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddManager));
            this.pnlManagerAdd = new System.Windows.Forms.Panel();
            this.lblOptional = new System.Windows.Forms.Label();
            this.lblSellerSignupAddress = new System.Windows.Forms.Label();
            this.lblSellerSignupConfirmPassword = new System.Windows.Forms.Label();
            this.txtManagerAddConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtManagerAddAddress = new System.Windows.Forms.TextBox();
            this.lblSellerSignupPassword = new System.Windows.Forms.Label();
            this.lblSellerSignupPhone = new System.Windows.Forms.Label();
            this.txtManagerAddPassword = new System.Windows.Forms.TextBox();
            this.txtManagerAddPhone = new System.Windows.Forms.TextBox();
            this.btnManagerAddSignup = new System.Windows.Forms.Button();
            this.btnAdminBack = new System.Windows.Forms.Button();
            this.lblSellerSignupEmail = new System.Windows.Forms.Label();
            this.lblSellerSignupName = new System.Windows.Forms.Label();
            this.txtManagerAddEmail = new System.Windows.Forms.TextBox();
            this.txtManagerAddName = new System.Windows.Forms.TextBox();
            this.pnlManagerAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManagerAdd
            // 
            this.pnlManagerAdd.BackColor = System.Drawing.Color.Black;
            this.pnlManagerAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlManagerAdd.BackgroundImage")));
            this.pnlManagerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlManagerAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlManagerAdd.Controls.Add(this.lblOptional);
            this.pnlManagerAdd.Controls.Add(this.lblSellerSignupAddress);
            this.pnlManagerAdd.Controls.Add(this.lblSellerSignupConfirmPassword);
            this.pnlManagerAdd.Controls.Add(this.txtManagerAddConfirmPassword);
            this.pnlManagerAdd.Controls.Add(this.txtManagerAddAddress);
            this.pnlManagerAdd.Controls.Add(this.lblSellerSignupPassword);
            this.pnlManagerAdd.Controls.Add(this.lblSellerSignupPhone);
            this.pnlManagerAdd.Controls.Add(this.txtManagerAddPassword);
            this.pnlManagerAdd.Controls.Add(this.txtManagerAddPhone);
            this.pnlManagerAdd.Controls.Add(this.btnManagerAddSignup);
            this.pnlManagerAdd.Controls.Add(this.btnAdminBack);
            this.pnlManagerAdd.Controls.Add(this.lblSellerSignupEmail);
            this.pnlManagerAdd.Controls.Add(this.lblSellerSignupName);
            this.pnlManagerAdd.Controls.Add(this.txtManagerAddEmail);
            this.pnlManagerAdd.Controls.Add(this.txtManagerAddName);
            this.pnlManagerAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManagerAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlManagerAdd.Name = "pnlManagerAdd";
            this.pnlManagerAdd.Size = new System.Drawing.Size(800, 450);
            this.pnlManagerAdd.TabIndex = 6;
            // 
            // lblOptional
            // 
            this.lblOptional.AutoSize = true;
            this.lblOptional.BackColor = System.Drawing.Color.Transparent;
            this.lblOptional.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOptional.Location = new System.Drawing.Point(288, 63);
            this.lblOptional.Name = "lblOptional";
            this.lblOptional.Size = new System.Drawing.Size(89, 20);
            this.lblOptional.TabIndex = 19;
            this.lblOptional.Text = "(optional)";
            // 
            // lblSellerSignupAddress
            // 
            this.lblSellerSignupAddress.AutoSize = true;
            this.lblSellerSignupAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblSellerSignupAddress.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerSignupAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSellerSignupAddress.Location = new System.Drawing.Point(28, 161);
            this.lblSellerSignupAddress.Name = "lblSellerSignupAddress";
            this.lblSellerSignupAddress.Size = new System.Drawing.Size(144, 20);
            this.lblSellerSignupAddress.TabIndex = 18;
            this.lblSellerSignupAddress.Text = "Present Address";
            // 
            // lblSellerSignupConfirmPassword
            // 
            this.lblSellerSignupConfirmPassword.AutoSize = true;
            this.lblSellerSignupConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblSellerSignupConfirmPassword.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerSignupConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSellerSignupConfirmPassword.Location = new System.Drawing.Point(28, 141);
            this.lblSellerSignupConfirmPassword.Name = "lblSellerSignupConfirmPassword";
            this.lblSellerSignupConfirmPassword.Size = new System.Drawing.Size(159, 20);
            this.lblSellerSignupConfirmPassword.TabIndex = 17;
            this.lblSellerSignupConfirmPassword.Text = "Confirm Password";
            // 
            // txtManagerAddConfirmPassword
            // 
            this.txtManagerAddConfirmPassword.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerAddConfirmPassword.Location = new System.Drawing.Point(193, 141);
            this.txtManagerAddConfirmPassword.Multiline = true;
            this.txtManagerAddConfirmPassword.Name = "txtManagerAddConfirmPassword";
            this.txtManagerAddConfirmPassword.PasswordChar = '*';
            this.txtManagerAddConfirmPassword.Size = new System.Drawing.Size(139, 20);
            this.txtManagerAddConfirmPassword.TabIndex = 16;
            // 
            // txtManagerAddAddress
            // 
            this.txtManagerAddAddress.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerAddAddress.Location = new System.Drawing.Point(193, 167);
            this.txtManagerAddAddress.Multiline = true;
            this.txtManagerAddAddress.Name = "txtManagerAddAddress";
            this.txtManagerAddAddress.Size = new System.Drawing.Size(139, 20);
            this.txtManagerAddAddress.TabIndex = 15;
            // 
            // lblSellerSignupPassword
            // 
            this.lblSellerSignupPassword.AutoSize = true;
            this.lblSellerSignupPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblSellerSignupPassword.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerSignupPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSellerSignupPassword.Location = new System.Drawing.Point(28, 115);
            this.lblSellerSignupPassword.Name = "lblSellerSignupPassword";
            this.lblSellerSignupPassword.Size = new System.Drawing.Size(86, 20);
            this.lblSellerSignupPassword.TabIndex = 14;
            this.lblSellerSignupPassword.Text = "Password";
            // 
            // lblSellerSignupPhone
            // 
            this.lblSellerSignupPhone.AutoSize = true;
            this.lblSellerSignupPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblSellerSignupPhone.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerSignupPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSellerSignupPhone.Location = new System.Drawing.Point(28, 89);
            this.lblSellerSignupPhone.Name = "lblSellerSignupPhone";
            this.lblSellerSignupPhone.Size = new System.Drawing.Size(61, 20);
            this.lblSellerSignupPhone.TabIndex = 13;
            this.lblSellerSignupPhone.Text = "Phone";
            // 
            // txtManagerAddPassword
            // 
            this.txtManagerAddPassword.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerAddPassword.Location = new System.Drawing.Point(143, 118);
            this.txtManagerAddPassword.Multiline = true;
            this.txtManagerAddPassword.Name = "txtManagerAddPassword";
            this.txtManagerAddPassword.PasswordChar = '*';
            this.txtManagerAddPassword.Size = new System.Drawing.Size(139, 20);
            this.txtManagerAddPassword.TabIndex = 12;
            // 
            // txtManagerAddPhone
            // 
            this.txtManagerAddPhone.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerAddPhone.Location = new System.Drawing.Point(143, 89);
            this.txtManagerAddPhone.Multiline = true;
            this.txtManagerAddPhone.Name = "txtManagerAddPhone";
            this.txtManagerAddPhone.Size = new System.Drawing.Size(139, 20);
            this.txtManagerAddPhone.TabIndex = 11;
            // 
            // btnManagerAddSignup
            // 
            this.btnManagerAddSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(224)))), ((int)(((byte)(143)))));
            this.btnManagerAddSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagerAddSignup.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerAddSignup.ForeColor = System.Drawing.Color.White;
            this.btnManagerAddSignup.Location = new System.Drawing.Point(143, 193);
            this.btnManagerAddSignup.Name = "btnManagerAddSignup";
            this.btnManagerAddSignup.Size = new System.Drawing.Size(80, 35);
            this.btnManagerAddSignup.TabIndex = 10;
            this.btnManagerAddSignup.Text = "Signup";
            this.btnManagerAddSignup.UseVisualStyleBackColor = false;
            this.btnManagerAddSignup.Click += new System.EventHandler(this.btnManagerAddSignup_Click);
            // 
            // btnAdminBack
            // 
            this.btnAdminBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdminBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminBack.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAdminBack.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminBack.Image")));
            this.btnAdminBack.Location = new System.Drawing.Point(19, 366);
            this.btnAdminBack.Name = "btnAdminBack";
            this.btnAdminBack.Size = new System.Drawing.Size(68, 35);
            this.btnAdminBack.TabIndex = 8;
            this.btnAdminBack.UseVisualStyleBackColor = false;
            this.btnAdminBack.Click += new System.EventHandler(this.btnAdminBack_Click);
            // 
            // lblSellerSignupEmail
            // 
            this.lblSellerSignupEmail.AutoSize = true;
            this.lblSellerSignupEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblSellerSignupEmail.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerSignupEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSellerSignupEmail.Location = new System.Drawing.Point(28, 63);
            this.lblSellerSignupEmail.Name = "lblSellerSignupEmail";
            this.lblSellerSignupEmail.Size = new System.Drawing.Size(59, 20);
            this.lblSellerSignupEmail.TabIndex = 5;
            this.lblSellerSignupEmail.Text = "Email";
            // 
            // lblSellerSignupName
            // 
            this.lblSellerSignupName.AutoSize = true;
            this.lblSellerSignupName.BackColor = System.Drawing.Color.Transparent;
            this.lblSellerSignupName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerSignupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSellerSignupName.Location = new System.Drawing.Point(26, 37);
            this.lblSellerSignupName.Name = "lblSellerSignupName";
            this.lblSellerSignupName.Size = new System.Drawing.Size(57, 20);
            this.lblSellerSignupName.TabIndex = 4;
            this.lblSellerSignupName.Text = "Name";
            // 
            // txtManagerAddEmail
            // 
            this.txtManagerAddEmail.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerAddEmail.Location = new System.Drawing.Point(143, 63);
            this.txtManagerAddEmail.Multiline = true;
            this.txtManagerAddEmail.Name = "txtManagerAddEmail";
            this.txtManagerAddEmail.Size = new System.Drawing.Size(139, 20);
            this.txtManagerAddEmail.TabIndex = 3;
            // 
            // txtManagerAddName
            // 
            this.txtManagerAddName.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerAddName.Location = new System.Drawing.Point(143, 37);
            this.txtManagerAddName.Multiline = true;
            this.txtManagerAddName.Name = "txtManagerAddName";
            this.txtManagerAddName.Size = new System.Drawing.Size(139, 20);
            this.txtManagerAddName.TabIndex = 2;
            // 
            // AddManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlManagerAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddManager_FormClosing);
            this.pnlManagerAdd.ResumeLayout(false);
            this.pnlManagerAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManagerAdd;
        private System.Windows.Forms.Label lblOptional;
        private System.Windows.Forms.Label lblSellerSignupAddress;
        private System.Windows.Forms.Label lblSellerSignupConfirmPassword;
        private System.Windows.Forms.TextBox txtManagerAddConfirmPassword;
        private System.Windows.Forms.TextBox txtManagerAddAddress;
        private System.Windows.Forms.Label lblSellerSignupPassword;
        private System.Windows.Forms.Label lblSellerSignupPhone;
        private System.Windows.Forms.TextBox txtManagerAddPassword;
        private System.Windows.Forms.TextBox txtManagerAddPhone;
        private System.Windows.Forms.Button btnManagerAddSignup;
        private System.Windows.Forms.Button btnAdminBack;
        private System.Windows.Forms.Label lblSellerSignupEmail;
        private System.Windows.Forms.Label lblSellerSignupName;
        private System.Windows.Forms.TextBox txtManagerAddEmail;
        private System.Windows.Forms.TextBox txtManagerAddName;
    }
}