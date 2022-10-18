using LawyersClient.Assets.Helper;
using LawyersClient.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Windows.Forms;

namespace LawyersClient.Controller
{
    public class DatabaseController
    {
        public static void WriteFile(string fileName, string key, List<Client> clients)
        {
            try
            {
                if (fileName.Contains("database") && !Directory.Exists("database"))
                {
                    Directory.CreateDirectory("database");
                }

                using (StreamWriter writer = new(fileName, false))
                {
                    string data = UserController.Encrypt(JsonSerializer.Serialize(clients, new JsonSerializerOptions { WriteIndented = false, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }), key);

                    writer.WriteLine(data);
                    writer.Dispose();
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro interno.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
            }
        }
    }
}
