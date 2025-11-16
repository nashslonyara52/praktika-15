using System;

namespace Praktika15
{
    interface IWorkable
    {
        void Work();
    }
    interface IRechargeable
    {
        void Charge();
    }
    class Robot : IWorkable, IRechargeable
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public Robot(string name, int energy)
        {
            Name = name;
            Energy = energy;
        }

        public void Work()
        {
            if (Energy - 20 < 0) Energy = 0;
            else Energy -= 20;
            Console.WriteLine($"{Name} работает, уровень энергии: {Energy}");
        }
        public void Charge()
        {
            if (Energy + 50 > 100) Energy = 100;
            else Energy += 50;
            Console.WriteLine($"{Name} заряжается, уровень энергии: {Energy}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Робот", 73);
            robot.Work();
            robot.Charge();
            robot.Work();
            Console.WriteLine();
        }
    }
}