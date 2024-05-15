using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    internal class Character
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Subrace { get; set; }
        public string Class { get; set; }
        public string Background { get; set; }
        public int Level { get; set; }
        public string Gender { get; set; }
        public bool Darkvision = true;
        public List<string> RacialTraits { get; set; } = new List<string>();
        public ArrayList Cantrips { get; set; } = new ArrayList();
        public ArrayList Skills { get; set;} = new ArrayList();

    }

    class Elf : Character
    {
        public Elf()
        {
            RacialTraits.Add("Elven Accuracy");
            RacialTraits.Add("Trance");
            RacialTraits.Add("Fey Ancestry");
            RacialTraits.Add("Darkvision");
            RacialTraits.Add("Keen Senses");
            RacialTraits.Add("Mask of the Wild");
        }
    }

    class Dwarf : Character
    {
        public Dwarf()
        {
            RacialTraits.Add("Darkvision");
            RacialTraits.Add("Dwarven Resilience");
            RacialTraits.Add("Dwarven Combat Training");
            RacialTraits.Add("Tool Proficiency");
            RacialTraits.Add("Stonecunning");
            RacialTraits.Add("Dwarven Toughness");
        }
    }

    class Tiefling : Character
    {
        public Tiefling()
        {
            RacialTraits.Add("Hellish Resistance");
            RacialTraits.Add("Infernal Legacy");
            RacialTraits.Add("Darkvision");
        }
    }

    class Gnome : Character
    {
        public Gnome()
        {
            RacialTraits.Add("Darkvision");
            RacialTraits.Add("Gnome Cunning");
        }
    }

    class HalfElf : Character
    {
        public HalfElf()
        {
            RacialTraits.Add("Darkvision");
            RacialTraits.Add("Fey Ancestry");
            RacialTraits.Add("Skill Versatility");
        }
    }

    class HalfOrc : Character
    {
        public HalfOrc()
        {
            RacialTraits.Add("Darkvision");
            RacialTraits.Add("Menacing");
            RacialTraits.Add("Relentless Endurance");
            RacialTraits.Add("Savage Attacks");
        }
    }

    class Human : Character
    {
        public Human()
        {
            RacialTraits.Add("No racial traits");
        }
    }

    class Halfling : Character
    {
        public Halfling()
        {
            RacialTraits.Add("Darkvision");
            RacialTraits.Add("Halfling Nimbleness");
        }
    }

    class Drow : Character
    {
        public Drow()
        {
            RacialTraits.Add("Superior Darkvision");
            RacialTraits.Add("Sunlight Sensitivity");
            RacialTraits.Add("Drow Magic");
        }
    }

    class Githyanki : Character
    {
        public Githyanki()
        {
            RacialTraits.Add("Githyanki Psionics");
        }
    }

    class Dragonborn : Character
    {
        public Dragonborn()
        {
            RacialTraits.Add("Draconic Ancestry");
            RacialTraits.Add("Breath Weapon");
        }
    }

    class Genasi : Character
    {
        public Genasi()
        {
            RacialTraits.Add("Subrace's Elemental Resistance");
            RacialTraits.Add("Subrace's Elemental Manifestation");
        }
    }
}

