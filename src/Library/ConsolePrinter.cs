using System;
using System.Text;
namespace Library;

public class ConsolePrinter //Clase responsable de tomar un array de boleanos e imprimirlo a pantalla
{
    //Es la unica responsabilidad que tiene, por lo que solo tendria una razon de cambio
    public static void Pantalla(bool[,] board)
    {
        bool[,] b = board;
        int width = board.GetLength(0);
        int height = board.GetLength(1);
        Console.Clear();
        StringBuilder s = new StringBuilder();
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (b[x, y])
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }

            s.Append("\n");
        }

        Console.WriteLine(s.ToString());
    }
}