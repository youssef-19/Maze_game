using System;
namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Maze maze = new Maze(50,30);
            while(true){
                maze.DrowMaze();
                maze.MovePlayer();
            }
        }
    }
}