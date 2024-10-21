using System.Runtime.Intrinsics.X86;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
// Flag to track which player's turn it is (true for Player 1, false for Player 2)

        bool player1 = true;
        // 2D array to hold references to the buttons (representing the grid)
        Button[,] button = new Button[3, 3];

// Variables to store the number of wins for each player
        int win1 = 0;
        int win2 = 0;

 // Constructor that initializes the form and sets up the button array
        public Form1()
        {
            InitializeComponent();
            button[0, 0] = b1;
            button[0, 1] = b2;
            button[0, 2] = b3;
            button[1, 0] = b4;
            button[1, 1] = b5;
            button[1, 2] = b6;
            button[2, 0] = b7;
            button[2, 1] = b8;
            button[2, 2] = b9;



        }
// Method to check if a player has won the game
        private bool checkWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (button[i, 0].Text == button[i, 1].Text && button[i, 1].Text == button[i, 2].Text && button[i, 0].Text != "" && button[i, 0].Enabled == false)
                {
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (button[0, i].Text == button[1, i].Text && button[1, i].Text == button[2, i].Text && button[0, i].Text != "" && button[0, i].Enabled == false)
                {
                    return true;
                }
            }

            if (button[0, 0].Text == button[1, 1].Text &&
        button[1, 1].Text == button[2, 2].Text &&
        button[0, 0].Text != "" && button[0, 0].Enabled == false)
            {
                return true;
            }

            if (button[0, 2].Text == button[1, 1].Text &&
                button[1, 1].Text == button[2, 0].Text &&
                button[0, 2].Text != "" && button[0, 2].Enabled == false)
            {
                return true;
            }
            return false;
        }
        // Method to reset the board for a new game
        private void resetBoard()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    button[i, j].Text = "";
                    button[i, j].Enabled = true;


                }
            player1 = true;
            turn.Text = "Turn Player 1(X)";
        }
// Event handler for a button click (when a player makes a move)
        private void button2_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (player1 == true)
            {

                player1 = false;
                b.Text = "X";
                turn.Text = "Turn Player 2(O)";
            }
            else
            {

                player1 = true;
                b.Text = "O";
                turn.Text = "Turn Player 1(X)";
            }
            b.Enabled = false;
            if (checkWin())
            {
                if (player1 == false)
                {
                    MessageBox.Show("Winner Player 1(X)", "Winner");
                    win1++;
                    wins1.Text = $"{win1}";
                }
                else
                {
                    MessageBox.Show("Winner Player 2(O)", "Winner");
                    win2++;
                    wins2.Text = $"{win2}";
                }
                // Ask the players if they want to play again
                DialogResult result = MessageBox.Show("Do you want to play again?", "Restart Game", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    resetBoard();
                }
                else
                {

                    this.Close();
                }

            }
            else if (b1.Enabled == false && b2.Enabled == false && b3.Enabled == false && b4.Enabled == false && b5.Enabled == false && b6.Enabled == false && b7.Enabled == false && b8.Enabled == false && b9.Enabled == false)
            {
                {
                    MessageBox.Show("It's a draw!", "No Winner");
                    resetBoard();
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
