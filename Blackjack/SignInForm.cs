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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
            this.Hide();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            RootObject ro = RequestManager.SignIn(emailText.Text, passwordText.Text);
            if (ro != null)
            {
                RoomIndexForm rif = new RoomIndexForm();
                rif.ro = ro;
                rif.Show();
                this.Hide();
            }
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(SignInForm_Closed);

            UseTestUser();
            emailText.Select();
            emailText.Focus();
        }

        void SignInForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UseTestUser()
        {
            emailText.Text = "newtest@test.com";
            passwordText.Text = "asdfasdf";
        }
    }
}
