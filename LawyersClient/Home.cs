using LawyersClient.Assets.Helper;
using LawyersClient.Assets.Tools;
using LawyersClient.Assets.View;
using LawyersClient.Controller;
using LawyersClient.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace LawyersClient
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientController.LoadClients();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                Environment.Exit(0);
            }
            catch
            {
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClientController.clients.Count >= 3)
                {
                    LogHelper.Message($"Limite máximo de 3 clientes foi atingido.", MessageBoxIcon.Information);
                    return;
                }

                if (Program.formInsert == null)
                {
                    (Program.formInsert = new Insert(null, true)).Show();
                    //Authentication auth = new Authentication(null, true);
                    //auth.Show();
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro ao abrir cadastro de cliente.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void menuStrip_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                TreeNode node = clientsTreeView.SelectedNode;

                if (node != null)
                {
                    clientName.Text = $"Cliente: {node.Text}";
                    editClient.Enabled = true;
                    removeClient.Enabled = true;
                }
                else
                {
                    editClient.Enabled = false;
                    removeClient.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void editClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.formInsert == null)
                {
                    TreeNode node = clientsTreeView.SelectedNode;
                    if (node != null)
                    {
                        Client client = ClientController.GetClient(node.Text);
                        if (client != null)
                        {
                            Authentication auth = new Authentication(client);
                            auth.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro ao abrir edição de cliente.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void removeClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.formInsert == null)
                {
                    TreeNode node = clientsTreeView.SelectedNode;
                    if (node != null)
                    {
                        Authentication auth = new Authentication(null, false, node.Text);
                        auth.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro ao abrir edição de cliente.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void clientsTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                clientView.Items.Clear();
                contractView.Items.Clear();
                contractItems.Items.Clear();

                TreeNode node = e.Node;
                if (node != null)
                {
                    Client client = ClientController.GetClient(node.Text);
                    if (client != null)
                    {
                        // dados do cliente

                        ListViewItem item = new() { Text = $"{client.Name}" };
                        item.SubItems.Add(new ListViewSubItem() { Text = $"{client.Phone}" });
                        item.SubItems.Add(new ListViewSubItem() { Text = $"{client.Email}" });
                        item.SubItems.Add(new ListViewSubItem() { Text = $"{client.LawyerName}" });
                        item.SubItems.Add(new ListViewSubItem() { Text = $"{client.ProcessNumber}" });

                        clientView.Items.Add(item);

                        // dados do contrato

                        ListViewItem itemContract = new() { Text = string.Format("{0:C}", client.ContractValue / 100) };
                        itemContract.SubItems.Add(new ListViewSubItem() { Text = string.Format("{0:C}", client.EntranceValue / 100) });
                        itemContract.SubItems.Add(new ListViewSubItem() { Text = $"{client.Installments}x" });
                        itemContract.SubItems.Add(new ListViewSubItem() { Text = string.Format("{0:C}", client.InstallmentsValue / 100) });
                        itemContract.SubItems.Add(new ListViewSubItem() { Text = string.Format("{0:C}", client.GetFinalValue() / 100) });
                        itemContract.SubItems.Add(new ListViewSubItem() { Text = $"{client.Date}" });

                        contractView.Items.Add(itemContract);

                        // divisão de contrato

                        int id = 0;
                        foreach (ContractPayment payment in client.ContractSplit)
                        {
                            ListViewItem itemDivision = new() { Text = $"{++id}" };
                            itemDivision.SubItems.Add(new ListViewSubItem() { Text = $"{payment.Percent}%" });
                            itemDivision.SubItems.Add(new ListViewSubItem() { Text = $"{payment.Name}" });
                            itemDivision.SubItems.Add(new ListViewSubItem() { Text = string.Format("{0:C}", payment.GetValue(client.ContractValue) / 100) });

                            contractItems.Items.Add(itemDivision);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro ao carregar informações do cliente.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Dump.JsonToExcel();

                LogHelper.Message($"OK.", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro interno.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
            }
        }
    }
}
