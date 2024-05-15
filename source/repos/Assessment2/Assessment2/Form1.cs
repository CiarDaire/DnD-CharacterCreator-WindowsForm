// Ciar Smythe - 20210993

// The problem I wanted to address is a lack of ease when creating characters in the popular game Dungeons and Dragons (DnD).
// Creating a character can be a long and complicated process at times, so I aim to create a GUI that will simplify the process,
// and allow users to save every character they make into a text file.

// This is the first iteration - later iterations will include more numerical functions for creating statistics,
// and will focus on inventory and spells. 

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Linq;
using System.IO;
using System.Reflection.Emit;

namespace Assessment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cantripCheckedlistbox.ItemCheck += cantripCheckedlistbox_ItemCheck;
            BaseSkillsRolled += BaseSkillsRolledHandler;

            // default option is the first race in list
            raceCombobox.SelectedIndex = 0;

            // default subrace 
            raceListbox.SelectedIndex = 0;

            // default class
            //classListbox.SelectedIndex = 0;

            // default background
            //backgroundListbox.SelectedIndex = 0;

            // default starting level
            startingLvl = 1;

            // default gender
            selectedGender = "Male";

            // populating classes dictionary
            classesDict.Add("Bard", "An inspiring magician whose power echoes the music of creation.");
            classesDict.Add("Druid", "A priest of the Old Faith, wielding the powers of nature — moonlight and plant growth, fire and lightning — and adopting animal forms.");
            classesDict.Add("Warlock", "A wielder of magic that is derived from a bargain with an extraplanar entity.");
            classesDict.Add("Sorcerer", "A spellcaster who draws on inherent magic from a gift or bloodline.");
            classesDict.Add("Wizard", "A scholarly magic-user capable of manipulating the structures of reality.");
            classesDict.Add("Ranger", "A warrior who uses martial prowess and nature magic to combat threats on the edges of civilization.");
            classesDict.Add("Paladin", "A holy warrior bound to a sacred oath.");
            classesDict.Add("Monk", "A master of martial arts, harnessing the power of the body in pursuit of physical and spiritual perfection.");
            classesDict.Add("Cleric", "A priestly champion who wields divine magic in service of a higher power.");
            classesDict.Add("Barbarian", "A fierce warrior of primitive background who can enter a battle rage.");
            classesDict.Add("Fighter", "A master of martial combat, skilled with a variety of weapons and armor.");
            classesDict.Add("Rogue", "A scoundrel who uses stealth and trickery to overcome obstacles and enemies.");

            // populating background dictionary
            backgroundsDict.Add("Urchin", "You grew up on the streets alone, orphaned, and poor, You had no one to watch over you or to provide for you, so you learned to provide for yourself. You fought fiercely over food and kept a constant watch out for other desperate souls who might steal from you. You slept on rooftops and in alleyways, exposed to the elements, and endured sickness without the advantage of medicine or a place to recuperate. You've survived despite all odds, and did so through cunning, strength, speed, or some combination of each.");
            backgroundsDict.Add("Entertainer", "You thrive in front of an audience. You know how to entrance them, entertain them, and even inspire them. Your poetics can stir the hearts of those who hear you, awakening grief or joy, laughter or anger. Your music raises their spirits or captures their sorrow. Your dance steps captivate, your humor cuts to the quick. Whatever techniques you use, your art is your life.");
            backgroundsDict.Add("Acolyte", "You have spent your life in the service of a temple to a specific god or pantheon of gods. You act as an intermediary between the realm of the holy and the mortal world, performing sacred rites and offering sacrifices in order to conduct worshipers into the presence of the divine. You are not necessarily a cleric—performing sacred rites is not the same thing as channeling divine power.");
            backgroundsDict.Add("Charlatan", "You have always had a way with people. You know what makes them tick, you can tease out their hearts' desires after a few minutes of conversation, and with a few leading questions you can read them like they were children's books. It's a useful talent, and one that you're perfectly willing to use for your advantage.");
            backgroundsDict.Add("Criminal", "You are an experienced criminal with a history of breaking the law. You have spent a lot of time among other criminals and still have contacts within the criminal underworld. You’re far closer than most people to the world of murder, theft, and violence that pervades the underbelly of civilization, and you have survived up to this point by flouting the rules and regulations of society.");
            backgroundsDict.Add("Folk Hero", "You come from a humble social rank, but you are destined for so much more. Already the people of your home village regard you as their champion, and your destiny calls you to stand against the tyrants and monsters that threaten the common folk everywhere.");
            backgroundsDict.Add("Guild Artisan", "You are a member of an artisan's guild, skilled in a particular field and closely associated with other artisans. You are a well-established part of the mercantile world, freed by talent and wealth from the constraints of a feudal social order. You learned your skills as an apprentice to a master artisan, under the sponsorship of your guild, until you became a master in your own right.");
            backgroundsDict.Add("Noble", "You understand wealth, power, and privilege. You carry a noble title, and your family owns land, collects taxes, and wields significant political influence. You might be a pampered aristocrat unfamiliar with work or discomfort, a former merchant just elevated to the nobility, or a disinherited scoundrel with a disproportionate sense of entitlement. Or you could be an honest, hard-working landowner who cares deeply about the people who live and work on your land, keenly aware of your responsibility to them.");
            backgroundsDict.Add("Soldier", "War has been your life for as long as you care to remember. You trained as a youth, studied the use of weapons and armor, learned basic survival techniques, including how to stay alive on the battlefield. You might have been part of a standing national army or a mercenary company, or perhaps a member of a local militia who rose to prominence during a recent war.");
            backgroundsDict.Add("Outlander", "You grew up in the wilds, far from civilization and the comforts of town and technology. You've witnessed the migration of herds larger than forests, survived weather more extreme than any city-dweller could comprehend, and enjoyed the solitude of being the only thinking creature for miles in any direction. The wilds are in your blood, whether you were a nomad, an explorer, a recluse, a hunter-gatherer, or even a marauder. Even in places where you don't know the specific features of the terrain, you know the ways of the wild.");
            backgroundsDict.Add("Sage", "You spent years learning the lore of the multiverse. You scoured manuscripts, studied scrolls, and listened to the greatest experts on the subjects that interest you. Your efforts have made you a master in your fields of study.");
        }

        // create global variables
        public string characterName;
        public int startingLvl;
        public string selectedRace;
        public string selectedSubRace;
        public string selectedClass;
        public string selectedBackground;
        public string selectedGender;
        public int cantripsCounter = 0;

        // skills counters
        public int strength = 0;
        public int charisma = 0;
        public int intelligence = 0;
        public int wisdom = 0;
        public int constitution = 0;
        public int dexterity = 0;

        // saves character
        List<Character> savedCharacters = new List<Character>();

        // saves list of selected cantrips
        ArrayList selectedCantrips = new ArrayList();

        // saves statistics of skills
        ArrayList skillsStats = new ArrayList();

        // dictionary for classes
        Dictionary<string, string> classesDict = new Dictionary<string, string>();

        // dictionary for backgrounds
        Dictionary<string, string> backgroundsDict = new Dictionary<string, string>();
        
        // dice generages random number
        private static Random dice = new Random();

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            // assign name
            characterName = nameInput.Text;
        }

        private void lvlNumeric_ValueChanged(object sender, EventArgs e)
        {
            // assign starting level number
            startingLvl = Convert.ToInt32(lvlNumeric.Value);
        }

        private void raceListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // assign sub race
            selectedSubRace = raceListbox.SelectedItem.ToString();
        }

        public void raceCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // arrays of subraces per race
            string[] elves = { "High Elf", "Wood Elf", "Eladrin Elf" };
            string[] dwarves = { "Hill Dwarf", "Mountain Dwarf", "Duergar" };
            string[] tieflings = { "Asmodeus Tiefling", "Mephistopheles Tiefling", "Zareil Tiefling" };
            string[] humans = { "Basic Human" };
            string[] drows = { "Lolth-sworn Drow", "Seldarine Drow" };
            string[] halflings = { "Lightfoot Halfling", "Strongheart Halfling" };
            string[] githyanki = { "Githyanki" };
            string[] halfelves = { "Half-Drow", "High Half-Elf", "Wood Half-Elf" };
            string[] gnomes = { "Forest Gnome", "Rock Gnome", "Deep Gnome" };
            string[] dragonborn = { "Black Dragonborn", "Blue Dragonborn", "Brass Dragonborn", "Bronze Dragonborn", "Copper Dragonborn", "Gold Dragonborn", "Green Dragonborn", "Red Dragonborn", "Silver Dragonborn", "White Dragonborn" };
            string[] genasi = { "Air Genasi", "Water Genasi", "Fire Genasi", "Earth Genasi" };
            string[] halforcs = { "Half-Orc" };

            // reset the values each time the selection changes
            strength = 0;
            charisma = 0;
            intelligence = 0;
            wisdom = 0;
            constitution = 0;
            dexterity = 0;

            // populate the list box with the subraces depending on the selected race
            if (raceCombobox.SelectedIndex != -1)
            {
                // if selected item = a specific race
                if (raceCombobox.SelectedItem.ToString() == "Elf")
                {
                    //  set the variable to that race
                    selectedRace = raceCombobox.SelectedItem.ToString();
                    // clear the listbox in case its already been populated
                    raceListbox.Items.Clear();
                    // fill it with a list of selectable sub races
                    raceListbox.Items.AddRange(elves);
                    // clear link url
                    raceLinkLabel.Links.Clear();
                    // set link url
                    raceLinkLabel.Links.Add(0, "Read more".Length, "https://www.dndbeyond.com/races/3-elf");
                    // create an instance of Elf inherited class
                    Elf elf = new Elf();
                    // clear label for racial traits
                    raceTraitsLabel.Text = "";
                    // show every racial trait
                    foreach (string trait in elf.RacialTraits)
                    {
                        raceTraitsLabel.Text += trait + "\n";
                    }
                    // update skills stats based on sub race selection
                    if (selectedSubRace == "High Elf")
                    {
                        dexterity += 2;
                        intelligence += 1;
                    } else
                    {
                        dexterity += 2;
                        wisdom += 1;
                    }
                }
                else if (raceCombobox.SelectedItem.ToString() == "Dwarf")
                {
                    selectedRace = raceCombobox.SelectedItem.ToString();
                    raceListbox.Items.Clear();
                    raceListbox.Items.AddRange(dwarves);
                    raceLinkLabel.Links.Clear();
                    raceLinkLabel.Links.Add(0, "Read more".Length, "https://www.dndbeyond.com/races/13-dwarf");
                    Dwarf dwarf = new Dwarf();
                    raceTraitsLabel.Text = "";
                    foreach (string trait in dwarf.RacialTraits)
                    {
                        raceTraitsLabel.Text += trait + "\n";
                    }
                    if (selectedSubRace == "Mountain Dwarf")
                    {
                        constitution += 2;
                        strength += 2;
                    } else if (selectedSubRace == "Hill Dwarf")
                    {
                        constitution += 2;
                        wisdom += 1;
                    }
                    else
                    {
                        constitution += 2;
                    }
                }
                else if (raceCombobox.SelectedItem.ToString() == "Tiefling")
                {
                    selectedRace = raceCombobox.SelectedItem.ToString();
                    raceListbox.Items.Clear();
                    raceListbox.Items.AddRange(tieflings);
                    raceLinkLabel.Links.Clear();
                    raceLinkLabel.Links.Add(0, "Read more".Length, "https://www.dndbeyond.com/races/7-tiefling");
                    Tiefling tiefling = new Tiefling();
                    raceTraitsLabel.Text = "";
                    foreach (string trait in tiefling.RacialTraits)
                    {
                        raceTraitsLabel.Text += trait + "\n";
                    }
                    // all tiefling subraces
                    charisma += 2;
                    intelligence += 1;
                }
                else if (raceCombobox.SelectedItem.ToString() == "Human")
                {
                    selectedRace = raceCombobox.SelectedItem.ToString();
                    raceListbox.Items.Clear();
                    raceListbox.Items.AddRange(humans);
                    raceLinkLabel.Links.Clear();
                    raceLinkLabel.Links.Add(0, "Read more".Length, "https://www.dndbeyond.com/races/1-human");
                    Human human = new Human();
                    raceTraitsLabel.Text = "";
                    foreach (string trait in human.RacialTraits)
                    {
                        raceTraitsLabel.Text += trait + "\n";
                    }
                    strength += 1;
                    dexterity += 1;
                    charisma += 1;
                    constitution += 1;
                    wisdom += 1;
                    intelligence += 1;
                }
                else if (raceCombobox.SelectedItem.ToString() == "Drow")
                {
                    selectedRace = raceCombobox.SelectedItem.ToString();
                    raceListbox.Items.Clear();
                    raceListbox.Items.AddRange(drows);
                    raceLinkLabel.Links.Clear();
                    raceLinkLabel.Links.Add(0, "Read more".Length, "https://www.dndbeyond.com/monsters/17133-drow");
                    Drow drow = new Drow();
                    raceTraitsLabel.Text = "";
                    foreach (string trait in drow.RacialTraits)
                    {
                        raceTraitsLabel.Text += trait + "\n";
                    }
                    // skill modifiers same for both drow subraces
                    dexterity += 2;
                    charisma += 1;
                }
                else if (raceCombobox.SelectedItem.ToString() == "Halfling")
                {
                    selectedRace = raceCombobox.SelectedItem.ToString();
                    raceListbox.Items.Clear();
                    raceListbox.Items.AddRange(halflings);
                    raceLinkLabel.Links.Clear();
                    raceLinkLabel.Links.Add(0, "Read more".Length, "https://www.dndbeyond.com/races/14-halfling");
                    Halfling halfling = new Halfling();
                    raceTraitsLabel.Text = "";
                    foreach (string trait in halfling.RacialTraits)
                    {
                        raceTraitsLabel.Text += trait + "\n";
                    }
                    if (selectedSubRace == "Lightfoot Halfling")
                    {
                        dexterity += 2;
                        charisma += 1;
                    } else if(selectedSubRace == "Strongheart Halfling")
                    {
                        dexterity += 2;
                        constitution += 1;
                    }
                }
                else if (raceCombobox.SelectedItem.ToString() == "Half-Elf")
                {
                    selectedRace = raceCombobox.SelectedItem.ToString();
                    raceListbox.Items.Clear();
                    raceListbox.Items.AddRange(halfelves);
                    raceLinkLabel.Links.Clear();
                    raceLinkLabel.Links.Add(0, "Read more".Length, "https://www.dndbeyond.com/races/20-half-elf");
                    HalfElf halfElf = new HalfElf();
                    raceTraitsLabel.Text = "";
                    foreach (string trait in halfElf.RacialTraits)
                    {
                        raceTraitsLabel.Text += trait + "\n";
                    }
                    charisma += 2;

                }
                else if (raceCombobox.SelectedItem.ToString() == "Half-Orc")
                {
                    selectedRace = raceCombobox.SelectedItem.ToString();
                    raceListbox.Items.Clear();
                    raceListbox.Items.AddRange(halforcs);
                    raceLinkLabel.Links.Clear();
                    raceLinkLabel.Links.Add(0, "Read more".Length, "https://www.dndbeyond.com/races/2-half-orc");
                    HalfOrc halfOrc = new HalfOrc();
                    raceTraitsLabel.Text = "";
                    foreach (string trait in halfOrc.RacialTraits)
                    {
                        raceTraitsLabel.Text += trait + "\n";
                    }
                    constitution += 1;
                    strength += 2;
                }
                else if (raceCombobox.SelectedItem.ToString() == "Githyanki")
                {
                    selectedRace = raceCombobox.SelectedItem.ToString();
                    raceListbox.Items.Clear();
                    raceListbox.Items.AddRange(githyanki);
                    raceLinkLabel.Links.Clear();
                    raceLinkLabel.Links.Add(0, "Read more".Length, "https://forgottenrealms.fandom.com/wiki/Githyanki");
                    Githyanki gith = new Githyanki();
                    raceTraitsLabel.Text = "";
                    foreach (string trait in gith.RacialTraits)
                    {
                        raceTraitsLabel.Text += trait + "\n";
                    }
                    intelligence += 1;
                    strength += 2;
                }
                else if (raceCombobox.SelectedItem.ToString() == "Genasi")
                {
                    selectedRace = raceCombobox.SelectedItem.ToString();
                    raceListbox.Items.Clear();
                    raceListbox.Items.AddRange(genasi);
                    raceLinkLabel.Links.Clear();
                    raceLinkLabel.Links.Add(0, "Read more".Length, "https://forgottenrealms.fandom.com/wiki/Genasi");
                    Genasi gen = new Genasi();
                    raceTraitsLabel.Text = "";
                    foreach (string trait in gen.RacialTraits)
                    {
                        raceTraitsLabel.Text += trait + "\n";
                    }
                    if(selectedSubRace == "Air Genasi")
                    {
                        dexterity += 2;
                        constitution += 1;
                    }else if (selectedSubRace == "Earth Genasi")
                    {
                        strength += 2;
                        constitution += 1;
                    }
                    else if (selectedSubRace == "Fire Genasi")
                    {
                        intelligence += 2;
                        constitution += 1;
                    }
                    else
                    {
                        wisdom += 2;
                        constitution += 1;
                    }
                }
                else if (raceCombobox.SelectedItem.ToString() == "Gnome")
                {
                    selectedRace = raceCombobox.SelectedItem.ToString();
                    raceListbox.Items.Clear();
                    raceListbox.Items.AddRange(gnomes);
                    raceLinkLabel.Links.Clear();
                    raceLinkLabel.Links.Add(0, "Read more".Length, "https://www.dndbeyond.com/races/18-gnome");
                    Gnome gnome = new Gnome();
                    raceTraitsLabel.Text = "";
                    foreach (string trait in gnome.RacialTraits)
                    {
                        raceTraitsLabel.Text += trait + "\n";
                    }
                    if (selectedRace == "Forest Gnome")
                    {
                        intelligence += 2;
                        dexterity += 1;
                    }
                    else
                    {
                        intelligence += 2;
                        constitution += 1;
                    }
                }
                else if (raceCombobox.SelectedItem.ToString() == "Dragonborn")
                {
                    selectedRace = raceCombobox.SelectedItem.ToString();
                    raceListbox.Items.Clear();
                    raceListbox.Items.AddRange(dragonborn);
                    raceLinkLabel.Links.Clear();
                    raceLinkLabel.Links.Add(0, "Read more".Length, "https://www.dndbeyond.com/races/16-dragonborn");
                    Dragonborn db = new Dragonborn();
                    raceTraitsLabel.Text = "";
                    foreach (string trait in db.RacialTraits)
                    {
                        raceTraitsLabel.Text += trait + "\n";
                    }
                    strength += 2;
                    charisma += 1;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // if the values are not null, save the character
            // note: most values have a default selection to show users 
            if (characterName != null && selectedBackground != null && selectedClass != null)
            {
                if (selectedRace == "Elf")
                {
                    // creates character item
                    Elf characterData = new Elf
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Subrace = selectedSubRace,
                        Gender = selectedGender,
                        Background = selectedBackground,
                        Class = selectedClass,
                        Level = startingLvl,
                        Cantrips = selectedCantrips,
                        Skills = skillsStats
                    };

                    // adds character to list of saved characters
                    savedCharacters.Add(characterData);

                }
                else if (selectedRace == "Human")
                {
                    Human characterData = new Human
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Subrace = selectedSubRace,
                        Gender = selectedGender,
                        Background = selectedBackground,
                        Class = selectedClass,
                        Level = startingLvl,
                        Cantrips = selectedCantrips,
                        Skills = skillsStats
                    };
                    savedCharacters.Add(characterData);

                }
                else if (selectedRace == "Githyanki")
                {
                    Githyanki characterData = new Githyanki
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Subrace = selectedSubRace,
                        Gender = selectedGender,
                        Background = selectedBackground,
                        Class = selectedClass,
                        Level = startingLvl,
                        Cantrips = selectedCantrips,
                        Skills = skillsStats
                    };
                    savedCharacters.Add(characterData);

                }
                else if (selectedRace == "Drow")
                {
                    Drow characterData = new Drow
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Subrace = selectedSubRace,
                        Gender = selectedGender,
                        Background = selectedBackground,
                        Class = selectedClass,
                        Level = startingLvl,
                        Cantrips = selectedCantrips,
                        Skills = skillsStats
                    };
                    savedCharacters.Add(characterData);
                }
                else if (selectedRace == "Gnome")
                {
                    Gnome characterData = new Gnome
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Subrace = selectedSubRace,
                        Gender = selectedGender,
                        Background = selectedBackground,
                        Class = selectedClass,
                        Level = startingLvl,
                        Cantrips = selectedCantrips,
                        Skills = skillsStats
                    };
                    savedCharacters.Add(characterData);

                }
                else if (selectedRace == "Dwarf")
                {
                    Dwarf characterData = new Dwarf
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Subrace = selectedSubRace,
                        Gender = selectedGender,
                        Background = selectedBackground,
                        Class = selectedClass,
                        Level = startingLvl,
                        Cantrips = selectedCantrips,
                        Skills = skillsStats
                    };
                    savedCharacters.Add(characterData);

                }
                else if (selectedRace == "Halfling")
                {
                    Halfling characterData = new Halfling
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Subrace = selectedSubRace,
                        Gender = selectedGender,
                        Background = selectedBackground,
                        Class = selectedClass,
                        Level = startingLvl,
                        Cantrips = selectedCantrips,
                        Skills = skillsStats
                    };
                    savedCharacters.Add(characterData);
                }
                else if (selectedRace == "Dragonborn")
                {
                    Dragonborn characterData = new Dragonborn
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Subrace = selectedSubRace,
                        Gender = selectedGender,
                        Background = selectedBackground,
                        Class = selectedClass,
                        Level = startingLvl,
                        Cantrips = selectedCantrips,
                        Skills = skillsStats
                    };
                    savedCharacters.Add(characterData);
                }
                else if (selectedRace == "Genasi")
                {
                    Genasi characterData = new Genasi
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Subrace = selectedSubRace,
                        Gender = selectedGender,
                        Background = selectedBackground,
                        Class = selectedClass,
                        Level = startingLvl,
                        Cantrips = selectedCantrips,
                        Skills = skillsStats
                    };
                    savedCharacters.Add(characterData);
                }
                else if (selectedRace == "Tiefling")
                {
                    Tiefling characterData = new Tiefling
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Subrace = selectedSubRace,
                        Gender = selectedGender,
                        Background = selectedBackground,
                        Class = selectedClass,
                        Level = startingLvl,
                        Cantrips = selectedCantrips,
                        Skills = skillsStats
                    };
                    savedCharacters.Add(characterData);
                }
                else if (selectedRace == "Half-Elf")
                {
                    HalfElf characterData = new HalfElf
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Subrace = selectedSubRace,
                        Gender = selectedGender,
                        Background = selectedBackground,
                        Class = selectedClass,
                        Level = startingLvl,
                        Cantrips = selectedCantrips,
                        Skills = skillsStats
                    };
                    savedCharacters.Add(characterData);
                }
                else if (selectedRace == "HalfOrc")
                {
                    HalfOrc characterData = new HalfOrc
                    {
                        Name = characterName,
                        Race = selectedRace,
                        Subrace = selectedSubRace,
                        Gender = selectedGender,
                        Background = selectedBackground,
                        Class = selectedClass,
                        Level = startingLvl,
                        Cantrips = selectedCantrips,
                        Skills = skillsStats
                    };
                    savedCharacters.Add(characterData);
                }

                // inform user character has been created
                string output = characterName + ", the " + selectedSubRace + " " + selectedClass + ", has been created.\n";
                ArrayList messages = new ArrayList();
                foreach (Character character in savedCharacters)
                {
                    // message box format
                    string characterStats = $"\nName: {character.Name}" +
                        $"\nRace: {character.Race}" +
                        $"\nSubrace: {character.Subrace}" +
                        $"\nGender: {character.Gender}" +
                        $"\nBackground: {character.Background}" +
                        $"\nClass: {character.Class}" +
                        $"\nLevel: {character.Level}";
                    string totalMessage = output + characterStats;
                    messages.Add(totalMessage);
                }
                MessageBox.Show((string)messages[0]);
                // save into text file
                try
                {
                    SaveFileDialog saveCharacterTxt = new SaveFileDialog();
                    saveCharacterTxt.InitialDirectory = @"C:\";
                    saveCharacterTxt.DefaultExt = "txt";
                    saveCharacterTxt.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog1.RestoreDirectory = true;
                    DialogResult result = saveCharacterTxt.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string fileName = saveCharacterTxt.FileName;

                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            foreach (Character character in savedCharacters)
                            {
                                // message box format
                                string characterData = $"\nName: {character.Name}" +
                                    $"\nRace: {character.Race}" +
                                    $"\nSubrace: {character.Subrace}" +
                                    $"\nGender: {character.Gender}" +
                                    $"\nBackground: {character.Background}" +
                                    $"\nClass: {character.Class}" +
                                    $"\nLevel: {character.Level}";

                                writer.WriteLine(characterData);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving character: ", ex.Message);
                }
            }
            // otherwise, notify user to fill out all forms first
            else
            {
                string output = "Please ensure all fields have been filled.";
                ArrayList errormessages = new ArrayList();
                errormessages.Add(output);
                MessageBox.Show((string)errormessages[0]);
            }
        }

        private void classListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // assigns class
            selectedClass = classListbox.SelectedItem.ToString();
            updateCantripCounter();
            updateCantripsList();

            // show class description when class is selected
            foreach (KeyValuePair<string, string> item in classesDict){
                if (item.Key == selectedClass )
                {
                    classTextbox.Text = item.Value;
                }
            }
        }

        private void backgroundListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // assigns background
            selectedBackground = backgroundListbox.SelectedItem.ToString();

            // show background description when background is selected
            foreach (KeyValuePair<string, string> item in backgroundsDict)
            {
                if (item.Key == selectedBackground)
                {
                    backgroundTextbox.Text = item.Value;
                }
            }
        }

        private void cantripLabel_Click_1(object sender, EventArgs e)
        {
            // loads number of cantrips the user can select based on prior choices; its a title
        }

        private void cantripCheckedlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // loads selectable cantrips here
        }

        private void updateCantripCounter()
        {
            // calculate cantrips amount based on selected class
            if (selectedClass == "Bard" || selectedClass == "Druid" || selectedClass == "Warlock")
            {
                cantripsCounter = 2;
            }
            else if (selectedClass == "Cleric" || selectedClass == "Wizard")
            {
                cantripsCounter = 3;
            }
            else if (selectedClass == "Sorcerer")
            {
                cantripsCounter = 4;
            }
            else
            {
                cantripsCounter = 0;
            }

            // update cantrip title label
            if (cantripsCounter == 0)
            {
                cantripLabel.Text = "You cannot select any cantrips.";
            }
            else
            {
                cantripLabel.Text = "Based on your prior choices, you can select " + cantripsCounter + " cantrips from the list.";
            }
        }

        private void updateCantripsList()
        {
            string[] magicCantrips = { "Eldritch Blast", "Acid Splash", "Blade Ward", "Chill Touch", "Dancing Lights", "Fire Bolt", "Friends", "Light", "Mage Hand", "Mending", "Message", "Minor Illusion", "Poison Spray", "Prestidigitation", "Ray of Frost", "True Strike", "Shocking Grasp" };
            string[] clericCantrips = { "Guidance", "Light", "Mending", "Resistance", "Sacred Flame", "Spare the Dying", "Thaumaturgy" };
            string[] druidCantrips = { "Druidcraft", "Guidance", "Mending", "Poison Spray", "Produce Flame", "Resistance", "Thorn Whip", "Shillelagh" };
            string[] bardCantrips = { "Blade Ward", "Dancing Lights", "Friends", "Light", "Mage Hand", "Mending", "Message", "Minor Illusion", "True Strike", "Prestidigitation", "Vicious Mockery" };

            cantripCheckedlistbox.Items.Clear();

            // show cantrip list based on class selection
            if (selectedClass == "Druid")
            {
                cantripCheckedlistbox.Items.AddRange(druidCantrips);
            }
            else if (selectedClass == "Bard")
            {
                cantripCheckedlistbox.Items.AddRange(bardCantrips);
            }
            else if (selectedClass == "Clerc")
            {
                cantripCheckedlistbox.Items.AddRange(clericCantrips);
            }
            else if (selectedClass == "Warlock" || selectedClass == "Sorcerer" || selectedClass == "Wizard")
            {
                cantripCheckedlistbox.Items.AddRange(magicCantrips);
            }

            // make list of chosen cantrips
            foreach (object cantrip in cantripCheckedlistbox.CheckedItems)
            {
                selectedCantrips.Add(cantrip.ToString());
            }
        }

        private void cantripCheckedlistbox_ItemCheck(object sender, ItemCheckEventArgs e)
        { 
            // this line ensures that we count the item that is currently being checked
            int checkedItemCount = cantripCheckedlistbox.CheckedItems.Count + (e.NewValue == CheckState.Checked ? 1 : 0);

            // do not check any boxes if the checked box number exceeds the total number of cantrips
            if (checkedItemCount > cantripsCounter)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("You can only check " + cantripsCounter + " boxes. Uncheck a box if you would like to check any different boxes.");
            }

        }

        private void raceTraitsLabel_Click(object sender, EventArgs e)
        {
            // loads traits/modifiers based on race here
        }

        private void raceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // opens link on browser
            string url = e.Link.LinkData.ToString();
            System.Diagnostics.Process.Start(url);
        }

        private void classDescLabel_Click(object sender, EventArgs e)
        {
            // loads descriptions for classes here
        }

        private void backgroundTextbox_TextChanged(object sender, EventArgs e)
        {
            // loads descriptions for backgrounds here
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // event for saving file: triggered in 'save' button
        }

        // sets gender
        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            selectedGender = "Male";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            selectedGender = "Female";
        }

        private void radioOther_CheckedChanged(object sender, EventArgs e)
        {
            selectedGender = "Other";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = @"D:\",
                    Title = "Browse Text Files",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "txt",
                    Filter = "txt files (*.txt)|*.txt",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileContent = File.ReadAllText(openFileDialog1.FileName);
                    fileContent = fileContent.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", Environment.NewLine);
                    viewTextbox.Text = fileContent;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening character file: ", ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // event for opening files
        }

        private void viewTextbox_TextChanged(object sender, EventArgs e)
        {
            // load open file text here
        }

        public int roll4d6()
        {
            // function to roll stats for skills
            // imitates a 6 sided dice, rolled 4 times

            // stores rolls
            List<int> overallRolls = new List<int>();

            // clear list of rolls first
            overallRolls.Clear();

            // do it 4 times
            for (int i = 0; i <4; i++)
            {
                // generate random number: 1,2,3,4,5,6
                int roll = dice.Next(1, 7);
                overallRolls.Add(roll);
            }

            // find lowest number
            int lowestRoll = overallRolls.Min();

            // remove lowest roll
            overallRolls.Remove(lowestRoll);

            // get sum of leftover rolls
            int fourDsix = overallRolls.Sum();

            // roll fourDsix for each skill
            BaseSkillsRolled?.Invoke(this, new BaseSkillsRollEventArgs(fourDsix, fourDsix, fourDsix, fourDsix, fourDsix, fourDsix));

            return fourDsix;
        }

        private void strRange_ValueChanged(object sender, EventArgs e){}

        private void wisRange_ValueChanged(object sender, EventArgs e){}

        private void constRange_ValueChanged(object sender, EventArgs e){}

        private void intRange_ValueChanged(object sender, EventArgs e){}

        private void chrRange_ValueChanged(object sender, EventArgs e){}

        private void dexRange_ValueChanged(object sender, EventArgs e){}

        public event EventHandler<BaseSkillsRollEventArgs> BaseSkillsRolled;

        private void baseSkillsRollBtn_Click(object sender, EventArgs e)
        {
            // roll random values when the button is clicked to get base skill values
            strRange.Value = roll4d6();
            wisRange.Value = roll4d6();
            constRange.Value = roll4d6();
            intRange.Value = roll4d6();
            chrRange.Value = roll4d6();
            dexRange.Value = roll4d6();

            // add and update skills in array
            skillsStats.Clear();
            skillsStats.Add("Strength:" + strRange.Value);
            skillsStats.Add("Wisdom" + wisRange.Value);
            skillsStats.Add("Constitution:" + constRange.Value);
            skillsStats.Add("Intelligence" + intRange.Value);
            skillsStats.Add("Charisma" + chrRange.Value);
            skillsStats.Add("Dexterity" + dexRange.Value);

            BaseSkillsRolled?.Invoke(this, new BaseSkillsRollEventArgs(strength, wisdom, constitution, intelligence, charisma, dexterity));

        }

        // custom event to add skill modifiers
        private void BaseSkillsRolledHandler(object sender, BaseSkillsRollEventArgs e)
        {
            // Handle the rolled base skills
            int strength = e.Strength;
            int wisdom = e.Wisdom;
            int constitution = e.Constitution;
            int intelligence = e.Intelligence;
            int charisma = e.Charisma;
            int dexterity = e.Dexterity;

            // add modifiers based on prior selections and counter
            strCounterLabel.Text = "+" + strength.ToString();
            wisCounterLabel.Text = "+" + wisdom.ToString();
            constCounterLabel.Text = "+" + constitution.ToString();
            intCounterLabel.Text = "+" + intelligence.ToString();
            chaCounterLabel.Text = "+" + charisma.ToString();
            dexCounterLabel.Text = "+" + dexterity.ToString();
        }

        private void strCounterLabel_Click(object sender, EventArgs e)
        {
            // counter for strength skill modifier
        }

        private void wisCounterLabel_Click(object sender, EventArgs e)
        {
            // counter for wisdom skill modifier
        }

        private void constCounterLabel_Click(object sender, EventArgs e)
        {
            // counter for consititution skill modifier
        }

        private void intCounterLabel_Click(object sender, EventArgs e)
        {
            // counter for intelligence skill modifier
        }

        private void chaCounterLabel_Click(object sender, EventArgs e)
        {
            // counter for charisma skill modifier
        }

        private void dexCounterLabel_Click(object sender, EventArgs e)
        {
            // counter for dexterity skill modifier
        }

        private void classTextbox_TextChanged(object sender, EventArgs e)
        {
            // loads class descriptions here
        }
    }
}
