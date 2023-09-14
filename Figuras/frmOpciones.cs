using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class frmOpciones : Form
    {
        public frmOpciones()
        {
            InitializeComponent();
        }




        private void btnBi_Click(object sender, EventArgs e)
        {
            frmFigurasBidimensionales bi = new frmFigurasBidimensionales();
            bi.ShowDialog();
        }

        private void btnTri_Click(object sender, EventArgs e)
        {
            frmFigurasTridimensionales tri = new frmFigurasTridimensionales();
            tri.ShowDialog();
        }
    }
}
