using System.Windows.Forms;

namespace TicTacToe2
{
    public class CellButton
    {
        private int _buttonNum;
        private Button _button;
        private Cell _cellStatus;
        private MiniField _parentField;

        public MiniField ParentField { get => this._parentField; }

        public Cell CellStatus 
        {
            get => this._cellStatus;
        }

        public Button Button 
        {
            get => this._button;
        }

        public CellButton(Button button, MiniField parentField, int buttonNum)
        {
            this._button = button;
            this._cellStatus = Cell.None;
            this._parentField = parentField;
            this._buttonNum = buttonNum;
        }

        public int Turn(Cell player)
        {
            this._cellStatus = player;
            this._button.Image = player == Cell.Cross ? TicTacToe2.Properties.Resources.cross : TicTacToe2.Properties.Resources.circle;
            this._parentField.FreeSpace -= 1;
            this._parentField.RecalculateStatus();
            return _buttonNum;
        }
    }
}

