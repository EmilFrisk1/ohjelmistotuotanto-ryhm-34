using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohjelmistotuotanto
{
    public static class Utility
    {
        public static void UpdateStatusStripText(string text, StatusStrip statusStrip)
        {
            foreach (ToolStripItem item in statusStrip.Items)
            {
                if (item.Name == "statusStripText" && item is ToolStripStatusLabel label)
                {
                    // Do something with the ToolStripStatusLabel
                    label.Text = text;
                }
            }
        }

        public static void HideErrors(StatusStrip statusStrip = null)
        {
            if (statusStrip != null)
                if (statusStrip.Visible) statusStrip.Visible = false;
        }


        public static void DefaultStatusStrip(StatusStrip statusStrip = null)
        {
            if (statusStrip != null)
            {
                UpdateStatusStripText("Täytä kaikki pakolliset kentät(*)", statusStrip);
            }
        }
    }
}
