namespace eDairy
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.LabelPass = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TimerMotion = new System.Windows.Forms.Timer(this.components);
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.AutoSize = true;
            this.ButtonEnter.Location = new System.Drawing.Point(401, 114);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(58, 33);
            this.ButtonEnter.TabIndex = 11;
            this.ButtonEnter.Text = "Вход";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // LabelPass
            // 
            this.LabelPass.AutoSize = true;
            this.LabelPass.Location = new System.Drawing.Point(114, 156);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(75, 23);
            this.LabelPass.TabIndex = 10;
            this.LabelPass.Text = "Пароль:";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(125, 121);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(64, 23);
            this.LabelLogin.TabIndex = 9;
            this.LabelLogin.Text = "Логин:";
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(195, 153);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(200, 30);
            this.TextBoxPass.TabIndex = 8;
            this.TextBoxPass.UseSystemPasswordChar = true;
            this.TextBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPass_KeyPress);
            this.TextBoxPass.MouseLeave += new System.EventHandler(this.TextBoxPass_MouseLeave);
            this.TextBoxPass.MouseHover += new System.EventHandler(this.TextBoxPass_MouseHover);
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(195, 117);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(200, 30);
            this.TextBoxLogin.TabIndex = 7;
            this.TextBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLogin_KeyPress);
            // 
            // TimerMotion
            // 
            this.TimerMotion.Interval = 1;
            this.TimerMotion.Tick += new System.EventHandler(this.TimerMotion_Tick);
            // 
            // ButtonClose
            // 
            this.ButtonClose.AutoSize = true;
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonClose.Location = new System.Drawing.Point(401, 153);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(86, 33);
            this.ButtonClose.TabIndex = 13;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.ButtonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonClose;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.LabelPass);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLogin);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Shown += new System.EventHandler(this.FormLogin_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.Label LabelPass;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.Timer TimerMotion;
        private System.Windows.Forms.Button ButtonClose;
    }
}

