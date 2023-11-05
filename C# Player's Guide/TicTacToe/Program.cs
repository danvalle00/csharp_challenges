Console.Title = "Tic-Tac-Toe";

BoardHandler boardHandler = new();
int turnCounter = 0;

while (turnCounter < 9) // 9 is the maximum amount of turns that an TicTacToe can have.
{
    boardHandler.GameWinner();
    
    Console.WriteLine($"It is {BoardHandler.PlayerTurnHandler(turnCounter)}'s Turn. ");
    boardHandler.UpdateBoard();
    Console.Write("What square do you want do play in? ");
    int playerChoice = Convert.ToInt32(Console.ReadLine());
    
    int[] playerCoord = BoardHandler.MakeAMove(playerChoice);
    
    if (!boardHandler.CheckSquareAvailable(playerCoord)) 
    {
        continue;
    }
       
    boardHandler.MarkingTheBoard(BoardHandler.PlayerTurnHandler(turnCounter), playerCoord);
    turnCounter++;
}
    

boardHandler.UpdateBoard();
Console.WriteLine("Its a Draw!!!1");

class BoardHandler
{
    public string[,] _boardSquare = new string[3, 3];
    
    public BoardHandler()
    {
        _boardSquare = new string[3, 3] 
        {   { " ", " ", " "}, 
            { " ", " ", " "}, 
            { " ", " ", " "} 
        };
    }
    
    public static string PlayerTurnHandler(int turnCounter)
    {
        string playerTurnMarker;
        if (turnCounter % 2 == 0)
        {
            playerTurnMarker = "X";
        }
        else
        {
            playerTurnMarker = "O";
        } 
        return playerTurnMarker;
    }
    
    public static int[] MakeAMove(int playerMove) 
    {
        int[] playerMoveCoords = new int[2];
        switch (playerMove)
        {
            case 1:
                playerMoveCoords[0] = 2; playerMoveCoords[1] = 0;
                break;               
            case 2:                
                playerMoveCoords[0] = 2; playerMoveCoords[1] = 1;
                break;
            case 3:                
                playerMoveCoords[0] = 2; playerMoveCoords[1] = 2;
                break;
            case 4:                
                playerMoveCoords[0] = 1; playerMoveCoords[1] = 0;
                break;
            case 5:                
                playerMoveCoords[0] = 1; playerMoveCoords[1] = 1;
                break;
            case 6:                
                playerMoveCoords[0] = 1; playerMoveCoords[1] = 2;
                break;
            case 7:                
                playerMoveCoords[0] = 0; playerMoveCoords[1] = 0;
                break;
            case 8:                
                playerMoveCoords[0] = 0; playerMoveCoords[1] = 1;
                break;
            case 9:               
                playerMoveCoords[0] = 0; playerMoveCoords[1] = 2;
                break;
        }  
        return playerMoveCoords;

    }

    public void MarkingTheBoard(string playerTurnMarker, int[] playerCoords)
    {
        _boardSquare[playerCoords[0], playerCoords[1]] = playerTurnMarker;   
    }

    public bool CheckSquareAvailable(int[] playerMoveCoord)
    {
        if (_boardSquare[playerMoveCoord[0], playerMoveCoord[1]] == " ")
        {
            return true;
        }
        Console.WriteLine("Illegal Move, Try again.");
        return false;    
    }

    public void UpdateBoard()
    {
        Console.WriteLine();
        Console.WriteLine($" {_boardSquare[0, 0]} | {_boardSquare[0, 1]} | {_boardSquare[0, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {_boardSquare[1, 0]} | {_boardSquare[1, 1]} | {_boardSquare[1, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {_boardSquare[2, 0]} | {_boardSquare[2, 1]} | {_boardSquare[2, 2]} ");
        Console.WriteLine();
    }

    public void GameWinner() // same X, same Y, same X and Y, diagonal oposta 
    {
        for (int i = 0; i < _boardSquare.GetLength(0); i++)
        {
            for (int j = 0; j < _boardSquare.GetLength(1); j++)
            {
                
            }
        }
    }

}

    
        
