using Azon.WeatherLib;
using Chapter02.UI.View;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var currentWeatherValue = new Temperature(21, TemperetarueType.Celcius);
        Console.WriteLine(currentWeatherValue);
        currentWeatherValue.ConvertToFahrenheit();
        Console.WriteLine(currentWeatherValue);


        Terminal.SplashScreen("Semih");
        Terminal.ShowMenu();
        Terminal.GetUserInput();



        


    }

    
}