using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //testi 04.04
using System.Windows.Forms.VisualStyles;

namespace ohjelmistotuotanto
{
    class ComponentFunctions
    {

        public static Button CreateButton(string text, Font font, int tabI, Point loc, Size sz, string name, Color? backColor = null, Color? foreColor = null)
        {
            var button = new Button();
            button.Text = text;
            button.Font = font;
            button.TabIndex = tabI;
            button.Location = loc;
            button.Size = sz;
            button.Name = name;

            if (backColor.HasValue)
                button.BackColor = backColor.Value;

            if (foreColor.HasValue)
                button.ForeColor = foreColor.Value;
            return button;
        }

        public static Label CreateLabel(string name,Font font , int tabI, Point loc, string name2, bool isErrorLbl = false)
        {
            var label = new Label();
            label.Font = font;
            label.TabIndex = tabI;
            label.Text = name;
            label.Location = loc;
            label.AutoSize = true;
            label.Name = name2;
            if (isErrorLbl)
                label.ForeColor = Color.Red;
            return label;
        }

        public static TextBox CreateTextBox(Control container, int tabI, Point loc, Size sz, string name)
        {
            var tb = new TextBox();
            tb.TabIndex = tabI;
            tb.Location = loc;
            tb.Size = sz;
            tb.Name = name;
            container.Controls.Add(tb);

            return tb;
        }
    }
}
