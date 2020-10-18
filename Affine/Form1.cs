using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Affine
{
    public partial class Form1 : Form
    {
        private char[] engAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        private int keyAValidation(int a, int b = 26)
        {
            int remainder = -1;

            if (a != 0 && b != 0)
            {
                a = (a < 0) ? Math.Abs(a) : a;
                b = (b < 0) ? Math.Abs(b) : b;

                int tmp;
                int divider;

                if (a > b)
                {
                    tmp = a;
                    a = b;
                    b = tmp;
                }

                while (remainder != 0)
                {
                    divider = b / a;
                    remainder = b - divider * a;

                    if (remainder == 0)
                    {
                        return a;
                    }

                    b = a;
                    a = remainder;
                }
            }

            return a;
        }

        private int getIndexPosition(char letter)
        {
            if (engAlphabet.Contains(letter))
            {
                return Array.IndexOf(engAlphabet, letter);
            }
            else if(letter == ' ')
            {
                return -2;
            }

            return -1;
        }

        private int changeIndexes(int index, sbyte parA, sbyte parB)
        {
            if (index >= 0)
            {
                int changedIndex = parA * index + parB % engAlphabet.Length;
                while (changedIndex > (engAlphabet.Length - 1))
                {
                    changedIndex -= engAlphabet.Length;
                }
                return changedIndex;
            }

            else if (index == -2)
            {
                return -2;
            }

            return -1;
        }


        private void encryption(string openText, sbyte parameterA, sbyte parameterB)
        {
            char[] specialCharacters = { '.', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_',
                                         '+', '-', '}', '{', '?', '>', '<', ':', '|', '[', ']', '"',
                                         '/', ',', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
                                       };

            openText = openText.Trim(specialCharacters).Trim();

            foreach (char c in specialCharacters)
            {
                openText = (openText.Contains(c)) ? openText.Replace(c, ' ') : openText;
            }
            

            string normalizedString = openText.Normalize(NormalizationForm.FormD);
            int[] indexPositions = new int[openText.Length];

            StringBuilder engText = new StringBuilder();

            for (int i = 0; i < normalizedString.Length; i++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(normalizedString[i]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    engText.Append(normalizedString[i]);
                }
            }
            
            string engOutput = engText.ToString().ToUpper();
            filteredTextVal.Text = engOutput;

            for (int i=0; i < engOutput.Length; i++)
            {
                indexPositions[i] = getIndexPosition(engOutput[i]);
            }

            int[] changedIndexes = new int[engOutput.Length];

            for(int i=0; i < engOutput.Length; i++)
            {
                changedIndexes[i] = changeIndexes(indexPositions[i], parameterA, parameterB);
            }

            StringBuilder encryptedLetters = new StringBuilder();
            foreach (int index in changedIndexes)
            {
                encryptedLetters = (index == -2) ? encryptedLetters.Append("XQW") : encryptedLetters.Append(engAlphabet[index].ToString());
            }

            encryptOutput.Text = "";

            for (int i = 0; i < encryptedLetters.Length; i++)
            {
                if (i % 5 == 0)
                {
                    encryptOutput.Text += " ";
                }

                encryptOutput.Text += encryptedLetters[i].ToString();
            }

        }

        private int modInverse(int a, int sizeOfAlphabet = 26)
        {
            a = a % sizeOfAlphabet;
            
            for (int i = 1; i < sizeOfAlphabet; i++)
            {
                if ((a * i) % sizeOfAlphabet == 1)
                {
                    return i;
                }
            }                
            
            return 0;
        }

        private int decryptIndex(int index, int invertedA, int b)
        {
            int decryptedIndex = ((index - b) * invertedA) % engAlphabet.Length;
            return (decryptedIndex < 0) ? decryptedIndex + engAlphabet.Length : decryptedIndex;
        }

        private void decryption(string encryptedText, sbyte keyA, sbyte keyB)
        {
            encryptedText = encryptedText.Replace(" ", "");
            encryptedText = (encryptedText.Contains("XQW")) ? encryptedText.Replace("XQW", " ") : encryptedText;

            int[] encryptedTextIndexes = new int[encryptedText.Length];

            for(int i = 0; i < encryptedText.Length; i++)
            {
                encryptedTextIndexes[i] =  getIndexPosition(encryptedText[i]);
            }

            int[] decryptedIndexes = new int[encryptedTextIndexes.Length];
            int multInversion = modInverse(keyA);

            for (int i = 0; i < encryptedTextIndexes.Length; i++)
            {
                decryptedIndexes[i] = (encryptedTextIndexes[i] == -2) ? decryptedIndexes[i] = -2 : decryptedIndexes[i] = decryptIndex(encryptedTextIndexes[i], multInversion, keyB); 
            }

            StringBuilder decryptedText = new StringBuilder();


            foreach (var index in decryptedIndexes)
            {
                if (index == -2)
                {
                    decryptedText.Append(" ");
                }
                else
                {
                    decryptedText.Append(engAlphabet[index]);
                }
            }

            decryptOutput.Text = decryptedText.ToString();
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string openText = textBoxEncrypt.Text;
            if (openText.Length < 1)
            {
                MessageBox.Show("If you want to encrypt text, you should enter it.");
            }
            sbyte parA = -1;
            sbyte parB = -1;
            try
            {
                parA = Convert.ToSByte(keyA.Text);
                parB = Convert.ToSByte(keyB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            if (keyAValidation(parA) != 1)
            {
                MessageBox.Show("Key parameter a is not matching: gcd(a,26) = 1\nEnter another parameter (a)\nHint: odd numbers");
            }
            else
            {
                encryption(openText, parA, parB);
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            string encryptedText = textBoxDecrypt.Text;
            if (encryptedText.Length < 1)
            {
                MessageBox.Show("If you want to decrypt text, you should enter it.");
            }
            else
            {
                sbyte parA = -1;
                sbyte parB = -1;

                try
                {
                    parA = Convert.ToSByte(keyA.Text);
                    parB = Convert.ToSByte(keyB.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (keyAValidation(parA) != 1)
                {
                    MessageBox.Show("Key parameter a is not matching: gcd(a,26) = 1\nEnter another parameter (a)\nHint: odd numbers");
                }
                else
                {
                    decryption(encryptedText, parA, parB);
                }
            }
        }

        private void keyA_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void decryptOutput_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEncrypt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
