using System;
using System.IO;

class Program
{
    static void Main()
    {
        string rutaArchivo = "texto.txt";

  
        Console.WriteLine("Escribe un texto:");
        string texto = Console.ReadLine();

      
        File.WriteAllText(rutaArchivo, texto);
        Console.WriteLine("\nTexto guardado en 'texto.txt'.");

       
        string textoLeido = File.ReadAllText(rutaArchivo);

        
        string[] palabras = textoLeido.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        int cantidadPalabras = palabras.Length;

        Console.WriteLine($"\nEl texto contiene {cantidadPalabras} palabra(s).");
    }
}
