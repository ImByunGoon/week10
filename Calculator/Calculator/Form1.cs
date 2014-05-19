using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    

    public partial class Form1 : Form
    {


        CalInfo calinfo = new CalInfo();

        public Form1()
        {
            InitializeComponent();
            textBox1.Text += 0;
            calinfo.Result = 0;
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumAction(int n)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += n;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NumAction(1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumAction(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumAction(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumAction(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumAction(5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumAction(6);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumAction(7);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumAction(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumAction(9);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NumAction(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            calinfo.Result = 0;
            textBox1.Text += 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calinfo.Result += Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            textBox1.Text += '+';
            

        }

        private void button13_Click(object sender, EventArgs e)
        {
            calinfo.Result += Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            textBox1.Text += calinfo.Result;
        }
    }

    class CalInfo
    {
        private int temp;
        private int result;

        public int Temp
        {
            get;
            set;
        }

        public int Result
        {
            get;
            set;
        }
    }
}
