using LawyersClient.Assets.Helper;
using LawyersClient.Controller;
using LawyersClient.Model;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace LawyersClient.Assets.View
{
    public partial class Insert : Form
    {
        private Client client;
        private bool newAccount;

        public Insert(Client clientEdit, bool newAccount)
        {
            InitializeComponent();

            this.newAccount = newAccount;

            if (clientEdit != null)
            {
                Text = "Editar cliente";

                // criar nova instância de cliente

                client = new Client
                {
                    Date = clientEdit.Date
                };
                client.Update(clientEdit);

                // atualizar formulário

                inputName.Text = client.Name;
                inputPhone.Text = client.Phone;
                inputEmail.Text = client.Email;
                inputProcessNumber.Text = client.ProcessNumber.ToString();
                inputLawyer.Text = client.LawyerName;
                inputValue.Text = client.ContractValue.ToString();
                inputEntrance.Text = client.EntranceValue.ToString();
                inputInstallments.Text = client.Installments.ToString();

                inputValue_Leave(null, null);
                inputEntrance_Leave(null, null);
                inputInstallments_TextChanged(null, null);

                CalculeDivisionItems();
                return;
            }

            if (newAccount)
            {
                client = new();

                inputValue.Text = "R$ 2,500.00";
                inputEntrance.Text = "R$ 1,450.00";
                inputInstallments.Text = "1";

                client.ContractSplit.Add(new ContractPayment
                {
                    Percent = 4,
                    Name = "Imposto"
                });

                client.ContractSplit.Add(new ContractPayment
                {
                    Percent = 6,
                    Name = "Comissão"
                });

                client.ContractSplit.Add(new ContractPayment
                {
                    Percent = 3,
                    Name = "Caixinha"
                });

                client.ContractSplit.Add(new ContractPayment
                {
                    Percent = 5,
                    Name = "Manutenção"
                });

                client.ContractSplit.Add(new ContractPayment
                {
                    Percent = 5,
                    Name = "Custo do Escritório"
                });

                client.ContractSplit.Add(new ContractPayment
                {
                    Percent = 10,
                    Name = "Reserva"
                });

                client.ContractSplit.Add(new ContractPayment
                {
                    Percent = 40,
                    Name = "Sócio Nominal"
                });

                client.ContractSplit.Add(new ContractPayment
                {
                    Percent = 10,
                    Name = "Comissão de Venda"
                });

                client.ContractSplit.Add(new ContractPayment
                {
                    Percent = 25,
                    Name = "Advogado do Caso"
                });

                client.ContractSplit.Add(new ContractPayment
                {
                    Percent = 2,
                    Name = "Envolvidos"
                });

                CalculeInstallmentsValue();
                CalculeFinalValue();
                CalculeDivisionItems(true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Insert_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                // não permite abrir outra instância

                if (Program.formInsert != null)
                {
                    Program.formInsert.Dispose();
                }
            }
            finally
            {
                Program.formInsert = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // verificações

                if (string.IsNullOrEmpty(inputName.Text)
                 || string.IsNullOrEmpty(inputPhone.Text)
                 || string.IsNullOrEmpty(inputLawyer.Text)
                 || string.IsNullOrEmpty(inputValue.Text)
                 || string.IsNullOrEmpty(inputEntrance.Text)
                 || string.IsNullOrEmpty(inputInstallments.Text))
                {
                    LogHelper.Message("Nenhum campo deve ficar vázio.", MessageBoxIcon.Warning);
                    return;
                }

                decimal contractValue = Convert.ToDecimal(Regex.Replace(new string(inputValue.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", ""));
                decimal entranceValue = Convert.ToDecimal(Regex.Replace(new string(inputEntrance.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", ""));
                decimal installmentsV = Convert.ToDecimal(Regex.Replace(new string(installmentsValue.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", ""));

                byte installments = Convert.ToByte(Regex.Replace(new string(inputInstallments.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", ""));

                if (client != null && !newAccount)
                {
                    // atualiza cliente

                    StringBuilder stringBuiler = new();

                    string newName = inputName.Text;
                    string newPhone = inputPhone.Text;
                    string newEmail = inputEmail.Text;
                    string newProcessNumber = inputProcessNumber.Text;
                    string newLawyerName = inputLawyer.Text;

                    if (!client.Name.Equals(newName))
                    {
                        stringBuiler.Append("Nome");
                    }
                    if (!client.Phone.Equals(newPhone))
                    {
                        stringBuiler.Append("; Telefone");
                    }
                    if (!client.Email.Equals(newEmail))
                    {
                        stringBuiler.Append("; Email");
                    }
                    if (!client.ProcessNumber.Equals(Convert.ToInt32(newProcessNumber)))
                    {
                        stringBuiler.Append("; N° do processo");
                    }
                    if (!client.LawyerName.Equals(newLawyerName))
                    {
                        stringBuiler.Append("; Advogado");
                    }

                    if (stringBuiler.Length == 0)
                    {
                        Close();
                        return;
                    }

                    if (LogHelper.Question($"Confirma as seguintes alterações: {(stringBuiler.Length > 0 ? (Environment.NewLine + Environment.NewLine) + stringBuiler : "")}?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        client.Name = newName;
                        client.Phone = newPhone;
                        client.Email = newEmail;
                        client.ProcessNumber = Convert.ToInt32(newProcessNumber);
                        client.LawyerName = newLawyerName;
                        client.ContractValue = contractValue;
                        client.EntranceValue = entranceValue;
                        client.Installments = installments;
                        client.InstallmentsValue = installmentsV;

                        if (ClientController.UpdateClient(client))
                        {
                            ClientController.LoadClients();
                            Close();
                        }
                    }
                }
                else
                {
                    // cria um cliente

                    if (client == null)
                    {
                        client = new();
                    }

                    client.Name = inputName.Text;
                    client.Phone = inputPhone.Text;
                    client.Email = inputEmail.Text;
                    client.Date = DateTime.Now.ToString("yy/MM/dd HH:mm");
                    client.ProcessNumber = Convert.ToInt32(inputProcessNumber.Text);
                    client.LawyerName = inputLawyer.Text;
                    client.ContractValue = contractValue;
                    client.EntranceValue = entranceValue;
                    client.Installments = installments;
                    client.InstallmentsValue = installmentsV;

                    CalculeDivisionItems();

                    if (ClientController.AddClient(client))
                    {
                        ClientController.LoadClients();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro interno.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void inputValue_TextChanged(object sender, EventArgs e)
        {
            CalculeInstallmentsValue();
            CalculeFinalValue();
        }

        private void inputEntrance_TextChanged(object sender, EventArgs e)
        {
            CalculeInstallmentsValue();
            CalculeFinalValue();
        }

        private void inputInstallments_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string formatValue = Regex.Replace(new string(inputInstallments.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", "");

                inputInstallments.Text = formatValue;

                CalculeInstallmentsValue();
                CalculeFinalValue();
            }
            catch
            {
            }
        }

        private void CalculeInstallmentsValue()
        {
            if (string.IsNullOrEmpty(inputValue.Text) && string.IsNullOrEmpty(inputEntrance.Text) && string.IsNullOrEmpty(inputInstallments.Text))
            {
                installmentsValue.Text = "";
                return;
            }
            try
            {
                decimal contractValue = Convert.ToDecimal(Regex.Replace(new string(inputValue.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", ""));
                decimal entranceValue = Convert.ToDecimal(Regex.Replace(new string(inputEntrance.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", ""));
                byte installments = Convert.ToByte(Regex.Replace(new string(inputInstallments.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", ""));

                decimal final = (contractValue - entranceValue) / installments;

                if (final < 0)
                    final = 0;

                installmentsValue.Text = string.Format("{0:C}", Convert.ToDecimal(final) / 100);
            }
            catch
            {
                installmentsValue.Text = string.Format("{0:C}", 0);
            }
        }

        public void CalculeFinalValue()
        {
            if (string.IsNullOrEmpty(inputValue.Text) && string.IsNullOrEmpty(inputEntrance.Text) && string.IsNullOrEmpty(inputInstallments.Text) || client == null)
            {
                valueFinalText.Text = "";
                valueFinalPercent.Text = "";
                return;
            }
            try
            {
                // valor atual do contrato

                decimal contractValue = Convert.ToDecimal(Regex.Replace(new string(inputValue.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", ""));
                if (contractValue < 0)
                    contractValue = 0;

                // calcular valor

                decimal value = 0;

                client.ContractSplit.ForEach(contract =>
                {
                    contract.Value = Math.Round(((contract.Percent / 100) * contractValue), 1);
                    value += contract.Value;
                });
                valueFinalText.Text = string.Format("{0:C}", value / 100);

                // calcular porcentagem

                decimal percent = 0;

                client.ContractSplit.ForEach(contract =>
                {
                    percent += contract.Percent;
                });

                valueFinalPercent.Text = $"{percent}%";
            }
            catch
            {
            }
        }

        public void CalculeDivisionItems(bool newAccount = false)
        {
            try
            {
                int id = 0;

                decimal contractValue = Convert.ToDecimal(Regex.Replace(new string(inputValue.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", ""));

                if (contractValue < 0)
                    contractValue = 0;

                if (newAccount)
                {
                    contractItems.Items.Clear();

                    foreach (ContractPayment payment in client.ContractSplit)
                    {
                        ListViewItem item = new() { Text = $"{++id}" };
                        item.SubItems.Add(new ListViewSubItem() { Text = $"{payment.Percent}%" });
                        item.SubItems.Add(new ListViewSubItem() { Text = $"{payment.Name}" });
                        item.SubItems.Add(new ListViewSubItem() { Text = string.Format("{0:C}", payment.GetValue(contractValue) / 100) });

                        contractItems.Items.Add(item);
                    }
                    return;
                }

                if (client == null)
                {
                    return;
                }

                contractItems.Items.Clear();

                foreach (ContractPayment payment in client.ContractSplit)
                {
                    ListViewItem item = new() { Text = $"{++id}" };
                    item.SubItems.Add(new ListViewSubItem() { Text = $"{payment.Percent}%" });
                    item.SubItems.Add(new ListViewSubItem() { Text = $"{payment.Name}" });
                    item.SubItems.Add(new ListViewSubItem() { Text = string.Format("{0:C}", payment.GetValue(contractValue) / 100) });

                    contractItems.Items.Add(item);
                }
            }
            catch
            {
            }
        }

        private void inputPhone_Leave(object sender, EventArgs e)
        {
            try
            {
                string formatValue = Regex.Replace(new string(inputPhone.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", "");

                string mask = "{0:(00) 0000-0000}";
                long number = Convert.ToInt64(formatValue);

                if (formatValue.Length == 11)
                    mask = "{0:(00) 00000-0000}";

                inputPhone.Text = string.Format(mask, number);
            }
            catch
            {
                if (inputPhone.Text != "")
                {
                    LogHelper.Message("Digite apenas números.", MessageBoxIcon.Warning);
                    inputPhone.Text = "";
                    inputPhone.Focus();
                }
            }
        }

        private void inputValue_Leave(object sender, EventArgs e)
        {
            try
            {
                string formatValue = Regex.Replace(new string(inputValue.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", "");

                if (!string.IsNullOrEmpty(formatValue))
                {
                    inputValue.Text = string.Format("{0:C}", Convert.ToDecimal(formatValue) / 100);

                    CalculeInstallmentsValue();
                    CalculeFinalValue();
                    CalculeDivisionItems();
                }
                else
                {
                    inputValue.Text = string.Empty;
                }
            }
            catch
            {
            }
        }

        private void inputEntrance_Leave(object sender, EventArgs e)
        {
            try
            {
                string formatValue = Regex.Replace(new string(inputEntrance.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", "");

                if (!string.IsNullOrEmpty(formatValue))
                {
                    inputEntrance.Text = string.Format("{0:C}", Convert.ToDecimal(formatValue) / 100);

                    CalculeInstallmentsValue();
                    CalculeFinalValue();
                }
                else
                {
                    inputEntrance.Text = string.Empty;
                }
            }
            catch
            {
            }
        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }

        private void editClient_Click(object sender, EventArgs e)
        {
        
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    for (int i = 0; i < contractItems.SelectedItems.Count; i++)
                    {
                        ListViewItem view = contractItems.SelectedItems[i];
                        if (view != null)
                        {
                            ListViewSubItem subItem = view.SubItems[2];
                            if (subItem != null)
                            {
                                foreach (ContractPayment payment in client.ContractSplit)
                                {
                                    if (subItem.Text.Equals(payment.Name))
                                    {
                                        ItemContract itemContract = new(3, client, payment, payment.Name, payment.Percent);
                                        itemContract.Show();
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void clientName_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    ContractPayment payment = new ContractPayment();

                    ItemContract itemContract = new(1, client, payment, payment.Name, payment.Percent);
                    itemContract.Show();
                }
            }
            catch
            {
            }
        }

        private void removeClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    for (int i = 0; i < contractItems.SelectedItems.Count; i++)
                    {
                        ListViewItem view = contractItems.SelectedItems[i];
                        if (view != null)
                        {
                            ListViewSubItem subItem = view.SubItems[2];
                            if (subItem != null)
                            {
                                foreach (ContractPayment payment in client.ContractSplit)
                                {
                                    if (subItem.Text.Equals(payment.Name))
                                    {
                                        if (ClientController.UpdateItemContract(client, payment, payment.Name, 2))
                                        {
                                            ClientController.LoadClients();

                                            CalculeDivisionItems();
                                            CalculeFinalValue();
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void inputProcessNumber_Leave(object sender, EventArgs e)
        {
            try
            {
                string formatValue = Regex.Replace(new string(inputProcessNumber.Text.Where(char.IsDigit).ToArray()), "[^A-Za-z0-9 -]", "");

                inputProcessNumber.Text = formatValue;
            }
            catch
            {
                if (inputProcessNumber.Text != "")
                {
                    LogHelper.Message("Digite apenas números.", MessageBoxIcon.Warning);
                    inputProcessNumber.Text = "";
                    inputProcessNumber.Focus();
                }
            }
        }
    }
}
