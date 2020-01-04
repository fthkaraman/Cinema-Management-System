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
    public partial class CustomerDelete : Form
    {
        public CustomerDelete()
        {
            InitializeComponent();
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

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = new Customer();
                dgvCustomer.DataSource = c.ListCustomer();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int tcKimlik = int.Parse(tbTcKimlik.Text);
  

                /*if (tcKimlik == string.Empty)
                {
                    MessageBox.Show("Please enter your TC NO");
                    return;
                }

                if (phoneNumber == string.Empty)
                {
                    MessageBox.Show("Please enter your phone number");
                    return;
                }*/

                Customer c = new Customer();

                
                c.TcKimlik = tcKimlik;
                

                int result = c.DeleteCustomer(c);
                if (result > 0)
                {
                    lblMessage.Text = "Customer Deleted";
                   
                    tbTcKimlik.Text = "";
                   
                }
                else
                {
                    lblMessage.Text = "Customer Not Deleted";
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
    }
}
