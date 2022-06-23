namespace TicTacToe2
{
    public abstract class Field
    {
        protected Cell _fieldStatus = Cell.None;
        protected WinCondition _winCondition = WinCondition.None;
    
        public Cell FieldStatus
        {
            get => _fieldStatus;
        }

        public WinCondition WinCondition
        {
            get => _winCondition;
        }

        public abstract void RecalculateStatus();

    }
}

