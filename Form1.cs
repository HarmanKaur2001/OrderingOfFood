using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingOfFood
{
    public partial class Form1 : Form
    {
        public static string SetValueForText1 { get; internal set; }
        public static string SetValueForText2 { get; internal set; }
        public static string SetValueForText3 { get; internal set; }
        public static string SetValueForText4 { get; internal set; }
        public string SetValueForText5 { get; private set; }
        public static string SetValueForText6 { get; internal set; }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            SetValueForText2 = textBox2.Text;
            SetValueForText3 = textBox3.Text;
            SetValueForText4 = textBox4.Text;
            SetValueForText5 = textBox5.Text;
            SetValueForText6 = textBox6.Text;

            Form2 frm2 = new Form2();
            frm2.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
