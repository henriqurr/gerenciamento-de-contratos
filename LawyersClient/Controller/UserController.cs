using LawyersClient.Assets.Helper;
using LawyersClient.Model;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LawyersClient.Controller
{
    public static class UserController
    {
        public static bool MatchAuthentication(string login, string password)
        {
            try
            {
                User user = new();

                string[] lines = File.ReadAllLines("settings/Admin.config");

                user.Login = lines[0].Split(':')[1].Trim();
                user.Password = lines[1].Split(':')[1].Trim();

                if (user.Login == Hash(login) && user.Password == Hash(password))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro interno.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
            }
            return false;
        }

        public static string Hash(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2")));
        }

        public static string Encrypt(string Data, string EncryptionKey)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(Data);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new())
                {
                    using (CryptoStream cs = new(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Dispose();

                        try
                        {
                            cs.Close();
                        }
                        catch
                        {
                        }
                    }
                    Data = Convert.ToBase64String(ms.ToArray());
                }
            }
            return Data;
        }

        public static string Decrypt(string Data, string EncryptionKey)
        {
            Data = Data.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(Data);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new())
                {
                    using (CryptoStream cs = new(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Dispose();

                        try
                        {
                            cs.Close();
                        }
                        catch
                        {
                        }
                    }
                    Data = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return Data;
        }
    }
}