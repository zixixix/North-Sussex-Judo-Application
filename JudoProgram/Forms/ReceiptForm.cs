using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JudoProgram
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void funcOnFocusLoss(object sender, EventArgs e)
        {
            
        }

        private void funcOnFormLoad(object sender, EventArgs e)
        {
            SendToBack();

        }

        public void funcMoveForm(object sender, EventArgs e, Form f)
        {
            Location = new Point(f.Location.X + Width, f.Location.Y);
        }

        private void funBtnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
