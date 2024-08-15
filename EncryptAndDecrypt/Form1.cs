using System.Security.Cryptography;
using System.Text;

namespace EncryptAndDecrypt
{
    public partial class Form1 : Form
    {

        private byte[] key;
        private byte[] iv;
        public Form1()
        {
            InitializeComponent();
            key = new byte[32];
            iv = new byte[16];
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                string plaintext = textValue.Text;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memory = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(memory, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter stream = new StreamWriter(cs))
                        {
                            stream.Write(plaintext);
                        }

                        byte[] encryptedBytes = memory.ToArray();
                        string encryptedText = Convert.ToBase64String(encryptedBytes);
                        textEncrypt.Text = encryptedText;
                    }
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                string encryptedText = textDecrypt.Text;
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memory = new MemoryStream(encryptedBytes))
                {
                    using (CryptoStream cs = new CryptoStream(memory, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            string decryptedText = reader.ReadToEnd();
                            textValue.Text = decryptedText;
                        }
                    }
                }
            }

        }
    }
    }