namespace DictionaryCipherForms
{
    public partial class frmCipherEngine : Form
    {
        public frmCipherEngine()
        {
            InitializeComponent();
            DictionaryUtil.GenerateEncryptionDictionary(3);
            DictionaryUtil.GenerateDecryptionDictionary();
        }

        private string EncryptMessage(string message)
        {
            char[] encryptedChars = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char currentChar = message[i];

                if (DictionaryUtil.encryptionDict.ContainsKey(currentChar))
                    encryptedChars[i] = DictionaryUtil.encryptionDict[currentChar];
                else
                    encryptedChars[i] = currentChar;
            }
            return new string(encryptedChars);
        }

        private string DecryptMessage(string message)
        {
            char[] decryptedChars = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char currentChar = message[i];

                if (DictionaryUtil.decryptionDict.ContainsKey(currentChar))
                    decryptedChars[i] = DictionaryUtil.decryptionDict[currentChar];
                else
                    decryptedChars[i] = currentChar;
            }
            return new string(decryptedChars);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string messageToEncrypt = txbInput.Text.ToUpper();
            string encryptedMessage = EncryptMessage(messageToEncrypt);
            txbOutput.Text = encryptedMessage;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string messageToDecrypt = txbInput.Text.ToUpper();
            string decryptedMessage = DecryptMessage(messageToDecrypt);
            txbOutput.Text = decryptedMessage;
        }
    }
}