// 31. Skriv metod: void ConvertDegrees(float Celsius, out float Fahrenheit, out float Kelvin)
// Metoden ska ta antal grader i Celsius in, och man ska få ut motsvarigheten i Fahrenheit och Kelvin i out-parametrarna.
// Ta input från användaren i Celsius, använd metoden och skriv ut resultat.


static void ConvertDegrees(float Celsius, out float Fahrenheit, out float Kelvin)
{ 
   Fahrenheit=(float)(Celsius * 1.8 + 32);
   Kelvin=(float)(Celsius + 273.15);
}

Console.WriteLine("Skriv in grader i Celsius");
float celsius = float.Parse(Console.ReadLine());


ConvertDegrees(celsius,out float fahrenheit,out float kelvin);
Console.WriteLine($"Fahrenheit = {fahrenheit}");
Console.WriteLine($"Kelvin = {kelvin}");


// 32.Lägg till en statisk metod på klassen i uppgift 29. Metoden ska ta en bil som inparameter och returnera en array med 10 bilar i samma färg, men med olika längd.
// Se övning 29.
