using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facebookIL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"all.txt");
            
            string name = "";
            string fname = "";
            string city = "";
            string ctovet = "";
            string id="";
            int match = 0;
           String city1 = textBox1.Text;
           String id1 = textBox2.Text;
           String fname1 = textBox3.Text;
           String name1 = textBox4.Text;
           String ctovet1 = textBox5.Text;

            for (int i = 0; i < lines.Length; i++)
            {
                String[] arr = lines[i].Split(",");
                name = arr[0];
                fname = arr[1];
                id = arr[2];
                city = arr[3];
                ctovet = arr[5];
                int[] arr3 = { 0,0,0,0,0  };

                if (id == id1)
                {
                    richTextBox1.Text += name + "," + fname + "," + id + "," + city + "," + ctovet + " \n";
                    break;
                }
         
                if (name1 == name &&fname==fname1 && name1 != "" && fname1 != "")
                {
                    richTextBox1.Text += name + "," + fname + "," + id + "," + city + "," + ctovet + " \n";

                }
                if (ctovet == ctovet1&&ctovet1!= "")
                {
                    richTextBox1.Text += name + "," + fname + "," + id + "," + city + "," + ctovet + " \n";
                }
                if(city==city1 && city1 != "")
                {
                    richTextBox1.Text += name + "," + fname + "," + id + "," + city + "," + ctovet + " \n";
                }
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
