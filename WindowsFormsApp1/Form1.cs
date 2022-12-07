using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] sibs = { "Andrew", "Ej", "Michelle", "John" };
            //var sibAge = new string[4, 1]
            //{
            //    {"39"},
            //    {"38"},
            //    {"48"},
            //    {"31"}
            //};
            //string[] sibs = { "Andrew", "Ej", "Michelle", "John" };
            ////for (int i = 0; i < sibAge.Length; i++)

            //for (int row = 0; row < 4; row++)

            //{
            //    //int rank = i + 1;
            //    textBox1.Text = textBox1.Text + (sibAge[1,0]);

            //List<string> sibs = new List<string>();
            //sibs.Add("Andrew");
            //sibs.Add("Ej");
            //sibs.Add("Michelle");
            //sibs.Add("John");

            //var andrew = sibs[0];
            //var ej = sibs[1];
            //var michelle = sibs[2];
            //var andrewjohn= sibs[3];

            var siblist = new SortedDictionary<string, int>
            {
                {"Andrew", 39},
                {"Ej", 38},
                {"Michelle", 48},
                {"John", 31},
            };

            //siblist[5] = "Dexter";
            //siblist[6] = "Michael";

            //siblist.Add(8, "Jason");

            foreach (var kvp in siblist)
            {
                //textBox1.Text = textBox1.Text + (siblist["John"]);
                textBox1.Text = $"Sibling: {kvp.Key}, Age: {kvp.Value}";
            }

            }
    }
    }

