using Parcial.Libreria.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial.frm.Forms
{
    public partial class VerListaFecha : Form
    {
        Presentismo presentismo;
        public VerListaFecha(Presentismo presentismo)
        {
            this.presentismo = presentismo;
            InitializeComponent();
        }

        private void dtpFecha_CloseUp(object sender, EventArgs e)
        {
            string texto = "";
            List<Asistencia> asistencias = presentismo.asists;
                foreach(Asistencia asistencia in asistencias)
                {
                    texto += $"{asistencia.ToString()} \n";
                }
                lblRes.Text = texto;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
