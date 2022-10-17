using LawyersClient.Assets.Helper;
using System;
using System.Windows.Forms;

namespace LawyersClient.Assets.View
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Authentication auth = new(true);
                auth.Show();
            }
            catch (Exception ex)
            {
                LogHelper.Message($"Ocorreu um erro interno.{Environment.NewLine}{ex.Message}", MessageBoxIcon.Error);
            }
        }
    }
}
