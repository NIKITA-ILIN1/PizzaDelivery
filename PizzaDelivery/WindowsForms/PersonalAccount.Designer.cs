namespace PizzaDelivery.WindowsForms
{
    partial class PersonalAccount
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.PersonalData = new System.Windows.Forms.TabPage();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.MakeOrder = new System.Windows.Forms.TabPage();
            this.Menu = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.PersonalData.SuspendLayout();
            this.MakeOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 415);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Вернуться";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.PersonalData);
            this.tabControl.Controls.Add(this.MakeOrder);
            this.tabControl.Controls.Add(this.Menu);
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(794, 407);
            this.tabControl.TabIndex = 1;
            // 
            // PersonalData
            // 
            this.PersonalData.Controls.Add(this.DateOfBirth);
            this.PersonalData.Controls.Add(this.PhoneNumber);
            this.PersonalData.Controls.Add(this.labelPhoneNumber);
            this.PersonalData.Controls.Add(this.labelLogin);
            this.PersonalData.Controls.Add(this.labelEmail);
            this.PersonalData.Controls.Add(this.labelDateOfBirth);
            this.PersonalData.Controls.Add(this.labelPatronymic);
            this.PersonalData.Controls.Add(this.labelName);
            this.PersonalData.Controls.Add(this.labelSurname);
            this.PersonalData.Controls.Add(this.Login);
            this.PersonalData.Controls.Add(this.Email);
            this.PersonalData.Controls.Add(this.Patronymic);
            this.PersonalData.Controls.Add(this.Name);
            this.PersonalData.Controls.Add(this.Surname);
            this.PersonalData.Location = new System.Drawing.Point(4, 22);
            this.PersonalData.Name = "PersonalData";
            this.PersonalData.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalData.Size = new System.Drawing.Size(786, 381);
            this.PersonalData.TabIndex = 0;
            this.PersonalData.Text = "Личные данные";
            this.PersonalData.UseVisualStyleBackColor = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(115, 150);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirth.TabIndex = 14;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(115, 288);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.PhoneNumber.TabIndex = 13;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(16, 288);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(93, 13);
            this.labelPhoneNumber.TabIndex = 12;
            this.labelPhoneNumber.Text = "Номер телефона";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(16, 247);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 11;
            this.labelLogin.Text = "Login";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(13, 198);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(11, 157);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(86, 13);
            this.labelDateOfBirth.TabIndex = 9;
            this.labelDateOfBirth.Text = "Дата рождения";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(11, 109);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 8;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(5, 24);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Фамилия";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(115, 240);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(200, 20);
            this.Login.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(115, 191);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(200, 20);
            this.Email.TabIndex = 4;
            // 
            // Patronymic
            // 
            this.Patronymic.Location = new System.Drawing.Point(115, 109);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(200, 20);
            this.Patronymic.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(115, 66);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(200, 20);
            this.Name.TabIndex = 1;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(115, 21);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(200, 20);
            this.Surname.TabIndex = 0;
            // 
            // MakeOrder
            // 
            this.MakeOrder.Controls.Add(this.button1);
            this.MakeOrder.Location = new System.Drawing.Point(4, 22);
            this.MakeOrder.Name = "MakeOrder";
            this.MakeOrder.Padding = new System.Windows.Forms.Padding(3);
            this.MakeOrder.Size = new System.Drawing.Size(786, 381);
            this.MakeOrder.TabIndex = 1;
            this.MakeOrder.Text = "Сделать заказ";
            this.MakeOrder.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(4, 22);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(3);
            this.Menu.Size = new System.Drawing.Size(786, 381);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Меню";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonBack);
            this.Name.Text = "PersonalAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalAccount_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.PersonalData.ResumeLayout(false);
            this.PersonalData.PerformLayout();
            this.MakeOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage PersonalData;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TabPage MakeOrder;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.Button button1;
    }
}