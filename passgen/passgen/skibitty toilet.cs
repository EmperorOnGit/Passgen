using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGeneratorForm : Form
    {
        private const string UppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Numbers = "0123456789";
        private const string SpecialCharacters = "!@#$%^&*()_+";

        public PasswordGeneratorForm()
        {
            InitializeComponent();
            ApplyDarkMode();
        }

        private void ApplyDarkMode()
        {
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ForeColor = System.Drawing.Color.White;

            PasswordLengthNumericUpDown.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            PasswordLengthNumericUpDown.ForeColor = System.Drawing.Color.White;

            GeneratePasswordButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50); // Dark gray
            GeneratePasswordButton.ForeColor = System.Drawing.Color.White;

            CopyPasswordButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50); // Dark gray
            CopyPasswordButton.ForeColor = System.Drawing.Color.White;

            PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            PasswordTextBox.ForeColor = System.Drawing.Color.White;

            label1.ForeColor = System.Drawing.Color.White;
        }

        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {
            int passwordLength = (int)PasswordLengthNumericUpDown.Value;

            if (passwordLength < 8)
            {
                MessageBox.Show("Please enter a valid password length of at least 8 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool includeUppercase = UppercaseCheckBox.Checked;
            bool includeLowercase = LowercaseCheckBox.Checked;
            bool includeNumbers = NumbersCheckBox.Checked;
            bool includeSpecialCharacters = SpecialCharactersCheckBox.Checked;

            if (!includeUppercase && !includeLowercase && !includeNumbers && !includeSpecialCharacters)
            {
                MessageBox.Show("Please select at least one character type.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = GeneratePassword(passwordLength, includeUppercase, includeLowercase, includeNumbers, includeSpecialCharacters);
            PasswordTextBox.Text = password;
        }

        private string GeneratePassword(int length, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSpecialCharacters)
        {
            StringBuilder password = new StringBuilder(length);

            string characterSet = "";
            if (includeUppercase) characterSet += UppercaseLetters;
            if (includeLowercase) characterSet += LowercaseLetters;
            if (includeNumbers) characterSet += Numbers;
            if (includeSpecialCharacters) characterSet += SpecialCharacters;

            if (characterSet.Length == 0)
                throw new ArgumentException("Character set cannot be empty.");

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                if (includeUppercase) password.Append(GetRandomCharacter(UppercaseLetters, rng));
                if (includeLowercase) password.Append(GetRandomCharacter(LowercaseLetters, rng));
                if (includeNumbers) password.Append(GetRandomCharacter(Numbers, rng));
                if (includeSpecialCharacters) password.Append(GetRandomCharacter(SpecialCharacters, rng));

                for (int i = password.Length; i < length; i++)
                {
                    password.Append(GetRandomCharacter(characterSet, rng));
                }
            }

            return ShuffleString(password.ToString());
        }

        private char GetRandomCharacter(string characterSet, RandomNumberGenerator rng)
        {
            byte[] bytes = new byte[4];
            rng.GetBytes(bytes);
            int index = BitConverter.ToInt32(bytes, 0) & int.MaxValue;
            return characterSet[index % characterSet.Length];
        }

        private string ShuffleString(string str)
        {
            char[] array = str.ToCharArray();
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                for (int i = array.Length - 1; i > 0; i--)
                {
                    byte[] bytes = new byte[4];
                    rng.GetBytes(bytes);
                    int j = (int)(BitConverter.ToUInt32(bytes, 0) % (i + 1));
                    char temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            return new string(array);
        }

        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                Clipboard.SetText(PasswordTextBox.Text);
                MessageBox.Show("Password copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No password to copy. Generate a password first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}