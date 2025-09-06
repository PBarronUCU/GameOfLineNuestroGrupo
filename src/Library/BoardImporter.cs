namespace Library; 
using System.IO;  
public class BoardImporter/*Clase Responsable de tomar un archivo de texto y convertirlo en un array de booleanos*/
                          /*Tine esta unica responbilidad, por lo que solo tendira que ser cambiada si queremos modificar
                         como importar un archivo*/
{
    public static bool[,] Importar(string path)
    {
        string url = path;
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        for (int  y=0; y<contentLines.Length;y++)
        {
            for (int x=0; x<contentLines[y].Length; x++)
            {
                if(contentLines[y][x]=='1')
                {
                    board[x,y]=true;
                }
            }
        }
        return board;
    }
}