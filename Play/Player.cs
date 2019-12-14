using System;
using System.Collections.Generic;
using System.Text;

namespace Play
{
    class Player: IPlayable,IRecodable
    {
        void IPlayable.play()
        {
            Console.WriteLine("IPlayable.play()");
        }
        void IPlayable.pause()
        {
            Console.WriteLine("IPlayable.pause()");
        }
        void IPlayable.stop()
        {
            Console.WriteLine("IPlayable.stop()");
        }
        void IRecodable.play()
        {
            Console.WriteLine("IRecodable.play()");
        }
        void IRecodable.pause()
        {
            Console.WriteLine("IRecodable.pause()");
        }
        void IRecodable.stop()
        {
            Console.WriteLine("IRecodable.stop()");
        }

    }
}
