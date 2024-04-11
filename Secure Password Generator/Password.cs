using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Password_Generator
{
    internal class Password
    {
        private string mPassword = "";
        private int mPasswordLength = 0;
        Random random = new Random();

        // Constructor
        public Password (int passwordLength)
        {
            // get password value from MainForm
            mPasswordLength = passwordLength;

            // generate a password any time this constructor is called
            GeneratePassword();
        }

        public string PasswordString
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public int PasswordLength
        {
            get { return mPasswordLength; }
            set { mPasswordLength = value; }
        }


        private string GeneratePassword()
        {
            /* For each character in the length of the password, generate a number between
                1 and 4 to determine whether the current character will be uppercase, lowercase,
                a number, or a symbol */
            int characterDeterminant = 0;

            for (int i = 0; i < PasswordLength; i++)
            {
                characterDeterminant = random.Next(1, 5); // generate number between 1 and 4
                string currentCharacter = "";

                switch (characterDeterminant)
                {
                    case 1:
                        currentCharacter = GenerateUppercase().ToString();
                        break;
                    case 2:
                        currentCharacter = GenerateLowercase().ToString();
                        break;
                    case 3:
                        currentCharacter = GenerateNumber().ToString();
                        break;
                    case 4:
                        currentCharacter = GenerateSymbol().ToString();
                        break;
                }

                // Add the current character to the passwordString
                PasswordString += currentCharacter;
            }


            return PasswordString;
        }


        /* For methods that generate ASCII characters, info from https://www.ascii-code.com/ */
        private char GenerateUppercase()
        {
            // Generate a number that is or is between 65 (A) and 90 (Z) and get its ASCII equivalent
            int uppercaseASCII = random.Next(65, 91);

            char uppercaseLetter = (char)uppercaseASCII;

            return uppercaseLetter;
        }

        private char GenerateLowercase()
        {
            // Generate a number that is or is between 97 (a) and 122 (z) and get its ASCII equivalent
            int lowercaseASCII = random.Next(97, 123);

            char lowercaseLetter = (char)lowercaseASCII;

            return lowercaseLetter;
        }

        private int GenerateNumber()
        {
            // Generate a number that is or is between 0 and 9
            int number = random.Next(0, 9);

            return number;
        }

        private char GenerateSymbol()
        {
            char[] symbolsArray = [ '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '{', '}', 
                                    '[', ']', '"', '\'', '-', '_', ':', ';', '|', '\\', '<',
                                    '>', '?', '/', ',', '.', '~', '`', '+', '=' ];

            // Generate a number that is between 0 and the Length of the symbolsArray and retrieve the symbol
            // that matches the index 
            int symbolIndex = random.Next(0, symbolsArray.Length);
            char symbol = symbolsArray[symbolIndex];

            return symbol;
        }

    }
}
