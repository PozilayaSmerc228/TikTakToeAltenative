using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe2
{
    public class MainField : Field
    {
        private MiniField[] _miniFields = new MiniField[9];

        public MiniField[] MiniFields { get => this._miniFields; }

        public bool GetMiniFieldAvalibility(int fieldNum) 
        {
            return _miniFields[fieldNum].isFull();
        }

        public void SetMiniFieldActive(int fieldNum, bool isActive)
        {
            _miniFields[fieldNum].SetActive(isActive);
        }

        public MainField(Button[][] fieldButtons, bool highlightEnable)
        {

            for (int k = 0; k < 9; k++) 
            {
                this._miniFields[k] = new MiniField(k, fieldButtons[k], highlightEnable);
            }
        }

        public void ShowGameResult() 
        {
            for (int k = 0; k < 9; k++) this._miniFields[k].FieldStatusButton.Visible = true;
        }

        public override void RecalculateStatus()
        {
            if (this._winCondition == WinCondition.None)
            {
                if (_miniFields[0].FieldStatus != Cell.None && _miniFields[0].FieldStatus == _miniFields[1].FieldStatus && _miniFields[1].FieldStatus == _miniFields[2].FieldStatus)
                {
                    _fieldStatus = _miniFields[0].FieldStatus;
                    _winCondition = WinCondition.TopRow;

                    _miniFields[0].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[1].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[2].FieldStatusButton.BackColor = Color.Cyan;
                }
                else if (_miniFields[3].FieldStatus != Cell.None && _miniFields[3].FieldStatus == _miniFields[4].FieldStatus && _miniFields[4].FieldStatus == _miniFields[5].FieldStatus)
                {
                    _fieldStatus = _miniFields[3].FieldStatus;
                    _winCondition = WinCondition.MiddleRow;

                    _miniFields[3].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[4].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[5].FieldStatusButton.BackColor = Color.Cyan;
                }
                else if (_miniFields[6].FieldStatus != Cell.None && _miniFields[6].FieldStatus == _miniFields[7].FieldStatus && _miniFields[7].FieldStatus == _miniFields[8].FieldStatus)
                {
                    _fieldStatus = _miniFields[6].FieldStatus;
                    _winCondition = WinCondition.BottomRow;

                    _miniFields[6].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[7].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[8].FieldStatusButton.BackColor = Color.Cyan;
                }
                else if (_miniFields[0].FieldStatus != Cell.None && _miniFields[0].FieldStatus == _miniFields[3].FieldStatus && _miniFields[3].FieldStatus == _miniFields[6].FieldStatus)
                {
                    _fieldStatus = _miniFields[0].FieldStatus;
                    _winCondition = WinCondition.LeftColumn;

                    _miniFields[0].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[3].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[6].FieldStatusButton.BackColor = Color.Cyan;
                }
                else if (_miniFields[1].FieldStatus != Cell.None && _miniFields[1].FieldStatus == _miniFields[4].FieldStatus && _miniFields[4].FieldStatus == _miniFields[7].FieldStatus)
                {
                    _fieldStatus = _miniFields[1].FieldStatus;
                    _winCondition = WinCondition.MiddleColumn;

                    _miniFields[1].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[4].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[7].FieldStatusButton.BackColor = Color.Cyan;
                }
                else if (_miniFields[2].FieldStatus != Cell.None && _miniFields[2].FieldStatus == _miniFields[5].FieldStatus && _miniFields[5].FieldStatus == _miniFields[8].FieldStatus)
                {
                    _fieldStatus = _miniFields[2].FieldStatus;
                    _winCondition = WinCondition.RightColumn;

                    _miniFields[2].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[5].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[8].FieldStatusButton.BackColor = Color.Cyan;
                }
                else if (_miniFields[0].FieldStatus != Cell.None && _miniFields[0].FieldStatus == _miniFields[4].FieldStatus && _miniFields[4].FieldStatus == _miniFields[8].FieldStatus)
                {
                    _fieldStatus = _miniFields[0].FieldStatus;
                    _winCondition = WinCondition.LeftToRightCorner;

                    _miniFields[0].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[4].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[8].FieldStatusButton.BackColor = Color.Cyan;
                }
                else if (_miniFields[2].FieldStatus != Cell.None && _miniFields[2].FieldStatus == _miniFields[4].FieldStatus && _miniFields[4].FieldStatus == _miniFields[6].FieldStatus)
                {
                    _fieldStatus = _miniFields[2].FieldStatus;
                    _winCondition = WinCondition.RightToLeftCorner;

                    _miniFields[2].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[4].FieldStatusButton.BackColor = Color.Cyan;
                    _miniFields[6].FieldStatusButton.BackColor = Color.Cyan;
                }
            }
        }
    }
}
