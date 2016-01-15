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
            if (button1.Text.Equals(button2.Text.Equals(button3.Text)))
            {
                MessageBox.Show("Tocha");
            }
        }

        #endregion
    }
}
