namespace ui_app_demo_tests.Models;

public class Calclulator
{
    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    [InlineData(98.6, 37)]
    [InlineData(0, -17.7778)]
    [InlineData(-40, -40)]
    public void Celsius_ConvertsFahrenheitToCelsius(double fahrenheit, double expectedCelsius)
    {
        // Arrange
        var calculator = new ui_app_demo.Models.Calculator();

        // Act
        var result = calculator.Celsius(fahrenheit);

        // Assert
        Assert.Equal(expectedCelsius, result, 4); // Allowing a precision of 4 decimal places
    }
    
    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(37, 98.6)]
    [InlineData(-17.7778, 0)]
    [InlineData(-40, -40)]
    public void Fahrenheit_ConvertsCelsiusToFahrenheit(double celsius, double expectedFahrenheit)
    {
        // Arrange
        var calculator = new ui_app_demo.Models.Calculator();

        // Act
        var result = calculator.Fahrenheit(celsius);

        // Assert
        Assert.Equal(expectedFahrenheit, result, 4); // Allowing a precision of 4 decimal places
    }
}