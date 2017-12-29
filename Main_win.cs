using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NCalc.Domain;

namespace Calculator
{
    public partial class Main_win : Form
    {
        int number_base_in;
        int number_base_out;

        public Main_win()
        {

            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            number_base_in = 10;  // inicializace
            number_base_out = 10;  // inicializace

            //textBox_vystup.Font = new Font("Arial", 24, FontStyle.Bold);
            textBox_vystup.CharacterCasing = CharacterCasing.Upper;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           textBox_vstup.Text = "";
           textBox_vystup.Text = "";

        }

        private void tOPWinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tOPWinToolStripMenuItem.Checked == true)
            {
                this.TopMost = true;
            }
            else {
                this.TopMost = false;
            }
      
        }

        private void rovna_se_Click(object sender, EventArgs e)
        {
            vysledek();           
        }

        private void vysledek()
        {
            if (textBox_vstup.TextLength > 0)
            {
                try
                {
                    if (number_base_in == 10){
                        textBox_vystup.Text = prepocet(new NCalc.Expression(textBox_vstup.Text).Evaluate().ToString(), number_base_out);
                    }else{

                        int a = Convert.ToInt32(textBox_vstup.Text, number_base_in);
                        textBox_vystup.Text = Convert.ToString(a, number_base_out);
                    
                    }
                    ///prepocet
                    toolStripStatusLabel1.Text = "";
                }
                catch (Exception err)
                {
                    textBox_vystup.Text = "interp. error";
                    toolStripStatusLabel1.Text = "Error: " + err.Message;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            number_base_in = 10;
            vysledek();
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            number_base_in = 16;
            vysledek();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            number_base_in = 2;
            vysledek();
        }

        private string prepocet(string a, int num_base)
        {
            int numValue;
            bool parsed = Int32.TryParse(a, out numValue);

            if (num_base == 10)
            {
                return a;
            }
            else if (parsed)
            {
                a = Convert.ToString(numValue, num_base);
                return a;

            }else {

                return "fract. part err";
            }
        }

        private void back_space_Click(object sender, EventArgs e)
        {
            string s = textBox_vstup.Text;
            if (s.Length > 0)
            {
                textBox_vstup.Text = s.Remove(s.Length-1);
            }
        }

        private void textBox_vstup_TextChanged(object sender, EventArgs e)
        {
            vysledek();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            number_base_out = 10; 
            vysledek();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            number_base_out = 16;
            vysledek();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            number_base_out = 2;
            vysledek();
        }

        private void pamet_clear_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void pamet_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text += textBox_vystup.Text + ", ";
            textBox_vstup.Text = textBox_vystup.Text;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutWindow = new AboutBox();
            aboutWindow.Show();
        }


    }
}
