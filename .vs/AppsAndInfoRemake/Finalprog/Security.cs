using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Finalprog
{
    public class Security
    {
        //private char Cipher(char ch, int key)
        //{
        //    if (!char.IsLetter(ch))
        //        return ch;

        //    char offset = char.IsUpper(ch) ? 'A' : 'a';
        //    return (char)((((ch + key) - offset) % 26) + offset);
        //}

        //public string Encipher(string input, int key)
        //{
        //    string output = string.Empty;

        //    foreach (char ch in input)
        //        output += Cipher(ch, key);

        //    return output;
        //}

        //public string Decipher(string input, int key)
        //{
        //    return Encipher(input, 26 - key);
        //}

        public string EncryptString(string plainText)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public string DecryptString(string cipherText)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }



        //sha encoding



        //public string DecryptString(string encrString)
        //{
        //    byte[] b;
        //    string decrypted;
        //    try
        //    {
        //        b = Convert.FromBase64String(encrString);
        //        decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
        //    }
        //    catch (FormatException fe)
        //    {
        //        decrypted = "";
        //    }
        //    return decrypted;
        //}
        //public string EncryptString(string strEncrypted)
        //{
        //    byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncrypted);
        //    string encrypted = Convert.ToBase64String(b);
        //    return encrypted;
        //}
    }
}