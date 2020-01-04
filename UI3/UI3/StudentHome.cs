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
    public partial class StudentHome : Form
    {
        public StudentHome()
        {
            InitializeComponent();
        }

        private void ListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student();
               dgvStudent.DataSource =  s.ListStudent();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbName.Text;
                string email = tbEmail.Text;
                string password = tbPassword.Text;

                if (name==string.Empty)
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

                Student s = new Student();

                s.Name = name;
                s.Email = email;
                s.Password = password;

                int result = s.AddStudent(s);
                if (result > 0)
                {
                    lblMessage.Text = "Student Added";
                    tbEmail.Text = "";
                    tbName.Text = "";
                    tbPassword.Text = "";
                }
                else
                {
                    lblMessage.Text = "Student Not Added";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
