namespace PizzaDelivery
{
    partial class PizzaDeliveryForm
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
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.UserLogin = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.buttonAuthorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(156, 119);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(108, 23);
            this.buttonRegistration.TabIndex = 0;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // UserLogin
            // 
            this.UserLogin.Location = new System.Drawing.Point(113, 29);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(186, 20);
            this.UserLogin.TabIndex = 1;
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(113, 83);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(186, 20);
            this.UserPassword.TabIndex = 2;
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Location = new System.Drawing.Point(51, 32);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(38, 13);
            this.labelUserLogin.TabIndex = 3;
            this.labelUserLogin.Text = "Логин";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(44, 83);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(45, 13);
            this.labelUserPassword.TabIndex = 4;
            this.labelUserPassword.Text = "Пароль";
            // 
            // buttonAuthorization
            // 
            this.buttonAuthorization.Location = new System.Drawing.Point(171, 161);
            this.buttonAuthorization.Name = "buttonAuthorization";
            this.buttonAuthorization.Size = new System.Drawing.Size(75, 23);
            this.buttonAuthorization.TabIndex = 5;
            this.buttonAuthorization.Text = "Вход";
            this.buttonAuthorization.UseVisualStyleBackColor = true;
            this.buttonAuthorization.Click += new System.EventHandler(this.buttonAuthorization_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 196);
            this.Controls.Add(this.buttonAuthorization);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.buttonRegistration);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PizzaDelivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.TextBox UserLogin;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Button buttonAuthorization;
    }
}

