namespace Login_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RememberUsernameCheckbox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.ClickHereLabel = new System.Windows.Forms.Label();
            this.ShowPasswordImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordImage)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.EmailLabel.Location = new System.Drawing.Point(27, 18);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(76, 13);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email Address:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.PasswordLabel.Location = new System.Drawing.Point(27, 53);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.EmailTextBox.Location = new System.Drawing.Point(112, 16);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(150, 20);
            this.EmailTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(112, 51);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(150, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // RememberUsernameCheckbox
            // 
            this.RememberUsernameCheckbox.AutoSize = true;
            this.RememberUsernameCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.RememberUsernameCheckbox.Location = new System.Drawing.Point(30, 85);
            this.RememberUsernameCheckbox.Name = "RememberUsernameCheckbox";
            this.RememberUsernameCheckbox.Size = new System.Drawing.Size(128, 17);
            this.RememberUsernameCheckbox.TabIndex = 4;
            this.RememberUsernameCheckbox.Text = "Remember Username";
            this.RememberUsernameCheckbox.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(30, 114);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(232, 25);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.RegisterLabel.Location = new System.Drawing.Point(27, 149);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(122, 13);
            this.RegisterLabel.TabIndex = 6;
            this.RegisterLabel.Text = "Don\'t have an account?";
            // 
            // ClickHereLabel
            // 
            this.ClickHereLabel.AutoSize = true;
            this.ClickHereLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClickHereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickHereLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(151)))), ((int)(((byte)(208)))));
            this.ClickHereLabel.Location = new System.Drawing.Point(146, 149);
            this.ClickHereLabel.Name = "ClickHereLabel";
            this.ClickHereLabel.Size = new System.Drawing.Size(54, 13);
            this.ClickHereLabel.TabIndex = 7;
            this.ClickHereLabel.Text = "Click here";
            this.ClickHereLabel.Click += new System.EventHandler(this.ClickHereLabel_Click);
            // 
            // ShowPasswordImage
            // 
            this.ShowPasswordImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordImage.Image = global::Login_UI.Properties.Resources.EYE_CROSS_NEW;
            this.ShowPasswordImage.Location = new System.Drawing.Point(266, 52);
            this.ShowPasswordImage.Name = "ShowPasswordImage";
            this.ShowPasswordImage.Size = new System.Drawing.Size(18, 18);
            this.ShowPasswordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPasswordImage.TabIndex = 8;
            this.ShowPasswordImage.TabStop = false;
            this.ShowPasswordImage.Click += new System.EventHandler(this.pictureBox1_Click);
            this.ShowPasswordImage.MouseLeave += new System.EventHandler(this.ShowPasswordImage_MouseLeave);
            this.ShowPasswordImage.MouseHover += new System.EventHandler(this.ShowPasswordImage_MouseHover);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(289, 181);
            this.Controls.Add(this.ShowPasswordImage);
            this.Controls.Add(this.ClickHereLabel);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RememberUsernameCheckbox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stronghold";
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox RememberUsernameCheckbox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label ClickHereLabel;
        private System.Windows.Forms.PictureBox ShowPasswordImage;
    }
}

