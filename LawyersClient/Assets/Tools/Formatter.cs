using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyersClient.Assets.Tools
{
    public static class Formatter
    {
        public static string FormatNumber(string Number)
        {
            try
            {
              
                Number = Number.Trim().Replace("-", "").Replace("+", "");
            }
            catch
            {
            }

            return Number;
        }
    }
}
