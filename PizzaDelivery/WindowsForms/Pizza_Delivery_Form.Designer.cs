namespace PizzaDelivery
{
    partial class Pizza_Delivery_Form
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
            this.buttonAuthorization = new System.Windows.Forms.Button();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.UserLogin = new System.Windows.Forms.TextBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAuthorization
            // 
            this.buttonAuthorization.Location = new System.Drawing.Point(165, 160);
            this.buttonAuthorization.Name = "buttonAuthorization";
            this.buttonAuthorization.Size = new System.Drawing.Size(75, 23);
            this.buttonAuthorization.TabIndex = 11;
            this.buttonAuthorization.Text = "Вход";
            this.buttonAuthorization.UseVisualStyleBackColor = true;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(38, 82);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(45, 13);
            this.labelUserPassword.TabIndex = 10;
            this.labelUserPassword.Text = "Пароль";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Location = new System.Drawing.Point(45, 31);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(38, 13);
            this.labelUserLogin.TabIndex = 9;
            this.labelUserLogin.Text = "Логин";
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(107, 82);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(186, 20);
            this.UserPassword.TabIndex = 8;
            // 
            // UserLogin
            // 
            this.UserLogin.Location = new System.Drawing.Point(107, 28);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(186, 20);
            this.UserLogin.TabIndex = 7;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(150, 118);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(108, 23);
            this.buttonRegistration.TabIndex = 6;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(23, 160);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Вернуться";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Pizza_Delivery_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 212);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAuthorization);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.buttonRegistration);
            this.Name = "Pizza_Delivery_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PizzaDelivery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pizza_Delivery_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAuthorization;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.TextBox UserLogin;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonBack;
    }
}