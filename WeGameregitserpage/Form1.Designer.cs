
namespace WeGameregitserpage
{
    partial class Form1
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
            this.txtphone = new System.Windows.Forms.MaskedTextBox();
            this.txtpassword = new System.Windows.Forms.MaskedTextBox();
            this.txtpstid = new System.Windows.Forms.MaskedTextBox();
            this.txtLname = new System.Windows.Forms.MaskedTextBox();
            this.fname = new System.Windows.Forms.MaskedTextBox();
            this.txtsteamid = new System.Windows.Forms.MaskedTextBox();
            this.txtusername = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.MaskedTextBox();
            this.txtCountry = new System.Windows.Forms.MaskedTextBox();
            this.txtfname = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.SteamID = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.pstid = new System.Windows.Forms.Label();
            this.texthead = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(615, 228);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(250, 22);
            this.txtphone.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(615, 283);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(250, 22);
            this.txtpassword.TabIndex = 2;
            // 
            // txtpstid
            // 
            this.txtpstid.Location = new System.Drawing.Point(615, 340);
            this.txtpstid.Name = "txtpstid";
            this.txtpstid.Size = new System.Drawing.Size(250, 22);
            this.txtpstid.TabIndex = 2;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(615, 121);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(250, 22);
            this.txtLname.TabIndex = 2;
            this.txtLname.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox9_MaskInputRejected);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(164, 121);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(250, 22);
            this.fname.TabIndex = 4;
            // 
            // txtsteamid
            // 
            this.txtsteamid.Location = new System.Drawing.Point(164, 340);
            this.txtsteamid.Name = "txtsteamid";
            this.txtsteamid.Size = new System.Drawing.Size(250, 22);
            this.txtsteamid.TabIndex = 5;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(164, 283);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(250, 22);
            this.txtusername.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(164, 228);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(250, 22);
            this.txtemail.TabIndex = 7;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(164, 170);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(250, 22);
            this.txtCountry.TabIndex = 3;
            // 
            // txtfname
            // 
            this.txtfname.AutoSize = true;
            this.txtfname.Location = new System.Drawing.Point(88, 121);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(74, 17);
            this.txtfname.TabIndex = 8;
            this.txtfname.Text = "First name";
            this.txtfname.Click += new System.EventHandler(this.label1_Click);
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(88, 173);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(57, 17);
            this.country.TabIndex = 8;
            this.country.Text = "Country";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(88, 233);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(42, 17);
            this.email.TabIndex = 8;
            this.email.Text = "Email";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(88, 283);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 17);
            this.username.TabIndex = 8;
            this.username.Text = "Username";
            // 
            // SteamID
            // 
            this.SteamID.AutoSize = true;
            this.SteamID.Location = new System.Drawing.Point(88, 340);
            this.SteamID.Name = "SteamID";
            this.SteamID.Size = new System.Drawing.Size(61, 17);
            this.SteamID.TabIndex = 8;
            this.SteamID.Text = "SteamID";
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Location = new System.Drawing.Point(533, 121);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(70, 17);
            this.Lastname.TabIndex = 8;
            this.Lastname.Text = "Lastname";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(533, 173);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(56, 17);
            this.gender.TabIndex = 8;
            this.gender.Text = "Gender";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(533, 233);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(49, 17);
            this.Phone.TabIndex = 8;
            this.Phone.Text = "Phone";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(533, 283);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 8;
            this.Password.Text = "Password";
            // 
            // pstid
            // 
            this.pstid.AutoSize = true;
            this.pstid.Location = new System.Drawing.Point(533, 340);
            this.pstid.Name = "pstid";
            this.pstid.Size = new System.Drawing.Size(52, 17);
            this.pstid.TabIndex = 8;
            this.pstid.Text = "PST ID";
            // 
            // texthead
            // 
            this.texthead.AutoSize = true;
            this.texthead.Location = new System.Drawing.Point(455, 41);
            this.texthead.Name = "texthead";
            this.texthead.Size = new System.Drawing.Size(234, 17);
            this.texthead.TabIndex = 8;
            this.texthead.Text = "JOIN OUR GROWING COMMUNITY";
            this.texthead.Click += new System.EventHandler(this.label11_Click);
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbgender.Location = new System.Drawing.Point(615, 173);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(250, 24);
            this.cmbgender.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(436, 420);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 33);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 543);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.pstid);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.SteamID);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.username);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.country);
            this.Controls.Add(this.texthead);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.txtsteamid);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtpstid);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtphone);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtphone;
        private System.Windows.Forms.MaskedTextBox txtpassword;
        private System.Windows.Forms.MaskedTextBox txtpstid;
        private System.Windows.Forms.MaskedTextBox txtLname;
        private System.Windows.Forms.MaskedTextBox fname;
        private System.Windows.Forms.MaskedTextBox txtsteamid;
        private System.Windows.Forms.MaskedTextBox txtusername;
        private System.Windows.Forms.MaskedTextBox txtemail;
        private System.Windows.Forms.MaskedTextBox txtCountry;
        private System.Windows.Forms.Label txtfname;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label SteamID;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label pstid;
        private System.Windows.Forms.Label texthead;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Button btnRegister;
    }
}

