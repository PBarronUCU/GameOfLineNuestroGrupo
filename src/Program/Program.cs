using System;  
using System.Threading;
using Library;

namespace Ucu.Poo.GameOfLife
{
    class Program //Es el programa ejectuable donde se llaman los metodos de las clases
    {
        static void Main(string[] args)
        {
            bool[,] boardInicial = BoardImporter.Importar("board.txt");
            bool[,] enJuego = boardInicial;
            while (true) //Este bucle es el que consantemente actualiza e imprime el tablero
            {
                ConsolePrinter.Pantalla(enJuego);
                enJuego = GameRules.Reglas(enJuego);
                Thread.Sleep(300);
            }
        }
    }
}
