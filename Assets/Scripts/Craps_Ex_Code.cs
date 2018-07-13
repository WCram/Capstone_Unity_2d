using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craps_Ex_Code : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

//using System;
//using System.Windows.Forms;

//namespace Craps_Prototype
//{
//    public partial class Form1 : Form
//    {
      

//        public Form1()
//        {

//            InitializeComponent();
//            lblBalance.Text = pot.ToString("c");


//        } // End Form1()

//        //        Players place an initial bet then roll a pair of die.If they roll a 7 or 11, they win.If it’s 2, 3 or 12 they lose. Any other values become “the point”.


//        //After the point is set the roller keeps rolling until they roll the point number again, for an even money payoff, or rolls a 7 to lose.


//        //If they roll their point the player keeps rolling with a new point.This continues until the roller rolls a 7 and a new round is started with a new roller.


//        private void btnRoll_Click(object sender, EventArgs e)
//        {
//            Play();
//        }

//        public void Play()
//        {
//            int roll = Roll();

//            if (Bet())
//            {
//                // First roll
//                if (first)
//                {

//                    pot -= bet;

//                    if (roll == 7 || roll == 11)
//                    {
//                        pot += bet * 2;
//                        richTextBox1.AppendText(roll + " You Win!" + "\n");
//                    }
//                    else if (roll == 2 || roll == 3 || roll == 12)
//                    {
//                        richTextBox1.AppendText(roll + " You Lose!" + "\n");
//                    }
//                    else
//                    {
//                        first = false;
//                        point = roll;
//                        richTextBox1.AppendText("Point: " + point + "\n");
//                    }
//                }
//                else
//                {
//                    if (roll == point)
//                    {
//                        pot += bet * 2;
//                        lblBalance.Text = pot.ToString("c");

//                        point = Roll();
//                        richTextBox1.AppendText("New Point: " + point + "\n");

//                    }
//                    else if (roll == 7)
//                    {
//                        richTextBox1.AppendText(roll + " You Lose!" + "\n");
//                        first = true;

//                    }
//                    else
//                    {
//                        richTextBox1.AppendText(roll + "\n");

//                    }
//                }
//                lblBalance.Text = pot.ToString("c");

//            }



//        } // End Play()

//        private bool Bet()
//        {

//            if (double.TryParse(txtBet.Text, out bet))
//            {

//                if (bet <= pot && bet != 0)
//                {
//                    return true;
//                }

//                MessageBox.Show("You do not have enough money");

//            }

//            MessageBox.Show("Enter a valid amount");


//            return false;

//        } // End Bet()

//        private int Roll()
//        {
//            Random rand = new Random();
//            int totalRoll = 0;
//            for (int i = 0; i < 2; i++)
//            {
//                totalRoll += rand.Next(1, 7);
//            }

//            return totalRoll;
//        } // End Roll()
//    }
//}
