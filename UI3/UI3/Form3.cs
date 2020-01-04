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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            if (email == "")
            {
                lblMessage.Text = "Please enter email.";
                lblMessage.ForeColor = Color.Red;
                tbEmail.Focus();
                return;
            }

            if (password == string.Empty)
            {
                lblMessage.Text = "Please enter password";
                lblMessage.ForeColor = Color.Red;
                tbPassword.Focus();
                return;
            }

            lblMessage.Text = "";

            Ticket t = new Ticket();
            int result = t.Login(email, password);

            if (result == 1)
            {
                TicketHome home = new TicketHome();
                home.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Invalid email or passwrod";
                lblMessage.ForeColor = Color.Red;
            }
        }
    }
}
