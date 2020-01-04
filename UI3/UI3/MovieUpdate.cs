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
    public partial class MovieUpdate : Form
    {
        Movie m = new Movie();

        public MovieUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tbTitle.Text;
                int dateTime = int.Parse(tbDateTime.Text);
                string place = tbPlace.Text;
                int date = int.Parse(tbDate.Text);


                if (title == string.Empty)
                {
                    MessageBox.Show("Please enter the title");
                    return;
                }

                if (place == string.Empty)
                {
                    MessageBox.Show("Please enter the place");
                    return;
                }

                Movie m = new Movie();

                m.Title = title;
                m.DateTime = dateTime;
                m.Place = place;
                m.Date = date;


                int result = m.UpdateMovie(m);
                if (result > 0)
                {
                    lblMessage.Text = "Movie Updated";
                    tbDateTime.Text = "";
                    tbTitle.Text = "";
                    tbPlace.Text = "";
                    tbDate.Text = "";

                }
                else
                {
                    lblMessage.Text = "Movie Not Updated";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MovieDelete home = new MovieDelete();
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

        private void dgvMovie_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int sl = dgvMovie.SelectedCells[0].RowIndex;
            m.Title = dgvMovie.Rows[sl].Cells[0].Value.ToString();
            m.DateTime = int.Parse(dgvMovie.Rows[sl].Cells[1].Value.ToString());
            m.Place = dgvMovie.Rows[sl].Cells[2].Value.ToString();
            m.Date = int.Parse(dgvMovie.Rows[sl].Cells[3].Value.ToString());

            tbTitle.Text = m.Title;
            tbDateTime.Text = m.DateTime.ToString();
            tbPlace.Text = m.Place;
            tbDate.Text = m.Date.ToString();
        }
    }
}
