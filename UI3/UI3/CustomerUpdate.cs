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
    public partial class CustomerUpdate : Form
    {
        public CustomerUpdate()
        {
            InitializeComponent();
        }
        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CustomerHome home = new CustomerHome();
            home.Show();
            this.Hide();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDelete home = new CustomerDelete();
            home.Show();
            this.Hide();
        }
        private void listToolStripMenuItem_Click_1(object sender, EventArgs e)
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
        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CustomerUpdate home = new CustomerUpdate();
            home.Show();
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = tbName.Text;
                string email = tbEmail.Text;
                string password = tbPassword.Text;
                int tcKimlik = int.Parse(tbTcKimlik.Text);
                long phoneNumber = long.Parse(tbPhoneNumber.Text);

                if (name == string.Empty)
                {
                    MessageBox.Show("Please enter your name");
                    return;
                }

                if (email == string.Empty)
                {
                    MessageBox.Show("Please enter your email");
                    return;
                }

                if (password == string.Empty)
                {
                    MessageBox.Show("Please enter your password");
                    return;
                }

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

                c.Name = name;
                c.Email = email;
                c.Password = password;
                c.TcKimlik = tcKimlik;
                c.PhoneNumber = phoneNumber;

                int result = c.UpdateCustomer(c);
                if (result > 0)
                {
                    lblMessage.Text = "Customer Updated";
                    tbEmail.Text = "";
                    tbName.Text = "";
                    tbPassword.Text = "";
                    tbTcKimlik.Text = "";
                    tbPhoneNumber.Text = "";
                }
                else
                {
                    lblMessage.Text = "Customer Not Updated";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CustomerUpdate_Load(object sender, EventArgs e)
        {

        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {

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

