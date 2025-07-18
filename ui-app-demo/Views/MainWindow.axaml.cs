using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ui_app_demo.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        // Handle button click event
        // You can add your logic here
        Debug.WriteLine($"Click! Celsius: {Celsius.Text}, Fahrenheit: {Fahrenheit.Text}");

        if (double.TryParse(Celsius.Text, out var C))
        {
            var F = C *(9d / 5d) + 32;
            Fahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }
    }
}