// See https://aka.ms/new-console-template for more information

using fahrenheitToCelsius;

// enter fahrenheit
Console.WriteLine("Enter fahrenheit value: ");
string inputValue = Console.ReadLine();
double value = System.Convert.ToDouble(inputValue);

// use method to output celsius
FahrenheitToCelsius conv = new FahrenheitToCelsius();
Console.WriteLine("Your value is: " + conv.ConvertF(value) + " celsius.");
