using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int randomNumber;

        private void GuessButton_Click(object sender, EventArgs e)
        {
            if (randomNumber == 0) ;
            {
                Random randGen = new Random();
                randomNumber = randGen.Next(1 - 101);
            }
            if (randomNumber > 0)
            {

            }
        }
    }
}
