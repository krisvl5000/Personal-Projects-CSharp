using System;

class Program
{
    static void Main()
    {
        // Initialize the grid
        string[,] grid = new string[20, 20];
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                grid[i, j] = ".";
            }
        }

        // Initialize the player's starting position
        int playerX = 0;
        int playerY = 0;
        grid[playerX, playerY] = "P";

        // Display the initial grid
        DisplayGrid(grid);

        while (true)
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey();

            // Move the player
            if (pressedKey.Key == ConsoleKey.UpArrow)
            {
                if (playerX > 0)
                {
                    grid[playerX, playerY] = ".";
                    playerX--;
                    grid[playerX, playerY] = "P";
                }
                else
                {
                    Console.WriteLine("Cannot move up, you are at the top edge!");
                }
            }
            else if (pressedKey.Key == ConsoleKey.DownArrow)
            {
                if (playerX < 19)
                {
                    grid[playerX, playerY] = ".";
                    playerX++;
                    grid[playerX, playerY] = "P";
                }
                else
                {
                    Console.WriteLine("Cannot move down, you are at the bottom edge!");
                }
            }
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
            {
                if (playerY > 0)
                {
                    grid[playerX, playerY] = ".";
                    playerY--;
                    grid[playerX, playerY] = "P";
                }
                else
                {
                    Console.WriteLine("Cannot move left, you are at the left edge!");
                }
            }
            else if (pressedKey.Key == ConsoleKey.RightArrow)
            {
                if (playerY < 19)
                {
                    grid[playerX, playerY] = ".";
                    playerY++;
                    grid[playerX, playerY] = "P";
                }
                else
                {
                    Console.WriteLine("Cannot move right, you are at the right edge!");
                }
            }

            // Display the updated grid
            DisplayGrid(grid);
            Spaces();
        }
    }

    static void DisplayGrid(string[,] grid)
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Spaces()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
