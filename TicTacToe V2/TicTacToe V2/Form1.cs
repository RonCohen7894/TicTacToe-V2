using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Pmain_Menu.Dock = DockStyle.Fill;
            Pmain_Menu.BringToFront();

            Button[] btns = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (Button btn in btns)
                btn.FlatAppearance.BorderSize = 0;
        }

        #region var

        private string player { get; set; }
        private string WinCheckAdd { get; set; }
        private string winPlayer { get; set; }
        #endregion

        #region Main Menu

        private void Choose_Player_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "ply_X":
                    btn.FlatAppearance.BorderColor = Color.Red;
                    btn.FlatAppearance.BorderSize = 3;
                    ply_O.FlatAppearance.BorderColor = Color.Black;
                    ply_O.FlatAppearance.BorderSize = 1;
                    player = "X";
                    break;

                case "ply_O":
                    btn.FlatAppearance.BorderColor = Color.Lime;
                    btn.FlatAppearance.BorderSize = 3;
                    ply_X.FlatAppearance.BorderColor = Color.Black;
                    ply_X.FlatAppearance.BorderSize = 1;
                    player = "O";
                    break;
            }
        }

        private void Bstart_Click(object sender, EventArgs e)
        {
            if (player != null)
            {
                Pmain_Menu.Dock = DockStyle.None;
                Pgame.Dock = DockStyle.Fill;
                Pgame.BringToFront();
                Lpmm_Error.Visible = false;
            }
            else
                Lpmm_Error.Visible = true;
        }

        #endregion

        #region Game

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = player;
            #region addSum

            if (player == "X")
                switch (btn.Name)
                {
                    case "btn1":
                        WinCheckAdd += "a";
                        break;
                    case "btn2":
                        WinCheckAdd += "b";
                        break;
                    case "btn3":
                        WinCheckAdd += "c";
                        break;
                    case "btn4":
                        WinCheckAdd += "d";
                        break;
                    case "btn5":
                        WinCheckAdd += "e";
                        break;
                    case "btn6":
                        WinCheckAdd += "f";
                        break;
                    case "btn7":
                        WinCheckAdd += "g";
                        break;
                    case "btn8":
                        WinCheckAdd += "h";
                        break;
                    case "btn9":
                        WinCheckAdd += "i";
                        break;
                }
            else if (player == "O")
                switch (btn.Name)
                {
                    case "btn1":
                        WinCheckAdd += 10;
                        break;
                    case "btn2":
                        WinCheckAdd += 20;
                        break;
                    case "btn3":
                        WinCheckAdd += 30;
                        break;
                    case "btn4":
                        WinCheckAdd += 40;
                        break;
                    case "btn5":
                        WinCheckAdd += 50;
                        break;
                    case "btn6":
                        WinCheckAdd += 60;
                        break;
                    case "btn7":
                        WinCheckAdd += 70;
                        break;
                    case "btn8":
                        WinCheckAdd += 80;
                        break;
                    case "btn9":
                        WinCheckAdd += 90;
                        break;
                }
            #endregion
            CheckWin();
        }
       
        private void CheckWin()
        {
            if (player == "X" && WinCheckAdd == "abc" || WinCheckAdd == "def" || WinCheckAdd == "ghi" || WinCheckAdd == "adg" || WinCheckAdd == "beh" || WinCheckAdd == "cfi" || WinCheckAdd == "aei" || WinCheckAdd == "ceg")
            {
                winPlayer = "X";
                MessageBox.Show("Player X won");
                restart();
            }

            else if (player == "O" && WinCheckAdd == "60" || WinCheckAdd == "150" || WinCheckAdd == "240" ||
                WinCheckAdd == "120" || WinCheckAdd == "180") winPlayer = "O";
        }

        private void restart()
        {
            WinCheckAdd = "";
            Button[] btns = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (Button btn in btns)
                btn.Text = "";
        }
        #endregion
    }
}