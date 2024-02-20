namespace InternProject.View
{
    partial class UserRegistration
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.headerLabel.Location = new System.Drawing.Point(279, 49);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(360, 52);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "User Registration";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(87, 146);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(158, 36);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(288, 143);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(351, 41);
            this.firstNameText.TabIndex = 0;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(87, 213);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(156, 36);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(288, 210);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(351, 41);
            this.lastNameText.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(87, 280);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(88, 36);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(288, 277);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(351, 41);
            this.emailText.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(87, 347);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(147, 36);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(288, 344);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(351, 41);
            this.passwordText.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(288, 419);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 42);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(539, 419);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 42);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Cyan;
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(413, 419);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(91, 42);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // UserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 560);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "UserRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button backButton;
    }
}