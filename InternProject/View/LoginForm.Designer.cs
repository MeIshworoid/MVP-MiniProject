namespace InternProject
{
    partial class LoginForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.headerLabel.Location = new System.Drawing.Point(217, 57);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(246, 52);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "MVP Demo";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(73, 163);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(88, 36);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(226, 163);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(247, 41);
            this.emailText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(226, 237);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(247, 41);
            this.passwordText.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Lime;
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(250, 310);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(98, 47);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Orange;
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(380, 310);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(83, 47);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "New";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 481);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
    }
}

