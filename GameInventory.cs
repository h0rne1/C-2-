using System;

namespace КТ2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inventory = new GameInventory(5);
            inventory[0] = "Меч";
            inventory[2] = "Зелье";

            Console.WriteLine(inventory);
            Console.WriteLine(inventory[0]); 
            Console.WriteLine(inventory["Зелье"]);
            Console.WriteLine(inventory["Щит"]);

            try
            {
                inventory[10] = "X";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}