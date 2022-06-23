using System.Windows.Forms;
using System;
using System.Threading;
using System.Linq;

namespace TicTacToe2
{
    public class GameController
    {
        private Cell _player = Cell.Cross;
        private MainField _mainField;
        private PictureBox _currentPlayer;
        private int _currentField = -1;
        private bool _highlightNext;

        public MainField MainField {get => this._mainField;}

        public GameController(Button[][] fieldButtons, PictureBox currentPlayer, bool highlightNext, bool highlightWin)
        {
            this._currentPlayer = currentPlayer;
            this._mainField = new MainField(fieldButtons, highlightWin);
            this._highlightNext = highlightNext;
        }

        public void Turn(CellButton button)
        {
            if (button.ParentField.FieldNum == this._currentField || _currentField == -1) 
            {                
                int nextField = button.Turn(this._player);
                this._mainField.RecalculateStatus();               

                // Game not over yet
                if (this._mainField.WinCondition == WinCondition.None)
                {
                    if (this._highlightNext) 
                    {
                        // Remove old hightlite
                        if (this._currentField == -1)
                        {
                            for (int i = 0; i < 9; i++) this._mainField.SetMiniFieldActive(i, false);
                        }
                        else
                        {
                            this._mainField.SetMiniFieldActive(this._currentField, false);
                        }
                    }  

                    // Change current field
                    this._currentField = this._mainField.GetMiniFieldAvalibility(nextField) ? nextField : -1;

                    if (this._highlightNext)
                    {
                        // Add old hightlite
                        if (this._currentField == -1)
                        {
                            for (int i = 0; i < 9; i++) this._mainField.SetMiniFieldActive(i, true);
                        }
                        else
                        {
                            this._mainField.SetMiniFieldActive(this._currentField, true);
                        }
                    }          

                    _player = _player == Cell.Cross ? Cell.Circle : Cell.Cross;
                    this._currentPlayer.Image = _player == Cell.Cross ? TicTacToe2.Properties.Resources.cross : TicTacToe2.Properties.Resources.circle;
                }
                // Game is over
                else 
                {
                    this._mainField.ShowGameResult();
                    Form.ActiveForm.Refresh();

                    DialogResult dialogResult = MessageBox.Show(
                     String.Format("Победа {0} игрока!", _player == Cell.Cross ? "красного" : "синего"),
                     "Игра окончена",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button1,
                     MessageBoxOptions.DefaultDesktopOnly);

                    Form m = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Menu").FirstOrDefault();
                    Form gf = Application.OpenForms.Cast<Form>().Where(x => x.Name == "GameForm").FirstOrDefault();
                    m.Show();
                    m.Activate();
                    gf.Close();
                }
            }
        }
    }
}
