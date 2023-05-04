using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ohjelmistotuotanto
{
    public static class TextBoxUtility
    {
        public static bool AllowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"^[0-9 ]*\.?[0-9 ]*$") || e.KeyChar == (char)8)
            {
                if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                    return true;
                }
                else
                {
                    e.Handled = false;
                    return false;
                }
            }
            else
            {
                e.Handled = true;
                return true;
            }
        }

        public static bool MaxLength(object sender, KeyPressEventArgs e, int maxLen)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.Length >= maxLen && e.KeyChar != (char)8) {
                e.Handled = true;
                return false;
            } else
            {
                e.Handled = false;
                return true;
            }
        }
    }
}
