using Adapter2._0;
using System;


namespace Adapter2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoolCorpInterface robot = new CoolCorpRobot();
            robot.CurrentSpeedInKilometersPerHour = 3;
            robot.Jump(12);
            Console.ReadKey();


        }

    }

}