namespace Mission04;

//creating a new public class, TicTacToe
public class TicTacToe
{
    //creating the printboard method, displays the numbers on the board, as well as the lines that separate everything
    //as the user begins to input data, it uses the data stored in the board array to populate the board in the terminal
    // takes the board as an array
    public static void PrintBoard(char[,] board)
    {
        Console.WriteLine("\n  {0} | {1} | {2}", board[0, 0], board[0, 1], board[0, 2]);
        Console.WriteLine(" ---|---|---");
        Console.WriteLine("  {0} | {1} | {2}", board[1, 0], board[1, 1], board[1, 2]);
        Console.WriteLine(" ---|---|---");
        Console.WriteLine("  {0} | {1} | {2}\n", board[2, 0], board[2, 1], board[2, 2]);
    }

    // checkwinner function, takes the board as an argument, as well as the player to determin who the winner is. 
    public static bool CheckWinner(char[,] board, char player)
    {
        // for loop that iterates 3 times to go through each position on the board
        for (int i = 0; i < 3; i++)
        {
            // this is checking if one of the users has won the game, it checks all vertical and horiztonal combinations

            if ((board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) || // this checks horizontal winning combinations
                (board[0, i] == player && board[1, i] == player && board[2, i] == player)) // this checks vertical winning combinations
            {
                return true;
            }
        }
        // this checks to see if one of the users has won diagonally, checks both possible diagonal combinations
        if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
            (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player))
        {
            return true;
        }

        return false;
    }
}