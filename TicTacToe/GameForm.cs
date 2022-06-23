using System;
using System.Windows.Forms;

namespace TicTacToe2
{
    public partial class GameForm : Form
    {
        private GameController gc;

        public GameForm(bool enableFieldSuggestionHighlight, bool enableFieldStatusHighlight)
        {
            InitializeComponent();

            Button[][] formGameButtons = new Button[][]
            {
                new Button[] {
                 this.button00, this.button01, this.button02,
                 this.button03, this.button04, this.button05,
                 this.button06, this.button07, this.button08,
                 this.button0
                },

                new Button[] {
                 this.button10, this.button11, this.button12,
                 this.button13, this.button14, this.button15,
                 this.button16, this.button17, this.button18,
                 this.button1
                },

                new Button[] {
                 this.button20, this.button21, this.button22,
                 this.button23, this.button24, this.button25,
                 this.button26, this.button27, this.button28,
                 this.button2
                },

                new Button[] {
                 this.button30, this.button31, this.button32,
                 this.button33, this.button34, this.button35,
                 this.button36, this.button37, this.button38,
                 this.button3
                },

                new Button[] {
                 this.button40, this.button41, this.button42,
                 this.button43, this.button44, this.button45,
                 this.button46, this.button47, this.button48,
                 this.button4
                },

                new Button[] {
                 this.button50, this.button51, this.button52,
                 this.button53, this.button54, this.button55,
                 this.button56, this.button57, this.button58,
                 this.button5
                },

                new Button[] {
                 this.button60, this.button61, this.button62,
                 this.button63, this.button64, this.button65,
                 this.button66, this.button67, this.button68,
                 this.button6
                },

                new Button[] {
                 this.button70, this.button71, this.button72,
                 this.button73, this.button74, this.button75,
                 this.button76, this.button77, this.button78,
                 this.button7
                },

                new Button[] {
                 this.button80, this.button81, this.button82,
                 this.button83, this.button84, this.button85,
                 this.button86, this.button87, this.button88,
                 this.button8
                }
            };

            gc = new GameController(formGameButtons, this.currentPlayer, enableFieldSuggestionHighlight, enableFieldSuggestionHighlight);
        }

        private void game_Click(object sender, EventArgs e)
        {
            int fieldNum = (int)char.GetNumericValue((sender as Button).Name[6]);
            int buttonNum = (int)char.GetNumericValue((sender as Button).Name[7]);
            CellButton currentButton = gc.MainField.MiniFields[fieldNum].GetCellButton(buttonNum);
            if (currentButton.CellStatus == Cell.None) gc.Turn(currentButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
