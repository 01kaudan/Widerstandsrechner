using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Widerstände
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void farbring1_SelectedIndexChanged(object sender, EventArgs e)
        {
            farbring1.SelectedItem.ToString();
            
            
        }

        private void farbring2_SelectedIndexChanged(object sender, EventArgs e)
        {
            farbring2.SelectedItem.ToString();
           
            
        }

        private void farbring3_SelectedIndexChanged(object sender, EventArgs e)
        {
            farbring3.SelectedItem.ToString();
           
            
        }

        private void Toleranz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Toleranz.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

        }

        
        public void berechnung()

        {
            int a = 0;
            int zahl;
            string ergebnis; 
            
            
            
            if (farbring3.SelectedText.ToString() == "0")
            {

                 farbring3.SelectedIndex = 1;
                 a = Convert.ToInt32(farbring3.SelectedIndex);
                 
            }

            if (farbring3.SelectedText.ToString() == "1")
            {

                farbring3.SelectedIndex = 10;
                a = Convert.ToInt32(farbring3.SelectedIndex);

            }
            if (farbring3.SelectedText.ToString() == "2")
            {

                farbring3.SelectedIndex = 100;
                a = Convert.ToInt32(farbring3.SelectedIndex);

            }

            if (farbring3.SelectedText.ToString() == "3")
            {

                farbring3.SelectedIndex = 1000;
                a = Convert.ToInt32(farbring3.SelectedIndex);

            }

            if (farbring3.SelectedText.ToString() == "4")
            {

                farbring3.SelectedIndex = 10000;
                a = Convert.ToInt32(farbring3.SelectedIndex);

            }

            if (farbring3.SelectedText.ToString() == "5")
            {

                farbring3.SelectedIndex = 100000;
                a = Convert.ToInt32(farbring3.SelectedIndex);

            }

            if (farbring3.SelectedText.ToString() == "6")
            {

                farbring3.SelectedIndex = 1000000;
                a = Convert.ToInt32(farbring3.SelectedIndex);

            }

            if (farbring3.SelectedText.ToString() == "7")
            {

                farbring3.SelectedIndex = 10000000;
                a = Convert.ToInt32(farbring3.SelectedIndex);

            }

            if (farbring3.SelectedText.ToString() == "8")
            {

                farbring3.SelectedIndex = 100000000;
                a = Convert.ToInt32(farbring3.SelectedIndex);

            }

            if (farbring3.SelectedText.ToString() == "9")
            {

                farbring3.SelectedIndex = 1000000000;
                a = Convert.ToInt32(farbring3.SelectedIndex);

            }

           


            textBox1.Text = farbring1.SelectedIndex.ToString() + farbring2.SelectedIndex.ToString();
            zahl = Convert.ToInt32(textBox1.Text);
            a = a * zahl;

            ergebnis = Convert.ToString(a);
            ergebnis = textBox1.Text; 


        }
        

        private void berechnen_Click(object sender, EventArgs e)
        {
            berechnung();
        }
    }
}
