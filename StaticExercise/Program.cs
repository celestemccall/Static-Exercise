namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheeitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"Celcius: {celcius}");
            Console.WriteLine($"");
            Console.WriteLine($"Fahrenheit:{fahrenheit}");
        }
    }
}
