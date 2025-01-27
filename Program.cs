// See https://aka.ms/new-console-template for more information
namespace Mission04;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!"); //welcome message

        //set the board array
        char[,] board =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };
        
        //set variable for ending the game to false so loop keeps going
        bool gameWon = false;
        //make it so we can increment the moves
        int moves = 0;
        //set current player to X
        char currentPlayer = 'X';

        //loop for playing the game that doesnt finish until gameWon is true or moves is 9 or more
        while (!gameWon && moves < 9)
        {
            //call method  PrintBoard from supporting class
            TicTacToe.PrintBoard(board);
            //print out whose turn it is
            Console.Write($"Player {currentPlayer}, enter your move (1-9): ");
            //gather input
            string input = Console.ReadLine();
            
            //validate input
            if (int.TryParse(input, out int position) && position >= 1 && position <= 9)
            {
                //logic to convert their input to row and column indices
                int row = (position - 1) / 3;
                int col = (position - 1) % 3;
                
                //validate the position hasn't already been inputted
                if (board[row, col] != 'X' && board[row, col] != 'O')
                {
                    //insert currentplayers mark into board
                    board[row, col] = currentPlayer;
                    //increment moves
                    moves++;
                    //call the checkwinner method
                    gameWon = TicTacToe.CheckWinner(board, currentPlayer);
                    
                    //if the gameWon is true then print the board and say who won
                    if (gameWon)
                    {
                        TicTacToe.PrintBoard(board);
                        Console.WriteLine($"Player {currentPlayer} wins!");
                    }
                    else //if it is still false then change the current player to O instead of X and vice versa
                    {
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    }
                }
                else //what prints if you gave a taken input
                {
                    Console.WriteLine("That position is already taken. Try again.");
                }
            }
            else //if they don't put in a valid input
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
            }
        }
        
        //if there are 9 moves made and the gameWon variable is false then it is a draw
        if (!gameWon)
        {
            TicTacToe.PrintBoard(board);
            Console.WriteLine("It's a draw!");
        }
    }
}


