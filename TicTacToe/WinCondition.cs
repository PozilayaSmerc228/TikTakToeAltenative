namespace TicTacToe2
{
    public enum WinCondition
    {
        None = 0,
        TopRow,
        MiddleRow,
        BottomRow,
        LeftColumn,
        MiddleColumn,
        RightColumn,
        LeftToRightCorner,
        RightToLeftCorner
    }
}