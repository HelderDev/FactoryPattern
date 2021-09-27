using FactoryPattern_MyExample.ConcreteProduct;
using FactoryPattern_MyExample.Creator;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern_MyExample.ConcreteCreator
{
    public class Rogue : CharacterBuilder
    {
        public override void CreateCharacter()
        {
            Abilities.Add(new Picklock());
            Abilities.Add(new SneakAttack());
            Abilities.Add(new Poison());
        }
    }
}
