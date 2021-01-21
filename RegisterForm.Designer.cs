
namespace Login_UI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.BackPicture = new System.Windows.Forms.PictureBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ShowPasswordPicture = new System.Windows.Forms.PictureBox();
            this.ShowConfirmPasswordPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowConfirmPasswordPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.EmailLabel.Location = new System.Drawing.Point(28, 23);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(76, 13);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email Address:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.NameLabel.Location = new System.Drawing.Point(28, 56);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Full Name:";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(28, 122);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(94, 13);
            this.ConfirmPasswordLabel.TabIndex = 3;
            this.ConfirmPasswordLabel.Text = "Confirm Password:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.PasswordLabel.Location = new System.Drawing.Point(28, 89);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.EmailTextBox.Location = new System.Drawing.Point(128, 20);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(160, 20);
            this.EmailTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.NameTextBox.Location = new System.Drawing.Point(128, 53);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(160, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(128, 86);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(160, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ConfirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(128, 119);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(160, 20);
            this.ConfirmPasswordTextBox.TabIndex = 4;
            // 
            // BackPicture
            // 
            this.BackPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackPicture.Image = global::Login_UI.Properties.Resources.BACK_ARROW;
            this.BackPicture.Location = new System.Drawing.Point(3, 3);
            this.BackPicture.Name = "BackPicture";
            this.BackPicture.Size = new System.Drawing.Size(25, 25);
            this.BackPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackPicture.TabIndex = 0;
            this.BackPicture.TabStop = false;
            this.BackPicture.Click += new System.EventHandler(this.BackPicture_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(31, 156);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(257, 25);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ShowPasswordPicture
            // 
            this.ShowPasswordPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordPicture.Image = global::Login_UI.Properties.Resources.EYE_CROSS_NEW;
            this.ShowPasswordPicture.Location = new System.Drawing.Point(296, 87);
            this.ShowPasswordPicture.Name = "ShowPasswordPicture";
            this.ShowPasswordPicture.Size = new System.Drawing.Size(18, 18);
            this.ShowPasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPasswordPicture.TabIndex = 6;
            this.ShowPasswordPicture.TabStop = false;
            this.ShowPasswordPicture.Click += new System.EventHandler(this.ShowPasswordPicture_Click);
            this.ShowPasswordPicture.MouseLeave += new System.EventHandler(this.ShowPasswordPicture_MouseLeave);
            this.ShowPasswordPicture.MouseHover += new System.EventHandler(this.ShowPasswordPicture_MouseHover);
            // 
            // ShowConfirmPasswordPicture
            // 
            this.ShowConfirmPasswordPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowConfirmPasswordPicture.Image = global::Login_UI.Properties.Resources.EYE_CROSS_NEW;
            this.ShowConfirmPasswordPicture.Location = new System.Drawing.Point(296, 120);
            this.ShowConfirmPasswordPicture.Name = "ShowConfirmPasswordPicture";
            this.ShowConfirmPasswordPicture.Size = new System.Drawing.Size(18, 18);
            this.ShowConfirmPasswordPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowConfirmPasswordPicture.TabIndex = 7;
            this.ShowConfirmPasswordPicture.TabStop = false;
            this.ShowConfirmPasswordPicture.Click += new System.EventHandler(this.ShowConfirmPasswordPicture_Click);
            this.ShowConfirmPasswordPicture.MouseLeave += new System.EventHandler(this.ShowConfirmPasswordPicture_MouseLeave);
            this.ShowConfirmPasswordPicture.MouseHover += new System.EventHandler(this.ShowConfirmPasswordPicture_MouseHover);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(323, 198);
            this.Controls.Add(this.ShowConfirmPasswordPicture);
            this.Controls.Add(this.ShowPasswordPicture);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.BackPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stronghold";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowConfirmPasswordPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackPicture;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.PictureBox ShowPasswordPicture;
        private System.Windows.Forms.PictureBox ShowConfirmPasswordPicture;
    }
}