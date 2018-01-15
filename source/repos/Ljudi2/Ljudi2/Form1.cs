using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ljudi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tableLayoutPanel2.ColumnCount = 4;
            //tableLayoutPanel2.RowCount = 100;
            //tableLayoutPanel2.Controls.Add(new Label() { Text = "Id" },1,0);
            //tableLayoutPanel2.Controls.Add(new Label() { Text = "First Name" }, 2, 0);
            //tableLayoutPanel2.Controls.Add(new Label() { Text = "Last Name" }, 3, 0);
            //tableLayoutPanel2.Controls.Add(new Label() { Text = "Age" }, 4, 0);

            DatabaseBroker selektovani = new DatabaseBroker();
            List<Person> listaselektovanih = selektovani.SelectAll();

            dataGridView1.DataSource = listaselektovanih;

       

            //foreach (DataGridViewColumn column in dataGridView1.Columns)
            //{

            //    column.SortMode = DataGridViewColumnSortMode.Automatic;
            //}

            //for (int i = 0; i < listaselektovanih.Count(); i++)
            //{
            //    tableLayoutPanel2.RowCount = tableLayoutPanel2.RowCount + 1;
            //    tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            //    tableLayoutPanel2.Controls.Add(new Label() { Text = listaselektovanih[i].Id.ToString() }, 1, tableLayoutPanel2.RowCount - 1);
            //    tableLayoutPanel2.Controls.Add(new Label() { Text = listaselektovanih[i].FirstName.ToString() }, 2, tableLayoutPanel2.RowCount - 1);
            //    tableLayoutPanel2.Controls.Add(new Label() { Text = listaselektovanih[i].LastName.ToString() }, 3, tableLayoutPanel2.RowCount - 1);
            //    tableLayoutPanel2.Controls.Add(new Label() { Text = listaselektovanih[i].Age.ToString() }, 3, tableLayoutPanel2.RowCount - 1);
            //}

            //for (int i = 0; i < listaselektovanih.Count(); i++)
            //{
            //    textBox4.Text = "ID: " + listaselektovanih[i].Id + " First Name " + listaselektovanih[i].FirstName +
            //         "Last Name: " + listaselektovanih[i].LastName + " Age: " + listaselektovanih[i].Age;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ime = textBox1.Text;
            String prezime = textBox2.Text;

            int godine = Int32.Parse(textBox3.Text.ToString());

            DatabaseBroker noviljudi = new DatabaseBroker();
            int rowsAffected = noviljudi.Insert(ime, prezime, godine);

            if (rowsAffected == 1)
            {
                MessageBox.Show("Uspesno uneta osoba");

            }

            else {
                MessageBox.Show("Neuspesno dodavanje");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{
        //    DatabaseBroker selektovani = new DatabaseBroker();
        //      List<Person> listaselektovanih = selektovani.SelectAll();
        //}

        private void button2_Click_1(object sender, EventArgs e)
        {
            DatabaseBroker selektovani = new DatabaseBroker();
            List<Person> listaselektovanih = selektovani.SelectAll();
            dataGridView1.Refresh();
            dataGridView1.Update();
           
        }
    }
}
