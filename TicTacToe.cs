namespace Mission04;

public class TicTacToe
{
    public static void PrintBoard(char[,] board)
    {
        Console.WriteLine("\n  {0} | {1} | {2}", board[0, 0], board[0, 1], board[0, 2]);
        Console.WriteLine(" ---|---|---");
        Console.WriteLine("  {0} | {1} | {2}", board[1, 0], board[1, 1], board[1, 2]);
        Console.WriteLine(" ---|---|---");
        Console.WriteLine("  {0} | {1} | {2}\n", board[2, 0], board[2, 1], board[2, 2]);
    }

    public static bool CheckWinner(char[,] board, char player)
    {
        for (int i = 0; i < 3; i++)
        {
            if ((board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) ||
                (board[0, i] == player && board[1, i] == player && board[2, i] == player))
            {
                return true;
            }
        }

        if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
            (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
        {
            return true;
        }

        return false;
    }
}