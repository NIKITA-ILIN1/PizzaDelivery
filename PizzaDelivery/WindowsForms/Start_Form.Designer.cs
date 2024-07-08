namespace PizzaDelivery
{
    partial class Start_Form
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
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(47, 88);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(162, 23);
            this.buttonUser.TabIndex = 0;
            this.buttonUser.Text = "Пользователь";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Location = new System.Drawing.Point(286, 88);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(167, 23);
            this.buttonEmployee.TabIndex = 1;
            this.buttonEmployee.Text = "Сотрудник";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(158, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(157, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Кто использует приложение?";
            // 
            // Start_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 146);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.buttonUser);
            this.Name = "Start_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PizzaDelivery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Label labelTitle;
    }
}

