﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labyrinth
{
    public class ConsoleDrawer:IDrawerInterface
    {
        public void PrintWelcomeMessage()
        {
            Console.WriteLine();
            Console.WriteLine(MenuMessages.Welcome);
        }

        public void PrintGoodbyeMessage()
        {
            Console.WriteLine();
            Console.WriteLine(MenuMessages.Goodbye);
        }

        public void PrintMovesCountMessage(int moves)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format(MenuMessages.ShowMovesCount, moves));
        }

        public void PrintEnterPlayerName()
        {
            Console.WriteLine();
            Console.WriteLine(MenuMessages.EnterPlayerName);
        }

        public void PrintEndOrNewGame()
        {
            Console.WriteLine();
            Console.WriteLine(MenuMessages.EndOrNewGame);
        }
 
        public void Draw(object obj)
        {
            Console.WriteLine();
            Console.WriteLine(obj.ToString());
        }
    }
}
