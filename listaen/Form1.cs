using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Alumno> ListaAlumno;
        Alumno alumno = new Alumno();
        public void limpiar()
        {
            txtApellidoMaterno.Clear();
            txtApellidoPaterno.Clear();
            txtmatricula.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cargarcombo();
            }
            catch
            {
                MessageBox.Show("No existe el archivo");
            }
        }
        public void cargarcombo()
        {
            alumno = new Alumno();
            ListaAlumno = new List<Alumno>(alumno.LeerArchivo());
            cmb.DataSource = ListaAlumno;
            cmb.ValueMember = "matricula";
            cmb.DisplayMember = "nombre";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            foreach(Alumno AlumnoImprime in ListaAlumno)
            {
                rtb.Text = rtb.Text + AlumnoImprime.Matricula + " " + AlumnoImprime.Nombre + " " +
                    AlumnoImprime.ApellidoPaterno+" "+ AlumnoImprime.ApellidoMaterno+" "+ AlumnoImprime.Direccion+"\n";
                    
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            alumno = new Alumno(txtmatricula.Text, txtNombre.Text, txtApellidoPaterno.Text,txtApellidoMaterno.Text, txtDireccion.Text);
            if (alumno.Guardar()==true)
            {
                cargarcombo();
                limpiar();
                MessageBox.Show("Registro Guardado");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmatricula.Text = cmb.SelectedValue.ToString();
            txtNombre.Text =cmb.SelectedValue.ToString();
            txtApellidoMaterno.Text = cmb.SelectedValue.ToString();
            txtApellidoPaterno.Text = cmb.SelectedValue.ToString();
            txtDireccion.Text = cmb.SelectedValue.ToString();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
