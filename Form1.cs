using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void rdBttHombre_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            String nombre = tbNombre.Text;
            String apellido = tbApellido.Text;
            String edad = tbEdad.Text;
            String estatura = tbEstatura.Text;
            String telefono = tbTelefono.Text;
            String genero = "";
            if (rdBttHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rdBttMujer.Checked)
            {
                genero = "Mujer";
            }
            String datos = $"Nombre: {nombre}\r\nApellido: {apellido}\r\nEdad: {edad}\r\nEstatura: {estatura}\r\nTelefono: {telefono}\r\nGenero: {genero}";
            String rutaArchivo = "C:/Users/AlanAltunar/Documents/Temporal/datos.txt";
            Boolean archivoExiste = File.Exists(rutaArchivo);
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine(datos);
                }
                else
                {
                    writer.WriteLine();
                }
            }
            MessageBox.Show("Datos guardados con exito:\r\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bttBorrar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellido.Clear();
            tbEdad.Clear();
            tbTelefono.Clear();
            tbEstatura.Clear();
            rdBttHombre.Checked = false;
            rdBttMujer .Checked = false;
        }
    }
}
