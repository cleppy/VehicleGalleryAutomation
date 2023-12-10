using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalotomasyon
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            finalGorselEntities vt = new finalGorselEntities();
            string name = txt_RName.Text;
            string surname = txt_RSurname.Text;
            string username = txt_RUsername.Text;
            string password = txt_RPassword.Text;

            metots.Register(name, surname, username, password);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;

            bool loginSuccessful = metots.Login(username, password);

            if (loginSuccessful)
            {
                finalGorselEntities vt = new finalGorselEntities();
                var userRole = vt.Users.FirstOrDefault(u => u.UserUsername == username);

                if (userRole != null)
                {
                    if (userRole.UserRoleID == 1)
                    {
                        ForAdmin forAdmin = new ForAdmin();
                        forAdmin.Show();
                        this.Hide();
                    }
                    else if (userRole.UserRoleID == 2)
                    {
                        ForUser forUser = new ForUser();
                        forUser.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Null User!!!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!!!");
            }
        }
    }
}