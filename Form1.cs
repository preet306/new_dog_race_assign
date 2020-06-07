using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_dog_race_assign
{
    public partial class Form1 : Form
    {

        Gamer instance = new Gamer();

        private int dog = 0;
        private int player = 0;
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        private void dg1_CheckedChanged(object sender, EventArgs e)
        {
            //if any of the player 
            if (dg1.Checked==true) {
                dog = 1;
            }
        }

        private void dg2_CheckedChanged(object sender, EventArgs e)
        {
            //if any of the player 
            if (dg2.Checked == true)
            {
                dog = 2;
            }

        }

        private void dg3_CheckedChanged(object sender, EventArgs e)
        {
            //if any of the player 
            if (dg3.Checked == true)
            {
                dog = 3;
            }
        }

        private void dg4_CheckedChanged(object sender, EventArgs e)
        {
            //if any of the player 
            if (dg4.Checked == true)
            {
                dog = 4;
            }
        }

        private void preet_CheckedChanged(object sender, EventArgs e)
        {
            //if any of the player 
            if (preet.Checked == true)
            {
                player= 1;
            }
        }

        private void sarobh_CheckedChanged(object sender, EventArgs e)
        {
            //if any of the player 
            if (sarobh.Checked == true)
            {
                player = 2;
            }
        }

        private void bully_CheckedChanged(object sender, EventArgs e)
        {
            //if any of the player 
            if (bully.Checked == true)
            {
                player = 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (player==1 && dog>0) {
                //player one is interest in the race and want to bet 
                //after that we must verify his betamount 
                if (Convert.ToInt32(bet_box.Text) < Convert.ToInt32(Preet_Lbl.Text) && Convert.ToInt32(bet_box.Text) <= 50)
                {
                    PreetBet.Text = "" + Convert.ToInt32(bet_box.Text);
                    PreetDog.Text = "" + dog;
                    button2.Visible = true;
                }
                else {
                    MessageBox.Show("bet Amount must be less than from the budget or 50 dollar ");
                }
            }
            if (player==2 && dog > 0) {
                //player is interest in the race and want to bet 
                //after that we must verify his betamount 
                if (Convert.ToInt32(bet_box.Text) < Convert.ToInt32(SarobhLbl.Text) && Convert.ToInt32(bet_box.Text) <= 50)
                {
                    SarobhBet.Text = "" + Convert.ToInt32(bet_box.Text);
                    SarobhDog.Text = "" + dog;
                    button2.Visible = true;
                }
                else
                {
                    MessageBox.Show("bet Amount must be less than from the budget or 50 dollar ");
                }

            }


            if (player == 3 && dog > 0)
            {
                //player is interest in the race and want to bet 
                //after that we must verify his betamount 
                if (Convert.ToInt32(bet_box.Text) < Convert.ToInt32(Bully_Lbl.Text) && Convert.ToInt32(bet_box.Text) <= 50)
                {
                    BullyBet.Text = "" + Convert.ToInt32(bet_box.Text);
                    BullyDog.Text = "" + dog;
                    button2.Visible = true;
                }
                else
                {
                    MessageBox.Show("bet Amount must be less than from the budget or 50 dollar ");
                }

            }



            player = 0;
            dog = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FrstDog.Left < instance.finishPoint())
            {
                FrstDog.Left += instance.movePoint();
            }
            else {
                timer1.Enabled = false;
                finalResult(1);
            }
             if (SecondDog.Left < instance.finishPoint())
            {
                SecondDog.Left += instance.movePoint();
            }
            else
            {
                timer1.Enabled = false;
                finalResult(2);
            }
            if (ThirdDog.Left < instance.finishPoint())
            {
                ThirdDog.Left += instance.movePoint();
            }
            else
            {
                timer1.Enabled = false;
                finalResult(3);
            }
            if (ForthDog.Left < instance.finishPoint())
            {
                ForthDog.Left += instance.movePoint();
            }
            else
            {
                timer1.Enabled = false;
                finalResult(4);
            }
        }

        public void finalResult(int dog) {
            MessageBox.Show(dog +" won the Race ");
            //if preet participate in the bet then his budget will reset after winning or lossing the game 
            if (!PreetBet.Text.Equals("0")) {
               Preet_Lbl.Text=""+instance.resetBudget(dog, Convert.ToInt32(PreetBet.Text), Convert.ToInt32(PreetDog.Text), Convert.ToInt32(Preet_Lbl.Text));   
            }

            //if sarobh participate in the bet then his budget will reset after winning or lossing the game 

            if (!SarobhBet.Text.Equals("0")) {
                SarobhLbl.Text = "" + instance.resetBudget(dog, Convert.ToInt32(SarobhBet.Text), Convert.ToInt32(SarobhDog.Text), Convert.ToInt32(SarobhLbl.Text));
            }

            // if Bully  participate in the bet then his budget will reset after winning or lossing the game 
            if (!BullyBet.Text.Equals("0")) {
                Bully_Lbl.Text = "" + instance.resetBudget(dog, Convert.ToInt32(BullyBet.Text), Convert.ToInt32(BullyDog.Text), Convert.ToInt32(Bully_Lbl.Text));
            }



            //after this all the position of the dog must be reset 
            FrstDog.Left = 0;SecondDog.Left = 0;ThirdDog.Left = 0;ForthDog.Left = 0;
            PreetBet.Text = "0";SarobhBet.Text = "0";BullyBet.Text = "0";
            PreetDog.Text = "0";SarobhDog.Text = "0";BullyDog.Text = "0";
            dg1.Checked = false;dg2.Checked = false; dg3.Checked = false; dg4.Checked = false;
            preet.Checked = false;sarobh.Checked = false;bully.Checked = false;
            button2.Visible = false;
            bet_box.Text = "";
        }


    }
}
