using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace arrayss
{
    public partial class Form1 : Form
    {
        string[] arrays = new string[5];
        int i;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (i < arrays.Length)
            {
                string inputText = textBox1.Text;


                arrays[i] = inputText;
                i++; 

                MessageBox.Show("values saved: " + inputText);

                

                textBox1.Clear();
                textBox1.Focus();

                
            }
            else
            {
                MessageBox.Show("Array is full. No more inputs can be saved.");
            }

            textBox2.Clear();
            string arrayss = string.Join(",", arrays);
            textBox2.AppendText(arrayss);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string allInputs = string.Join(Environment.NewLine, arrays);

            MessageBox.Show("All saved values:\n" + allInputs, "Values in array");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
