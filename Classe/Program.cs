using System;
using TrabalhoATP_Tetris.Classes;
﻿namespace TrabalhoATP_Tetris
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            jogo.Iniciar();
            
            Console.ReadLine();
        }
    }
}
