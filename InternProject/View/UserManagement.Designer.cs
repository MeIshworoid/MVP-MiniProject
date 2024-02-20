namespace InternProject.View
{
    partial class UserManagement
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
            this.loginInfoLabel = new System.Windows.Forms.Label();
            this.userManagementLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.userLists = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginInfoLabel
            // 
            this.loginInfoLabel.AutoSize = true;
            this.loginInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginInfoLabel.Location = new System.Drawing.Point(15, 21);
            this.loginInfoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.loginInfoLabel.Name = "loginInfoLabel";
            this.loginInfoLabel.Size = new System.Drawing.Size(0, 25);
            this.loginInfoLabel.TabIndex = 0;
            // 
            // userManagementLabel
            // 
            this.userManagementLabel.AutoSize = true;
            this.userManagementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementLabel.ForeColor = System.Drawing.Color.Blue;
            this.userManagementLabel.Location = new System.Drawing.Point(376, 30);
            this.userManagementLabel.Name = "userManagementLabel";
            this.userManagementLabel.Size = new System.Drawing.Size(346, 46);
            this.userManagementLabel.TabIndex = 1;
            this.userManagementLabel.Text = "User Management";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Cyan;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(510, 341);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(98, 40);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(636, 341);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(86, 40);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Lime;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(384, 341);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(99, 40);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(384, 273);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(338, 34);
            this.passwordText.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(226, 273);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(120, 29);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(384, 164);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(338, 34);
            this.lastNameText.TabIndex = 7;
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(384, 218);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(338, 34);
            this.emailText.TabIndex = 9;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(218, 164);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(128, 29);
            this.lastNameLabel.TabIndex = 10;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(272, 218);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(74, 29);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email";
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(384, 109);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(338, 34);
            this.firstNameText.TabIndex = 6;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(215, 112);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(131, 29);
            this.firstNameLabel.TabIndex = 12;
            this.firstNameLabel.Text = "First Name";
            // 
            // userLists
            // 
            this.userLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLists.FormattingEnabled = true;
            this.userLists.ItemHeight = 31;
            this.userLists.Location = new System.Drawing.Point(39, 379);
            this.userLists.Name = "userLists";
            this.userLists.Size = new System.Drawing.Size(307, 314);
            this.userLists.TabIndex = 17;
            this.userLists.SelectedIndexChanged += new System.EventHandler(this.userLists_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(743, 101);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 42);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 714);
            this.Controls.Add(this.userLists);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.userManagementLabel);
            this.Controls.Add(this.loginInfoLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginInfoLabel;
        private System.Windows.Forms.Label userManagementLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ListBox userLists;
        private System.Windows.Forms.Button deleteButton;
    }
}