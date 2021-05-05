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
    public partial class TomarListaForm : Form
    {
        Presentismo presentismo;
        List<Array> checks;
        public TomarListaForm(Presentismo presentismo)
        {
            InitializeComponent();
            checks = new List<Array>();
            this.presentismo = presentismo;
        }

        public void Limpiar()
        {
            foreach(Object[] arr in checks)
            {
                CheckBox chBox = (CheckBox)arr[1];
                chBox.Checked = false;
            }
            this.dtpFecha.Value = DateTime.Today;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!presentismo.AsistenciaRegistrada(this.dtpFecha.ToString()))
            {
                List<Asistencia> asistencias = new List<Asistencia>();
                foreach (Object[] array in checks)
                {
                    Alumno alumno = (Alumno)array[0];
                    CheckBox box = (CheckBox)array[1];
                    Asistencia asistencia = new Asistencia(dtpFecha.Value, alumno, presentismo.GetPreceptorActivo(), box.Checked);
                    asistencias.Add(asistencia);
                }
                presentismo.AgregarAsistencia(asistencias);
                Limpiar();
            } else
            {
                MessageBox.Show("Esa fecha ya esta registrada");
            }
        }

        private void TomarListaForm_Load(object sender, EventArgs e)
        {
            int limit = this.lblPresente.Location.Y;
            for(int i = 0; i < presentismo.GetListaAlumnos().Count; i++)
            {
                Alumno alumno = presentismo.GetListaAlumnos()[i];

                CheckBox chBox = new System.Windows.Forms.CheckBox();
                chBox.Text = alumno.ToString();
                chBox.Location = new System.Drawing.Point(100,(limit + i*20));
                chBox.Size = new System.Drawing.Size(50, 50);
                chBox.AutoSize = true;
                chBox.Name = "chbox" + i;
                chBox.TabIndex = i;
                Object[] arr = {alumno, chBox };
                checks.Add(arr);
                this.Controls.Add(chBox);
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
