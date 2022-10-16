using LawyersClient.Assets.Helper;
using LawyersClient.Controller;
using LawyersClient.Model;
using System;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LawyersClient.Assets.View
{
    public partial class ItemContract : Form
    {
        public Client client;
        public ContractPayment contract;
        public string oldName;
        public string Object;
        public decimal Percent;

        public int Type;

        public ItemContract(int type, Client _client, ContractPayment payment, string @object, decimal percent)
        {
            InitializeComponent();
            Type = type;
            client = _client;
            contract = payment;
            Object = @object;
            Percent = percent;

            oldName = @object;

            inputObject.Text = Object;
            inputPercent.Text = Percent.ToString();

            if (!string.IsNullOrEmpty(payment.Name))
            {
                Text = $"Item do contrato ({payment.Name})";
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(inputObject.Text) || string.IsNullOrEmpty(inputPercent.Text))
                {
                    LogHelper.Message("Nenhum campo deve ficar vázio.", MessageBoxIcon.Warning);
                    return;
                }

                contract.Name = Object;
                contract.Percent = Percent;

                if (ClientController.UpdateItemContract(client, contract, oldName, Type))
                {
                    ClientController.LoadClients();

                    Program.formInsert.CalculeDivisionItems();
                    Program.formInsert.CalculeFinalValue();
                    Program.formInsert.Focus();

                    Close();
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro interno.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void inputObject_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Object = inputObject.Text;
            }
            catch
            {
                LogHelper.Message("Ocorreu um erro. Digite novamente.", MessageBoxIcon.Error);
            }
        }

        private void inputPercent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Percent = Convert.ToDecimal(Regex.Replace(new string(inputPercent.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", ""));
            }
            catch
            {
            }
        }
    }
}
