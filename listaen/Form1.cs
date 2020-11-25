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
            textAMater.Clear();
            textApater.Clear();
            textmatri.Clear();
            textnombre.Clear();
            textDirecc.Clear();
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
            comboBox1.DataSource = ListaAlumno;
            comboBox1.ValueMember = "matricula";
            comboBox1.DisplayMember = "nombre";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            foreach(Alumno AlumnoImprime in ListaAlumno)
            {
                richlista.Text = richlista.Text + AlumnoImprime.Matricula + " " + AlumnoImprime.Nombre + " " +
                    AlumnoImprime.ApellidoPaterno+" "+ AlumnoImprime.ApellidoMaterno+" "+ AlumnoImprime.Direccion+"\n";
                    
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            alumno = new Alumno(textmatri.Text, textnombre.Text, textApater.Text,textAMater.Text, textDirecc.Text);
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
            textmatri.Text = comboBox1.SelectedValue.ToString();
            textnombre.Text =comboBox1.SelectedValue.ToString();
            textAMater.Text = comboBox1.SelectedValue.ToString();
            textApater.Text = comboBox1.SelectedValue.ToString();
            textDirecc.Text = comboBox1.SelectedValue.ToString();
        }

        
    }
}
