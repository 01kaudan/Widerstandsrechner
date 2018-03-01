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
            int a; 
           
            if (farbring3.SelectedIndex.ToString() == "0")
            {

                 farbring3.SelectedIndex = 1;
                 a = Convert.ToInt32(farbring3);

            }
            
            int zahl;


            textBox1.Text = farbring1.SelectedIndex.ToString() + farbring2.SelectedIndex.ToString();

            zahl = Convert.ToInt32(textBox1);

            a = a * zahl; 
             


        }
        

        private void berechnen_Click(object sender, EventArgs e)
        {
            berechnung();
        }
    }
}
