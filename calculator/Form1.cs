using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string opt = "";
        string prevValue = "";
        private void calc(string opt) { 
            //operations perform 


            if (opt == "" || prevValue == "") {
                MessageBox.Show("Make sure you have selected the operation and provided both value", "Inavlid Input");
                return;
            }

              string cur = this.textBox1.Text.ToString();
            
              prevValue = prevValue.ToString();
              if (opt == "+") {
                int re=(Int16.Parse(prevValue) + Int16.Parse(cur));
                Console.WriteLine(re);
                this.textBox1.Text = re.ToString();
              }
              else if (opt == "-") {
                  int re = (Int16.Parse(prevValue) - Int16.Parse(cur));
                  Console.WriteLine(re);
                  this.textBox1.Text = re.ToString();
              }
              else if (opt == "/")
              {
                  try {
                      int re = (Int16.Parse(prevValue) / Int16.Parse(cur));
                      Console.WriteLine(re);
                      this.textBox1.Text = re.ToString();
                  }
                  catch (Exception ex) {
                      this.textBox1.Text = "Invalid Operation";
                  }
                  
              }
              else if (opt == "*")
              {
                  int re = (Int16.Parse(prevValue) * Int16.Parse(cur));
                  Console.WriteLine(re);
                  this.textBox1.Text = re.ToString();
              }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = textBox1.Text+"1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.textBox1.Text = this.textBox1.Text + "2";
         


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "8";
        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void my_button1(object sender, EventArgs e)
        {
            
            this.textBox1.Text =this.textBox1.Text+ "1";
         

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "7";
        }

     
        private void button0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {
            calc(opt);
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            opt = "+";
            prevValue = this.textBox1.Text.ToString();
            this.textBox1.Text="";
           
        }

        private void minus_click(object sender, EventArgs e)
        {
            opt = "-";
            prevValue = this.textBox1.Text.ToString();
            this.textBox1.Text = "";
        }

        private void mul_click(object sender, EventArgs e)
        {
            opt = "*";
            prevValue = this.textBox1.Text.ToString();
            this.textBox1.Text = "";

        }

        private void divide_click(object sender, EventArgs e)
        {
            opt = "/";
            prevValue = this.textBox1.Text.ToString();
            this.textBox1.Text = "";

        }

        private void clear_click(object sender, EventArgs e)
        {
            this.textBox1.Text="";
            opt = "";
                prevValue="";
        }
    }
}
