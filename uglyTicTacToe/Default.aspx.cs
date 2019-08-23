using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace uglyTicTacToe
{
    public partial class Default : Page
    {
        // Turn Count is keeping track of two things:
        private const string TurnViewStateKey = "CurrentTurn";
        public int turn
        {
            get
            {
                object viewStateNumber = ViewState[TurnViewStateKey];
                if (viewStateNumber != null)
                {
                    return (int)viewStateNumber;
                }
                else
                {
                    // Start on turn 0 as default.
                    return 0;
                }
            }
            set
            {
                ViewState[TurnViewStateKey] = value;
            }
        }

        // The biggest most colossal waste of my life.
        private void ComputerMove()
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            // Keeps track of the turn. Mainly useful for debugging.
            //TurnNumber.Text = turn.ToString();

            string topLeftText = TopLeft.Text;

            if (turn % 2 != 0)
            {
                ComputerMove();
            }

            //if((TopLeft.Text != " " && TopLeft.Text == Top.Text && TopLeft.Text == TopRight.Text) ||
            //    (Left.Text != " " && Left.Text == Center.Text && Left.Text == Right.Text) ||
            //    (BottomLeft.Text != " " && BottomLeft.Text == Bottom.Text && BottomLeft.Text == BottomRight.Text) ||

            //    (TopLeft.Text != " " && TopLeft.Text == Left.Text && TopLeft.Text == BottomRight.Text) ||
            //    (Top.Text != " " && Top.Text == Center.Text && Top.Text == Bottom.Text) ||
            //    (TopRight.Text != " " && TopRight.Text == Right.Text && TopRight.Text == BottomRight.Text) ||

            //    (TopLeft.Text != " " && TopLeft.Text == Center.Text && TopLeft.Text == BottomRight.Text) ||
            //    (BottomLeft.Text != " " && BottomLeft.Text == Center.Text && BottomLeft.Text == TopRight.Text))
            //{

            if ((TopLeft.Text != " " && TopLeft.Text == Top.Text && TopLeft.Text == TopRight.Text) ||
                (TopLeft.Text != " " && TopLeft.Text == Left.Text && TopLeft.Text == BottomLeft.Text) ||
                (TopLeft.Text != " " && TopLeft.Text == Center.Text && TopLeft.Text == BottomRight.Text))
            {
                if (TopLeft.Text == "X")
                {
                    DeclareWinner("X");
                }
                else
                {
                    DeclareWinner("O");
                }
            }
            // Seems a bit weird to check right, but it has a commonality.
            else if (Right.Text != " " && Right.Text == Center.Text && Right.Text == Left.Text ||
                (Right.Text != " " && Right.Text == TopRight.Text && Right.Text == BottomRight.Text))
            {
                if (Left.Text == "X")
                {
                    DeclareWinner("X");
                }
                else
                {
                    DeclareWinner("O");
                }
            }
            else if (Top.Text != " " && Top.Text == Center.Text && Top.Text == Bottom.Text)
            {
                if (Top.Text == "X")
                {
                    DeclareWinner("X");
                }
                else
                {
                    DeclareWinner("O");
                }
            }
            else if ((BottomLeft.Text != " " && BottomLeft.Text == Bottom.Text && BottomLeft.Text == BottomRight.Text) ||
                (BottomLeft.Text != " " && BottomLeft.Text == Center.Text && BottomLeft.Text == TopRight.Text))
            {
                if (BottomLeft.Text == "X")
                {
                    DeclareWinner("X");
                }
                else
                {
                    DeclareWinner("O");
                }
            }
            else if (turn == 9)
            {
                Result.Text = "It was a tie! Play again?";
            }
        }

        private void DeclareWinner(string winner)
        {
            Board.Enabled = false;

            Result.Text = $"{winner} has won!";
        }

        private void BoardUpdate(Button pressedButton)
        {
                if (turn % 2 == 0)
                {
                    pressedButton.Text = "X";
                    pressedButton.Enabled = false;
                }
                else
                {
                    pressedButton.Text = "O";
                    pressedButton.Enabled = false;
                }
                turn++;
        }

        protected void TopLeft_Click(object sender, EventArgs e)
        {
            BoardUpdate(TopLeft);
        }
        protected void Top_Click(object sender, EventArgs e)
        {
            BoardUpdate(Top);
        }
        protected void TopRight_Click(object sender, EventArgs e)
        {
            BoardUpdate(TopRight);
        }
        protected void Left_Click(object sender, EventArgs e)
        {
            BoardUpdate(Left);
        }
        protected void Center_Click(object sender, EventArgs e)
        {
            BoardUpdate(Center);
        }
        protected void Right_Click(object sender, EventArgs e)
        {
            BoardUpdate(Right);
        }
        protected void BottomLeft_Click(object sender, EventArgs e)
        {
            BoardUpdate(BottomLeft);
        }
        protected void Bottom_Click(object sender, EventArgs e)
        {
            BoardUpdate(Bottom);
        }
        protected void BottomRight_Click(object sender, EventArgs e)
        {
            BoardUpdate(BottomRight);
        }
    }
}
