using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Collections;
using System.IO;
//using System.Data.Sql;

namespace Calculator
{
    
    public partial class DatabaseSetup : Form
    {
        SqlCeConnection conn;
        SqlCeDataAdapter adapt;

        public DatabaseSetup()
        {
            InitializeComponent();

            conn = new SqlCeConnection("Data Source = Dictionary.sdf; Persist Security Info=False");
            this.dataGridView1.Font = new Font("Arial", 10);

            refresh_dataView();

            // cmd.CommandText = "SELECT * FROM myTable WHERE Id =2";
            // cmd.CommandText = "SELECT * FROM myTable WHERE Id =2";
            // cmd.ExecuteNonQuery();
   
            // cmd = new SqlCeCommand(cmdText, targetConnection);

        }

        static public int[] get_score(List<Zaznam> a) {

            int [] score = new int[2];

            score[0] = 0;
            score[1] = 0;

            for(int i=0; i < a.Count; i++){           
                score[0] += a[i].ODPOVED_OK;
                score[1] += a[i].ODPOVED_NOK;
            }

            return score;
        }
        

        static public void set_result_database(Zaznam a,int res)
        {
            SqlCeConnection conn = new SqlCeConnection("Data Source = Dictionary.sdf; Persist Security Info=False");
            string query;
            SqlCeCommand com;
            Zaznam b = null;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
 
                // read actual value
                com = new SqlCeCommand("SELECT * FROM CZ_EN_dict WHERE EN='"+ a.EN +"'", conn);
                SqlCeDataReader dataReader = com.ExecuteReader();

                while (dataReader.Read()) // dokud neprojdeme vsechny zaznamy
                {
                    b = new Zaznam(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[3].ToString(), dataReader.GetInt32(2), dataReader.GetInt32(4), dataReader.GetInt32(5));
                }
                dataReader.Close();

                // change value

                if (res == 1) 
                {
                    b.ODPOVED_OK = b.ODPOVED_OK + 1;
                }
                else if (res == 0)
                {
                    b.ODPOVED_NOK = b.ODPOVED_NOK + 1; 
                }

                // set new value
                query = "UPDATE CZ_EN_dict SET ODPOVED_OK = " + b.ODPOVED_OK + ", ODPOVED_NOK= " + b.ODPOVED_NOK + " WHERE EN = '" + b.EN + "'";
                com = new SqlCeCommand(query, conn);
                com.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

            conn.Close();

        }

        static public List<Zaznam> read_database()
        {
            List<Zaznam> zaznam_list = new List<Zaznam>();
            SqlCeConnection conn = new SqlCeConnection("Data Source = Dictionary.sdf; Persist Security Info=False");

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                SqlCeCommand com = new SqlCeCommand("SELECT * FROM CZ_EN_dict", conn);
                SqlCeDataReader dataReader = com.ExecuteReader();

                while (dataReader.Read()) // dokud neprojdeme vsechny zaznamy
                {
                    zaznam_list.Add(new Zaznam(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[3].ToString(), dataReader.GetInt32(2), dataReader.GetInt32(4), dataReader.GetInt32(5)));
                }
                dataReader.Close();
                

                /*
                com.Parameters.AddWithValue("u_id", "pes");
                SqlCeDataReader reader = com.ExecuteReader();
                string name = reader["CZ"].ToString();
                MessageBox.Show(name);
                 */

            }
            catch (SqlCeException err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
            finally
            {
                conn.Close();
            }

            return zaznam_list;

        }

