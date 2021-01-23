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
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();

         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {

            this.productoTableAdapter.Fill(this.productosDataSet.producto);

        }

        private void ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.productosDataSet.producto);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                

                textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                textBox8.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                textBox5.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                
              
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cantidad = textBox3.Text;
            string precio = textBox5.Text;
            

            double peka = Double.Parse(cantidad) * Double.Parse(precio);

           label4.Text = "El precio total es :"+ peka.ToString();

            label7.Text = "Su pago es: "+ textBox4.Text;

            double peki = peka - Double.Parse(textBox4.Text) ;
            label9.Text = "Su cambio es: " + peki.ToString();

            string miro = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            double com = Double.Parse(cantidad);
             Double qw = Double.Parse(miro);
            try
            {
                if(peka > Double.Parse(textBox4.Text))
                {
                    MessageBox.Show("error no hay tanto dinero");
                    label9.Text = "Su cambio es: erorr";
                    label7.Text = "Su pago es: error";
                    label4.Text = "El precio total es : error";
                }
                else
                {
                    
                    if (qw >= com)
                    {
                        var mensaje = funciones3.comprar(Session.usuario, textBox2.Text, textBox8.Text, textBox5.Text, textBox3.Text, textBox4.Text, peka.ToString(), peki.ToString());
                        MessageBox.Show(mensaje);

                        double q = (com - qw) * -1;
                        var mensaje1 = funciones2.actualizar(Int32.Parse(textBox2.Text), textBox8.Text, textBox5.Text, q.ToString());
                        MessageBox.Show(mensaje1);







                    }
                    else
                    {
                        MessageBox.Show("error no hay tanta cantidad de productos");
                        label9.Text = "Su cambio es: erorr";
                        label7.Text = "Su pago es: error";
                        label4.Text = "El precio total es : error";
                    }
                }

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cantidad = textBox3.Text;
            string precio = textBox5.Text;


            double peka = Double.Parse(cantidad) * Double.Parse(precio);

            label4.Text = "El precio total es :" + peka.ToString();

            label7.Text = "Su pago es: " + textBox4.Text;
            double peki = peka - Double.Parse(textBox4.Text);
            label9.Text = "Su cambio es: " + peki.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string cantidad = textBox3.Text;
            string precio = textBox5.Text;


            double peka = Double.Parse(cantidad) * Double.Parse(precio);

            label4.Text = "El precio total es :" + peka.ToString();

            label7.Text = "Su pago es: " + textBox4.Text;
            double peki = peka - Double.Parse(textBox4.Text);
            label9.Text = "Su cambio es: " + peki.ToString();
            button2.Visible = true;
        }
    }
}
