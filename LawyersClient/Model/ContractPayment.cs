using System;
using System.Diagnostics.Contracts;
using System.Text.Json.Serialization;

namespace LawyersClient.Model
{
    public class ContractPayment
    {
        public decimal Percent { get; set; }

        public string Name { get; set; }

        [JsonIgnore]
        public decimal Value { get; set; }

        public decimal GetValue(decimal ContractValue)
        {
            return Math.Round(((Percent / 100) * ContractValue), 1);
        }
    }
}