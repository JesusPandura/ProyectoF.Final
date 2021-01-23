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
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();

         
        }

        private void consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosDataSet.ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.productosDataSet.ventas);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                actualizarcompras a = new actualizarcompras();
                
               
                    a.textBox9.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    a.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    a.textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    a.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    a.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    a.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    a.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    a.textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    a.textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                a.Show();
                   



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
          admin fm1 = new admin();
           
            fm1.Show();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ventasTableAdapter.Fill(this.productosDataSet.ventas);
        }
       
        private void button1_Click_1(object sender, EventArgs e)

        {
           
                var mensaje = funciones3.eliminar(Int32.Parse(textBox1.Text));
                MessageBox.Show(mensaje);

                this.ventasTableAdapter.Fill(this.productosDataSet.ventas);
           
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.ventasTableAdapter.Fill(this.productosDataSet.ventas);
        }
    }
}
