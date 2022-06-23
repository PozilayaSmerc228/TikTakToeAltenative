using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe2
{
    public class MiniField : Field
    {
        private CellButton[,] _fieldButtons = new CellButton[3, 3];
        private Button _fieldStatusButton;
        private int _fieldNum;
        private int _freeSpace;
        private bool _highlightEnable;

        public int FieldNum { get => this._fieldNum; }

        public int FreeSpace { get => this._freeSpace;  set => this._freeSpace = value; }

        public Button FieldStatusButton { get => this._fieldStatusButton; }


        public CellButton GetCellButton(int cellNum)
        {
            switch (cellNum) 
            {
                case 0: return this._fieldButtons[0, 0];
                case 1: return this._fieldButtons[0, 1];
                case 2: return this._fieldButtons[0, 2];
                case 3: return this._fieldButtons[1, 0];
                case 4: return this._fieldButtons[1, 1];
                case 5: return this._fieldButtons[1, 2];
                case 6: return this._fieldButtons[2, 0];
                case 7: return this._fieldButtons[2, 1];
                case 8: return this._fieldButtons[2, 2];
                default: return null;
            }
        }

        public MiniField(int fieldNum, Button[] fieldButtons, bool highlightEnable) 
        {
            this._freeSpace = 9;
            this._fieldNum = fieldNum;
            int k = 0;
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    this._fieldButtons[i, j] = new CellButton(fieldButtons[k], this, k);
                    k++;
                }
            }
            this._fieldStatusButton = fieldButtons[9];
            this._highlightEnable = highlightEnable;
        }

        public bool isFull() 
        {
            return this._freeSpace > 0;
        }

        public void SetActive(bool isActive)
        {
            for (int i = 0; i < 9; i++) GetCellButton(i).Button.BackColor = GetCellButton(i).Button.BackColor != Color.Cyan ? (isActive ? Color.LightYellow : Color.White) : Color.Cyan;
        }

        public override void RecalculateStatus()
        {
            if (this._winCondition == WinCondition.None) 
            {
                if (_fieldButtons[0, 0].CellStatus != Cell.None && _fieldButtons[0, 0].CellStatus == _fieldButtons[0, 1].CellStatus && _fieldButtons[0, 1].CellStatus == _fieldButtons[0, 2].CellStatus)
                {
                    _fieldStatus = _fieldButtons[0, 0].CellStatus;
                    _winCondition = WinCondition.TopRow;

                    if (this._highlightEnable)
                    {
                        _fieldButtons[0, 0].Button.BackColor = Color.Cyan;
                        _fieldButtons[0, 1].Button.BackColor = Color.Cyan;
                        _fieldButtons[0, 2].Button.BackColor = Color.Cyan;
                    }

                }
                else if (_fieldButtons[1, 0].CellStatus != Cell.None && _fieldButtons[1, 0].CellStatus == _fieldButtons[1, 1].CellStatus && _fieldButtons[1, 1].CellStatus == _fieldButtons[1, 2].CellStatus)
                {
                    _fieldStatus = _fieldButtons[1, 0].CellStatus;
                    _winCondition = WinCondition.MiddleRow;

                    if (this._highlightEnable)
                    {
                        _fieldButtons[1, 0].Button.BackColor = Color.Cyan;
                        _fieldButtons[1, 1].Button.BackColor = Color.Cyan;
                        _fieldButtons[1, 2].Button.BackColor = Color.Cyan;
                    }

                }
                else if (_fieldButtons[2, 0].CellStatus != Cell.None && _fieldButtons[2, 0].CellStatus == _fieldButtons[2, 1].CellStatus && _fieldButtons[2, 1].CellStatus == _fieldButtons[2, 2].CellStatus)
                {
                    _fieldStatus = _fieldButtons[2, 0].CellStatus;
                    _winCondition = WinCondition.BottomRow;

                    if (this._highlightEnable)
                    {
                        _fieldButtons[2, 0].Button.BackColor = Color.Cyan;
                        _fieldButtons[2, 1].Button.BackColor = Color.Cyan;
                        _fieldButtons[2, 2].Button.BackColor = Color.Cyan;
                    }

                }
                else if (_fieldButtons[0, 0].CellStatus != Cell.None && _fieldButtons[0, 0].CellStatus == _fieldButtons[1, 0].CellStatus && _fieldButtons[1, 0].CellStatus == _fieldButtons[2, 0].CellStatus)
                {
                    _fieldStatus = _fieldButtons[0, 0].CellStatus;
                    _winCondition = WinCondition.LeftColumn;

                    if (this._highlightEnable)
                    {
                        _fieldButtons[0, 0].Button.BackColor = Color.Cyan;
                        _fieldButtons[1, 0].Button.BackColor = Color.Cyan;
                        _fieldButtons[2, 0].Button.BackColor = Color.Cyan;
                    }

                }
                else if (_fieldButtons[0, 1].CellStatus != Cell.None && _fieldButtons[0, 1].CellStatus == _fieldButtons[1, 1].CellStatus && _fieldButtons[1, 1].CellStatus == _fieldButtons[2, 1].CellStatus)
                {
                    _fieldStatus = _fieldButtons[0, 1].CellStatus;
                    _winCondition = WinCondition.MiddleColumn;

                    if (this._highlightEnable)
                    {
                        _fieldButtons[0, 1].Button.BackColor = Color.Cyan;
                        _fieldButtons[1, 1].Button.BackColor = Color.Cyan;
                        _fieldButtons[2, 1].Button.BackColor = Color.Cyan;
                    }

                }
                else if (_fieldButtons[0, 2].CellStatus != Cell.None && _fieldButtons[0, 2].CellStatus == _fieldButtons[1, 2].CellStatus && _fieldButtons[1, 2].CellStatus == _fieldButtons[2, 2].CellStatus)
                {
                    _fieldStatus = _fieldButtons[0, 2].CellStatus;
                    _winCondition = WinCondition.RightColumn;

                    if (this._highlightEnable)
                    {
                        _fieldButtons[0, 2].Button.BackColor = Color.Cyan;
                        _fieldButtons[1, 2].Button.BackColor = Color.Cyan;
                        _fieldButtons[2, 2].Button.BackColor = Color.Cyan;
                    }

                }
                else if (_fieldButtons[0, 0].CellStatus != Cell.None && _fieldButtons[0, 0].CellStatus == _fieldButtons[1, 1].CellStatus && _fieldButtons[1, 1].CellStatus == _fieldButtons[2, 2].CellStatus)
                {
                    _fieldStatus = _fieldButtons[0, 0].CellStatus;
                    _winCondition = WinCondition.LeftToRightCorner;

                    if (this._highlightEnable)
                    {
                        _fieldButtons[0, 0].Button.BackColor = Color.Cyan;
                        _fieldButtons[1, 1].Button.BackColor = Color.Cyan;
                        _fieldButtons[2, 2].Button.BackColor = Color.Cyan;
                    }

                }
                else if (_fieldButtons[0, 2].CellStatus != Cell.None && _fieldButtons[0, 2].CellStatus == _fieldButtons[1, 1].CellStatus && _fieldButtons[1, 1].CellStatus == _fieldButtons[2, 0].CellStatus)
                {
                    _fieldStatus = _fieldButtons[0, 2].CellStatus;
                    _winCondition = WinCondition.RightToLeftCorner;

                    if (this._highlightEnable)
                    {
                        _fieldButtons[0, 2].Button.BackColor = Color.Cyan;
                        _fieldButtons[1, 1].Button.BackColor = Color.Cyan;
                        _fieldButtons[2, 0].Button.BackColor = Color.Cyan;
                    }

                }

                _fieldStatusButton.BackgroundImage = _fieldStatus == Cell.None ? null : (_fieldStatus == Cell.Cross ? TicTacToe2.Properties.Resources.cross_big : TicTacToe2.Properties.Resources.circle_big);

            }
            
        }
    }
}
