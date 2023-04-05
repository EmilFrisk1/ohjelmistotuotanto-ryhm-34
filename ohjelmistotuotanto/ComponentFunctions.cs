using Org.BouncyCastle.Asn1.Crmf;
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

        public static Button CreateButton(Control container, string text, Font font, int tabI, Point loc, Size sz, string name, Color clr, Color bc, EventHandler mouseEnterEventHandler, EventHandler mouseLeaveEventHandler)
        {
            var button = new Button();
            button.Text = text; // styles
            button.Font = font;
            button.TabIndex = tabI;
            button.Location = loc;
            button.Size = sz;
            button.Name = name;
            button.ForeColor = clr;
            button.BackColor = bc;

            button.MouseEnter += mouseEnterEventHandler; // Add events
            button.MouseLeave += mouseLeaveEventHandler;

            container.Controls.Add(button);
            return button;
        }

        public static Label CreateLabel(Control container, Color fc, string txt, Font font, int tabI, Point loc, string name, bool isErrorLbl = false, bool bc = false)
        {
            var label = new Label();
            label.Font = font;
            label.TabIndex = tabI;
            label.Text = txt;
            label.Location = loc;
            label.AutoSize = true;
            label.Name = name;
            label.ForeColor = fc;

            if (bc)
            {
                label.BackColor = Color.Transparent; 
            } else
            {
                label.BackColor = SystemColors.Control; // default
            }

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

        public static PictureBox CreatePrevButton(Control container, Point loc, Size sz)
        { // get projectDir
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;


            PictureBox prevButton = new PictureBox();
            prevButton.Name = "prevBtn";
            prevButton.BackColor = Color.Transparent;
            prevButton.Size = sz;
            prevButton.Location = loc;
            string imageLocation;
            string imagePath = projectDirectory + "\\img\\arrow_back.png"; // TODO - tähän vois ettii jonkun hienomman nuolen vaikka joku puinen nuoli menis hyvin teemaan, jos ois viel silverin värinen nii sopis teksiten kaa hyvin
            prevButton.Image = System.Drawing.Image.FromFile(imagePath);
            prevButton.Click += new EventHandler(ComponentEvents.ClickPrevArr);
            //prevButton.MouseEnter += new EventHandler(HoverEnterPrevArr);
            //prevButton.MouseLeave += new EventHandler(HoverLeavePrevArr);
            container.Controls.Add(prevButton);
            prevButton.Hide();

            return prevButton;
        }
    }
}
