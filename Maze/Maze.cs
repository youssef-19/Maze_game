using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Maze
{
    public class Maze
    {
        private int _width;
        private int _height;
        private Player _player;
        private ImazeObject[,] _mazeObjectarray;
        public Maze(int width, int height)
        {
            _height = height;
            _width = width;
            _mazeObjectarray = new ImazeObject[width, height];
            _player = new Player()
            {
                x = 1,
                y = 1,
            };

        }
        public void DrowMaze()
        {
            Console.Clear();
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    if (x==49&&y==29)
                    {
                        _mazeObjectarray[x, y] = new EmptySpace();
                        Console.Write(_mazeObjectarray[x, y].Icon);

                    }
                    else if (x == 0 || y == 0 || x == _width - 1 || y == _height - 1)
                    {
                        _mazeObjectarray[x, y] = new Wall();
                        Console.Write(_mazeObjectarray[x, y].Icon);
                    }
                    else if (x == _player.x && y == _player.y)
                    {
                        Console.Write(_player.Icon);
                    }
                    else if (x % 2 == 0 && y % 2 == 0)
                    {
                        _mazeObjectarray[x, y] = new Wall();
                        Console.Write(_mazeObjectarray[x, y].Icon);
                    }
                    else
                    {
                        _mazeObjectarray[x, y] = new EmptySpace();
                        Console.Write(_mazeObjectarray[x, y].Icon);
                    }
                }
                Console.WriteLine();
            }

        }
        public void MovePlayer()
        {
           ConsoleKeyInfo userInput= Console.ReadKey();
            ConsoleKey key = userInput.Key;
            switch(key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayer(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                    break;
            }
        }
        private void UpdatePlayer(int dx,int dy)
         {
            int newx =_player.x+ dx;
            int newy=_player.y+ dy;
            if (newx < _width && newx >= 0 && newy < _height && newy >= 0 && _mazeObjectarray[newx,newy].IsSolid == false) 
            {
                _player.x = newx;
                _player.y = newy;
                DrowMaze();
            }
         }
    }
}
