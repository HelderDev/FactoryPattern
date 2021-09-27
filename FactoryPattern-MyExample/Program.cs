using FactoryPattern_MyExample.ConcreteCreator;
using FactoryPattern_MyExample.Creator;
using System;

namespace FactoryPattern_MyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterBuilder[] characters = new CharacterBuilder[3];
            characters[0] = new Mage();
            characters[1] = new Warrior();
            characters[2] = new Rogue();

            foreach (var item in characters)
            {
                Console.WriteLine($"\n {item.GetType().Name} --");
                foreach (var val in item.Abilities)
                {
                    Console.WriteLine($" {val.GetType().Name}");
                }
            }
        }
    }
}
