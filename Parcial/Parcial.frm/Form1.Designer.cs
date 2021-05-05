
namespace Parcial.frm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTomarLista = new System.Windows.Forms.Button();
            this.btnVerLista = new System.Windows.Forms.Button();
            this.btnAddAlumno = new System.Windows.Forms.Button();
            this.btnAddPreceptor = new System.Windows.Forms.Button();
            this.cmbPreceptores = new System.Windows.Forms.ComboBox();
            this.lblPrecActivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTomarLista
            // 
            this.btnTomarLista.Location = new System.Drawing.Point(186, 118);
            this.btnTomarLista.Name = "btnTomarLista";
            this.btnTomarLista.Size = new System.Drawing.Size(147, 51);
            this.btnTomarLista.TabIndex = 0;
            this.btnTomarLista.Text = "Tomar Lista";
            this.btnTomarLista.UseVisualStyleBackColor = true;
            this.btnTomarLista.Click += new System.EventHandler(this.btnTomarLista_Click);
            // 
            // btnVerLista
            // 
            this.btnVerLista.Location = new System.Drawing.Point(186, 200);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(147, 51);
            this.btnVerLista.TabIndex = 1;
            this.btnVerLista.Text = "Ver Lista";
            this.btnVerLista.UseVisualStyleBackColor = true;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // btnAddAlumno
            // 
            this.btnAddAlumno.FlatAppearance.BorderSize = 0;
            this.btnAddAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlumno.Location = new System.Drawing.Point(50, 289);
            this.btnAddAlumno.Name = "btnAddAlumno";
            this.btnAddAlumno.Size = new System.Drawing.Size(140, 33);
            this.btnAddAlumno.TabIndex = 2;
            this.btnAddAlumno.Text = "Añadir Alumno";
            this.btnAddAlumno.UseVisualStyleBackColor = true;
            this.btnAddAlumno.Click += new System.EventHandler(this.btnAddAlumno_Click);
            // 
            // btnAddPreceptor
            // 
            this.btnAddPreceptor.BackColor = System.Drawing.Color.White;
            this.btnAddPreceptor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddPreceptor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddPreceptor.FlatAppearance.BorderSize = 0;
            this.btnAddPreceptor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPreceptor.Location = new System.Drawing.Point(331, 289);
            this.btnAddPreceptor.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPreceptor.Name = "btnAddPreceptor";
            this.btnAddPreceptor.Size = new System.Drawing.Size(140, 33);
            this.btnAddPreceptor.TabIndex = 3;
            this.btnAddPreceptor.Text = "Añadir Preceptor";
            this.btnAddPreceptor.UseVisualStyleBackColor = false;
            // 
            // cmbPreceptores
            // 
            this.cmbPreceptores.FormattingEnabled = true;
            this.cmbPreceptores.Location = new System.Drawing.Point(50, 30);
            this.cmbPreceptores.Name = "cmbPreceptores";
            this.cmbPreceptores.Size = new System.Drawing.Size(121, 21);
            this.cmbPreceptores.TabIndex = 4;
            this.cmbPreceptores.SelectionChangeCommitted += new System.EventHandler(this.cmbPreceptores_SelectionChangeCommitted);
            // 
            // lblPrecActivo
            // 
            this.lblPrecActivo.AutoSize = true;
            this.lblPrecActivo.Location = new System.Drawing.Point(50, 13);
            this.lblPrecActivo.Name = "lblPrecActivo";
            this.lblPrecActivo.Size = new System.Drawing.Size(86, 13);
            this.lblPrecActivo.TabIndex = 5;
            this.lblPrecActivo.Text = "Preceptor Activo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 370);
            this.Controls.Add(this.lblPrecActivo);
            this.Controls.Add(this.cmbPreceptores);
            this.Controls.Add(this.btnAddPreceptor);
            this.Controls.Add(this.btnAddAlumno);
            this.Controls.Add(this.btnVerLista);
            this.Controls.Add(this.btnTomarLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTomarLista;
        private System.Windows.Forms.Button btnVerLista;
        private System.Windows.Forms.Button btnAddAlumno;
        private System.Windows.Forms.Button btnAddPreceptor;
        private System.Windows.Forms.ComboBox cmbPreceptores;
        private System.Windows.Forms.Label lblPrecActivo;
    }
}

