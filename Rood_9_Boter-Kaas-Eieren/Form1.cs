using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rood_9_Boter_Kaas_Eieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum GameState
        {
            noWinner,
            winner
        }

        enum CellState
        {
            empty,
            X,
            O
        }

        const int maxCells = 9;
        const int HoriCells = 3;
        const int VertCells = 3;

        CellState[] cellStates = new CellState[maxCells];
        System.Windows.Forms.PictureBox[] pictureBoxes = new System.Windows.Forms.PictureBox[maxCells];

        CellState playerTurn;
        GameState gameState;

        Dictionary<CellState, Image> imageDictionary = new Dictionary<CellState, Image>();

        Image background;

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Assert(HoriCells * VertCells == maxCells,
                "vertical and horizontal size don't match amount of cells",
                "Yes, I know doing it like this is error prone. Might fix later.");

            pictureBoxes[0] = pictureBox0;
            pictureBoxes[1] = pictureBox1;
            pictureBoxes[2] = pictureBox2;
            pictureBoxes[3] = pictureBox3;
            pictureBoxes[4] = pictureBox4;
            pictureBoxes[5] = pictureBox5;
            pictureBoxes[6] = pictureBox6;
            pictureBoxes[7] = pictureBox7;
            pictureBoxes[8] = pictureBox8;

            string pathMod = "./../..";

            string imagePath = Path.Combine(Environment.CurrentDirectory, pathMod, "X.png");
            imageDictionary.Add(CellState.X, Image.FromFile(imagePath));

            imagePath = Path.Combine(Environment.CurrentDirectory, pathMod, "O.png");
            imageDictionary.Add(CellState.O, Image.FromFile(imagePath));



            imagePath = Path.Combine(Environment.CurrentDirectory, pathMod, "BKE_Background.png");
            background = Image.FromFile(imagePath);

            pictureBox_Background.Image = background;

            reset_game();
        }

        private void reset_game()
        {
            for (int i = 0; i < maxCells; i++)
            {
                cellStates[i] = CellState.empty;
                pictureBoxes[i].Image = null;
            }
            pictureBoxWinner.Image = null;

            playerTurn = CellState.X;
            gameState = GameState.noWinner;
            pictureBoxTurn.Image = imageDictionary[CellState.X];
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            if(gameState == GameState.winner)
            {
                return;
            }

            for(int i = 0; i < maxCells; i++)
            {
                if( sender == pictureBoxes[i])
                {
                    if(cellStates[i] == CellState.empty)
                    {
                        pictureBoxes[i].Image = imageDictionary[playerTurn];
                        cellStates[i] = playerTurn;
                    }
                }
            }
            if( check_Winner() )
            {
                return;
            }
            changeTurn();
        }

        private void changeTurn()
        {
            if(playerTurn == CellState.X)
            {
                playerTurn = CellState.O;
                pictureBoxTurn.Image = imageDictionary[playerTurn];
            } else if(playerTurn == CellState.O)
            {
                playerTurn = CellState.X;
                pictureBoxTurn.Image = imageDictionary[playerTurn];
            }
        }


        private bool check_Winner()
        {
            // check hori cells (read verti)
            CellState winner = CellState.empty;
            if( cellStates[0] == cellStates[1] && cellStates[1] == cellStates[2] && cellStates[2] != CellState.empty)
            {
                winner = playerTurn;
            } else
            if (cellStates[3] == cellStates[4] && cellStates[4] == cellStates[5] && cellStates[5] != CellState.empty)
            {
                winner = playerTurn;
            }
            else if (cellStates[6] == cellStates[7] && cellStates[7] == cellStates[8] && cellStates[8] != CellState.empty)
            {
                winner = playerTurn;
            }
            else
            //check veri cells (read hori)
            if (cellStates[0] == cellStates[3] && cellStates[3] == cellStates[6] && cellStates[6] != CellState.empty)
            {
                winner = playerTurn;
            }
            else if (cellStates[1] == cellStates[4] && cellStates[4] == cellStates[7] && cellStates[7] != CellState.empty)
            {
                winner = playerTurn;
            }
            else if (cellStates[2] == cellStates[5] && cellStates[5] == cellStates[8] && cellStates[8] != CellState.empty)
            {
                winner = playerTurn;
            }
            else

            //check diag cells
            if (cellStates[0] == cellStates[4] && cellStates[4] == cellStates[8] && cellStates[8] != CellState.empty)
            {
                winner = playerTurn;
            }
            else if (cellStates[2] == cellStates[4] && cellStates[4] == cellStates[6] && cellStates[6] != CellState.empty)
            {
                winner = playerTurn;
            }

            if( winner != CellState.empty)
            {
                gameState = GameState.winner;
                pictureBoxWinner.Image = imageDictionary[playerTurn];
                return true;
            }
            else
            {
                return false;
            }

        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset_game();
        }
    }
}
