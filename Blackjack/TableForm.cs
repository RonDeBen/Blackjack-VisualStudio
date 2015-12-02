using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Blackjack

{
    public struct Coords
    {
        public int x, y;

        public Coords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
    public partial class TableForm : Form
    {

        public Coords[] cardOrigins = new Coords[5];
        public Coords offset = new Coords(15, 15);
        public Coords cardSize = new Coords(72, 96);

        public int[] handValues = new int[5];
        public Label[] handValueLabels = new Label[5];

        public int[] cardsInHand = new int[5];
        public bool[] acesInHand = new bool[5];

        List<PictureBox> cardPictureBoxes = new List<PictureBox>();

        public User user = new User();
        public Room room = new Room();

        public bool canHit = false;

        public TableForm()
        {
            InitializeComponent();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(TableForm_Closed);

            cardOrigins[0] = new Coords(280, 30);//house
            cardOrigins[1] = new Coords(280, 230);//player1

            handValueLabels[0] = houseValue;//house label
            handValueLabels[1] = handValue;//player1 label

            Console.WriteLine(update_funds(0));

            this.Text = room.name;
            
            nameLabel.Text = "Welcome, "  + user.name + "!";
        }
        void TableForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SpawnCard(int playerNumber, int cardNumber, Card card)
        {
            PictureBox newCard = new PictureBox();

            Object cardImage = Properties.Resources.ResourceManager.GetObject(card.rank + "_" + card.suit);
            if (cardImage is Image)
            {
                newCard.Image = cardImage as Image;
            }

            newCard.Width = cardSize.x;
            newCard.Height = cardSize.y;

            newCard.Location = new Point(cardOrigins[playerNumber].x + offset.x * cardNumber, cardOrigins[playerNumber].y + offset.y * cardNumber);

            newCard.Visible = true;

            this.Controls.Add(newCard);
            newCard.BringToFront();

            cardPictureBoxes.Add(newCard);
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            clearCurrentCards();

            NewPlayerCard(0);

            NewPlayerCard(1);
            NewPlayerCard(1);
        }

        private void NewPlayerCard(int playerNumber)
        {
            Card card = RequestManager.GetCard(room.id);
            SpawnCard(playerNumber, cardsInHand[playerNumber], card);
            AddCardToHand(playerNumber, card);
        }

        private void AddCardToHand(int playerNumber, Card card)
        {

            cardsInHand[playerNumber]++;

            switch (card.rank)
            {
                case "two":
                    handValues[playerNumber] += 2;
                    break;
                case "three":
                    handValues[playerNumber] += 3;
                    break;
                case "four":
                    handValues[playerNumber] += 4;
                    break;
                case "five":
                    handValues[playerNumber] += 5;
                    break;
                case "six":
                    handValues[playerNumber] += 6;
                    break;
                case "seven":
                    handValues[playerNumber] += 7;
                    break;
                case "eight":
                    handValues[playerNumber] += 8;
                    break;
                case "nine":
                    handValues[playerNumber] += 9;
                    break;
                case "ten":
                    handValues[playerNumber] += 10;
                    break;
                case "jack":
                    handValues[playerNumber] += 10;
                    break;
                case "queen":
                    handValues[playerNumber] += 10;
                    break;
                case "king":
                    handValues[playerNumber] += 10;
                    break;
                case "ace":
                    handValues[playerNumber] += 1;
                    acesInHand[playerNumber] = true;
                    break;
            }

            if (acesInHand[playerNumber] == true && handValues[playerNumber] + 10 <= 21)
            {
               handValueLabels[playerNumber].Text = "Hand Value: " + handValues[playerNumber] + " or " + (handValues[playerNumber] + 10);
            }
            else
            {
                handValueLabels[playerNumber].Text = "Hand Value: " + handValues[playerNumber];
            }
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            if (canHit)
            {
                NewPlayerCard(1);

                if (acesInHand[1] && handValues[1] + 10 == 21)//currently not working if the player hits blackjack with an ace
                {
                    resultLabel.Text = "You hit blackjack!";
                    canHit = false;
                }
                else if(handValues[1] == 21)//I think I can just merge this into the last operation with an or
                {
                    resultLabel.Text = "You hit blackjack!";
                    canHit = false;
                }

                if (handValues[1] > 21)
                {
                    resultLabel.Text = "You Busted :/";
                    canHit = false;
                }

            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            if (canHit)
            {
                canHit = false;
                while (handValues[0] < 17)
                {
                    NewPlayerCard(0);
                }

                for (int j = 0; j < acesInHand.Length; j++)
                {
                    if (acesInHand[j] && handValues[j] + 10 <= 21)
                    {
                        handValues[j] += 10;
                    }
                }

                if (handValues[1] > handValues[0] || handValues[0] > 21)//player1 wins
                {
                    resultLabel.Text = "You Win!";
                }
                else if (handValues[1] < handValues[0])
                {
                    resultLabel.Text = "You Lose";
                }
                else
                {
                    resultLabel.Text = "Tie!";
                }
            }
        }

        private void clearCurrentCards()
        {
            canHit = true;
            resultLabel.Text = "";

            for (int k = 0; k < cardPictureBoxes.Count; k++)
            {
                this.Controls.Remove(cardPictureBoxes[k]);
            }
            cardPictureBoxes.Clear();

            handValues = new int[5];

            //change this once there's multiplayer support
            handValueLabels[0].Text = "House Value: ";
            handValueLabels[1].Text = "Hand Value: ";

            cardsInHand = new int[5];
            acesInHand = new bool[5];
        }

        private double update_funds(int bet_result)
        {
            user = RequestManager.UpdateFunds(user.id, bet_result);
            return Double.Parse(user.funds);
        }

    }
}
