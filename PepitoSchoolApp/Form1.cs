using PepitoSchoolApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PepitoSchoolApp
{
    public partial class Form1 : Form
    {
        List<Estudiante> listaestudiante = new List<Estudiante>();

        Estudiante estudiante;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estudiante = new Estudiante(int.Parse(txtID.Text), txtNombre.Text, txtApellido.Text, txtCarnet.Text, int.Parse(txtPhone.Text), txtDireccion.Text, txtCorreo.Text, int.Parse(txtMat.Text), int.Parse(txtCont.Text), int.Parse(txtEsta.Text));

            listaestudiante.Add(estudiante);

            dgvEstudiante.DataSource = null;
            dgvEstudiante.DataSource = listaestudiante;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int not1, not2, not3, suma;
            not1 = int.Parse(txtMat.Text);
            not2 = int.Parse(txtCont.Text);
            not3 = int.Parse(txtEsta.Text);
            suma = not1 + not2 + not3;

            textBox1.Text= (suma/3).ToString();
        }
    }
}
