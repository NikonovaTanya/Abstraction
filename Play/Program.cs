using System;

namespace Play
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IPlayable playable = player as IPlayable;
            playable.play();
            playable.pause();
            playable.stop();
            Console.WriteLine("----------------------------------");
            IRecodable record = player as IRecodable;
            record.play();
            record.pause();
            record.stop();
        }
    }
}
