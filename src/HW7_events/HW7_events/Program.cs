using HW7_events;

var instance = new KeystrokeHandler();

instance.OnKeyPressed += PrintSymbol;

instance.Run();

void PrintSymbol(object? sender, char symbol)
{
    Console.WriteLine($"You entered symbol: {symbol}");
}

