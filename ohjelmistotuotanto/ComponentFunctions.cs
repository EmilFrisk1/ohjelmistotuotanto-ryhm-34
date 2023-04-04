using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //testi 04.04

namespace ohjelmistotuotanto
{
    class ComponentFunctions
    {

        public static Button CreateButton(Control container, string text, Font font, int tabI, Point loc, Size sz, string name)
        {
            var button = new Button();
            button.Text = text;
            button.Font = font;
            button.TabIndex = tabI;
            button.Location = loc;
            button.Size = sz;
            button.Name = name;
            container.Controls.Add(button);
            return button;
        }

        public static Label CreateLabel(Control container, string name, Font font, int tabI, Point loc, string name2, bool isErrorLbl = false)
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

            container.Controls.Add(label);

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
