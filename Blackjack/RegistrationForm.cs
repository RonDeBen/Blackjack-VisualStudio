using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class RegistrationForm : Form
    {

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string email = emailText.Text;
            string name = nameText.Text;
            string password = passwordText.Text;
            string funds = fundsTExt.Text;

            RootObject ro = RequestManager.RegisterUser(email, name, password, funds);

            RoomIndexForm rif = new RoomIndexForm();
            rif.ro = ro;
            rif.Show();
            this.Hide();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(RegistrationForm_Closed);
            generateTestUser();
        }

        void RegistrationForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void generateTestUser()
        {
            Random rand = new Random();
            emailText.Text = "test" + rand.Next(1, 5000) + "@test.com";
            nameText.Text = "Crooshed Toast";
            passwordText.Text = "password";
            fundsTExt.Text = "1234567890";
        }

    }
}
