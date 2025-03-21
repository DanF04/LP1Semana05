using System;
using System.IO;
using Spectre.Console;
using SoGoodLib;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SoGoodClass.SoGoodMethod());
        
        string defaultImage = "tux.jpg";
        int defaultWidth = 24;

        string imagePath = args.Length > 0 ? args[0] : defaultImage;
        int width = args.Length > 1 && int.TryParse(args[1], out int w) ? w : defaultWidth;

        if (!File.Exists(imagePath))
        {
            Console.WriteLine($"Erro: O ficheiro '{imagePath}' não foi encontrado.");
            return;
        }

        try
        {
            var image = new CanvasImage(imagePath);
            image.MaxWidth(width);
            AnsiConsole.Write(image);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao carregar a imagem: {ex.Message}");
        }
    }
}