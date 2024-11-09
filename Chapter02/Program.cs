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

        var reporter = new Reporter();
        var ankara = new City("Ankara", new Temperature(18, TemperetarueType.Celcius));
        reporter.AddCity(ankara);
        var tokyo = new City("Tokyo", new Temperature(24, TemperetarueType.Celcius));
        reporter.AddCity(tokyo);
        reporter.AddCity(new City("Istanbul", new Temperature(20, TemperetarueType.Celcius)));

        var cities = reporter.GetCityList();
        foreach (var city in cities)
        {
            Console.WriteLine($"City: {city}");
        }

        var ankaraTemperature = reporter.GetTemperature("ankara");
        Console.WriteLine("{0}",ankaraTemperature);

    }
    
}