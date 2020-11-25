using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldsHardestGame;

namespace Evolution_games
{
    public partial class Form1 : Form
    {
        GameController gc = new GameController();
        GameArea ga;
        int populationSize = 100;
        int nbrOfSteps = 10;
        int nbrofStepsIncrement = 10;
        int generation = 1;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < populationSize; i++)
            {
                gc.AddPlayer(nbrOfSteps);
            }            
            gc.Start();
            ga = gc.ActivateDisplay();
            this.Controls.Add(ga);
        }
    }
}
