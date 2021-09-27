using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern_MyExample.Creator
{
   public abstract class CharacterBuilder
    {
        private List<Abilities> _abilities = new List<Abilities>();
        public CharacterBuilder()
        {
            this.CreateCharacter();
        }
        public abstract void CreateCharacter();
        public List<Abilities> Abilities
        {
            get { return _abilities; }
        }
    }
}
