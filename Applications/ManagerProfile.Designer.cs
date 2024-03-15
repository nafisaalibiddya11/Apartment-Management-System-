namespace ApartmentManagement.Applications
{
    partial class ManagerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnremoveseller = new System.Windows.Forms.Button();
            this.dgvseller = new System.Windows.Forms.DataGridView();
            this.sellerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellercontactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnremovebuyer = new System.Windows.Forms.Button();
            this.dgvbuyer = new System.Windows.Forms.DataGridView();
            this.buyerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyercontactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsellersearch = new System.Windows.Forms.TextBox();
            this.txtbuyersearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.lblcontract = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnchangepassword = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuyer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnremoveseller);
            this.panel1.Controls.Add(this.dgvseller);
            this.panel1.Controls.Add(this.btnremovebuyer);
            this.panel1.Controls.Add(this.dgvbuyer);
            this.panel1.Controls.Add(this.txtsellersearch);
            this.panel1.Controls.Add(this.txtbuyersearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.txtcontact);
            this.panel1.Controls.Add(this.lblcontract);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.lbladdress);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.btnchangepassword);
            this.panel1.Controls.Add(this.lblpassword);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 627);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(508, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 34);
            this.btnLogout.TabIndex = 84;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(671, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 34);
            this.button4.TabIndex = 83;
            this.button4.Text = "Show All Advertisements";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnremoveseller
            // 
            this.btnremoveseller.BackColor = System.Drawing.Color.Red;
            this.btnremoveseller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremoveseller.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveseller.ForeColor = System.Drawing.Color.White;
            this.btnremoveseller.Location = new System.Drawing.Point(267, 585);
            this.btnremoveseller.Name = "btnremoveseller";
            this.btnremoveseller.Size = new System.Drawing.Size(108, 30);
            this.btnremoveseller.TabIndex = 81;
            this.btnremoveseller.Text = "Remove";
            this.btnremoveseller.UseVisualStyleBackColor = false;
            this.btnremoveseller.Click += new System.EventHandler(this.btnremoveseller_Click);
            // 
            // dgvseller
            // 
            this.dgvseller.AllowUserToAddRows = false;
            this.dgvseller.AllowUserToDeleteRows = false;
            this.dgvseller.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvseller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvseller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellerid,
            this.sellername,
            this.sellercontactno});
            this.dgvseller.Location = new System.Drawing.Point(12, 424);
            this.dgvseller.Name = "dgvseller";
            this.dgvseller.ReadOnly = true;
            this.dgvseller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvseller.Size = new System.Drawing.Size(363, 159);
            this.dgvseller.TabIndex = 80;
            // 
            // sellerid
            // 
            this.sellerid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellerid.DataPropertyName = "id";
            this.sellerid.HeaderText = "ID";
            this.sellerid.Name = "sellerid";
            this.sellerid.ReadOnly = true;
            // 
            // sellername
            // 
            this.sellername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellername.DataPropertyName = "name";
            this.sellername.HeaderText = "Name";
            this.sellername.Name = "sellername";
            this.sellername.ReadOnly = true;
            // 
            // sellercontactno
            // 
            this.sellercontactno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellercontactno.DataPropertyName = "contactno";
            this.sellercontactno.HeaderText = "ContactNo";
            this.sellercontactno.Name = "sellercontactno";
            this.sellercontactno.ReadOnly = true;
            // 
            // btnremovebuyer
            // 
            this.btnremovebuyer.BackColor = System.Drawing.Color.Red;
            this.btnremovebuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremovebuyer.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremovebuyer.ForeColor = System.Drawing.Color.White;
            this.btnremovebuyer.Location = new System.Drawing.Point(765, 585);
            this.btnremovebuyer.Name = "btnremovebuyer";
            this.btnremovebuyer.Size = new System.Drawing.Size(106, 30);
            this.btnremovebuyer.TabIndex = 79;
            this.btnremovebuyer.Text = "Remove";
            this.btnremovebuyer.UseVisualStyleBackColor = false;
            this.btnremovebuyer.Click += new System.EventHandler(this.btnremovebuyer_Click);
            // 
            // dgvbuyer
            // 
            this.dgvbuyer.AllowUserToAddRows = false;
            this.dgvbuyer.AllowUserToDeleteRows = false;
            this.dgvbuyer.BackgroundColor = System.Drawing.Color.Orchid;
            this.dgvbuyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuyer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyerid,
            this.buyername,
            this.buyercontactno});
            this.dgvbuyer.Location = new System.Drawing.Point(508, 422);
            this.dgvbuyer.Name = "dgvbuyer";
            this.dgvbuyer.ReadOnly = true;
            this.dgvbuyer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbuyer.Size = new System.Drawing.Size(363, 159);
            this.dgvbuyer.TabIndex = 78;
            // 
            // buyerid
            // 
            this.buyerid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buyerid.DataPropertyName = "id";
            this.buyerid.HeaderText = "ID";
            this.buyerid.Name = "buyerid";
            this.buyerid.ReadOnly = true;
            // 
            // buyername
            // 
            this.buyername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buyername.DataPropertyName = "name";
            this.buyername.HeaderText = "Name";
            this.buyername.Name = "buyername";
            this.buyername.ReadOnly = true;
            // 
            // buyercontactno
            // 
            this.buyercontactno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buyercontactno.DataPropertyName = "contactno";
            this.buyercontactno.HeaderText = "Contactno";
            this.buyercontactno.Name = "buyercontactno";
            this.buyercontactno.ReadOnly = true;
            // 
            // txtsellersearch
            // 
            this.txtsellersearch.BackColor = System.Drawing.Color.Aqua;
            this.txtsellersearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtsellersearch.Location = new System.Drawing.Point(190, 397);
            this.txtsellersearch.Name = "txtsellersearch";
            this.txtsellersearch.Size = new System.Drawing.Size(185, 20);
            this.txtsellersearch.TabIndex = 74;
            this.txtsellersearch.TextChanged += new System.EventHandler(this.txtsellersearch_TextChanged);
            // 
            // txtbuyersearch
            // 
            this.txtbuyersearch.BackColor = System.Drawing.Color.Orchid;
            this.txtbuyersearch.Location = new System.Drawing.Point(681, 397);
            this.txtbuyersearch.Multiline = true;
            this.txtbuyersearch.Name = "txtbuyersearch";
            this.txtbuyersearch.Size = new System.Drawing.Size(185, 20);
            this.txtbuyersearch.TabIndex = 73;
            this.txtbuyersearch.TextChanged += new System.EventHandler(this.txtbuyersearch_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Seller Information:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(505, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 69;
            this.label2.Text = "Buyer Information:";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(88, 234);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(136, 36);
            this.btnupdate.TabIndex = 68;
            this.btnupdate.Text = "Edit Information";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtcontact
            // 
            this.txtcontact.BackColor = System.Drawing.Color.Coral;
            this.txtcontact.Enabled = false;
            this.txtcontact.Location = new System.Drawing.Point(101, 198);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(123, 20);
            this.txtcontact.TabIndex = 66;
            // 
            // lblcontract
            // 
            this.lblcontract.BackColor = System.Drawing.Color.Transparent;
            this.lblcontract.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblcontract.Location = new System.Drawing.Point(4, 202);
            this.lblcontract.Name = "lblcontract";
            this.lblcontract.Size = new System.Drawing.Size(91, 29);
            this.lblcontract.TabIndex = 65;
            this.lblcontract.Text = "Contract No.";
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.Coral;
            this.txtaddress.Enabled = false;
            this.txtaddress.Location = new System.Drawing.Point(101, 166);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(123, 20);
            this.txtaddress.TabIndex = 64;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.Coral;
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(101, 134);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(123, 20);
            this.txtemail.TabIndex = 63;
            // 
            // lbladdress
            // 
            this.lbladdress.BackColor = System.Drawing.Color.Transparent;
            this.lbladdress.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbladdress.Location = new System.Drawing.Point(4, 171);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(91, 29);
            this.lbladdress.TabIndex = 62;
            this.lbladdress.Text = "Address:";
            // 
            // lblemail
            // 
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblemail.Location = new System.Drawing.Point(4, 141);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(91, 29);
            this.lblemail.TabIndex = 61;
            this.lblemail.Text = "Email:";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Coral;
            this.txtpass.Enabled = false;
            this.txtpass.Location = new System.Drawing.Point(101, 64);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(123, 20);
            this.txtpass.TabIndex = 60;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Coral;
            this.txtname.Location = new System.Drawing.Point(101, 32);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(123, 20);
            this.txtname.TabIndex = 59;
            // 
            // btnchangepassword
            // 
            this.btnchangepassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnchangepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchangepassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangepassword.ForeColor = System.Drawing.Color.White;
            this.btnchangepassword.Location = new System.Drawing.Point(101, 90);
            this.btnchangepassword.Name = "btnchangepassword";
            this.btnchangepassword.Size = new System.Drawing.Size(123, 32);
            this.btnchangepassword.TabIndex = 58;
            this.btnchangepassword.Text = "Edit Password";
            this.btnchangepassword.UseVisualStyleBackColor = false;
            this.btnchangepassword.Click += new System.EventHandler(this.btnchangepassword_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblpassword.Location = new System.Drawing.Point(4, 67);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(91, 29);
            this.lblpassword.TabIndex = 57;
            this.lblpassword.Text = "Password: ";
            // 
            // lblname
            // 
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblname.Location = new System.Drawing.Point(4, 38);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(91, 29);
            this.lblname.TabIndex = 56;
            this.lblname.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Yours Profile Manager :";
            // 
            // ManagerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 627);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerProfile_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvseller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuyer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnremoveseller;
        private System.Windows.Forms.DataGridView dgvseller;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellername;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellercontactno;
        private System.Windows.Forms.Button btnremovebuyer;
        private System.Windows.Forms.DataGridView dgvbuyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyername;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyercontactno;
        private System.Windows.Forms.TextBox txtsellersearch;
        private System.Windows.Forms.TextBox txtbuyersearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label lblcontract;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnchangepassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button4;
    }
}