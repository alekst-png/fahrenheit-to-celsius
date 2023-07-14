namespace fahrenheitToCelsius;

public class FahrenheitToCelsius
{
    // method to convert value
    public double ConvertF(double fahrenheit)
    {
        double celsius = ((fahrenheit - 32) * 5) / 9;
        return celsius;
    }
}