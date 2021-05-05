using Parcial.frm.Forms;
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

namespace Parcial.frm
{
    public partial class Form1 : Form
    {
        Presentismo presentismo;
        public Form1()
        {
            presentismo = new Presentismo();
            InitializeComponent();

        }

        private void btnTomarLista_Click(object sender, EventArgs e)
        {
            TomarListaForm tlf = new TomarListaForm(presentismo);
            tlf.Owner = this;
            tlf.Show();
            this.Hide();
        }

        private void btnAddAlumno_Click(object sender, EventArgs e)
        {
            AddAlumnoForm aaf = new AddAlumnoForm(presentismo);
            aaf.Owner = this;
            aaf.Show();
            this.Hide();
        }

        private void cmbPreceptores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if((int)this.cmbPreceptores.SelectedValue > 0)
            {
                presentismo.ActivarPreceptor((int)this.cmbPreceptores.SelectedValue);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbPreceptores.DataSource = presentismo.Preceptores;
            this.cmbPreceptores.ValueMember = "Legajo";
            this.cmbPreceptores.DisplayMember = "ToString()";
        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            VerListaFecha vlf = new VerListaFecha(presentismo);
            vlf.Owner = this;
            vlf.Show();
            this.Hide();
        }
    }
}
