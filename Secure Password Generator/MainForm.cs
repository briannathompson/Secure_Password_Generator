namespace Secure_Password_Generator
{
    public partial class MainForm : Form
    {
        const int DEFAULT_PASSWORD_LENGTH = 18;
        int passwordLength = DEFAULT_PASSWORD_LENGTH;

        public MainForm()
        {
            InitializeComponent();

            /* When form loads: 
                Set length trackbar to default password length and display the value in the textbox */
            passwordLengthTrackBar.Value = DEFAULT_PASSWORD_LENGTH;
            DisplayPasswordLengthValue();

            // Generate and display a password using the default length
            GenerateAndDisplayPassword();

        }

        /* On trackbar value changed, get new password length and generate a password, then display the password */
        private void passwordLengthTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // set password length and display the length back to the user
            passwordLength = passwordLengthTrackBar.Value;
            DisplayPasswordLengthValue();

            // Create a new password object to generate a new password and display it to the user
            GenerateAndDisplayPassword();

        }

        /* METHODS */
        private void DisplayPasswordLengthValue() // min trackbar: 8; max trackbar: 40
        {
            passwordLengthTextBox.Text = passwordLength.ToString();

        }

        private void GenerateAndDisplayPassword()
        {
            // Hide password copied label
            passwordCopiedLabel.Visible = false;

            // Upon calling the Password constructor method, a password using the given length is generated
            // with the GeneratePassword method and stored in the PasswordString property
            Password newPassword = new Password(passwordLength);
            passwordTextBox.Text = newPassword.PasswordString;

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            GenerateAndDisplayPassword();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(passwordTextBox.Text);
                passwordCopiedLabel.Visible = true;
                
            }
            catch
            {
                MessageBox.Show("Password could not be copied.");
            }
            

        }
    }
}
