using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public class BaseSkillsRollEventArgs : EventArgs
    {
        public int Strength { get; }
        public int Wisdom { get; }
        public int Constitution { get; }
        public int Intelligence { get; }
        public int Charisma { get; }
        public int Dexterity { get; }

        public BaseSkillsRollEventArgs(int strength, int wisdom, int constitution, int intelligence, int charisma, int dexterity)
        {
            Strength = strength;
            Wisdom = wisdom;
            Constitution = constitution;
            Intelligence = intelligence;
            Charisma = charisma;
            Dexterity = dexterity;
        }
    }
}
