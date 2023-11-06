Console.Title = "Tic-Tac-Toe";
new TicTacToe().Run(); 

class TicTacToe
{ 
    public void Run()
    {
        BoardRender boardRenderer = new BoardRender();
        Board board = new Board();
        Player player1 = new Player(Cell.X);
        Player player2 = new Player(Cell.O);
        int turnCounter = 0;
        Player currentPlayer;
        
        currentPlayer = Player.FirstPlayerChooser(player1, player2);
        Console.Clear();
        
        while (turnCounter < 9) // draw
        {
            Console.WriteLine($"It is {currentPlayer.PlayerMark}'s Turn"); 
            boardRenderer.UpdateBoard(board);
            BoardSquare boardSquare = currentPlayer.ChooseSquare(board);
            board.MarkCell(boardSquare.Row, boardSquare.Col, currentPlayer.PlayerMark);
            
            if (CheckVictory(board, currentPlayer.PlayerMark))
            {
                Console.Clear();
                boardRenderer.UpdateBoard(board);
                Console.WriteLine($"{currentPlayer.PlayerMark} has WON !!!!\n");
                return;
            }
            currentPlayer = (currentPlayer == player1) ? player2 : player1;
            turnCounter++;
            Console.Clear();
        }
        
        Console.WriteLine("Its a Draw!!\n");
        boardRenderer.UpdateBoard(board);
    }

    public bool CheckVictory(Board board, Cell markValue)
    {
        // horizontal
        if (board.GetMarkers(0, 0) == markValue && board.GetMarkers(0, 1) == markValue && board.GetMarkers(0, 2) == markValue) 
            return true;
        if (board.GetMarkers(1, 0) == markValue && board.GetMarkers(1, 1) == markValue && board.GetMarkers(1, 2) == markValue)
            return true;
        if (board.GetMarkers(2, 0) == markValue && board.GetMarkers(2, 1) == markValue && board.GetMarkers(2, 2) == markValue)
            return true;

        // vertical
        if (board.GetMarkers(0, 0) == markValue && board.GetMarkers(1, 0) == markValue && board.GetMarkers(2, 0) == markValue)
            return true;
        if (board.GetMarkers(0, 1) == markValue && board.GetMarkers(1, 1) == markValue && board.GetMarkers(2, 1) == markValue)
            return true;
        if (board.GetMarkers(0, 2) == markValue && board.GetMarkers(1, 2) == markValue && board.GetMarkers(2, 2) == markValue)
            return true;

        // diagonals
        if (board.GetMarkers(0, 0) == markValue && board.GetMarkers(1, 1) == markValue && board.GetMarkers(2, 2) == markValue)
            return true;
        if (board.GetMarkers(0, 2) == markValue && board.GetMarkers(1, 1) == markValue && board.GetMarkers(2, 0) == markValue)
            return true;

        return false;
    }
}

class Player
{
    public Cell PlayerMark { get; }
    
    public Player(Cell playerMark)
    {
        PlayerMark = playerMark;

    }

    public BoardSquare ChooseSquare(Board board)
    {
        while (true)
        {
            Console.Write("Which square do you want to play in? (Use numPad) ");
            ConsoleKey playerMove = Console.ReadKey().Key;
            Console.WriteLine();

            BoardSquare choice = playerMove switch
            {
                ConsoleKey.NumPad7 => new BoardSquare(0, 0),
                ConsoleKey.NumPad8 => new BoardSquare(0, 1),
                ConsoleKey.NumPad9 => new BoardSquare(0, 2),
                ConsoleKey.NumPad4 => new BoardSquare(1, 0),
                ConsoleKey.NumPad5 => new BoardSquare(1, 1),
                ConsoleKey.NumPad6 => new BoardSquare(1, 2),
                ConsoleKey.NumPad1 => new BoardSquare(2, 0),
                ConsoleKey.NumPad2 => new BoardSquare(2, 1),
                ConsoleKey.NumPad3 => new BoardSquare(2, 2),
            };
               
            if (board.CheckIfIsEmpty(choice.Row, choice.Col))
            {
                return choice; 
            }
            else
            {
                Console.WriteLine("Illegal Move, this square is already taken.");
            }
        }
    }
    
    public static Player FirstPlayerChooser(Player player1, Player player2)
    {
        Console.Write($"How goes first? 1 -> {Cell.X} or 2 -> {Cell.O}: ");
        int firstPlayerChoice = Convert.ToInt32(Console.ReadLine());
        
        if (firstPlayerChoice == 1)
        {
            return player1;
        }
        else
        {
            return player2;
        }
    }
}

class Board
{
    private Cell[,] _boardCells = new Cell[3, 3];

    public void MarkCell(int row, int col, Cell playerMark)
    {
        _boardCells[row, col] = playerMark; 
    }

    public bool CheckIfIsEmpty(int row, int col)
    {
        if (_boardCells[row, col] == Cell.Empty)
        {
            return true;
        }
        return false;
    }
    public Cell GetMarkers(int row, int col)
    {
        
        if(_boardCells[row, col] == Cell.X)
        {
            return Cell.X;
        }
        else if (_boardCells[row, col] == Cell.O)
        {
            return Cell.O;
        }
        return Cell.Empty;
    }
    
}
  
class BoardRender
{
    public void UpdateBoard(Board board)
    {

        Console.WriteLine($" {GetEnumAsChar(board.GetMarkers(0, 0))} | {GetEnumAsChar(board.GetMarkers(0, 1))} | {GetEnumAsChar(board.GetMarkers(0, 2))} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {GetEnumAsChar(board.GetMarkers(1, 0))} | {GetEnumAsChar(board.GetMarkers(1, 1))} | {GetEnumAsChar(board.GetMarkers(1, 2))} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {GetEnumAsChar(board.GetMarkers(2, 0))} | {GetEnumAsChar(board.GetMarkers(2, 1))} | {GetEnumAsChar(board.GetMarkers(2, 2))} ");
        Console.WriteLine();
    }
    private char GetEnumAsChar(Cell enumChars)
    {
        return enumChars switch
        {
            Cell.X => 'X',
            Cell.O => 'O',
            Cell.Empty => ' ',
        };

    }
}

class BoardSquare
{
    public int Row { get; }
    public int Col { get; }
    public BoardSquare(int row, int col)
    {
        Row = row;
        Col = col;
    }
}
public enum Cell { Empty, X, O}        
