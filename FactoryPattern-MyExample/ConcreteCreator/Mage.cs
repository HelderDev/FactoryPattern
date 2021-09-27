using FactoryPattern_MyExample.ConcreteProduct;
using FactoryPattern_MyExample.Creator;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern_MyExample.ConcreteCreator
{
    public class Mage : CharacterBuilder
    {
        public override void CreateCharacter()
        {
            Abilities.Add(new Arcane());
            Abilities.Add(new Blizzard());
            Abilities.Add(new Fireball());
        }
    }
}
