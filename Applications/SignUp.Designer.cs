namespace ApartmentManagement.Applications
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.btnSeller = new System.Windows.Forms.Button();
            this.btnBuyer = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeller
            // 
            this.btnSeller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeller.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeller.ForeColor = System.Drawing.Color.Gold;
            this.btnSeller.Image = ((System.Drawing.Image)(resources.GetObject("btnSeller.Image")));
            this.btnSeller.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSeller.Location = new System.Drawing.Point(455, 147);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(100, 39);
            this.btnSeller.TabIndex = 6;
            this.btnSeller.Text = "Seller";
            this.btnSeller.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeller.UseVisualStyleBackColor = false;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // btnBuyer
            // 
            this.btnBuyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBuyer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuyer.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyer.ForeColor = System.Drawing.Color.Gold;
            this.btnBuyer.Image = ((System.Drawing.Image)(resources.GetObject("btnBuyer.Image")));
            this.btnBuyer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuyer.Location = new System.Drawing.Point(455, 192);
            this.btnBuyer.Name = "btnBuyer";
            this.btnBuyer.Size = new System.Drawing.Size(100, 39);
            this.btnBuyer.TabIndex = 5;
            this.btnBuyer.Text = "Buyer";
            this.btnBuyer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuyer.UseVisualStyleBackColor = false;
            this.btnBuyer.Click += new System.EventHandler(this.btnBuyer_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(52, 364);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 46);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(455, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSellerBack_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSeller);
            this.Controls.Add(this.btnBuyer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeller;
        private System.Windows.Forms.Button btnBuyer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
    }
}