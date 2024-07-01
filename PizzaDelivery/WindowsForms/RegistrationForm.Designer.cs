namespace PizzaDelivery.WindowsForms
{
    partial class RegistrationForm
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(428, 188);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(135, 23);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(22, 36);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 77);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(24, 120);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 3;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(24, 157);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(86, 13);
            this.labelDateOfBirth.TabIndex = 4;
            this.labelDateOfBirth.Text = "Дата рождения";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(21, 205);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(128, 33);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(200, 20);
            this.Surname.TabIndex = 6;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(128, 74);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(200, 20);
            this.Name.TabIndex = 7;
            // 
            // Patronymic
            // 
            this.Patronymic.Location = new System.Drawing.Point(128, 113);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(200, 20);
            this.Patronymic.TabIndex = 8;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(128, 202);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(200, 20);
            this.Email.TabIndex = 10;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(24, 251);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 11;
            this.labelLogin.Text = "Login";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(128, 248);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(200, 20);
            this.Login.TabIndex = 12;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(390, 36);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Пароль";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(492, 33);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(155, 20);
            this.Password.TabIndex = 14;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(390, 88);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(93, 13);
            this.labelPhoneNumber.TabIndex = 15;
            this.labelPhoneNumber.Text = "Номер телефона";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(492, 85);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(155, 20);
            this.PhoneNumber.TabIndex = 16;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(128, 157);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirth.TabIndex = 17;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            //this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
    }
}