        private void button1_Click(object sender, EventArgs e)  // Import csv
        {
            // import database
            //try{

            List<List<string>> csv_data;
            string query;
            List<string> CZ, EN;
            string SKUPINA = "all";
            int ID = 0;
            int ODPOVED_OK = 0;
            int ODPOVED_NOK = 0;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Otevření záznamu *.csv";

            fileDialog.Filter = "CSV (*.csv)|*.csv";

            //String[] pamet = myNastaveniDialog.vrat_pamet();
            String cesta = "0";
            if (cesta == "0") { cesta = @"C:\"; }

            fileDialog.InitialDirectory = cesta;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo file_info = new FileInfo(fileDialog.FileName);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (StreamReader stream_reader = new StreamReader(file_info.FullName, System.Text.Encoding.GetEncoding(1250)))
                {
                    csv_data = nacti_csv_soubor(stream_reader);
                    CZ = csv_data[0];
                    EN = csv_data[1];

                    for (int i = 0; i < csv_data[0].Count; i++)
                    //for (int i = 0; i < 3; i++)
                    {
                        try
                        {
                            query = "INSERT INTO CZ_EN_dict(CZ,EN,ID,SKUPINA,ODPOVED_OK,ODPOVED_NOK)VALUES('" + CZ[i] + "', '" + EN[i] + "', " + ID + ", '" + SKUPINA + "', " + ODPOVED_OK + ", " + ODPOVED_NOK + ")";
                            ID++;
                            SqlCeCommand com = new SqlCeCommand(query, conn);
                            com.ExecuteNonQuery();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Error: " + err.Message);
                        }
                    }
                }
                conn.Close();
            }

            refresh_dataView();

        }

        private void refresh_dataView()
        {
            conn.Open();

            DataTable dt = new DataTable();
            adapt = new SqlCeDataAdapter("select * from CZ_EN_dict", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            
            conn.Close();
        }

        private List<List<string>> nacti_csv_soubor(StreamReader stream_reader)
        {
           List<List<string>> listy_nactene = new List<List<string>>();

           List<string> CZ_list = new List<string>();
           List<string> EN_list = new List<string>();

           //List<int> SKUPINA_list = new List<int>();
            String[] radek_pole;
            String radek = stream_reader.ReadLine();

            while (radek != null)
            {
                try
                {
                radek_pole = radek.Split(';');

                    if (radek_pole.Length == 1)
                    {
                        CZ_list.Add(radek_pole[0]);
                        radek = stream_reader.ReadLine();
                        radek_pole = radek.Split(';');
                        EN_list.Add(radek_pole[1]);
                    }else{
                        CZ_list.Add(radek_pole[0]);
                        EN_list.Add(radek_pole[1]);
                    }
                radek = stream_reader.ReadLine();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message +" row:"+ CZ_list.Count.ToString());
                }
            }

           stream_reader.Close();

           listy_nactene.Add(CZ_list);
           listy_nactene.Add(EN_list);

            return listy_nactene;
       }   


