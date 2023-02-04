using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Taskform2
{
    public partial class Form1 : Form
    {
        SqlConnection connect;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            connect = new SqlConnection("Data Source=WIN-PFGV5N8DK24;Initial Catalog=Mekteb;Integrated Security=True");
        }
        void ConnectList()
        {
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From GamesList", connect);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            connect.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectList();
            TextBoxClear();
        }
        void TextBoxClear()
        {
            name.Text = " ";
            price.Text = " ";
            revenue.Text = " ";
            company.Text = " ";
            realeasedate.Text = " ";
            imdbrating.Text = " ";
            prating.Text = " ";
            idtext.Text = " ";
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            price.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            revenue.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            company.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            realeasedate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            imdbrating.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            prating.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            idtext.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Insert into GamesList Values(@name,@price,@revenue,@company,@release_Date,@imdb_rating,@player_rating)", connect);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@price", float.Parse(price.Text));
                cmd.Parameters.AddWithValue("@revenue", float.Parse(revenue.Text));
                cmd.Parameters.AddWithValue("@company", company.Text);
                cmd.Parameters.AddWithValue("@release_Date", realeasedate.Text);
                cmd.Parameters.AddWithValue("@imdb_Rating", float.Parse(imdbrating.Text));
                cmd.Parameters.AddWithValue("@player_rating", float.Parse(prating.Text));

                if (connect.State != ConnectionState.Open)
                    connect.Open();
                cmd.ExecuteNonQuery();
                if (connect.State == ConnectionState.Open)
                    connect.Close();
                TextBoxClear();
                ConnectList();
            }
            catch
            {
                MessageBox.Show("Enter the information correctly");
            }
        }
        
        private void update_Click(object sender, EventArgs e)
        {
            if (idtext.Text != " ")
            {
                try
                {
                    cmd = new SqlCommand("Update GamesList Set Name = @name , Price = @price , Revenue = @revenue , Company = @company , Release_Date = @release_Date , Imdb_Rating = @imdb_Rating , Player_Rating = player_rating Where Id = @id", connect);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@price", float.Parse(price.Text));
                    cmd.Parameters.AddWithValue("@revenue", float.Parse(revenue.Text));
                    cmd.Parameters.AddWithValue("@company", company.Text);
                    cmd.Parameters.AddWithValue("@release_Date", realeasedate.Text);
                    cmd.Parameters.AddWithValue("@imdb_Rating", float.Parse(imdbrating.Text));
                    cmd.Parameters.AddWithValue("@player_rating", float.Parse(prating.Text));
                    cmd.Parameters.AddWithValue("id", idtext.Text);


                    if (connect.State != ConnectionState.Open)
                        connect.Open();
                    cmd.ExecuteNonQuery();
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                    TextBoxClear();
                    ConnectList();
                }
                catch
                {
                    MessageBox.Show("Did you enter the informations wrong");
                }
            }
            else
            {
                MessageBox.Show("You have not selected an id");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd = new SqlCommand(
                       "DELETE FROM GamesList WHERE Id = @id",
                         connect);
                cmd.Parameters.AddWithValue("@id", idtext.Text);

                if (connect.State != ConnectionState.Open)
                    connect.Open();
                cmd.ExecuteNonQuery();
                if (connect.State == ConnectionState.Open)
                    connect.Close();
                TextBoxClear();
                ConnectList();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        #region
        private void name_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You must write the name of the game";
        }

        private void price_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You must write the price of the game";
        }

        private void revenue_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You must write the revenue of the game";
        }

        private void company_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You must write the company's name of the game";
        }

        private void realeasedate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You must write the release date of the game";
        }

        private void imdbrating_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You must write the imdb rating of the game";
        }

        private void prating_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You must write the player rating of the game";
        }

        private void idtext_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }
#endregion
    }
}
