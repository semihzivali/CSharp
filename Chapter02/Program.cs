using Chapter02.UI.View;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Terminal.SplashScreen("Semih");
        

        Terminal.ShowMenu();

        var userInput = Console.ReadLine();
    }

    
}