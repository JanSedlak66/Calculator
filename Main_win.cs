using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NCalc.Domain;
using NCalc;

namespace Calculator
{
    public partial class Main_win : Form
    {
        int number_base_in;
        int number_base_out;
        double[] memory_calc = new double[5];
        Expression exp_hl;
        List<Zaznam> database_dict = new List<Zaznam>();
        Random random = new Random();
        int index_zadani;
        int counter_refresh_dat;
        int position_label_dict;
        Timer timer1;
        Button [] button_answ = new Button[9];
        int[] answer_dict = new int[2];                // OK NOK

        public Main_win()
        {

            InitializeComponent();

            position_label_dict = label_EN_input.Location.X;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            number_base_in = 10;  // inicializace
            number_base_out = 10;  // inicializace
            memory_calc[0] = 0;

            //textBox_vystup.Font = new Font("Arial", 24, FontStyle.Bold);
            textBox_vystup.CharacterCasing = CharacterCasing.Upper;

            database_dict = DatabaseSetup.read_database();
            // toolStripStatusLabel1.Text = database_dict.Count.ToString();

            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(this.timer1_Tick);

            button_answ[0] = answ_button1;
            button_answ[1] = answ_button2;
            button_answ[2] = answ_button3;
            button_answ[3] = answ_button4;
            button_answ[4] = answ_button5;
            button_answ[5] = answ_button6;
            button_answ[6] = answ_button7;
            button_answ[7] = answ_button8;
            button_answ[8] = answ_button9;

            answer_dict[0] = 0;
            answer_dict[1] = 0;

            counter_refresh_dat = 0;

            index_zadani = getNewIndex();

            if (database_dict.Count > 30)
            {
                init_dict();
            }
            else {
                toolStripStatusLabel1.Text = "Database is to small to play ";
            }
        }

        private void init_dict()
        {
            int randomNumber = random.Next(0, database_dict.Count-9);
            int rn_button = random.Next(0, 8);

            label_EN_input.Text = database_dict[index_zadani].CZ;
            label_EN_input.Left = position_label_dict - label_EN_input.Text.Length*4;

            for (int i = 0; i < 9;i++){
                button_answ[i].Text = database_dict[i + randomNumber].EN;
            }
            button_answ[rn_button].Text = database_dict[index_zadani].EN;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_EN_input.BackColor = Color.Transparent;
            timer1.Stop();

            if ((answer_dict[0] == 1) & (database_dict.Count > 30))
            {
                DatabaseSetup.set_result_database(database_dict[index_zadani], 1);
                if (answer_dict[1] > 0){
                     DatabaseSetup.set_result_database(database_dict[index_zadani], 0);
                }
                index_zadani = getNewIndex();
                init_dict();

                answer_dict[0] = 0; 
                answer_dict[1] = 0;

            }

        }

        private int getNewIndex()
        {
            int a;
            int [] b = new int[2];

            if (counter_refresh_dat > 10)
            {
                database_dict = DatabaseSetup.read_database();
                counter_refresh_dat = 0;

                b = DatabaseSetup.get_score(database_dict);

                toolStripStatusLabel1.Text = "Score: OK/NOK " +b[0]+ "/" +b[1];
            }


            a = random.Next(0, database_dict.Count);

            counter_refresh_dat++;
            return a;
        }

        private void answ_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (string.Equals(btn.Text, database_dict[index_zadani].EN))
            {
                label_EN_input.BackColor = Color.Green;
                answer_dict[0] = 1;            
            }else{
                label_EN_input.BackColor = Color.Red;
                answer_dict[1] = answer_dict[1] + 1;
            }

            timer1.Start();
            //toolStripStatusLabel1.Text += "AAA BBB ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           textBox_vstup.Text = "";
           textBox_vystup.Text = "";

        }

        private void topWinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (topWinToolStripMenuItem.Checked == true)
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
            string input;
            if (textBox_vstup.TextLength > 0)
            {
                try
                {
                    if (ignoreToolStripMenuItem.Checked == true)
                    {
                        input = textBox_vstup.Text.Replace(',', '.');
                    }
                    else { input = textBox_vstup.Text; }

                    if (number_base_in == 10){
                        //textBox_vystup.Text = prepocet(new NCalc.Expression(input).Evaluate().ToString(), number_base_out);

                        exp_hl = new Expression(input);
                        exp_hl.Parameters["Pi"] = Math.PI;
                        exp_hl.Parameters["M"] = memory_calc[0];
                        textBox_vystup.Text = prepocet(exp_hl.Evaluate().ToString(), number_base_out);

                    }else{

                        int a = Convert.ToInt32(input, number_base_in);
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
            memory_calc[0] = 0;
            vysledek();
        }

        private void pamet_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text += textBox_vystup.Text + ", ";
            // textBox_vstup.Text = textBox_vystup.Text;

            double numValue = 0;
            bool parsed = Double.TryParse(textBox_vystup.Text, out numValue);

            memory_calc[0] = numValue;
            vysledek();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseSetup databaseWindow = new DatabaseSetup();
            databaseWindow.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutWindow = new AboutBox();
            aboutWindow.Show();
        }


    }
}
