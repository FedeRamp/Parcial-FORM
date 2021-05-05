using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial.Libreria.Clases;

namespace Parcial.frm
{
    public partial class AddAlumnoForm : Form
    {
        Presentismo presentismo;

        public AddAlumnoForm(Presentismo presentismo)
        {
            InitializeComponent();
            this.presentismo = presentismo;
        }

        private void AddAlumnoForm_Load(object sender, EventArgs e)
        {
            CodTipoAlumno tipoOyente = new CodTipoAlumno(1, "OYENTE");
            CodTipoAlumno tipoRegular = new CodTipoAlumno(2, "REGULAR");
            CodTipoAlumno tipoSelect = new CodTipoAlumno(0, "SELECCIONE");
            List<CodTipoAlumno> tiposAlumno = new List<CodTipoAlumno>();
            tiposAlumno.Add(tipoSelect);
            tiposAlumno.Add(tipoRegular);
            tiposAlumno.Add(tipoOyente);

            this.cmbTipoAlumno.DataSource = tiposAlumno;
            this.cmbTipoAlumno.ValueMember = "Codigo";
            this.cmbTipoAlumno.DisplayMember = "Descripcion";
        }

        private void Validar()
        {
            if ((string)cmbTipoAlumno.SelectedText == "SELECCIONE")
                throw new Exception("Seleccione un tipo de alumno");
            if (txtNombre.Text == "")
                throw new Exception("Nombre es obligatorio");
            if (txtApellido.Text == "")
                throw new Exception("Apellido es obligarotio");
            if (txtRegistro.Text == "")
                throw new Exception("Registro es obligatorio");
            if ((int)cmbTipoAlumno.SelectedValue == 2 && txtEmail.Text == "")
                throw new Exception("Email es obligatorio");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                if ((int)cmbTipoAlumno.SelectedValue == 1)
                {
                    int registro = int.Parse(this.txtRegistro.Text);
                    string nombre = this.txtNombre.Text;
                    string apellido = this.txtApellido.Text;
                    AlumnoOyente oyente = new AlumnoOyente(registro, nombre, apellido);
                    presentismo.AddAlumno(oyente);
                    Limpiar();
                } else if((int)cmbTipoAlumno.SelectedValue == 2)
                {
                    int registro = int.Parse(this.txtRegistro.Text);
                    string nombre = this.txtNombre.Text;
                    string apellido = this.txtApellido.Text;
                    string email = this.txtEmail.Text;
                    AlumnoRegular regular = new AlumnoRegular(registro, nombre, apellido, email);
                    presentismo.AddAlumno(regular);
                    Limpiar();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Limpiar()
        {
            this.txtEmail.Text = "";
            this.txtApellido.Text = "";
            this.txtNombre.Text = "";
            this.txtRegistro.Text = "";
            this.cmbTipoAlumno.SelectedIndex = 0;

        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void txtRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void cmbTipoAlumno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((int)cmbTipoAlumno.SelectedValue == 1)
            {
                txtEmail.Hide();
                lblEmail.Hide();
            }
            else if((int)cmbTipoAlumno.SelectedValue == 2)
            {
                txtEmail.Show();
                lblEmail.Show();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
