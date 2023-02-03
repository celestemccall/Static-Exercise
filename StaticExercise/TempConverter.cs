using System;
namespace StaticExercise
{
	public static class TempConverter
	{
	
		public static double FahrenheeitToCelsius(double f)
		{
			var results = (f - 32) / 1.8;

			return results;
		}

		public static double CelsiusToFahrenheit(double c)
		{
			var answer = (c * 9) / 5 +  32;

			return answer;
		}
	}
}

