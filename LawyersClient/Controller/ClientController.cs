﻿using LawyersClient.Assets.Tools;
using LawyersClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using LawyersClient.Assets.Helper;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text.Encodings.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Linq;

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

                if (!File.Exists("Clientes.json"))
                {
                    LogHelper.Message($"Clientes.json não foi localizado, ele será criado mas nenhum cliente foi carregado.", MessageBoxIcon.Warning);

                    using (StreamWriter writer = new("Clientes.json", false))
                    {
                        string data = JsonSerializer.Serialize(clients, new JsonSerializerOptions { WriteIndented = false, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });

                        writer.WriteLine(data);
                        writer.Dispose();
                    }
                }

                string bufferJson = File.ReadAllText("Clientes.json");

                if (bufferJson.Length > 0)
                {
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
                LogHelper.Message($"Ocorreu um erro erro ao carregar lista de clientes.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
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

                    using (StreamWriter writer = new("Clientes.json", false))
                    {
                        string data = JsonSerializer.Serialize(clients, new JsonSerializerOptions { WriteIndented = false, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });

                        writer.WriteLine(data);
                        writer.Dispose();
                    }

                    LogHelper.Message($"Cliente adicionado com sucesso.", MessageBoxIcon.Information);
                    return true;
                }
                catch
                {
                    using (StreamWriter writer = new("Clientes.json", false))
                    {
                        string data = JsonSerializer.Serialize(backup, new JsonSerializerOptions { WriteIndented = false, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });

                        writer.WriteLine(data);
                        writer.Dispose();
                    }
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

                            using (StreamWriter writer = new("Clientes.json", false))
                            {
                                string data = JsonSerializer.Serialize(clients, new JsonSerializerOptions { WriteIndented = false, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });

                                writer.WriteLine(data);
                                writer.Dispose();
                            }

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

            LogHelper.Message($"Não foi possível remover cliente.", MessageBoxIcon.Error);
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

                    using (StreamWriter writer = new("Clientes.json", false))
                    {
                        string data = JsonSerializer.Serialize(clients, new JsonSerializerOptions { WriteIndented = false, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });

                        writer.WriteLine(data);
                        writer.Dispose();
                    }

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

                    using (StreamWriter writer = new("Clientes.json", false))
                    {
                        string data = JsonSerializer.Serialize(clients, new JsonSerializerOptions { WriteIndented = false, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });

                        writer.WriteLine(data);
                        writer.Dispose();
                    }

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

        public static Client GetClient(string name)
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
