namespace ApartmentManagement.Applications
{
    partial class SellerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvalladd = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaddadvertisement = new System.Windows.Forms.Button();
            this.btnremoveadvertisements = new System.Windows.Forms.Button();
            this.txtalladdsearch = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnaddvertisement = new System.Windows.Forms.Button();
            this.dgvconfirmedadd = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvrequestedadd = new System.Windows.Forms.DataGridView();
            this.reqaddid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyercontactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.lblcontract = new System.Windows.Forms.Label();
            this.btnremovebuyerrequest = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnconfirmbuyerrequest = new System.Windows.Forms.Button();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtconfirmedaddsearch = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtrequestedaddsearch = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnchangepassword = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alladdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allreqid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allreqname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allreqcontactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conaddid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalladd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconfirmedadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrequestedadd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dgvalladd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnaddadvertisement);
            this.panel1.Controls.Add(this.btnremoveadvertisements);
            this.panel1.Controls.Add(this.txtalladdsearch);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnaddvertisement);
            this.panel1.Controls.Add(this.dgvconfirmedadd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvrequestedadd);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcontact);
            this.panel1.Controls.Add(this.lblcontract);
            this.panel1.Controls.Add(this.btnremovebuyerrequest);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.btnconfirmbuyerrequest);
            this.panel1.Controls.Add(this.lbladdress);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.txtconfirmedaddsearch);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtrequestedaddsearch);
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
            // dgvalladd
            // 
            this.dgvalladd.AllowUserToAddRows = false;
            this.dgvalladd.AllowUserToDeleteRows = false;
            this.dgvalladd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvalladd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalladd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alladdid,
            this.allreqid,
            this.allreqname,
            this.allreqcontactno});
            this.dgvalladd.Location = new System.Drawing.Point(6, 436);
            this.dgvalladd.Name = "dgvalladd";
            this.dgvalladd.ReadOnly = true;
            this.dgvalladd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvalladd.Size = new System.Drawing.Size(267, 159);
            this.dgvalladd.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 111;
            this.label2.Text = "All Advertisements Information:";
            // 
            // btnaddadvertisement
            // 
            this.btnaddadvertisement.BackColor = System.Drawing.Color.Fuchsia;
            this.btnaddadvertisement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddadvertisement.ForeColor = System.Drawing.Color.White;
            this.btnaddadvertisement.Location = new System.Drawing.Point(9, 597);
            this.btnaddadvertisement.Name = "btnaddadvertisement";
            this.btnaddadvertisement.Size = new System.Drawing.Size(48, 24);
            this.btnaddadvertisement.TabIndex = 112;
            this.btnaddadvertisement.Text = "Add";
            this.btnaddadvertisement.UseVisualStyleBackColor = false;
            this.btnaddadvertisement.Click += new System.EventHandler(this.btnaddadvertisement_Click);
            // 
            // btnremoveadvertisements
            // 
            this.btnremoveadvertisements.BackColor = System.Drawing.Color.Red;
            this.btnremoveadvertisements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremoveadvertisements.ForeColor = System.Drawing.Color.White;
            this.btnremoveadvertisements.Location = new System.Drawing.Point(179, 596);
            this.btnremoveadvertisements.Name = "btnremoveadvertisements";
            this.btnremoveadvertisements.Size = new System.Drawing.Size(94, 24);
            this.btnremoveadvertisements.TabIndex = 113;
            this.btnremoveadvertisements.Text = "Remove";
            this.btnremoveadvertisements.UseVisualStyleBackColor = false;
            // 
            // txtalladdsearch
            // 
            this.txtalladdsearch.BackColor = System.Drawing.Color.Teal;
            this.txtalladdsearch.Location = new System.Drawing.Point(8, 406);
            this.txtalladdsearch.Name = "txtalladdsearch";
            this.txtalladdsearch.Size = new System.Drawing.Size(185, 20);
            this.txtalladdsearch.TabIndex = 114;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(607, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(68, 34);
            this.btnLogout.TabIndex = 110;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnaddvertisement
            // 
            this.btnaddvertisement.BackColor = System.Drawing.Color.Navy;
            this.btnaddvertisement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddvertisement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddvertisement.ForeColor = System.Drawing.Color.White;
            this.btnaddvertisement.Location = new System.Drawing.Point(688, 12);
            this.btnaddvertisement.Name = "btnaddvertisement";
            this.btnaddvertisement.Size = new System.Drawing.Size(184, 34);
            this.btnaddvertisement.TabIndex = 109;
            this.btnaddvertisement.Text = "Show All Advertisements";
            this.btnaddvertisement.UseVisualStyleBackColor = false;
            this.btnaddvertisement.Click += new System.EventHandler(this.btnaddvertisement_Click);
            // 
            // dgvconfirmedadd
            // 
            this.dgvconfirmedadd.AllowUserToAddRows = false;
            this.dgvconfirmedadd.AllowUserToDeleteRows = false;
            this.dgvconfirmedadd.BackgroundColor = System.Drawing.Color.Lime;
            this.dgvconfirmedadd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconfirmedadd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conaddid,
            this.conuid,
            this.conuname,
            this.concontact});
            this.dgvconfirmedadd.Location = new System.Drawing.Point(607, 436);
            this.dgvconfirmedadd.Name = "dgvconfirmedadd";
            this.dgvconfirmedadd.ReadOnly = true;
            this.dgvconfirmedadd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvconfirmedadd.Size = new System.Drawing.Size(267, 159);
            this.dgvconfirmedadd.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(303, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 19);
            this.label3.TabIndex = 96;
            this.label3.Text = "Requested to Confirm:";
            // 
            // dgvrequestedadd
            // 
            this.dgvrequestedadd.AllowUserToAddRows = false;
            this.dgvrequestedadd.AllowUserToDeleteRows = false;
            this.dgvrequestedadd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvrequestedadd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrequestedadd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reqaddid,
            this.buyerid,
            this.buyername,
            this.buyercontactno});
            this.dgvrequestedadd.Location = new System.Drawing.Point(306, 436);
            this.dgvrequestedadd.Name = "dgvrequestedadd";
            this.dgvrequestedadd.ReadOnly = true;
            this.dgvrequestedadd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrequestedadd.Size = new System.Drawing.Size(267, 159);
            this.dgvrequestedadd.TabIndex = 106;
            // 
            // reqaddid
            // 
            this.reqaddid.DataPropertyName = "addid";
            this.reqaddid.HeaderText = "AddvertisementID";
            this.reqaddid.Name = "reqaddid";
            this.reqaddid.ReadOnly = true;
            this.reqaddid.Width = 95;
            // 
            // buyerid
            // 
            this.buyerid.DataPropertyName = "rid";
            this.buyerid.HeaderText = "ID";
            this.buyerid.Name = "buyerid";
            this.buyerid.ReadOnly = true;
            this.buyerid.Width = 25;
            // 
            // buyername
            // 
            this.buyername.DataPropertyName = "name";
            this.buyername.HeaderText = "Name";
            this.buyername.Name = "buyername";
            this.buyername.ReadOnly = true;
            this.buyername.Width = 37;
            // 
            // buyercontactno
            // 
            this.buyercontactno.DataPropertyName = "contactno";
            this.buyercontactno.HeaderText = "Contactno";
            this.buyercontactno.Name = "buyercontactno";
            this.buyercontactno.ReadOnly = true;
            this.buyercontactno.Width = 67;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Navy;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(110, 227);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(124, 40);
            this.btnupdate.TabIndex = 90;
            this.btnupdate.Text = "Edit Information";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(604, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 19);
            this.label4.TabIndex = 97;
            this.label4.Text = "Confirmed Addvertisements:";
            // 
            // txtcontact
            // 
            this.txtcontact.BackColor = System.Drawing.Color.Violet;
            this.txtcontact.Enabled = false;
            this.txtcontact.Location = new System.Drawing.Point(103, 201);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(131, 20);
            this.txtcontact.TabIndex = 89;
            // 
            // lblcontract
            // 
            this.lblcontract.BackColor = System.Drawing.Color.Transparent;
            this.lblcontract.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontract.ForeColor = System.Drawing.Color.Green;
            this.lblcontract.Location = new System.Drawing.Point(3, 202);
            this.lblcontract.Name = "lblcontract";
            this.lblcontract.Size = new System.Drawing.Size(91, 29);
            this.lblcontract.TabIndex = 88;
            this.lblcontract.Text = "Contract No.";
            // 
            // btnremovebuyerrequest
            // 
            this.btnremovebuyerrequest.BackColor = System.Drawing.Color.Red;
            this.btnremovebuyerrequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremovebuyerrequest.ForeColor = System.Drawing.Color.White;
            this.btnremovebuyerrequest.Location = new System.Drawing.Point(512, 596);
            this.btnremovebuyerrequest.Name = "btnremovebuyerrequest";
            this.btnremovebuyerrequest.Size = new System.Drawing.Size(61, 24);
            this.btnremovebuyerrequest.TabIndex = 104;
            this.btnremovebuyerrequest.Text = "Reject";
            this.btnremovebuyerrequest.UseVisualStyleBackColor = false;
            this.btnremovebuyerrequest.Click += new System.EventHandler(this.btnremovebuyerrequest_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.Violet;
            this.txtaddress.Enabled = false;
            this.txtaddress.Location = new System.Drawing.Point(103, 169);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(131, 20);
            this.txtaddress.TabIndex = 87;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.Violet;
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(103, 137);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(131, 20);
            this.txtemail.TabIndex = 86;
            // 
            // btnconfirmbuyerrequest
            // 
            this.btnconfirmbuyerrequest.BackColor = System.Drawing.Color.Fuchsia;
            this.btnconfirmbuyerrequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmbuyerrequest.ForeColor = System.Drawing.Color.White;
            this.btnconfirmbuyerrequest.Location = new System.Drawing.Point(307, 596);
            this.btnconfirmbuyerrequest.Name = "btnconfirmbuyerrequest";
            this.btnconfirmbuyerrequest.Size = new System.Drawing.Size(69, 24);
            this.btnconfirmbuyerrequest.TabIndex = 103;
            this.btnconfirmbuyerrequest.Text = "Confirm";
            this.btnconfirmbuyerrequest.UseVisualStyleBackColor = false;
            this.btnconfirmbuyerrequest.Click += new System.EventHandler(this.btnconfirmbuyerrequest_Click);
            // 
            // lbladdress
            // 
            this.lbladdress.BackColor = System.Drawing.Color.Transparent;
            this.lbladdress.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.Color.Green;
            this.lbladdress.Location = new System.Drawing.Point(6, 173);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(91, 29);
            this.lbladdress.TabIndex = 85;
            this.lbladdress.Text = "Address:";
            // 
            // lblemail
            // 
            this.lblemail.BackColor = System.Drawing.Color.Transparent;
            this.lblemail.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Green;
            this.lblemail.Location = new System.Drawing.Point(7, 138);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(91, 19);
            this.lblemail.TabIndex = 84;
            this.lblemail.Text = "Email:";
            // 
            // txtconfirmedaddsearch
            // 
            this.txtconfirmedaddsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtconfirmedaddsearch.Location = new System.Drawing.Point(607, 410);
            this.txtconfirmedaddsearch.Name = "txtconfirmedaddsearch";
            this.txtconfirmedaddsearch.Size = new System.Drawing.Size(185, 20);
            this.txtconfirmedaddsearch.TabIndex = 102;
            this.txtconfirmedaddsearch.TextChanged += new System.EventHandler(this.txtconfirmedaddsearch_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.Violet;
            this.txtpass.Enabled = false;
            this.txtpass.Location = new System.Drawing.Point(103, 67);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(131, 20);
            this.txtpass.TabIndex = 83;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtrequestedaddsearch
            // 
            this.txtrequestedaddsearch.BackColor = System.Drawing.Color.Purple;
            this.txtrequestedaddsearch.Location = new System.Drawing.Point(306, 406);
            this.txtrequestedaddsearch.Name = "txtrequestedaddsearch";
            this.txtrequestedaddsearch.Size = new System.Drawing.Size(185, 20);
            this.txtrequestedaddsearch.TabIndex = 101;
            this.txtrequestedaddsearch.TextChanged += new System.EventHandler(this.txtrequestedaddsearch_TextChanged);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Violet;
            this.txtname.Location = new System.Drawing.Point(103, 35);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(131, 20);
            this.txtname.TabIndex = 82;
            // 
            // btnchangepassword
            // 
            this.btnchangepassword.BackColor = System.Drawing.Color.Navy;
            this.btnchangepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchangepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangepassword.ForeColor = System.Drawing.Color.White;
            this.btnchangepassword.Location = new System.Drawing.Point(123, 93);
            this.btnchangepassword.Name = "btnchangepassword";
            this.btnchangepassword.Size = new System.Drawing.Size(111, 32);
            this.btnchangepassword.TabIndex = 81;
            this.btnchangepassword.Text = "Edit Password";
            this.btnchangepassword.UseVisualStyleBackColor = false;
            this.btnchangepassword.Click += new System.EventHandler(this.btnchangepassword_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Green;
            this.lblpassword.Location = new System.Drawing.Point(6, 65);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(91, 29);
            this.lblpassword.TabIndex = 80;
            this.lblpassword.Text = "Password: ";
            // 
            // lblname
            // 
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Green;
            this.lblname.Location = new System.Drawing.Point(6, 36);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(91, 29);
            this.lblname.TabIndex = 79;
            this.lblname.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 29);
            this.label1.TabIndex = 78;
            this.label1.Text = "Yours Profile Seller :";
            // 
            // alladdid
            // 
            this.alladdid.DataPropertyName = "addid";
            this.alladdid.HeaderText = "AddvertisementID";
            this.alladdid.Name = "alladdid";
            this.alladdid.ReadOnly = true;
            this.alladdid.Width = 95;
            // 
            // allreqid
            // 
            this.allreqid.DataPropertyName = "rid";
            this.allreqid.FillWeight = 73.52941F;
            this.allreqid.HeaderText = "ID";
            this.allreqid.Name = "allreqid";
            this.allreqid.ReadOnly = true;
            this.allreqid.Width = 25;
            // 
            // allreqname
            // 
            this.allreqname.DataPropertyName = "name";
            this.allreqname.FillWeight = 113.2353F;
            this.allreqname.HeaderText = "Name";
            this.allreqname.Name = "allreqname";
            this.allreqname.ReadOnly = true;
            this.allreqname.Width = 37;
            // 
            // allreqcontactno
            // 
            this.allreqcontactno.DataPropertyName = "contactno";
            this.allreqcontactno.FillWeight = 113.2353F;
            this.allreqcontactno.HeaderText = "Contactno";
            this.allreqcontactno.Name = "allreqcontactno";
            this.allreqcontactno.ReadOnly = true;
            this.allreqcontactno.Width = 67;
            // 
            // conaddid
            // 
            this.conaddid.DataPropertyName = "addid";
            this.conaddid.HeaderText = "AddvertisementID";
            this.conaddid.Name = "conaddid";
            this.conaddid.ReadOnly = true;
            this.conaddid.Width = 95;
            // 
            // conuid
            // 
            this.conuid.DataPropertyName = "rid";
            this.conuid.HeaderText = "ID";
            this.conuid.Name = "conuid";
            this.conuid.ReadOnly = true;
            this.conuid.Width = 25;
            // 
            // conuname
            // 
            this.conuname.DataPropertyName = "name";
            this.conuname.HeaderText = "Name";
            this.conuname.Name = "conuname";
            this.conuname.ReadOnly = true;
            this.conuname.Width = 37;
            // 
            // concontact
            // 
            this.concontact.DataPropertyName = "contactno";
            this.concontact.HeaderText = "Contactno";
            this.concontact.Name = "concontact";
            this.concontact.ReadOnly = true;
            this.concontact.Width = 67;
            // 
            // SellerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 627);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellerProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seller Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellerProfile_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalladd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconfirmedadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrequestedadd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvconfirmedadd;
        private System.Windows.Forms.DataGridView dgvrequestedadd;
        private System.Windows.Forms.Button btnremovebuyerrequest;
        private System.Windows.Forms.Button btnconfirmbuyerrequest;
        private System.Windows.Forms.TextBox txtconfirmedaddsearch;
        private System.Windows.Forms.TextBox txtrequestedaddsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.DataGridView dgvalladd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnaddadvertisement;
        private System.Windows.Forms.Button btnremoveadvertisements;
        private System.Windows.Forms.TextBox txtalladdsearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnaddvertisement;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqaddid;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyername;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyercontactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn alladdid;
        private System.Windows.Forms.DataGridViewTextBoxColumn allreqid;
        private System.Windows.Forms.DataGridViewTextBoxColumn allreqname;
        private System.Windows.Forms.DataGridViewTextBoxColumn allreqcontactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn conaddid;
        private System.Windows.Forms.DataGridViewTextBoxColumn conuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn conuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn concontact;
    }
}