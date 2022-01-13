using System.Timers;


namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer myTimer = new System.Timers.Timer(2000);
            myTimer.Elapsed += MyTimerElapsed;
            myTimer.Elapsed += MyTimerElapsed1;


            myTimer.Start();

            Console.WriteLine("Press enter to remove the red event.");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimerElapsed1;

            Console.ReadLine();
        }

        private static void MyTimerElapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed:{0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimerElapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed:{0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}