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
    public partial class LoginForm : Form
    {
        // This bool controls which image is being used for the show password button
        bool ButtonEnabled = false;

        // Defining images because it makes the code cleaner later
        Image Eye = Properties.Resources.EYE;
        Image EyeClear = Properties.Resources.EYE_TRANSPARENT;
        Image EyeCross = Properties.Resources.EYE_CROSS_NEW;
        Image EyeCrossClear = Properties.Resources.EYE_CROSS_NEW_TRANSPARENT;

        // Create a connection
        static string connectionQuery = "datasource=localhost;port=3306;username=root;password=";
        MySqlConnection connection = new MySqlConnection(connectionQuery);

        // Define objects for Sql command and data reader
        MySqlCommand command;
        MySqlDataReader mdr;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Define these for cleaner code later
            string inputEmail = EmailTextBox.Text,
                inputPass = PasswordTextBox.Text,
                queryEmail, queryPassword;

            // Check if email text box is empty
            if (inputEmail == "")
            {
                MessageBox.Show("Please enter an email", "Error");
                return;
            }

            // Open the Sql connection
            connection.Open();

            // Send a request for the email and password under the email the user inputs
            string selectQuery = "SELECT email, password FROM stronghold_db.users WHERE email='" + inputEmail + "'";
            command = new MySqlCommand(selectQuery, connection);

            // Start the reader
            mdr = command.ExecuteReader();

            // To check for errors, and avoid crashes
            if (mdr.Read())
            {
                // Assign the correct email and password to their own variables to be compared later
                queryEmail = mdr.GetString("email");
                queryPassword = mdr.GetString("password");
            }
            else
            {
                MessageBox.Show("No account registered with email: " + inputEmail, "Error");
                return;
            }

            // Check if email is correct
            if (inputEmail != queryEmail)
            {
                MessageBox.Show("Invalid email", "Error");
                return;
            }

            // Check if password is correct
            if (inputPass != queryPassword)
            {
                MessageBox.Show("Invalid password", "Error");
                return;
            }

            // Close the connection
            connection.Close();

            // Login was successful, let the user know it worked.
            
        }

        // ISSUE: Creating a new window without deleting it when you open login or register
        //        window causes a small memory leak.
        // TODO: Fix it
        private void ClickHereLabel_Click(object sender, EventArgs e)
        {
            // Hide the login window
            Hide();

            // Create and show the register window
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ButtonEnabled = !ButtonEnabled;

            // Change the image source for the show password button,
            // and set the password char to * or none
            PasswordTextBox.PasswordChar = ButtonEnabled ? '\0' : '*';
            ShowPasswordImage.Image = ButtonEnabled ? Eye : EyeCross;
        }

        private void ShowPasswordImage_MouseHover(object sender, EventArgs e)
        {
            // Make the image transparent on hover
            ShowPasswordImage.Image = ButtonEnabled ? EyeClear : EyeCrossClear;
        }

        private void ShowPasswordImage_MouseLeave(object sender, EventArgs e)
        {
            // Make the image transparent on hover
            ShowPasswordImage.Image = ButtonEnabled ? Eye : EyeCross;
        }
    }
}
