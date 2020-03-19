using System;
using WiredBrainCoffee.Simulators;

namespace Uddip.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffeeMachine = new CoffeeMachine();
            coffeeMachine.MakeCappuccino();
            coffeeMachine.MakeCappuccino();

            Console.WriteLine($"Cappuccino number {coffeeMachine.CounterCappuccino}");

            coffeeMachine.ShowStoredState();
        }
    }
}
