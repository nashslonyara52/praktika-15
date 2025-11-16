using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        interface ISwitch
        {
            void TurnOn();
            void TurnOff();
            void Info();
        }
        interface ISetLevel
        {
            void SetLevel(int level);
        }
        class Lamp : ISwitch, ISetLevel
        {
            private int level;
            public int Level { get; }
            public void TurnOn() { level = 100; }
            public void TurnOff() { level = 0; }
            public void SetLevel(int level)
            {
                if (level < 0) this.level = 0;
                else if (level > 100) this.level = 100;
                else this.level = level;
            }
            public void Info() { Console.WriteLine($"Уровень лампы: {level}"); }
        }
        class Ventilator : ISwitch
        {
            public int Level { get; set; }
            public void TurnOn() { Level = 100; }
            public void TurnOff() { Level = 0; }
            public void Info() { Console.WriteLine($"Уровень вентилятора: {Level}"); }
        }
        static void Main(string[] args)
        {
            ISwitch[] a = { new Lamp(), new Ventilator() };
            foreach (ISwitch item in a)
            {
                item.TurnOn();
                item.Info();
                item.TurnOff();
                item.Info();
            }
            Lamp lamp = new Lamp();
            lamp.SetLevel(30);
            lamp.Info();
            Console.WriteLine();
        }
    }
}
