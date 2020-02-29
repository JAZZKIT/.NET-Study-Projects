using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        bool TurnX_O = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button senderBut = (Button)sender;
            if (TurnX_O)
                senderBut.Text = "X";
            else
                senderBut.Text = "O";
            TurnX_O = !TurnX_O;
            senderBut.Enabled = false;

            Checker(senderBut);
        }

        void Checker(Button lastClick)
        {
            //----------Horizontal----------
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Enabled == false)
            {
                MessageBox.Show("Win - " + lastClick.Text);
                Application.Restart();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Enabled == false)
            {
                MessageBox.Show("Win - " + lastClick.Text);
                Application.Restart();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Enabled == false)
            {
                MessageBox.Show("Win - " + lastClick.Text);
                Application.Restart();
            }

            //----------Vertical----------
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Enabled == false)
            {
                MessageBox.Show("Win - " + lastClick.Text);
                Application.Restart();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Enabled == false)
            {
                MessageBox.Show("Win - " + lastClick.Text);
                Application.Restart();
            }
            if (button3.Text == button6.Text && button9.Text == button9.Text && button3.Enabled == false)
            {
                MessageBox.Show("Win - " + lastClick.Text);
                Application.Restart();
            }

            //----------Diagonal----------
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Enabled == false)
            {
                MessageBox.Show("Win - " + lastClick.Text);
                Application.Restart();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Enabled == false)
            {
                MessageBox.Show("Win - " + lastClick.Text);
                Application.Restart();
            }
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnX_O = true;
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnX_O = false;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void fQAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. The game is played on a grid that's 3 squares by 3 squares.\n" +
                "2. You are X, your friend(or the computer in this case) is O.Players take turns putting their marks in empty squares.\n" +
                "3. The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner.\n" +
                "4. When all 9 squares are full, the game is over.If no player has 3 marks in a row, the game ends in a tie.");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WinForm test project by JÄZZKIIT");
        }
    }
}