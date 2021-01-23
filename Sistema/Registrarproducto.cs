using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Registrarproducto : Form
    {
        public Registrarproducto()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mensaje = funciones2.insertar(textBox1.Text, textBox2.Text,textBox5.Text);
            MessageBox.Show(mensaje);
            dataGridView1.DataSource = funciones2.mostrar();
            textBox3.Visible = false;
            label3.Visible = false;

            nombrelb.Visible = false;
            textBox1.Visible = false;

            preciolb.Visible = false;
            textBox2.Visible = false;

            cantidadlb.Visible = false;
            textBox5.Visible = false;

            actualizarbtn.Visible = false;
            registrarbtn.Visible = false;
            Eliminarb.Visible = false;

            //limpiar
            textBox3.Clear();
           
            textBox1.Clear();

            textBox2.Clear();

            textBox5.Clear();

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = funciones2.mostrar();

            textBox3.Visible = false;
            label3.Visible = false;

            nombrelb.Visible = false;
            textBox1.Visible = false;

            preciolb.Visible = false;
            textBox2.Visible = false;

            cantidadlb.Visible = false;
            textBox5.Visible = false;

            actualizarbtn.Visible = false;
            registrarbtn.Visible = false;
            Eliminarb.Visible = false;

            //limpiar
            textBox3.Clear();

            textBox1.Clear();

            textBox2.Clear();

            textBox5.Clear();







        }

        private void Registrarproducto_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mensaje = funciones2.eliminar(Int32.Parse(textBox3.Text));
            MessageBox.Show(mensaje);
            dataGridView1.DataSource = funciones2.mostrar();
            textBox3.Visible = false;
            label3.Visible = false;

            nombrelb.Visible = false;
            textBox1.Visible = false;

            preciolb.Visible = false;
            textBox2.Visible = false;

            cantidadlb.Visible = false;
            textBox5.Visible = false;

            actualizarbtn.Visible = false;
            registrarbtn.Visible = false;
            Eliminarb.Visible = false;


            textBox3.Clear();

            textBox1.Clear();

            textBox2.Clear();

            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var mensaje = funciones2.actualizar(Int32.Parse(textBox3.Text), textBox1.Text, textBox2.Text, textBox5.Text);
            MessageBox.Show(mensaje);

            dataGridView1.DataSource = funciones2.mostrar();
            textBox3.Visible = false;
            label3.Visible = false;

            nombrelb.Visible = false;
            textBox1.Visible = false;

            preciolb.Visible = false;
            textBox2.Visible = false;

            cantidadlb.Visible = false;
            textBox5.Visible = false;

            actualizarbtn.Visible = false;
            registrarbtn.Visible = false;
            Eliminarb.Visible = false;

            textBox3.Clear();

            textBox1.Clear();

            textBox2.Clear();

            textBox5.Clear();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //id y su campo
            textBox3.Visible = true;
            label3.Visible = true;
            
            nombrelb.Visible = true;
            textBox1.Visible = true;

            preciolb.Visible = true;
            textBox2.Visible = true;

            cantidadlb.Visible = true;
            textBox5.Visible = true;

            actualizarbtn.Visible = true;
            registrarbtn.Visible = false;
            Eliminarb.Visible = false;
            //limpiar
            textBox3.Clear();

            textBox1.Clear();

            textBox2.Clear();

            textBox5.Clear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            label3.Visible = true;

            Eliminarb.Visible = true;

            nombrelb.Visible = false;
            textBox1.Visible = false;

            preciolb.Visible = false;
            textBox2.Visible = false;
            cantidadlb.Visible = false;
            textBox5.Visible = false;
            actualizarbtn.Visible = false;
            registrarbtn.Visible = false;
            //limpiar
            textBox3.Clear();

            textBox1.Clear();

            textBox2.Clear();

            textBox5.Clear();
        }

        private void regis_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            label3.Visible = false;
            actualizarbtn.Visible = false;
            Eliminarb.Visible = false;

            nombrelb.Visible = true;
            textBox1.Visible = true;

            preciolb.Visible = true;
            textBox2.Visible = true;

            cantidadlb.Visible = true;
            textBox5.Visible = true;
            registrarbtn.Visible = true;
            //limpiar
            textBox3.Clear();

            textBox1.Clear();

            textBox2.Clear();

            textBox5.Clear();
        }
    }
}
