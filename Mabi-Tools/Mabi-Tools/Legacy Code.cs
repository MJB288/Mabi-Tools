//A small function to delay without locking the UI with Thread.Sleep()
//No longer needed - but kept around as a reminder since it may be useful in the future
/*public static void Delay(int milliseconds)
{
    Timer delayTimer = new Timer();
    if (milliseconds == 0 || milliseconds < 0) return;

    delayTimer.Interval = milliseconds;
    delayTimer.Enabled = true;
    delayTimer.Start();

    delayTimer.Tick += (s, e) =>
    {
        delayTimer.Enabled = false;
        delayTimer.Stop();
        // Console.WriteLine("stop wait timer");
    };

    while (delayTimer.Enabled)
    {
        Application.DoEvents();
    }
}*/