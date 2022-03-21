namespace HW7_events;

public class KeystrokeHandler
{
    public event EventHandler<char>? OnKeyPressed;

    public void Run()
    {
        while (true)
        {
            var currentKey = Console.ReadKey().KeyChar;
            
            if (currentKey == 'c')
            {
                break;
            }

            OnKeyPressed?.Invoke(this, currentKey);
        }
    }
}