        private void button2_Click(object sender, EventArgs e)  // Add row
        {

            string CZ = textBox_CZ.Text;
            string EN = textBox_EN.Text;
            string SKUPINA = "ext";
            string query;
            int ID = 0;
            int ODPOVED_OK = 0;
            int ODPOVED_NOK = 0;

            try
            {
                if (CZ.Length > 0 & EN.Length > 0)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    query = "INSERT INTO CZ_EN_dict(CZ,EN,ID,SKUPINA,ODPOVED_OK,ODPOVED_NOK)VALUES('" + CZ + "', '" + EN + "', " + ID + ", '" + SKUPINA + "', " + ODPOVED_OK + ", " + ODPOVED_NOK + ")";
                    SqlCeCommand com = new SqlCeCommand(query, conn);
                    com.ExecuteNonQuery();
                    conn.Close();

                    refresh_dataView();
                }
            }
            catch (SqlCeException err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)      // Duplicity removal
        {
            List<Zaznam> zaznam_list = new List<Zaznam>();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                //SqlCeCommand com = new SqlCeCommand("SELECT EN FROM CZ_EN_dict GROUP BY EN HAVING COUNT(*) > 1", conn);
                // SqlCeCommand com = new SqlCeCommand("SELECT * FROM CZ_EN_dict WHERE EN NOT IN (SELECT MIN(ID) FROM CZ_EN_dict GROUP BY EN)", conn);
                SqlCeCommand com = new SqlCeCommand("SELECT * FROM CZ_EN_dict WHERE EN IN(SELECT EN FROM CZ_EN_dict GROUP BY EN HAVING (COUNT(*) > 1))", conn);
                SqlCeDataReader dataReader = com.ExecuteReader();

                int i = 0;
                while (dataReader.Read()) // dokud neprojdeme vsechny zaznamy
                {
                    zaznam_list.Add(new Zaznam(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[3].ToString(), dataReader.GetInt32(2), dataReader.GetInt32(4), dataReader.GetInt32(5)));
                }
                dataReader.Close();

                com = new SqlCeCommand("DELETE FROM CZ_EN_dict WHERE EN IN(SELECT EN FROM CZ_EN_dict GROUP BY EN HAVING (COUNT(*) > 1))", conn);
                com.ExecuteNonQuery();

                i = 0;
                List<Zaznam> pivot_list = new List<Zaznam>();
                int count_dupl=0;

                while (zaznam_list.Count > 0) // dokud zbyvaji data v listu
                {
                    pivot_list.Add(zaznam_list[0]);
                    zaznam_list.RemoveAt(0);

                    for (int a = 0; a < zaznam_list.Count; a++)
                    {
                        if (string.Equals(pivot_list[0].EN, zaznam_list[a].EN))
                        {
                            pivot_list.Add(zaznam_list[a]);
                            zaznam_list.RemoveAt(a);
                        }
                    }

                    if (zaznam_list.Count == 1)  // oprava kvuli chybe for pokud se maze za behu
                    {
                        for (int a = 0; a < zaznam_list.Count; a++)
                        {
                            if (string.Equals(pivot_list[0].EN, zaznam_list[a].EN))
                            {
                                pivot_list.Add(zaznam_list[a]);
                                zaznam_list.RemoveAt(a);
                            }
                        }
                    }

                    int max_v = 0;
                    int ind_max = 0;

                    for (int a = 0; a < pivot_list.Count; a++)
                    {
                        if (max_v < pivot_list[a].get_score())   // vybira se verze s nejvice zaznamy testu, nebo 0
                        {
                            max_v = pivot_list[a].get_score();
                            ind_max = i;
                        }
                    }

                    com = new SqlCeCommand("INSERT INTO CZ_EN_dict(CZ,EN,ID,SKUPINA,ODPOVED_OK,ODPOVED_NOK)VALUES('" + pivot_list[ind_max].CZ + "', '" + pivot_list[ind_max].EN + "', " + pivot_list[ind_max].ID + ", '" + pivot_list[ind_max].SKUPINA + "', " + pivot_list[ind_max].ODPOVED_OK + ", " + pivot_list[ind_max].ODPOVED_NOK + ")", conn);
                    com.ExecuteNonQuery();

                    pivot_list.Clear();
                    count_dupl++;
                }

                conn.Close();

                refresh_dataView();

                MessageBox.Show("Was deleted diplicite data at: " + count_dupl .ToString()+ " records.");

            }
            catch (SqlCeException err)
            {
                MessageBox.Show("Error: " + err.Message);

            }
            finally
            {
                conn.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)   // Clear table
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure? Table data will be loss... ", "Deletion confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                try
                {
                    //string cmd = "DROP TABLE CZ_EN_dict";
                    string cmd = "DELETE FROM CZ_EN_dict";
                    SqlCeCommand sqlCommand = new SqlCeCommand(cmd, conn);
                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error in Delete(): " + exc.Message);
                }

                conn.Close();

                refresh_dataView();
            }

        }

    }

    public class Zaznam
    {

        public string EN;
        public string CZ;
        public string SKUPINA;
        public int ID;
        public int ODPOVED_OK;
        public int ODPOVED_NOK;

        public Zaznam(string cz, string en, string sk, int id, int odp_ok, int odp_nok)
        {
            EN = en;
            CZ = cz;
            SKUPINA = sk;
            ID = id;
            ODPOVED_OK = odp_ok;
            ODPOVED_NOK = odp_nok;
        }

        public int get_score()
        {

            return this.ODPOVED_OK + this.ODPOVED_NOK;
        }
    }

}
