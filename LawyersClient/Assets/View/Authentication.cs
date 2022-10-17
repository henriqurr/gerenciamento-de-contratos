using LawyersClient.Assets.Helper;
using LawyersClient.Controller;
using LawyersClient.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LawyersClient.Assets.View
{
    public partial class Authentication : Form
    {
        public Client client;
        public bool addClient;
        public string removeClient;

        public bool welcome = false;

        public Authentication(Client client, bool addClient = false, string removeClient = "")
        {
            InitializeComponent();
            this.client = client;
            this.addClient = addClient;
            this.removeClient = removeClient;
        }

        public Authentication(bool welcome)
        {
            InitializeComponent();
            this.welcome = welcome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthenticationFunction();
        }

        public void AuthenticationFunction()
        {
            try
            {
                string login = inputLogin.Text;
                string password = inputPassword.Text;

                if (UserController.MatchAuthentication(login, password))
                {
                    if (welcome)
                    {
                        Program.user.Login = login;
                        Program.user.Password = password;

                        Program.welcome.Visible = false;
                        Program.form = new Home();
                        Program.form.Show();
                    }
                    else if (addClient)
                    {
                        (Program.formInsert = new Insert(null, true)).Show();
                    }
                    else if (string.IsNullOrEmpty(removeClient))
                    {
                        (Program.formInsert = new Insert(client, false)).Show();
                    }
                    else
                    {
                        if (ClientController.RemoveClient(removeClient))
                        {
                            ClientController.LoadClients();
                        }
                    }
                    Close();
                }
                else
                {
                    statusLabel.Visible = true;
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Usuário/Senha inválidos.";
                }
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro ao abrir edição de cliente.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
            }
        }
    }
}
