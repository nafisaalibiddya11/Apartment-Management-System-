namespace ApartmentManagement.Applications
{
    partial class BuyerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyerProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvbuyercofirmed = new System.Windows.Forms.DataGridView();
            this.btnremoverequest = new System.Windows.Forms.Button();
            this.dgvbuyerreq = new System.Windows.Forms.DataGridView();
            this.txtconfirmedsearch = new System.Windows.Forms.TextBox();
            this.txtrequestedsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowAddvertisement = new System.Windows.Forms.Button();
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
            this.addid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyercontactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addidc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellercontactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuyercofirmed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuyerreq)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.dgvbuyercofirmed);
            this.panel1.Controls.Add(this.btnremoverequest);
            this.panel1.Controls.Add(this.dgvbuyerreq);
            this.panel1.Controls.Add(this.txtconfirmedsearch);
            this.panel1.Controls.Add(this.txtrequestedsearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnShowAddvertisement);
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
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(321, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(73, 34);
            this.btnLogout.TabIndex = 101;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvbuyercofirmed
            // 
            this.dgvbuyercofirmed.AllowUserToAddRows = false;
            this.dgvbuyercofirmed.AllowUserToDeleteRows = false;
            this.dgvbuyercofirmed.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvbuyercofirmed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuyercofirmed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addidc,
            this.sellerid,
            this.sellername,
            this.sellercontactno});
            this.dgvbuyercofirmed.Location = new System.Drawing.Point(31, 422);
            this.dgvbuyercofirmed.Name = "dgvbuyercofirmed";
            this.dgvbuyercofirmed.ReadOnly = true;
            this.dgvbuyercofirmed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbuyercofirmed.Size = new System.Drawing.Size(304, 159);
            this.dgvbuyercofirmed.TabIndex = 100;
            // 
            // btnremoverequest
            // 
            this.btnremoverequest.BackColor = System.Drawing.Color.Purple;
            this.btnremoverequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremoverequest.ForeColor = System.Drawing.Color.White;
            this.btnremoverequest.Location = new System.Drawing.Point(554, 586);
            this.btnremoverequest.Name = "btnremoverequest";
            this.btnremoverequest.Size = new System.Drawing.Size(174, 29);
            this.btnremoverequest.TabIndex = 99;
            this.btnremoverequest.Text = "Delete Request";
            this.btnremoverequest.UseVisualStyleBackColor = false;
            this.btnremoverequest.Click += new System.EventHandler(this.btnremoverequest_Click);
            // 
            // dgvbuyerreq
            // 
            this.dgvbuyerreq.AllowUserToAddRows = false;
            this.dgvbuyerreq.AllowUserToDeleteRows = false;
            this.dgvbuyerreq.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvbuyerreq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuyerreq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addid,
            this.buyerid,
            this.buyername,
            this.buyercontactno});
            this.dgvbuyerreq.Location = new System.Drawing.Point(554, 422);
            this.dgvbuyerreq.Name = "dgvbuyerreq";
            this.dgvbuyerreq.ReadOnly = true;
            this.dgvbuyerreq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbuyerreq.Size = new System.Drawing.Size(304, 159);
            this.dgvbuyerreq.TabIndex = 98;
            // 
            // txtconfirmedsearch
            // 
            this.txtconfirmedsearch.BackColor = System.Drawing.Color.Orange;
            this.txtconfirmedsearch.Location = new System.Drawing.Point(150, 400);
            this.txtconfirmedsearch.Name = "txtconfirmedsearch";
            this.txtconfirmedsearch.Size = new System.Drawing.Size(185, 20);
            this.txtconfirmedsearch.TabIndex = 96;
            this.txtconfirmedsearch.TextChanged += new System.EventHandler(this.txtconfirmedsearch_TextChanged);
            // 
            // txtrequestedsearch
            // 
            this.txtrequestedsearch.BackColor = System.Drawing.Color.Orange;
            this.txtrequestedsearch.Location = new System.Drawing.Point(720, 399);
            this.txtrequestedsearch.Name = "txtrequestedsearch";
            this.txtrequestedsearch.Size = new System.Drawing.Size(138, 20);
            this.txtrequestedsearch.TabIndex = 95;
            this.txtrequestedsearch.TextChanged += new System.EventHandler(this.txtrequestedsearch_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(28, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 93;
            this.label3.Text = "Confirmed:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(551, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 22);
            this.label2.TabIndex = 92;
            this.label2.Text = "Requested by You :";
            // 
            // btnShowAddvertisement
            // 
            this.btnShowAddvertisement.BackColor = System.Drawing.Color.Purple;
            this.btnShowAddvertisement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAddvertisement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAddvertisement.ForeColor = System.Drawing.Color.White;
            this.btnShowAddvertisement.Location = new System.Drawing.Point(431, 10);
            this.btnShowAddvertisement.Name = "btnShowAddvertisement";
            this.btnShowAddvertisement.Size = new System.Drawing.Size(182, 34);
            this.btnShowAddvertisement.TabIndex = 91;
            this.btnShowAddvertisement.Text = "Show All Advertisements";
            this.btnShowAddvertisement.UseVisualStyleBackColor = false;
            this.btnShowAddvertisement.Click += new System.EventHandler(this.btnShowAddvertisement_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Purple;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(12, 195);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(118, 40);
            this.btnupdate.TabIndex = 90;
            this.btnupdate.Text = "Edit Information";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtcontact
            // 
            this.txtcontact.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtcontact.Enabled = false;
            this.txtcontact.Location = new System.Drawing.Point(125, 171);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(112, 20);
            this.txtcontact.TabIndex = 89;
            // 
            // lblcontract
            // 
            this.lblcontract.BackColor = System.Drawing.Color.Transparent;
            this.lblcontract.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontract.ForeColor = System.Drawing.Color.Purple;
            this.lblcontract.Location = new System.Drawing.Point(12, 169);
            this.lblcontract.Name = "lblcontract";
            this.lblcontract.Size = new System.Drawing.Size(116, 29);
            this.lblcontract.TabIndex = 88;
            this.lblcontract.Text = "Contract No.";
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtaddress.Enabled = false;
            this.txtaddress.Location = new System.Drawing.Point(125, 148);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(112, 20);
            this.txtaddress.TabIndex = 87;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(125, 120);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(112, 20);
            this.txtemail.TabIndex = 86;
            // 
            // lbladdress
            // 
            this.lbladdress.BackColor = System.Drawing.Color.Transparent;
            this.lbladdress.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.Color.Purple;
            this.lbladdress.Location = new System.Drawing.Point(12, 146);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(91, 29);
            this.lbladdress.TabIndex = 85;
            this.lbladdress.Text = "Address:";
            // 
            // lblemail
            // 
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Purple;
            this.lblemail.Location = new System.Drawing.Point(12, 117);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(91, 29);
            this.lblemail.TabIndex = 84;
            this.lblemail.Text = "Email:";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtpass.Enabled = false;
            this.txtpass.Location = new System.Drawing.Point(110, 57);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(112, 22);
            this.txtpass.TabIndex = 83;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtname.Location = new System.Drawing.Point(110, 28);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(112, 22);
            this.txtname.TabIndex = 82;
            // 
            // btnchangepassword
            // 
            this.btnchangepassword.BackColor = System.Drawing.Color.Purple;
            this.btnchangepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchangepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangepassword.ForeColor = System.Drawing.Color.White;
            this.btnchangepassword.Location = new System.Drawing.Point(31, 82);
            this.btnchangepassword.Name = "btnchangepassword";
            this.btnchangepassword.Size = new System.Drawing.Size(112, 32);
            this.btnchangepassword.TabIndex = 81;
            this.btnchangepassword.Text = "Edit Password";
            this.btnchangepassword.UseVisualStyleBackColor = false;
            this.btnchangepassword.Click += new System.EventHandler(this.btnchangepassword_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Purple;
            this.lblpassword.Location = new System.Drawing.Point(12, 55);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(100, 29);
            this.lblpassword.TabIndex = 80;
            this.lblpassword.Text = "Password: ";
            // 
            // lblname
            // 
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Purple;
            this.lblname.Location = new System.Drawing.Point(12, 26);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(62, 29);
            this.lblname.TabIndex = 79;
            this.lblname.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 26);
            this.label1.TabIndex = 78;
            this.label1.Text = "Yours Profile Buyer:";
            // 
            // addid
            // 
            this.addid.DataPropertyName = "addid";
            this.addid.HeaderText = "AddvertisementID";
            this.addid.Name = "addid";
            this.addid.ReadOnly = true;
            // 
            // buyerid
            // 
            this.buyerid.DataPropertyName = "id";
            this.buyerid.HeaderText = "ID";
            this.buyerid.Name = "buyerid";
            this.buyerid.ReadOnly = true;
            this.buyerid.Width = 27;
            // 
            // buyername
            // 
            this.buyername.DataPropertyName = "name";
            this.buyername.FillWeight = 83.33334F;
            this.buyername.HeaderText = "Name";
            this.buyername.Name = "buyername";
            this.buyername.ReadOnly = true;
            this.buyername.Width = 38;
            // 
            // buyercontactno
            // 
            this.buyercontactno.DataPropertyName = "contactno";
            this.buyercontactno.HeaderText = "Contactno";
            this.buyercontactno.Name = "buyercontactno";
            this.buyercontactno.ReadOnly = true;
            this.buyercontactno.Width = 95;
            // 
            // addidc
            // 
            this.addidc.DataPropertyName = "addid";
            this.addidc.HeaderText = "AddvertisementID";
            this.addidc.Name = "addidc";
            this.addidc.ReadOnly = true;
            // 
            // sellerid
            // 
            this.sellerid.DataPropertyName = "id";
            this.sellerid.FillWeight = 77.31959F;
            this.sellerid.HeaderText = "ID";
            this.sellerid.Name = "sellerid";
            this.sellerid.ReadOnly = true;
            this.sellerid.Width = 27;
            // 
            // sellername
            // 
            this.sellername.DataPropertyName = "name";
            this.sellername.FillWeight = 111.3402F;
            this.sellername.HeaderText = "Name";
            this.sellername.Name = "sellername";
            this.sellername.ReadOnly = true;
            this.sellername.Width = 38;
            // 
            // sellercontactno
            // 
            this.sellercontactno.DataPropertyName = "contactno";
            this.sellercontactno.FillWeight = 111.3402F;
            this.sellercontactno.HeaderText = "ContactNo";
            this.sellercontactno.Name = "sellercontactno";
            this.sellercontactno.ReadOnly = true;
            this.sellercontactno.Width = 95;
            // 
            // BuyerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(884, 627);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuyerProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buyer Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuyerProfile_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuyercofirmed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuyerreq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvbuyercofirmed;
        private System.Windows.Forms.Button btnremoverequest;
        private System.Windows.Forms.DataGridView dgvbuyerreq;
        private System.Windows.Forms.TextBox txtconfirmedsearch;
        private System.Windows.Forms.TextBox txtrequestedsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowAddvertisement;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn addidc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellername;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellercontactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn addid;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyername;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyercontactno;
    }
}