namespace Azon.WeatherLib
{

    public struct Temperature
    {
        public double Value { get; set; }
        public TemperetarueType Type { get; set; }
        public Temperature(double value, TemperetarueType type)
        {
            Value = value;
            Type = type;
        }
        public void ConvertToCelcius()
        {
            if (Type == TemperetarueType.Celcius)
                return;   // early return

            Type = TemperetarueType.Celcius;
            Value = (Value - 32) * 5.0 / 9.0;


        }
        public void ConvertToFahrenheit()
        {
            if (Type == TemperetarueType.Celcius)
            {
                Type = TemperetarueType.Fahrenheit;
                Value = (Value * 9.0 / 5.0) * 32;
            }
        }


        /*  public double ConvertToCelcius()
            {
                if(Type == TemperetarueType.Celcius) 
                    return Value;   // early return

                Type = TemperetarueType.Celcius;
                return (Value - 32) * 5.0 / 9.0;


            }
            public double ConvertToFahrenheit()
            {
                if (Type == TemperetarueType.Celcius)
                {
                    Type = TemperetarueType.Fahrenheit;
                    return (Value * 9.0 / 5.0 ) * 32;
                }
                return Value;
            }
        */

        public override string ToString()
        {
            return $"{Value} ({Type})";
        }
    }

    public enum TemperetarueType
    {
        Celcius,
        Fahrenheit
    }


}

