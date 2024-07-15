namespace PizzaDelivery
{
    partial class Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAuthorization = new System.Windows.Forms.Button();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.PasswordUser = new System.Windows.Forms.TextBox();
            this.LoginUser = new System.Windows.Forms.TextBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAuthorization
            // 
            this.buttonAuthorization.Location = new System.Drawing.Point(163, 151);
            this.buttonAuthorization.Name = "buttonAuthorization";
            this.buttonAuthorization.Size = new System.Drawing.Size(75, 23);
            this.buttonAuthorization.TabIndex = 18;
            this.buttonAuthorization.Text = "Вход";
            this.buttonAuthorization.UseVisualStyleBackColor = true;
            this.buttonAuthorization.Click += new System.EventHandler(this.buttonAuthorization_Click);
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(36, 73);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(45, 13);
            this.labelUserPassword.TabIndex = 17;
            this.labelUserPassword.Text = "Пароль";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Location = new System.Drawing.Point(43, 22);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(38, 13);
            this.labelUserLogin.TabIndex = 16;
            this.labelUserLogin.Text = "Логин";
            // 
            // PasswordUser
            // 
            this.PasswordUser.Location = new System.Drawing.Point(105, 73);
            this.PasswordUser.Name = "PasswordUser";
            this.PasswordUser.Size = new System.Drawing.Size(186, 20);
            this.PasswordUser.TabIndex = 15;
            // 
            // LoginUser
            // 
            this.LoginUser.Location = new System.Drawing.Point(105, 19);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Size = new System.Drawing.Size(186, 20);
            this.LoginUser.TabIndex = 14;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(148, 109);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(108, 23);
            this.buttonRegistration.TabIndex = 13;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 188);
            this.Controls.Add(this.buttonAuthorization);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.PasswordUser);
            this.Controls.Add(this.LoginUser);
            this.Controls.Add(this.buttonRegistration);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PizzaDelivery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAuthorization;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.TextBox PasswordUser;
        private System.Windows.Forms.TextBox LoginUser;
        private System.Windows.Forms.Button buttonRegistration;
    }
}

