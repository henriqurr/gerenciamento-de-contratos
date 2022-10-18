using LawyersClient.Assets.Helper;
using LawyersClient.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LawyersClient.Controller
{
    public static class ClientController
    {
        public static List<Client> clients = new();

        public static void LoadClients()
        {
            try
            {
                clients.Clear();

                if (!Directory.Exists("database"))
                {
                    Directory.CreateDirectory("database");
                }

                if (!File.Exists("database/Clientes.json"))
                {
                    LogHelper.Message($"Clientes.json não foi localizado, ele será criado mas nenhum cliente foi carregado.", MessageBoxIcon.Warning);

                    DatabaseController.WriteFile("database/Clientes.json", Program.user.Password, clients);
                }

                if (!File.Exists("database/Backup.json"))
                {
                    DatabaseController.WriteFile("database/Backup.json", "150322", clients);
                }

                string bufferJson = File.Exists("database/Clientes.json") ? File.ReadAllText("database/Clientes.json") : "";

                if (bufferJson.Length > 0)
                {
                    bufferJson = UserController.Decrypt(bufferJson, Program.user.Password);

                    clients.AddRange(JsonSerializer.Deserialize<List<Client>>(bufferJson)!);
                }

                Program.form.clientsTreeView.Nodes.Clear();

                int count = 0;

                foreach (var client in clients)
                {
                    Program.form.clientsTreeView.Nodes.Add(client.Name);
                    count++;
                }

                Program.form.groupBox1.Text = $"Lista de Clientes ({count})";
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro ao carregar lista de clientes.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
            }
        }

        public static bool AddClient(Client client)
        {
            try
            {
                List<Client> backup = new();
                backup.AddRange(clients);

                try
                {
                    clients.Add(client);

                    DatabaseController.WriteFile("database/Clientes.json", Program.user.Password, clients);
                    DatabaseController.WriteFile("database/Backup.json", "150322", clients);

                    LogHelper.Message($"Cliente adicionado com sucesso.", MessageBoxIcon.Information);
                    return true;
                }
                catch
                {
                    DatabaseController.WriteFile("database/Clientes.json", Program.user.Password, backup);
                }
                finally
                {
                    backup.Clear();
                    backup = null;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro ao adicionar cliente.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
                return false;
            }

            LogHelper.Message($"Não foi possível salvar o cliente no momento.", MessageBoxIcon.Error);
            return false;
        }

        public static bool RemoveClient(string name)
        {
            try
            {
                if (LogHelper.Question($"Deseja remover o cliente '{name}'?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (Client client in clients)
                    {
                        if (client.Name.Equals(name))
                        {
                            clients.Remove(client);

                            DatabaseController.WriteFile("database/Clientes.json", Program.user.Password, clients);
                            DatabaseController.WriteFile("database/Backup.json", "150322", clients);

                            LogHelper.Message($"Cliente removido com sucesso.", MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro ao remover cliente.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
                return false;
            }

            //LogHelper.Message($"Não foi possível remover cliente.", MessageBoxIcon.Error);
            return false;
        }

        public static bool UpdateClient(Client client)
        {
            try
            {
                Client c = GetClient(client.OldName);
                if (c != null)
                {
                    c.Update(client);

                    DatabaseController.WriteFile("database/Clientes.json", Program.user.Password, clients);
                    DatabaseController.WriteFile("database/Backup.json", "150322", clients);

                    LogHelper.Message($"Cliente atualizado com sucesso.", MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro ao atualizar cliente.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
                return false;
            }

            LogHelper.Message($"Não foi possível atualizar cliente.", MessageBoxIcon.Error);
            return false;
        }

        public static bool UpdateItemContract(Client client, ContractPayment contract, string name, int type)
        {
            try
            {
                if (client != null && contract != null)
                {
                    if (type == 1)
                    {
                        client.ContractSplit.Add(contract);
                    }
                    else if (type == 2)
                    {
                        if (LogHelper.Question($"Deseja remover o item '{name}'?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (ContractPayment payment in client.ContractSplit)
                            {
                                if (payment.Name.Equals(name))
                                {
                                    client.ContractSplit.Remove(payment);
                                    LogHelper.Message($"Item removido com sucesso.", MessageBoxIcon.Information);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        foreach (ContractPayment payment in client.ContractSplit)
                        {
                            if (payment.Name.Equals(name))
                            {
                                payment.Name = contract.Name;
                                payment.Percent = contract.Percent;
                                break;
                            }
                        }
                    }

                    DatabaseController.WriteFile("database/Clientes.json", Program.user.Password, clients);
                    DatabaseController.WriteFile("database/Backup.json", "150322", clients);

                    if (type != 2)
                    {
                        LogHelper.Message($"Item atualizado com sucesso.", MessageBoxIcon.Information);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro ao atualizar item.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
                return false;
            }

            LogHelper.Message($"Não foi possível atualizar item.", MessageBoxIcon.Error);
            return false;
        }

        public static Client? GetClient(string name)
        {
            foreach (Client client in clients)
            {
                if (client.Name.Equals(name))
                {
                    return client;
                }
            }
            return null;
        }
    }
}
