using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteGUI
{
    public partial class ClioGUI : Form
    {
        public ClioGUI()
        {
            InitializeComponent();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int ancho = this.ClientSize.Width;
            int alto = this.ClientSize.Height;
            panel2.Top = alto / 2 - 75;
            panel2.Left = ancho / 2 - 135;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
