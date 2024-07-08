namespace PizzaDelivery.WindowsForms
{
    partial class Registration_Form
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.listBoxAddressesFromDaData = new System.Windows.Forms.ListBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(15, 303);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 42;
            this.buttonBack.Text = "Вернуться";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listBoxAddressesFromDaData
            // 
            this.listBoxAddressesFromDaData.FormattingEnabled = true;
            this.listBoxAddressesFromDaData.Location = new System.Drawing.Point(118, 205);
            this.listBoxAddressesFromDaData.Name = "listBoxAddressesFromDaData";
            this.listBoxAddressesFromDaData.Size = new System.Drawing.Size(251, 134);
            this.listBoxAddressesFromDaData.TabIndex = 41;
            this.listBoxAddressesFromDaData.SelectedIndexChanged += new System.EventHandler(this.listBoxAddressesFromDaData_SelectedIndexChanged);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(118, 188);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(251, 20);
            this.Address.TabIndex = 40;
            this.Address.TextChanged += new System.EventHandler(this.Address_TextChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(15, 191);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(38, 13);
            this.labelAddress.TabIndex = 39;
            this.labelAddress.Text = "Адрес";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(118, 147);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(251, 20);
            this.DateOfBirth.TabIndex = 38;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(495, 147);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(251, 20);
            this.PhoneNumber.TabIndex = 37;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(396, 147);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(93, 13);
            this.labelPhoneNumber.TabIndex = 36;
            this.labelPhoneNumber.Text = "Номер телефона";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(495, 100);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(251, 20);
            this.Password.TabIndex = 35;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(396, 106);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 34;
            this.labelPassword.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(495, 60);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(251, 20);
            this.Login.TabIndex = 33;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(395, 60);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 32;
            this.labelLogin.Text = "Login";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(495, 19);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(251, 20);
            this.Email.TabIndex = 31;
            // 
            // Patronymic
            // 
            this.Patronymic.Location = new System.Drawing.Point(118, 100);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(251, 20);
            this.Patronymic.TabIndex = 30;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(118, 60);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(251, 20);
            this.Name.TabIndex = 29;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(118, 20);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(251, 20);
            this.Surname.TabIndex = 28;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(396, 23);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 27;
            this.labelEmail.Text = "Email";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(12, 150);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(86, 13);
            this.labelDateOfBirth.TabIndex = 26;
            this.labelDateOfBirth.Text = "Дата рождения";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(14, 103);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 25;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 24;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 19);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 23;
            this.labelSurname.Text = "Фамилия";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(519, 267);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(135, 23);
            this.buttonRegister.TabIndex = 22;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxAddressesFromDaData);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.buttonRegister);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBoxAddressesFromDaData;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Patronymic;
        private new System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button buttonRegister;
    }
}