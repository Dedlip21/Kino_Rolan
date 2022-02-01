using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino_Rolan
{
    class AdminMenu
    {
        public FormStartPosition StartPosition { get; internal set; }
        public Size ClientSize { get; private set; }

        internal void Show()
        {
            this.ClientSize = new System.Drawing.Size(720, 500);

        }
    }
}
