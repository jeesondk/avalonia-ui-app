namespace ui_app_demo.Models;

public class Calculator
{
    public double Celsius(double fahrenheit)
    {
        return (fahrenheit - 32) * (5d / 9d);
    }
    
    public double Fahrenheit(double celsius)
    {
        return celsius * (9d / 5d) + 32;
    }
}