namespace eDairy
{
    partial class FormSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxNewPass = new System.Windows.Forms.TextBox();
            this.TextBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.LabelConfirmPass = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelNewPass = new System.Windows.Forms.Label();
            this.LabelOldPass = new System.Windows.Forms.Label();
            this.TextBoxOldPass = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TimerMotion = new System.Windows.Forms.Timer(this.components);
            this.LabelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = true;
            this.ButtonSave.Location = new System.Drawing.Point(218, 229);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(79, 27);
            this.ButtonSave.TabIndex = 0;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.AutoSize = true;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(133, 229);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(79, 27);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(78, 42);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(338, 24);
            this.TextBoxLogin.TabIndex = 2;
            this.TextBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLogin_KeyPress);
            // 
            // TextBoxNewPass
            // 
            this.TextBoxNewPass.Location = new System.Drawing.Point(179, 169);
            this.TextBoxNewPass.Name = "TextBoxNewPass";
            this.TextBoxNewPass.Size = new System.Drawing.Size(238, 24);
            this.TextBoxNewPass.TabIndex = 4;
            this.TextBoxNewPass.UseSystemPasswordChar = true;
            this.TextBoxNewPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNewPass_KeyPress);
            this.TextBoxNewPass.MouseLeave += new System.EventHandler(this.TextBoxNewPass_MouseLeave);
            this.TextBoxNewPass.MouseHover += new System.EventHandler(this.TextBoxNewPass_MouseHover);
            // 
            // TextBoxConfirmPass
            // 
            this.TextBoxConfirmPass.Location = new System.Drawing.Point(179, 199);
            this.TextBoxConfirmPass.Name = "TextBoxConfirmPass";
            this.TextBoxConfirmPass.Size = new System.Drawing.Size(238, 24);
            this.TextBoxConfirmPass.TabIndex = 5;
            this.TextBoxConfirmPass.UseSystemPasswordChar = true;
            this.TextBoxConfirmPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxConfirmPass_KeyPress);
            this.TextBoxConfirmPass.MouseLeave += new System.EventHandler(this.TextBoxConfirmPass_MouseLeave);
            this.TextBoxConfirmPass.MouseHover += new System.EventHandler(this.TextBoxConfirmPass_MouseHover);
            // 
            // LabelConfirmPass
            // 
            this.LabelConfirmPass.AutoSize = true;
            this.LabelConfirmPass.Location = new System.Drawing.Point(12, 202);
            this.LabelConfirmPass.Name = "LabelConfirmPass";
            this.LabelConfirmPass.Size = new System.Drawing.Size(160, 17);
            this.LabelConfirmPass.TabIndex = 6;
            this.LabelConfirmPass.Text = "Повторите новый пароль:";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(24, 45);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(48, 17);
            this.LabelLogin.TabIndex = 7;
            this.LabelLogin.Text = "Логин:";
            // 
            // LabelNewPass
            // 
            this.LabelNewPass.AutoSize = true;
            this.LabelNewPass.Location = new System.Drawing.Point(75, 172);
            this.LabelNewPass.Name = "LabelNewPass";
            this.LabelNewPass.Size = new System.Drawing.Size(97, 17);
            this.LabelNewPass.TabIndex = 9;
            this.LabelNewPass.Text = "Новый пароль:";
            // 
            // LabelOldPass
            // 
            this.LabelOldPass.AutoSize = true;
            this.LabelOldPass.Location = new System.Drawing.Point(72, 142);
            this.LabelOldPass.Name = "LabelOldPass";
            this.LabelOldPass.Size = new System.Drawing.Size(100, 17);
            this.LabelOldPass.TabIndex = 10;
            this.LabelOldPass.Text = "Старый пароль:";
            // 
            // TextBoxOldPass
            // 
            this.TextBoxOldPass.Location = new System.Drawing.Point(179, 139);
            this.TextBoxOldPass.Name = "TextBoxOldPass";
            this.TextBoxOldPass.Size = new System.Drawing.Size(238, 24);
            this.TextBoxOldPass.TabIndex = 11;
            this.TextBoxOldPass.UseSystemPasswordChar = true;
            this.TextBoxOldPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxOldPass_KeyPress);
            this.TextBoxOldPass.MouseLeave += new System.EventHandler(this.TextBoxOldPass_MouseLeave);
            this.TextBoxOldPass.MouseHover += new System.EventHandler(this.TextBoxOldPass_MouseHover);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(35, 15);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(37, 17);
            this.LabelName.TabIndex = 13;
            this.LabelName.Text = "Имя:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(78, 12);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(338, 24);
            this.TextBoxName.TabIndex = 12;
            this.TextBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxName_KeyPress);
            // 
            // TimerMotion
            // 
            this.TimerMotion.Interval = 1;
            this.TimerMotion.Tick += new System.EventHandler(this.TimerMotion_Tick);
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInfo.ForeColor = System.Drawing.Color.Red;
            this.LabelInfo.Location = new System.Drawing.Point(130, 95);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(167, 17);
            this.LabelInfo.TabIndex = 15;
            this.LabelInfo.Text = "Недопустимые символы \' \"";
            // 
            // FormSettings
            // 
            this.AcceptButton = this.ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(428, 268);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxOldPass);
            this.Controls.Add(this.LabelOldPass);
            this.Controls.Add(this.LabelNewPass);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelConfirmPass);
            this.Controls.Add(this.TextBoxConfirmPass);
            this.Controls.Add(this.TextBoxNewPass);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.FormSettings_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSettings_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormSettings_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox TextBoxConfirmPass;
        private System.Windows.Forms.Label LabelConfirmPass;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelNewPass;
        private System.Windows.Forms.Label LabelOldPass;
        private System.Windows.Forms.TextBox TextBoxOldPass;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Timer TimerMotion;
        internal System.Windows.Forms.TextBox TextBoxLogin;
        internal System.Windows.Forms.TextBox TextBoxName;
        internal System.Windows.Forms.TextBox TextBoxNewPass;
        private System.Windows.Forms.Label LabelInfo;
    }
}