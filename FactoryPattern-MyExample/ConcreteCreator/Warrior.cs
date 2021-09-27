using FactoryPattern_MyExample.ConcreteProduct;
using FactoryPattern_MyExample.Creator;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern_MyExample.ConcreteCreator
{
    public class Warrior : CharacterBuilder
    {
        public override void CreateCharacter()
        {
            Abilities.Add(new Enrage());
            Abilities.Add(new Whirlwind());
            Abilities.Add(new Execute());
        }
    }
}
