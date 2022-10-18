//using Aspose.Cells;
//using Aspose.Cells.Utility;
using LawyersClient.Controller;
using LawyersClient.Model;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LawyersClient.Assets.Tools
{
    public static class Dump
    {
        public static void JsonToExcel()
        {
            /**
            // Create a Workbook object
            Workbook workbook = new();
            Worksheet worksheet = workbook.Worksheets[0];

            // Read JSON File
            string jsonInput = File.Exists("database/Clientes.json") ? File.ReadAllText("database/Clientes.json") : "";

            if (jsonInput.Length > 0)
            {
                jsonInput = UserController.Decrypt(jsonInput, Program.user.Password);
            }

            jsonInput.Replace("Name" , "Nome");
            jsonInput.Replace("Phone", "Telefone");
            jsonInput.Replace("Date", "Data");
            jsonInput.Replace("ProcessNumber", "N° do processo");
            jsonInput.Replace("LawyerName", "Advogado");
            jsonInput.Replace("ContractValue", "Valor do contrato");
            jsonInput.Replace("EntranceValue", "Valor de entrada");
            jsonInput.Replace("Installments", "Parcelamento");
            jsonInput.Replace("InstallmentsValue", "Valor das parcelas");
            jsonInput.Replace("ContractSplit", "Divisão de contrato");
            jsonInput.Replace("Percent", "Porcentagem (%)");

            jsonInput = JsonSerializer.Serialize(new Client());


            // Set Styles
            CellsFactory factory = new();
            Style style = factory.CreateStyle();
            style.HorizontalAlignment = TextAlignmentType.Center;
            style.Font.Color = System.Drawing.Color.BlueViolet;
            style.Font.IsBold = true;

            // Set JsonLayoutOptions
            JsonLayoutOptions options = new();
            options.TitleStyle = style;
            options.ArrayAsTable = true;

            // Import JSON Data
            JsonUtility.ImportData(jsonInput, worksheet.Cells, 0, 0, options);

            if (!Directory.Exists("export"))
            {
                Directory.CreateDirectory("export");
            }

            // Save Excel file
            workbook.Save("export/Clientes.xlsx");**/
        }
    }
}
