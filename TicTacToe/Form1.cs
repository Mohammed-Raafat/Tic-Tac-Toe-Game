using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.MessageBox;

namespace TicTacToe
{
    public partial class asd : Form
    {
        public asd()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)                  //1 Player Button
        {

        }

        private void button2_Click(object sender, EventArgs e)                  //2 Player Button
        {
            PlayingCourtForm f2 = new PlayingCourtForm();
            f2.Show(); // Shows Form2
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)                  //About Button
        {
            MessageBox.Show("Designed and Programmed Using C# by :\n\n           --------------------------------\n              Mohammed Raafat Ibrahim \n            --------------------------------\n\n", "About");
        }

        private void button3_Click(object sender, EventArgs e)                  //Quit Button
        {
            this.Close();
        }
    }
}
