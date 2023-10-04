using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<int> items = new List<int>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int value))
            {
                items.Add(value);
            }

            textBox1.Text = string.Empty;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int value))
            {
                var rnd = new Random(); 

                for (int i = 0; i < value; i++)
                {
                    items.Add(rnd.Next()); 
                }
            }

            textBox2.Text = string.Empty; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
