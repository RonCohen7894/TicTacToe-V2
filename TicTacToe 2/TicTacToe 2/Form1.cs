using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_2
{
    public partial class Form1 : Form
    {
        #region variable

        string player;
        bool turn = true;
        bool win;
        #endregion

        public Form1()
        {
            InitializeComponent();
            Pmenu.Dock = DockStyle.Fill;
            Pmenu.BringToFront();

            #region set_btn
            Button[] set_btn = { button1, button2, button3, button4, button5 ,
                              button6, button7, button8, button9 };
            foreach (Button btn in set_btn)
            {
                btn.FlatAppearance.BorderSize = 0;
            }
            #endregion

        }

        #region menu

        private void Chosse_Player(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "Choose_X")
            {
                player = "X";
                Choose_X.FlatAppearance.BorderColor = Color.Red;
                Choose_X.FlatAppearance.BorderSize = 3;
                Choose_O.FlatAppearance.BorderColor = Color.Black;
                Choose_O.FlatAppearance.BorderSize = 1;
            }
            else
            {
                player = "O";
                Choose_X.FlatAppearance.BorderColor = Color.Black;
                Choose_X.FlatAppearance.BorderSize = 1;
                Choose_O.FlatAppearance.BorderColor = Color.Lime;
                Choose_O.FlatAppearance.BorderSize = 3;
            }
        }

        private void Default_CheckedChanged(object sender, EventArgs e)
        {
            if (Default_Color.Checked)
            {
                Change_Color.Checked = false;
            }
        }

        private void Change_Color_CheckedChanged(object sender, EventArgs e)
        {
            if (Change_Color.Checked)
            {
                Default_Color.Checked = false;

                ColorDialog cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }

        private void B_Play_Click(object sender, EventArgs e)
        {
            Pgame.Dock = DockStyle.Fill;
            Pgame.BringToFront();
        }

        #endregion

        #region playGround

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (turn == true)
            {
                btn.Text = player;
                turn = false;
            }


            else if (turn == false)
            {
                switch (player)
                {
                    case "X":
                        btn.Text = "O";
                        break;

                    case "O":
                        btn.Text = "X";
                        break;
                }
                turn = true;
            }
            btn.Enabled = false;
            Check_for_win();

        }

        #endregion

        #region score



        #endregion

        #region tools

        private void Check_for_win()
        {
            #region var
            string btn1 = button1.Text;
            string btn2 = button2.Text;
            string btn3 = button3.Text;
            string btn4 = button4.Text;
            string btn5 = button5.Text;
            string btn6 = button6.Text;
            string btn7 = button7.Text;
            string btn8 = button8.Text;
            string btn9 = button9.Text;
            #endregion

            #region if
            if (btn1 == btn2 && btn3 == btn2)     
                after_win();          

            else if (btn4 == btn5 && btn6 == btn5)            
                after_win();

            else if (btn7 == btn8 && btn9 == btn8)            
                after_win();
            
            else if (btn1 == btn4 && btn7 == btn4) 
                after_win();
            
            else if (btn2 == btn5 && btn8 == btn5)            
                after_win();

            else if (btn3 == btn6 && btn9 == btn6)
                after_win();
            
            else if (btn1 == btn5 && btn9 == btn5)
                after_win();

            else if (btn3 == btn5 && btn7 == btn5)
                after_win();
            
            #endregion
        }

        private void after_win()
        {
            int wins = 0;
            if (turn = true)
            {
                wins += 1;
                C_win.Text = wins.ToString();
            }
        }
        #endregion
    }
}
