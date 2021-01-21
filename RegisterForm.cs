using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login_UI
{
    public partial class RegisterForm : Form
    {
        // Befine booleans for show password image changing
        bool showPassEnabled = false;
        bool showPassEnabledConf = false;

        // Define the images here so code is cleaner later
        Image Eye = Properties.Resources.EYE;
        Image EyeClear = Properties.Resources.EYE_TRANSPARENT;
        Image EyeCross = Properties.Resources.EYE_CROSS_NEW;
        Image EyeCrossClear = Properties.Resources.EYE_CROSS_NEW_TRANSPARENT;

        static string connectionQuery = "datasource=localhost;port=3306;username=root;password=";
        MySqlConnection connection = new MySqlConnection(connectionQuery);

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
        
        // This function validates emails
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Create variables for text bot inputs for cleaner code
            string name = NameTextBox.Text,
                email = EmailTextBox.Text,
                password = PasswordTextBox.Text,
                confpassword = ConfirmPasswordTextBox.Text;

            // Check if email is valid
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address", "Error");
                return;
            }

            // Check if password and confirm password are the same
            if (password != confpassword)
            {
                MessageBox.Show("Passwords do not match", "Error");
                return;
            }

            // Open the connection
            connection.Open();

            // Query to send data to the table
            string insertQuery = "INSERT INTO stronghold_db.users(name, email, password)" +
                "VALUES('" + name +
                "', '" + email +
                "', '" + password + "')";

            // Create command to send the info
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            // Check if query was successful
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account registered", "Success");
            }
            else
            {
                MessageBox.Show("Failed to register account, please try again later", "Error");
            }

            // Close the connection
            connection.Close();
        }

        // ISSUE: Creating a new window without deleting it when you open login or register
        //        window causes a small memory leak.
        // TODO: Fix it
        private void BackPicture_Click(object sender, EventArgs e)
        {
            // Hide the register form
            Hide();

            // Create and show the login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void ShowPasswordPicture_Click(object sender, EventArgs e)
        {
            showPassEnabled = !showPassEnabled;

            // Change the image source for the show password button,
            // and set the password char to * or none
            PasswordTextBox.PasswordChar = showPassEnabled ? '\0' : '*';
            ShowPasswordPicture.Image = showPassEnabled ? Eye : EyeCross;
        }

        private void ShowPasswordPicture_MouseHover(object sender, EventArgs e)
        {
            // Make the image transparent on hover
            ShowPasswordPicture.Image = showPassEnabled ? EyeClear : EyeCrossClear;
        }

        private void ShowPasswordPicture_MouseLeave(object sender, EventArgs e)
        {
            // Make the image transparent on hover
            ShowPasswordPicture.Image = showPassEnabled ? Eye : EyeCross;
        }

        private void ShowConfirmPasswordPicture_Click(object sender, EventArgs e)
        {
            showPassEnabledConf = !showPassEnabledConf;

            // Change the image source for the show password button,
            // and set the password char to * or none
            ConfirmPasswordTextBox.PasswordChar = showPassEnabledConf ? '\0' : '*';
            ShowConfirmPasswordPicture.Image = showPassEnabledConf ? Eye : EyeCross;
        }

        private void ShowConfirmPasswordPicture_MouseHover(object sender, EventArgs e)
        {
            // Make the image transparent on hover
            ShowConfirmPasswordPicture.Image = showPassEnabledConf ? EyeClear : EyeCrossClear;
        }

        private void ShowConfirmPasswordPicture_MouseLeave(object sender, EventArgs e)
        {
            // Make the image transparent on hover
            ShowConfirmPasswordPicture.Image = showPassEnabledConf ? Eye : EyeCross;
        }
    }
}
