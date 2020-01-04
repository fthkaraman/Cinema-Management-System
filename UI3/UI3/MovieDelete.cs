using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI3
{
    public partial class MovieDelete : Form
    {
        public MovieDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int dateTime = int.Parse(tbDateTime.Text);
               
                /*if (title == string.Empty)
                {
                    MessageBox.Show("Please enter the title");
                    return;
                }

                if (place == string.Empty)
                {
                    MessageBox.Show("Please enter the place");
                    return;
                }*/

                Movie m = new Movie();

                m.DateTime = dateTime;
 
                int result = m.DeleteMovie(m);
                if (result > 0)
                {
                    lblMessage.Text = "Movie Deleted";
                    tbDateTime.Text = "";

                }
                else
                {
                    lblMessage.Text = "Movie Not Deleted";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MovieDelete home = new MovieDelete();
            home.Show();
            this.Hide();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MovieHome home = new MovieHome();
            home.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MovieUpdate home = new MovieUpdate();
            home.Show();
            this.Hide();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Movie m = new Movie();
                dgvMovie.DataSource = m.ListMovie();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerHome home = new CustomerHome();
            home.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerUpdate home = new CustomerUpdate();
            home.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDelete home = new CustomerDelete();
            home.Show();
            this.Hide();
        }
    }
}
