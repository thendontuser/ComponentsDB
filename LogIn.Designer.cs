namespace ComponentsDB
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            UserNameLbl = new Label();
            PasswordLbl = new Label();
            LogInBtn = new Button();
            SuspendLayout();
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(12, 35);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(400, 27);
            UserNameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(12, 105);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(400, 27);
            PasswordTextBox.TabIndex = 1;
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Location = new Point(187, 9);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(52, 20);
            UserNameLbl.TabIndex = 2;
            UserNameLbl.Text = "Логин";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(187, 82);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(62, 20);
            PasswordLbl.TabIndex = 3;
            PasswordLbl.Text = "Пароль";
            // 
            // LogInBtn
            // 
            LogInBtn.Location = new Point(136, 160);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(154, 50);
            LogInBtn.TabIndex = 4;
            LogInBtn.Text = "Вход";
            LogInBtn.UseVisualStyleBackColor = true;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 222);
            Controls.Add(LogInBtn);
            Controls.Add(PasswordLbl);
            Controls.Add(UserNameLbl);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LogIn";
            Text = "LogIn";
            FormClosed += LogIn_FormClosed;
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Label UserNameLbl;
        private Label PasswordLbl;
        private Button LogInBtn;
    }
}