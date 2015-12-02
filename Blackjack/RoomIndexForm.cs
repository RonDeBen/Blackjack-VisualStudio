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
    public partial class RoomIndexForm : Form
    {
        public RootObject ro = new RootObject();
        public List<Room> rooms = new List<Room>();
        public RoomIndexForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (roomList.SelectedIndex != -1) { 
                TableForm tf = new TableForm();
                tf.user = ro.user;
                tf.room = rooms[roomList.SelectedIndex];
                tf.Show();
                this.Hide();
            }
        }

        private void RoomIndexForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(RegistrationForm_Closed);

            rooms = RequestManager.GetRooms().rooms;
            for (int k = 0; k < rooms.Count(); k++)
            {
                roomList.Items.Add(rooms[k].name);
            }
        }

        void RegistrationForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
