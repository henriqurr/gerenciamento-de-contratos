using System.Windows.Forms;

namespace LawyersClient.Assets.Helper
{
    public class LogHelper
    {
        public static void Message(string text, MessageBoxIcon icon)
        {
            try
            {
                MessageBox.Show(text, Application.ProductName, MessageBoxButtons.OK, icon);
            }
            catch
            {
            }
        }

        public static DialogResult Question(string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            try
            {
                return MessageBox.Show(text, Application.ProductName, buttons, icon);
            }
            catch
            {
            }
            return DialogResult.OK;
        }
    }
}
