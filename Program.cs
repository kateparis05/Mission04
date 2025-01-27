// See https://aka.ms/new-console-template for more information
namespace Mission04;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        char[,] board =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        bool gameWon = false;
        int moves = 0;
        char currentPlayer = 'X';

        while (!gameWon && moves < 9)
        {
            TicTacToe.PrintBoard(board);
            Console.Write($"Player {currentPlayer}, enter your move (1-9): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int position) && position >= 1 && position <= 9)
            {
                int row = (position - 1) / 3;
                int col = (position - 1) % 3;

                if (board[row, col] != 'X' && board[row, col] != 'O')
                {
                    board[row, col] = currentPlayer;
                    moves++;
                    gameWon = TicTacToe.CheckWinner(board, currentPlayer);

                    if (gameWon)
                    {
                        TicTacToe.PrintBoard(board);
                        Console.WriteLine($"Player {currentPlayer} wins!");
                    }
                    else
                    {
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("That position is already taken. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
            }
        }

        if (!gameWon)
        {
            TicTacToe.PrintBoard(board);
            Console.WriteLine("It's a draw!");
        }
    }
}


