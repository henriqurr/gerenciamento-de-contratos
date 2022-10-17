using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawyersClient.Model
{
    public class Client
    {
        // Client infos
        public string Name { get; set; }

        public string OldName { get; set; }

        public string Phone { get; set; }
        
        public string Email { get; set; }

        public string Date { get; set; }

        // Contract
        public int ProcessNumber { get; set; }

        public string LawyerName { get; set; }

        public decimal ContractValue { get; set; }

        public decimal EntranceValue { get; set; } 

        public byte Installments { get; set; }

        public decimal InstallmentsValue { get; set; }

        [JsonInclude]
        public List<ContractPayment> ContractSplit = new List<ContractPayment>();

        public void Update(Client update)
        {
            if (update != null)
            {
                Name = update.Name;
                OldName = update.Name;
                Phone = update.Phone;
                Email = update.Email;
                ProcessNumber = update.ProcessNumber;
                LawyerName = update.LawyerName;
                ContractValue = update.ContractValue;
                EntranceValue = update.EntranceValue;
                Installments = update.Installments;
                InstallmentsValue = update.InstallmentsValue;

                ContractSplit.Clear();
                ContractSplit.AddRange(update.ContractSplit);
            }
        }

        public decimal GetFinalValue()
        {
            decimal value = 0;

            ContractSplit.ForEach(contract =>
            {
                contract.Value = Math.Round(((contract.Percent / 100) * ContractValue), 1);
                value += contract.Value;
            });

            return value;
        }
    }
}