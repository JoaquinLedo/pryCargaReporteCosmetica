using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCargaReporte
{
    public partial class frmCargaReporte : Form
    {
        public frmCargaReporte()
        {
            InitializeComponent();
            OcultarGroupBox();
        }
        private void OcultarGroupBox()
        {
            gbInasistencia.Visible = false;
            gbAmonestaciones.Visible = false;
            gbSuspensión.Visible = false;
            gbEvaluaciónDesempeño.Visible = false;
        }
        private void btnInasistencia_Click(object sender, EventArgs e)
        {
            OcultarGroupBox();
            gbInasistencia.Visible = true;
        }

        private void btnAmonestaciones_Click(object sender, EventArgs e)
        {
            OcultarGroupBox();
            gbAmonestaciones.Visible = true;
        }

        private void btnSuspensiones_Click(object sender, EventArgs e)
        {
            OcultarGroupBox();
            gbSuspensión.Visible = true;
           
        }

        private void btnEvaluaciónDesempeño_Click(object sender, EventArgs e)
        {
            OcultarGroupBox();
            gbEvaluaciónDesempeño.Visible = true;
            
        }


    }
}
