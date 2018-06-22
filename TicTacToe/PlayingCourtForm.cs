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
    /*class PlayingCourt
    {
        char[,] courtMatrix = new char[3, 3];
        public char checkWinner(char xo)
        {
            int coll=0, roww=0;
            for (int row = 0; row < 3; row++) 
            {
                if (courtMatrix[row,coll] == courtMatrix[row,coll + 1] && courtMatrix[row,coll] == courtMatrix[row,coll+2] && courtMatrix[row,coll] == xo)
                    return xo;
            }

            for (int col = 0; col < 3; col++) 
            {
                if (courtMatrix[roww,col] == courtMatrix[roww + 1,col] && courtMatrix[roww,col] == courtMatrix[roww + 2,col] && courtMatrix[roww,col] == xo)
                    return xo;
            }
            
            if (courtMatrix[0,0] == courtMatrix[1,1] && courtMatrix[0,0] == courtMatrix[2,2] && courtMatrix[0,0] == xo)
                return xo;
            else if (courtMatrix[1,1] == courtMatrix[0,2] && courtMatrix[1,1] == courtMatrix[2,0] && courtMatrix[1,1] == xo)
                return xo;
        }
    }
    public class Player
    {
        string playerName;
        int score = new int();
        bool turn = new bool();
        bool xORo = new bool();

        public Player() 
        {
            score = 0;
            turn = false;
        }
    }*/

    public partial class PlayingCourtForm : Form
    {
        public PlayingCourtForm()
        {
            InitializeComponent();
            //Player player1 = new Player();
            //Player player2 = new Player();
        }
        string playerName;
        int score = 0;
        bool winned = false;
        char xORo = 'X';
        char[] courtMatrix = new char[9];

        public void newGame()
        {
            Array.Clear(courtMatrix, 0, courtMatrix.Length);
        }
        public void checkWinner()
        {
            if (courtMatrix[0] == courtMatrix[4] && courtMatrix[0] == courtMatrix[8] && courtMatrix[0] == xORo)
                winned = true;

            else if (courtMatrix[2] == courtMatrix[4] && courtMatrix[2] == courtMatrix[6] && courtMatrix[2] == xORo)
                winned = true;

            else
            {
                for (int i = 0; i < 7; i += 3)
                {
                    if (courtMatrix[i] == courtMatrix[i + 1] && courtMatrix[i] == courtMatrix[i + 2] && courtMatrix[i] == xORo)
                    {
                        winned = true;
                        break;
                    }
                }

                if (!winned)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (courtMatrix[i] == courtMatrix[i + 3] && courtMatrix[i] == courtMatrix[i + 6] && courtMatrix[i] == xORo)
                        {
                            winned = true;
                            break;
                        }
                    }
                }
            }
        }
        public void play(int pos)
        {
            courtMatrix[pos] = xORo;
            for (int i = 0; i < 9; i++) 
            {
                Console.Write(courtMatrix[i]);
            }
            checkWinner();
            if (winned)
                MessageBox.Show("Winner is " + xORo);

            if (xORo == 'X')
                xORo = 'O';
            else
                xORo = 'X';
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            asd f1 = new asd();
            f1.Show(); // Shows Form1
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)              //[0][0] Button
        {
            button1.Enabled = false;
            button1.Text = xORo.ToString();
            play(0);
        }

        private void button2_Click_1(object sender, EventArgs e)              //[0][1] Button
        {
            button2.Enabled = false;
            button2.Text = xORo.ToString();
            play(1);
        }

        private void button3_Click_1(object sender, EventArgs e)              //[0][2] Button
        {
            button3.Enabled = false;
            button3.Text = xORo.ToString();
            play(2);
        }

        private void button4_Click_1(object sender, EventArgs e)              //[1][0] Button
        {
            button4.Enabled = false;
            button4.Text = xORo.ToString();
            play(3);
        }

        private void button5_Click_1(object sender, EventArgs e)              //[1][1] Button
        {
            button5.Enabled = false;
            button5.Text = xORo.ToString();
            play(4);
        }

        private void button6_Click_1(object sender, EventArgs e)              //[1][2] Button
        {
            button6.Enabled = false;
            button6.Text = xORo.ToString();
            play(5);
        }

        private void button7_Click_1(object sender, EventArgs e)              //[2][0] Button
        {
            button7.Enabled = false;
            button7.Text = xORo.ToString();
            play(6);
        }

        private void button8_Click_1(object sender, EventArgs e)              //[2][1] Button
        {
            button8.Enabled = false;
            button8.Text = xORo.ToString();
            play(7);
        }

        private void button9_Click_1(object sender, EventArgs e)              //[2][2] Button
        {
            button9.Enabled = false;
            button9.Text = xORo.ToString();
            play(8);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
