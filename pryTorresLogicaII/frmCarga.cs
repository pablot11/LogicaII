using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTorresLogicaII
{
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lstProducto.SelectedIndex == 0)
            {
                frmCargaTornillo objVentanaCargaTornillo = new frmCargaTornillo();
                objVentanaCargaTornillo.ShowDialog();
            }
            else
            {
                frmCargaTuercas objVentanaCargaTuercas = new frmCargaTuercas();
                objVentanaCargaTuercas.ShowDialog();
            }
        }
    }
}
