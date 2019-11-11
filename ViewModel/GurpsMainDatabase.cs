using System;
using System.Collections.Generic;
using GurpsCC.Model;
using GurpsCC.Model.Advantages;
using GurpsCC.Model.Disadvantages;
using GurpsCC.Model.Skills;

namespace GurpsCC.ViewModel
{
    public class GurpsMainDatabase : IGurpsMainDatabase
    {
        public GurpsDatabase<SkillModel> SkillDB { get; set; }
        public GurpsDatabase<AdvantageModel> AdvantageDB { get; set; }
        public GurpsDatabase<DisadvantageModel> DisadvantageDB { get; set; }

        private Dictionary<string, string> SkillDescription { get; set; }
        private Dictionary<string, string> AdvantageDescription { get; set; }
        private Dictionary<string, string> DisadvantageDescription { get; set; }


        public GurpsMainDatabase()
        {
            SkillDescription = new Dictionary<string, string>();
            LoadSkillDescription();
            SkillDB = new GurpsDatabase<SkillModel>();
            LoadSkillDB();

            AdvantageDescription = new Dictionary<string, string>();
            LoadAdvantageDescription();
            AdvantageDB = new GurpsDatabase<AdvantageModel>();
            LoadAdvantageDB();

            DisadvantageDescription = new Dictionary<string, string>();
            LoadDisadvantageDescription();
            DisadvantageDB = new GurpsDatabase<DisadvantageModel>();
            LoadDisadvantageDB();
        }

        private void LoadSkillDB()
        {
            // GURPS LITE
            SkillDB.Add("Acrobatics",
                new SkillModel("Acrobatics", EStatAttribute.DX, EDifficulty.Hard, SkillDescription["Acrobatics"]));
            SkillDB.Add("Acting",
                new SkillModel("Acting", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Acting"]));
            SkillDB.Add("Animal Handling",
                new SkillModel("Animal Handling", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Animal Handling"]));
            SkillDB.Add("Area Knowledge",
                new SkillModel("Area Knowledge", EStatAttribute.IQ, EDifficulty.Easy, SkillDescription["Area Knowledge"]));
            SkillDB.Add("Armoury",
                new SkillModel("Armoury", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Armoury"]));
            SkillDB.Add("Brawling",
                new SkillModel("Brawling", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Brawling"]));
            SkillDB.Add("Camouflage",
                new SkillModel("Camouflage", EStatAttribute.IQ, EDifficulty.Easy, SkillDescription["Camouflage"]));
            SkillDB.Add("Carousing",
                new SkillModel("Carousing", EStatAttribute.HT, EDifficulty.Easy, SkillDescription["Carousing"]));
            SkillDB.Add("Climbing",
                new SkillModel("Climbing", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Climbing"]));
            SkillDB.Add("Computer Operation",
                new SkillModel("Computer Operation", EStatAttribute.IQ, EDifficulty.Easy, SkillDescription["Computer Operation"]));
            SkillDB.Add("Computer Programming",
                new SkillModel("Computer Programming", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Computer Programming"]));
            SkillDB.Add("Crewman",
                new SkillModel("Crewman", EStatAttribute.IQ, EDifficulty.Easy, SkillDescription["Crewman"]));
            SkillDB.Add("Criminology",
                new SkillModel("Criminology", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Criminology"]));
            SkillDB.Add("Diagnosis",
                new SkillModel("Diagnosis", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Diagnosis"]));
            SkillDB.Add("Disguise",
                new SkillModel("Disguise", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Disguise"]));
            SkillDB.Add("Electronics Operation",
                new SkillModel("Electronics Operation", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Electronics Operation"]));
            SkillDB.Add("Electronics Repair",
                new SkillModel("Electronics Repair", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Electronics Repair"]));
            SkillDB.Add("Engineer",
                new SkillModel("Engineer", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Engineer"]));
            SkillDB.Add("Environment Suit (Battlesuit)",
                new SkillModel("Environment Suit (Battlesuit)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Environment Suit (Battlesuit)"]));
            SkillDB.Add("Environment Suit (Driving Suit)",
                new SkillModel("Environment Suit (Driving Suit)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Environment Suit (Driving Suit)"]));
            SkillDB.Add("Environment Suit (NBC Suit)",
                new SkillModel("Environment Suit (NBC Suit)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Environment Suit (NBC Suit)"]));
            SkillDB.Add("Environment Suit (Vacc Suit)",
                new SkillModel("Environment Suit (Vacc Suit)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Environment Suit (Vacc Suit)"]));
            SkillDB.Add("Escape",
                new SkillModel("Escape", EStatAttribute.DX, EDifficulty.Hard, SkillDescription["Escape"]));
            SkillDB.Add("Explosives",
                new SkillModel("Explosives", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Explosives"]));
            SkillDB.Add("First Aid",
                new SkillModel("First Aid", EStatAttribute.IQ, EDifficulty.Easy, SkillDescription["First Aid"]));
            SkillDB.Add("Forgery",
                new SkillModel("Forgery", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Forgery"]));
            SkillDB.Add("Gambling",
                new SkillModel("Gambling", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Gambling"]));
            SkillDB.Add("Hiking",
                new SkillModel("Hiking", EStatAttribute.HT, EDifficulty.Average, SkillDescription["Hiking"]));
            SkillDB.Add("Holdout",
                new SkillModel("Holdout", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Holdout"]));
            SkillDB.Add("Humanities",
                new SkillModel("Humanities", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Humanities"]));
            SkillDB.Add("Influence Skills (Diplomacy)",
                new SkillModel("Influence Skills (Diplomacy)", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Influence Skills (Diplomacy)"]));
            SkillDB.Add("Influence Skills (Fast-Talk)",
                new SkillModel("Influence Skills (Fast-Talk)", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Influence Skills (Fast-Talk)"]));
            SkillDB.Add("Influence Skills (Intimidation)",
                new SkillModel("Influence Skills (Intimidation)", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Influence Skills (Intimidation)"]));
            SkillDB.Add("Influence Skills (Savoir-Faire)",
                new SkillModel("Influence Skills (Savoir-Faire)", EStatAttribute.IQ, EDifficulty.Easy, SkillDescription["Influence Skills (Savoir-Faire)"]));
            SkillDB.Add("Influence Skills (Sex Appeal)",
                new SkillModel("Influence Skills (Sex Appeal)", EStatAttribute.HT, EDifficulty.Average, SkillDescription["Influence Skills (Sex Appeal)"]));
            SkillDB.Add("Influence Skills (Streetwise)",
                new SkillModel("Influence Skills (Streetwise)", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Influence Skills (Streetwise)"]));
            SkillDB.Add("Interrogation",
                new SkillModel("Interrogation", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Interrogation"]));
            SkillDB.Add("Jumping",
                new SkillModel("Jumping", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Jumping"]));
            SkillDB.Add("Karate",
                new SkillModel("Karate", EStatAttribute.DX, EDifficulty.Hard, SkillDescription["Karate"]));
            SkillDB.Add("Law",
                new SkillModel("Law", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Law"]));
            SkillDB.Add("Leadership",
                new SkillModel("Leadership", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Leadership"]));
            SkillDB.Add("Lockpicking",
                new SkillModel("Lockpicking", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Lockpicking"]));
            SkillDB.Add("Mathematics",
                new SkillModel("Mathematics", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Mathematics"]));
            SkillDB.Add("Mechanic",
                new SkillModel("Mechanic", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Mechanic"]));
            SkillDB.Add("Melee Weapon (Rapier)",
                new SkillModel("Melee Weapon (Rapier)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Melee Weapon (Rapier)"]));
            SkillDB.Add("Melee Weapon (Smallsword)",
                new SkillModel("Melee Weapon (Smallsword)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Melee Weapon (Smallsword)"]));
            SkillDB.Add("Melee Weapon (Flail)",
                new SkillModel("Melee Weapon (Flail)", EStatAttribute.DX, EDifficulty.Hard, SkillDescription["Melee Weapon (Flail)"]));
            SkillDB.Add("Melee Weapon (Axe/Mace)",
                new SkillModel("Melee Weapon (Axe/Mace)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Melee Weapon (Axe/Mace)"]));
            SkillDB.Add("Melee Weapon (Polearm)",
                new SkillModel("Melee Weapon (Polearm)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Melee Weapon (Polearm)"]));
            SkillDB.Add("Melee Weapon (Spear)",
                new SkillModel("Melee Weapon (Spear)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Melee Weapon (Spear)"]));
            SkillDB.Add("Melee Weapon (Staff)",
                new SkillModel("Melee Weapon (Staff)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Melee Weapon (Staff)"]));
            SkillDB.Add("Melee Weapon (Broadsword)",
                new SkillModel("Melee Weapon (Broadsword)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Melee Weapon (Broadsword)"]));
            SkillDB.Add("Melee Weapon (Knife)",
                new SkillModel("Melee Weapon (Knife)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Melee Weapon (Knife)"]));
            SkillDB.Add("Melee Weapon (Shortsword)",
                new SkillModel("Melee Weapon (Shortsword)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Melee Weapon (Shortsword)"]));
            SkillDB.Add("Melee Weapon (Two-Handed Sword)",
                new SkillModel("Melee Weapon (Two-Handed Sword)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Melee Weapon (Two-Handed Sword)"]));
            SkillDB.Add("Merchant",
                new SkillModel("Merchant", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Merchant"]));
            SkillDB.Add("Missile Weapon (Beams)",
                new SkillModel("Missile Weapon (Beams)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Missile Weapon (Beams)"]));
            SkillDB.Add("Missile Weapon (Cannon)",
                new SkillModel("Missile Weapon (Cannon)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Missile Weapon (Cannon)"]));
            SkillDB.Add("Missile Weapon (Machine Gun)",
                new SkillModel("Missile Weapon (Machine Gun)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Missile Weapon (Machine Gun)"]));
            SkillDB.Add("Missile Weapon (Light Anti-Armor Weapon)",
                new SkillModel("Missile Weapon (Light Anti-Armor Weapon)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Missile Weapon (Light Anti-Armor Weapon)"]));
            SkillDB.Add("Missile Weapon (Pistol)",
                new SkillModel("Missile Weapon (Pistol)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Missile Weapon (Pistol)"]));
            SkillDB.Add("Missile Weapon (Rifle)",
                new SkillModel("Missile Weapon (Rifle)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Missile Weapon (Rifle)"]));
            SkillDB.Add("Missile Weapon (Shotgun)",
                new SkillModel("Missile Weapon (Shotgun)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Missile Weapon (Shotgun)"]));
            SkillDB.Add("Missile Weapon (Submachine Gun)",
                new SkillModel("Missile Weapon (Submachine Gun)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Missile Weapon (Submachine Gun)"]));
            SkillDB.Add("Missile Weapon (Flamethrower)",
                new SkillModel("Missile Weapon (Flamethrower)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Missile Weapon (Flamethrower)"]));
            SkillDB.Add("Missile Weapon (Blowpipe)",
                new SkillModel("Missile Weapon (Blowpipe)", EStatAttribute.DX, EDifficulty.Hard, SkillDescription["Missile Weapon (Blowpipe)"]));
            SkillDB.Add("Missile Weapon (Bow)",
                new SkillModel("Missile Weapon (Bow)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Missile Weapon (Bow)"]));
            SkillDB.Add("Missile Weapon (Crossbow)",
                new SkillModel("Missile Weapon (Crossbow)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Missile Weapon (Crossbow)"]));
            SkillDB.Add("Natural Sciences (Astronomy)",
                new SkillModel("Natural Sciences (Astronomy)", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Natural Sciences (Astronomy)"]));
            SkillDB.Add("Natural Sciences (Biology)",
                new SkillModel("Natural Sciences (Biology)", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Natural Sciences (Biology)"]));
            SkillDB.Add("Natural Sciences (Chemistry)",
                new SkillModel("Natural Sciences (Chemistry)", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Natural Sciences (Chemistry)"]));
            SkillDB.Add("Natural Sciences (Physics)",
                new SkillModel("Natural Sciences (Physics)", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Natural Sciences (Physics)"]));
            SkillDB.Add("Naturalist",
                new SkillModel("Naturalist", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Naturalist"]));
            SkillDB.Add("Navigation (Sea)",
                new SkillModel("Navigation (Sea)", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Navigation (Sea)"]));
            SkillDB.Add("Navigation (Air)",
                new SkillModel("Navigation (Air)", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Navigation (Air)"]));
            SkillDB.Add("Navigation (Land)",
                new SkillModel("Navigation (Land)", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Navigation (Land)"]));
            SkillDB.Add("Navigation (Space)",
                new SkillModel("Navigation (Space)", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Navigation (Space)"]));
            SkillDB.Add("Navigation (Hyperspace)",
                new SkillModel("Navigation (Hyperspace)", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Navigation (Hyperspace)"]));
            SkillDB.Add("Observation",
                new SkillModel("Observation", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Observation"]));
            SkillDB.Add("Occultism",
                new SkillModel("Occultism", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Occultism"]));
            SkillDB.Add("Photography",
                new SkillModel("Photography", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Photography"]));
            SkillDB.Add("Physician",
                new SkillModel("Physician", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Physician"]));
            SkillDB.Add("Pickpocket",
                new SkillModel("Pickpocket", EStatAttribute.DX, EDifficulty.Hard, SkillDescription["Pickpocket"]));
            SkillDB.Add("Public Speaking",
                new SkillModel("Public Speaking", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Public Speaking"]));
            SkillDB.Add("Research",
                new SkillModel("Research", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Research"]));
            SkillDB.Add("Riding",
                new SkillModel("Riding", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Riding"]));
            SkillDB.Add("Scrounging",
                new SkillModel("Scrounging", EStatAttribute.IQ, EDifficulty.Easy, SkillDescription["Scrounging"]));
            SkillDB.Add("Search",
                new SkillModel("Search", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Search"]));
            SkillDB.Add("Shadowing",
                new SkillModel("Shadowing", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Shadowing"]));
            SkillDB.Add("Shield",
                new SkillModel("Shield", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Shield"]));
            SkillDB.Add("Social Sciences (Anthropology)",
                new SkillModel("Social Sciences (Anthropology)", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Social Sciences (Anthropology)"]));
            SkillDB.Add("Social Sciences (Archaeology)",
                new SkillModel("Social Sciences (Archaeology)", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Social Sciences (Archaeology)"]));
            SkillDB.Add("Social Sciences (Psychology)",
                new SkillModel("Social Sciences (Psychology)", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Social Sciences (Psychology)"]));
            SkillDB.Add("Social Sciences (Sociology)",
                new SkillModel("Social Sciences (Sociology)", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Social Sciences (Sociology)"]));
            SkillDB.Add("Smuggling",
                new SkillModel("Smuggling", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Smuggling"]));
            SkillDB.Add("Stealth",
                new SkillModel("Stealth", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Stealth"]));
            SkillDB.Add("Survival",
                new SkillModel("Survival", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Survival"]));
            SkillDB.Add("Swimming",
                new SkillModel("Swimming", EStatAttribute.HT, EDifficulty.Easy, SkillDescription["Swimming"]));
            SkillDB.Add("Tactics",
                new SkillModel("Tactics", EStatAttribute.IQ, EDifficulty.Hard, SkillDescription["Tactics"]));
            SkillDB.Add("Throwing",
                new SkillModel("Throwing", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Throwing"]));
            SkillDB.Add("Thrown Weapon (Axe/Mace)",
                new SkillModel("Thrown Weapon (Axe/Mace)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Thrown Weapon (Axe/Mace)"]));
            SkillDB.Add("Thrown Weapon (Knife)",
                new SkillModel("Thrown Weapon (Knife)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Thrown Weapon (Knife)"]));
            SkillDB.Add("Thrown Weapon (Shuriken)",
                new SkillModel("Thrown Weapon (Shuriken)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Thrown Weapon (Shuriken)"]));
            SkillDB.Add("Thrown Weapon (Spear)",
                new SkillModel("Thrown Weapon (Spear)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Thrown Weapon (Spear)"]));
            SkillDB.Add("Tracking",
                new SkillModel("Tracking", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Tracking"]));
            SkillDB.Add("Traps",
                new SkillModel("Traps", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Traps"]));
            SkillDB.Add("Vehicle Skill (Bicycling)",
                new SkillModel("Vehicle Skill (Bicycling)", EStatAttribute.DX, EDifficulty.Easy, SkillDescription["Vehicle Skill (Bicycling)"]));
            SkillDB.Add("Vehicle Skill (Boating)",
                new SkillModel("Vehicle Skill (Boating)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Vehicle Skill (Boating)"]));
            SkillDB.Add("Vehicle Skill (Driving)",
                new SkillModel("Vehicle Skill (Driving)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Vehicle Skill (Driving)"]));
            SkillDB.Add("Vehicle Skill (Piloting)",
                new SkillModel("Vehicle Skill (Piloting)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Vehicle Skill (Piloting)"]));
            SkillDB.Add("Vehicle Skill (Submarine)",
                new SkillModel("Vehicle Skill (Submarine)", EStatAttribute.DX, EDifficulty.Average, SkillDescription["Vehicle Skill (Submarine)"]));
            SkillDB.Add("Writing",
                new SkillModel("Writing", EStatAttribute.IQ, EDifficulty.Average, SkillDescription["Writing"]));
        }

        private void LoadSkillDescription()
        {
            SkillDescription.Add("Acrobatics", "This is the ability to perform gymnastic stunts, roll, take falls, etc.");
            SkillDescription.Add("Acting", "This is the ability to counterfeit moods, emotions, and voices, and to lie convincingly over a period of time.");
            SkillDescription.Add("Animal Handling", "This is the ability to train and work with animals. When working with a trained animal, roll against skill for each task you give the animal.");
            SkillDescription.Add("Area Knowledge", "This skill represents familiarity with the people, places, and politics of a given region. You usually have Area Knowledge only for the area you consider your “home base.”");
            SkillDescription.Add("Armoury", "This is the ability to build, modify, and repair a specific class of weapons or armor. A successful roll lets you find a problem, if it isn’t obvious; a second roll lets you repair it. Time required is up to the GM.");
            SkillDescription.Add("Brawling", "This is the skill of “unscientific” unarmed combat. Roll against Brawling to hit with a punch, or Brawling-2 to hit with a kick.");
            SkillDescription.Add("Camouflage", "This is the ability to use natural materials, special fabrics and paints, etc. to hide yourself, your position, or your equipment.");
            SkillDescription.Add("Carousing", "This is the skill of socializing, partying, etc. A successful Carousing roll, under the right circumstances, gives you a +2 bonus on a request for aid or information, or just on a general reaction. A failed roll means you made a fool of yourself in some way; you get a -2 penalty on any reaction roll made by those you caroused with.");
            SkillDescription.Add("Climbing", "This is the ability to climb mountains, rock walls, trees, the sides of buildings, etc. See Climbing (p. 22) for details.");
            SkillDescription.Add("Computer Operation", "This is the ability to use a computer: call up data, run programs, play games, etc. It is the only computer skill needed by most end users.");
            SkillDescription.Add("Computer Programming", "The ability to write and debug computer software. Roll to write, debug, or figure out a program.");
            SkillDescription.Add("Crewman", "This is the ability to serve as crew aboard a large vehicle. It includes familiarity with “shipboard life,” knowledge of safety measures, and training in damage control.");
            SkillDescription.Add("Criminology", "This is the study of crime and the criminal mind. A successful skill roll allows you to find and interpret clues, guess how criminals might behave, etc.");
            SkillDescription.Add("Diagnosis", "This is the ability to tell what is wrong with a sick or injured person, or what killed a dead person. It might not determine the exact problem, but it always gives hints, rule out impossibilities, etc.");
            SkillDescription.Add("Disguise", "This is the art of altering your appearance using clothing, makeup, and prosthetics. A good disguise requires a Disguise roll and 30 minutes to an hour of preparation.");
            SkillDescription.Add("Electronics Operation", "This skill lets you use electronic equipment. Make a skill roll in an emergency situation or for “abnormal” use of equipment – not for ordinary, everyday use.");
            SkillDescription.Add("Electronics Repair", "This is the ability to diagnose and repair known types of electronic equipment.");
            SkillDescription.Add("Engineer", "This is the ability to design and build technological devices and systems. A successful roll lets you design a new system, diagnose a glitch, identify the purpose of a strange device, or improvise a gadget to solve a problem.");
            SkillDescription.Add("Environment Suit (Battlesuit)", "All kinds of powered battle armor and exoskeletons. This is training in the use of a specific class of protective suit. Suits designed against environmental or battlefield hazards are so complex that you do not merely wear such gear – you operate it.");
            SkillDescription.Add("Environment Suit (Driving Suit)", "All types of hard diving suits. This is training in the use of a specific class of protective suit. Suits designed against environmental or battlefield hazards are so complex that you do not merely wear such gear – you operate it.");
            SkillDescription.Add("Environment Suit (NBC Suit)", "All forms of hazardous materials(“HazMat”) gear. This is training in the use of a specific class of protective suit. Suits designed against environmental or battlefield hazards are so complex that you do not merely wear such gear – you operate it.");
            SkillDescription.Add("Environment Suit (Vacc Suit)", "Any kind of spacesuit. This is training in the use of a specific class of protective suit. Suits designed against environmental or battlefield hazards are so complex that you do not merely wear such gear – you operate it.");
            SkillDescription.Add("Escape", "This is the ability to slip out of ropes, handcuffs, and similar restraints. The first attempt to escape takes one minute; each subsequent attempt takes 10 minutes.");
            SkillDescription.Add("Explosives", "This is the skill of working with explosives and incendiaries, including the ability to set up, disarm, and dispose of bombs and other explosives.");
            SkillDescription.Add("First Aid", "This is the ability to patch up an injury in the field (see Recovery, p. 30). Make a skill roll to halt bleeding, suck out poison, give artificial respiration to a drowning victim, etc.");
            SkillDescription.Add("Forgery", "This is the ability to create falsified documents (identity cards, passports, etc.). When you use a forged document, make your Forgery roll each time it is inspected – unless you roll a critical success on your first attempt. Failure means someone spots the forgery.");
            SkillDescription.Add("Gambling", "This is skill at playing games of chance. A successful Gambling roll can (among other things) tell you if a game is rigged, identify a fellow gambler in a group of strangers, or “estimate the odds” in any tricky situation.");
            SkillDescription.Add("Hiking", "This skill represents training for endurance walking, hiking, and marching. Make a Hiking roll before each day’s march; on a success, increase the distance traveled by 20%.");
            SkillDescription.Add("Holdout", "This is the skill of concealing items on your person or on other people (usually with their cooperation). An item’s size and shape govern its concealability, from +4 for a BB-sized jewel or a postage stamp, to -6 for a crossbow or a heavy sniper rifle.");
            SkillDescription.Add("Humanities", "Each academic “humanity” or “arts” subject (such as History, Literature, Philosophy, or Theology) is a separate skill.");
            SkillDescription.Add("Influence Skills (Diplomacy)", "Negotiation and compromise." + Environment.NewLine + Environment.NewLine + "There are several ways to influence others; each is a separate influence skill. A successful roll will result in a good reaction from an NPC. Failure results in a bad reaction (except for Diplomacy, which is relatively safe). To actually coerce or manipulate an NPC, you must win a Quick Contest of your skill versus his Will.");
            SkillDescription.Add("Influence Skills (Fast-Talk)", "Lying and deceit." + Environment.NewLine + Environment.NewLine + "There are several ways to influence others; each is a separate influence skill. A successful roll will result in a good reaction from an NPC. Failure results in a bad reaction (except for Diplomacy, which is relatively safe). To actually coerce or manipulate an NPC, you must win a Quick Contest of your skill versus his Will.");
            SkillDescription.Add("Influence Skills (Intimidation)", "Threats and violence." + Environment.NewLine + Environment.NewLine + "There are several ways to influence others; each is a separate influence skill. A successful roll will result in a good reaction from an NPC. Failure results in a bad reaction (except for Diplomacy, which is relatively safe). To actually coerce or manipulate an NPC, you must win a Quick Contest of your skill versus his Will.");
            SkillDescription.Add("Influence Skills (Savoir-Faire)", "Manners and etiquette. Mainly useful in “high society” situations." + Environment.NewLine + Environment.NewLine + "There are several ways to influence others; each is a separate influence skill. A successful roll will result in a good reaction from an NPC. Failure results in a bad reaction (except for Diplomacy, which is relatively safe). To actually coerce or manipulate an NPC, you must win a Quick Contest of your skill versus his Will.");
            SkillDescription.Add("Influence Skills (Sex Appeal)", "Vamping and seduction, usually of the opposite sex." + Environment.NewLine + Environment.NewLine + "There are several ways to influence others; each is a separate influence skill. A successful roll will result in a good reaction from an NPC. Failure results in a bad reaction (except for Diplomacy, which is relatively safe). To actually coerce or manipulate an NPC, you must win a Quick Contest of your skill versus his Will.");
            SkillDescription.Add("Influence Skills (Streetwise)", "Contacts and (usually) subtle intimidation." + Environment.NewLine + Environment.NewLine + "There are several ways to influence others; each is a separate influence skill. A successful roll will result in a good reaction from an NPC. Failure results in a bad reaction (except for Diplomacy, which is relatively safe). To actually coerce or manipulate an NPC, you must win a Quick Contest of your skill versus his Will.");
            SkillDescription.Add("Interrogation", "This is the ability to question a prisoner. Roll a Quick Contest of Interrogation vs. the prisoner’s Will for each question. This requires 5 minutes per question. If you win, you get a truthful answer. If you tie or lose, the victim remains silent or lies. If you lose by more than five points, he tells you a good, believable lie!");
            SkillDescription.Add("Jumping", "This skill represents trained jumping ability. When you attempt a difficult jump, roll against the higher of Jumping or DX.In addition, you may use half your Jumping skill(round down) instead of Basic Move when calculating jumping distance.");
            SkillDescription.Add("Karate", "This skill represents any advanced training at unarmed striking, not just the Okinawan martial art of karate. Roll against Karate to hit with a punch (at no -4 for the “off” hand), or Karate-2 to hit with a kick." + Environment.NewLine + Environment.NewLine + "Karate improves damage: if you know Karate at DX level, add +1 per die to basic thrust damage when you calculate damage with Karate attacks: punches, kicks, elbow strikes, etc. Add +2 per die if you know Karate at DX+1 or better!");
            SkillDescription.Add("Law", "This skill represents knowledge of law codes and jurisprudence. A successful roll lets you remember, deduce, or figure out the answer to a question about the law.");
            SkillDescription.Add("Leadership", "This is the ability to coordinate a group. Make a Leadership roll to lead NPCs into a dangerous or stressful situation. (PCs can decide for themselves if they want to follow you!)");
            SkillDescription.Add("Lockpicking", "This is the ability to open locks without the key or combination. Each attempt requires one minute. If you make the roll and open the lock, each point by which you succeeded shaves five seconds off the required time.");
            SkillDescription.Add("Mathematics", "This is the scientific study of quantities and magnitudes, and their relationships and attributes, through the use of numbers and symbols.");
            SkillDescription.Add("Mechanic", "This is the ability to diagnose and fix ordinary mechanical problems. A successful skill roll will let you find or repair one problem.");
            SkillDescription.Add("Melee Weapon (Rapier)", "Fencing weapons are light, one-handed weapons, usually hilted blades, optimized for parrying.");
            SkillDescription.Add("Melee Weapon (Smallsword)", "Fencing weapons are light, one-handed weapons, usually hilted blades, optimized for parrying.");
            SkillDescription.Add("Melee Weapon (Flail)", "A flail is any flexible, unbalanced weapon with its mass concentrated in the head. Because flails tend to wrap around the target’s shield or weapon, attempts to block them are at -2 and attempts to parry them are at -4.");
            SkillDescription.Add("Melee Weapon (Axe/Mace)", "An impact weapon is any rigid, unbalanced weapon with most of its mass concentrated in the head, such as axes and maces. Such a weapon cannot parry if you have already attacked with it on your turn.");
            SkillDescription.Add("Melee Weapon (Polearm)", "Pole weapons are long (usually wooden) shafts, often adorned with striking heads. All require two hands.");
            SkillDescription.Add("Melee Weapon (Spear)", "Pole weapons are long (usually wooden) shafts, often adorned with striking heads. All require two hands.");
            SkillDescription.Add("Melee Weapon (Staff)", "Pole weapons are long (usually wooden) shafts, often adorned with striking heads. All require two hands. Also +2 Parry.");
            SkillDescription.Add("Melee Weapon (Broadsword)", "A sword is a rigid, hilted blade with a thrusting point, cutting edge, or both. All swords are balanced, and can attack and parry without becoming unready.");
            SkillDescription.Add("Melee Weapon (Knife)", "A sword is a rigid, hilted blade with a thrusting point, cutting edge, or both. All swords are balanced, and can attack and parry without becoming unready. -1 to Parry");
            SkillDescription.Add("Melee Weapon (Shortsword)", "A sword is a rigid, hilted blade with a thrusting point, cutting edge, or both. All swords are balanced, and can attack and parry without becoming unready.");
            SkillDescription.Add("Melee Weapon (Two-Handed Sword)", "A sword is a rigid, hilted blade with a thrusting point, cutting edge, or both. All swords are balanced, and can attack and parry without becoming unready.");
            SkillDescription.Add("Merchant", "This is the skill of buying, selling, and trading retail and wholesale goods. It involves bargaining, salesmanship, and an understanding of trade practices.");
            SkillDescription.Add("Missile Weapon (Beams)", "Any kind of heavy directed-energy weapon: laser, particle beam, etc.");
            SkillDescription.Add("Missile Weapon (Cannon)", "Any kind of heavy projectile weapon – e.g., the main gun of a tank or an ultra-tech railgun on a starship – that fires single shots.");
            SkillDescription.Add("Missile Weapon (Machine Gun)", "Any kind of heavy projectile weapon capable of firing bursts.");
            SkillDescription.Add("Missile Weapon (Light Anti-Armor Weapon)", "All forms of rocket launchers and recoilless rifles.");
            SkillDescription.Add("Missile Weapon (Pistol)", "All kinds of handguns, including derringers, pepperboxes, revolvers, and automatics, but not machine pistols.");
            SkillDescription.Add("Missile Weapon (Rifle)", "Any kind of rifled long arm – assault rifle, hunting rifle, sniper rifle, etc. – that fires a solid projectile.");
            SkillDescription.Add("Missile Weapon (Shotgun)", "Any kind of smoothbore long arm that fires multiple projectiles (flechettes, shot, etc.).");
            SkillDescription.Add("Missile Weapon (Submachine Gun)", "All short, fully automatic weapons that fire pistol-caliber ammunition, including machine pistols.");
            SkillDescription.Add("Missile Weapon (Flamethrower)", "This is the ability to use a weapon that projects a stream of liquid or gas.");
            SkillDescription.Add("Missile Weapon (Blowpipe)", "You can use this weapon to shoot small, usually poisoned, darts. You can also use it to blow powders at targets within one yard.");
            SkillDescription.Add("Missile Weapon (Bow)", "This is the ability to use all bows except crossbows.");
            SkillDescription.Add("Missile Weapon (Crossbow)", "This is the ability to use all types of crossbows.");
            SkillDescription.Add("Natural Sciences (Astronomy)", "There are a number of skill types under this heading, including Astronomy, Biology, Chemistry, Geology, and Physics, plus any others the GM approves.");
            SkillDescription.Add("Natural Sciences (Biology)", "There are a number of skill types under this heading, including Astronomy, Biology, Chemistry, Geology, and Physics, plus any others the GM approves.");
            SkillDescription.Add("Natural Sciences (Chemistry)", "There are a number of skill types under this heading, including Astronomy, Biology, Chemistry, Geology, and Physics, plus any others the GM approves.");
            SkillDescription.Add("Natural Sciences (Physics)", "There are a number of skill types under this heading, including Astronomy, Biology, Chemistry, Geology, and Physics, plus any others the GM approves.");
            SkillDescription.Add("Natural Sciences (Geology)", "There are a number of skill types under this heading, including Astronomy, Biology, Chemistry, Geology, and Physics, plus any others the GM approves.");
            SkillDescription.Add("Naturalist", "This skill represents practical knowledge of nature – notably, how to tell dangerous plants and animals from benign ones, how to locate a cave to shelter in; and how to “read” weather patterns to know when to take shelter.");
            SkillDescription.Add("Navigation (Sea)", "This is the ability to find your position through careful observation of your surroundings and the use of instrumentation. A successful roll tells you where you are or lets you plot a course.");
            SkillDescription.Add("Navigation (Air)", "This is the ability to find your position through careful observation of your surroundings and the use of instrumentation. A successful roll tells you where you are or lets you plot a course.");
            SkillDescription.Add("Navigation (Land)", "This is the ability to find your position through careful observation of your surroundings and the use of instrumentation. A successful roll tells you where you are or lets you plot a course.");
            SkillDescription.Add("Navigation (Space)", "This is the ability to find your position through careful observation of your surroundings and the use of instrumentation. A successful roll tells you where you are or lets you plot a course.");
            SkillDescription.Add("Navigation (Hyperspace)", "This is the ability to find your position through careful observation of your surroundings and the use of instrumentation. A successful roll tells you where you are or lets you plot a course.");
            SkillDescription.Add("Observation", "This is the talent of observing dangerous or “interesting” situations without letting others know that you are watching. Use this skill to monitor a location, a group of people, or your immediate surroundings for concealed or tactically significant details.");
            SkillDescription.Add("Occultism", "This is the study of the mysterious and the supernatural. An occultist is an expert on ancient rituals, hauntings, mysticism, primitive magical beliefs, psychic phenomena, etc.");
            SkillDescription.Add("Photography", "This is the ability to use a camera competently, use a darkroom (TL5+) or digital imaging software (TL8+), etc., and to produce recognizable and attractive photos. You may roll at default to use a camera, but not to develop film or prints in a darkroom.");
            SkillDescription.Add("Physician", "This is the ability to aid the sick and the injured, prescribe drugs and care, etc. Make a skill roll to hasten natural recovery from injury (see Recovery, p. 30), and whenever the GM requires a roll to test general medical competence or knowledge.");
            SkillDescription.Add("Pickpocket", "This is the ability to steal a purse, knife, etc., from someone’s person – or to “plant” something on him.");
            SkillDescription.Add("Public Speaking", "This is general talent with the spoken word. A successful skill roll lets you (for instance) give a good political speech, entertain a group around a campfire, incite or calm a riot, or put on a successful “court jester” act.");
            SkillDescription.Add("Research", "This is the ability to do library and file research. Roll against skill to find a useful piece of data in an appropriate place of research . . . ifthe information is there to be found.");
            SkillDescription.Add("Riding", "This is the ability to ride a particular kind of mount. Make a skill roll when you first try to mount a riding animal, and again each time something happens to frighten or challenge the creature (e.g., a jump).");
            SkillDescription.Add("Scrounging", "This is the ability to find, salvage, or improvise useful items that others can’t locate. Each attempt takes an hour. You do not necessarily steal your booty; you just locate it – somehow – and then acquire it by any means necessary.");
            SkillDescription.Add("Search", "This is the ability to search people, baggage, and vehicles for items that aren’t in plain sight. The GM rolls once – in secret – per item of interest. For deliberately concealed items, this is a Quick Contest of your Search skill vs. the Holdout or Smuggling skill used to hide the item. If you fail, the GM simply says, “You found nothing.”");
            SkillDescription.Add("Shadowing", "This is the ability to follow another person through a crowd without being noticed. Roll a Quick Contest every 10 minutes: your Shadowing vs. the subject’s Vision roll. If you lose, you lost the subject; if you lose by more than 5, you were seen.");
            SkillDescription.Add("Shield", "This is the ability to use a shield, both to block and to attack. Your Block score with any shield is (skill/2) + 3, rounded down.");
            SkillDescription.Add("Social Sciences (Anthropology)", "Each “social science” (e.g., Anthropology, Archaeology, Psychology or Sociology) is a separate skill.");
            SkillDescription.Add("Social Sciences (Archaeology)", "Each “social science” (e.g., Anthropology, Archaeology, Psychology or Sociology) is a separate skill.");
            SkillDescription.Add("Social Sciences (Psychology)", "Each “social science” (e.g., Anthropology, Archaeology, Psychology or Sociology) is a separate skill.");
            SkillDescription.Add("Social Sciences (Sociology)", "Each “social science” (e.g., Anthropology, Archaeology, Psychology or Sociology) is a separate skill.");
            SkillDescription.Add("Smuggling", "This is the ability to conceal items in baggage and vehicles. You can also use it to hide an object in a room or a building. Roll against skill to hide an item from casual inspection. In an active search, the searchers must win a Quick Contest of Search vs. your Smuggling skill to find the item.");
            SkillDescription.Add("Stealth", "This is the ability to hide and to move silently. A successful roll lets you conceal yourself practically anywhere, or move so quietly that nobody will hear you, or follow someone without being noticed." + Environment.NewLine + Environment.NewLine + "If someone is specifically on the alert for intruders, the GM will roll a Quick Contest between your Stealth and the sentinel’s Perception.");
            SkillDescription.Add("Survival", "This is the ability to “live off the land,” find safe food and water, avoid hazards, build shelter, etc. To live safely in a wilderness situation, you must make a successful Survival roll once per day. Failure inflicts 2d-4 injury on you and anyone in your care. There are many different types of Survival skill, which must be learned independently.");
            SkillDescription.Add("Swimming", "This is the skill of swimming (on purpose or to keep afloat in emergencies) and lifesaving. Roll against the higher of Swimming or HT to avoid fatigue or injury due to aquatic misfortunes.");
            SkillDescription.Add("Tactics", "This is the ability to outguess and outmaneuver the enemy in small-unit or personal combat." + Environment.NewLine + Environment.NewLine + "When commanding a small unit, roll against Tactics to place your troops correctly for an ambush, know where to post sentries, etc. In personal combat, you may make a Tactics roll before the fight begins if you had any time to prepare. On a success, you start the fight in an advantageous position – e.g., behind cover or on higher ground – as determined by the GM.");
            SkillDescription.Add("Throwing", "This is the ability to throw any small, relatively smooth object that fits in the palm of your hand. Examples include baseballs, hand grenades, and rocks.");
            SkillDescription.Add("Thrown Weapon (Axe/Mace)", "Any axe, hatchet, or mace balanced for throwing (but not an unbalanced battleaxe or maul!).");
            SkillDescription.Add("Thrown Weapon (Knife)", "Any sort of knife.");
            SkillDescription.Add("Thrown Weapon (Shuriken)", "Any sort of hiltless blade, notably shuriken(“ninja stars”).");
            SkillDescription.Add("Thrown Weapon (Spear)", "Any sort of spear, javelin, etc.");
            SkillDescription.Add("Tracking", "This is the ability to follow a man or an animal by its tracks. Make a Tracking roll to pick up the trail, then roll every 15 minutes to avoid losing it, at a modifier ranging from 0 for soft terrain to -6 for city streets.");
            SkillDescription.Add("Traps", "This is the skill of building and nullifying traps. For the purposes of Traps skill, detection devices are “traps.” Thus, this skill covers everything from covered pits to elaborate electronic security systems!");
            SkillDescription.Add("Vehicle Skill (Bicycling)", "Each class of vehicle requires a different skill to operate it. Roll once to get under way and again each time a hazard is encountered; failure indicates lost time or even an accident.");
            SkillDescription.Add("Vehicle Skill (Boating)", "Each class of vehicle requires a different skill to operate it. Roll once to get under way and again each time a hazard is encountered; failure indicates lost time or even an accident.");
            SkillDescription.Add("Vehicle Skill (Driving)", "Each class of vehicle requires a different skill to operate it. Roll once to get under way and again each time a hazard is encountered; failure indicates lost time or even an accident.");
            SkillDescription.Add("Vehicle Skill (Piloting)", "Each class of vehicle requires a different skill to operate it. Roll once to get under way and again each time a hazard is encountered; failure indicates lost time or even an accident.");
            SkillDescription.Add("Vehicle Skill (Submarine)", "Each class of vehicle requires a different skill to operate it. Roll once to get under way and again each time a hazard is encountered; failure indicates lost time or even an accident.");
            SkillDescription.Add("Writing", "This is the ability to write in a clear or entertaining manner. A successful roll means the work is readable and accurate.");
        }

        private void LoadAdvantageDB()
        {
            AdvantageDB.Add("Acute Senses (Hearing)", 
                new AdvantageModel("Acute Senses (Hearing)", 2, true, AdvantageDescription["Acute Senses (Hearing)"]));
            AdvantageDB.Add("Acute Senses (Taste and Smell)", 
                new AdvantageModel("Acute Senses (Taste and Smell)", 2, true, AdvantageDescription["Acute Senses (Taste and Smell)"]));
            AdvantageDB.Add("Acute Senses (Touch)", 
                new AdvantageModel("Acute Senses (Touch)", 2, true, AdvantageDescription["Acute Senses (Touch)"]));
            AdvantageDB.Add("Acute Senses (Vision)", 
                new AdvantageModel("Acute Senses (Vision)", 2, true, AdvantageDescription["Acute Senses (Vision)"]));
            AdvantageDB.Add("Ambidexterity", 
                new AdvantageModel("Ambidexterity", 5, false, AdvantageDescription["Ambidexterity"]));
            AdvantageDB.Add("Animal Empathy", 
                new AdvantageModel("Animal Empathy", 5, false, AdvantageDescription["Animal Empathy"]));
            AdvantageDB.Add("Catfall", 
                new AdvantageModel("Catfall", 10, false, AdvantageDescription["Catfall"]));
            AdvantageDB.Add("Combat Reflexes", 
                new AdvantageModel("Combat Reflexes", 15, false, AdvantageDescription["Combat Reflexes"]));
            AdvantageDB.Add("Danger Sense", 
                new AdvantageModel("Danger Sense", 15, false, AdvantageDescription["Danger Sense"]));
            AdvantageDB.Add("Daredevil", 
                new AdvantageModel("Daredevil", 15, false, AdvantageDescription["Daredevil"]));
            AdvantageDB.Add("Empathy", 
                new AdvantageModel("Empathy", 15, false, AdvantageDescription["Empathy"]));
            AdvantageDB.Add("Enhanced Defenses (Block)", 
                new AdvantageModel("Enhanced Defenses (Block)", 5, false, AdvantageDescription["Enhanced Defenses (Block)"]));
            AdvantageDB.Add("Ehhanced Defenses (Dodge)", 
                new AdvantageModel("Enhanced Defenses (Dodge)", 15, false, AdvantageDescription["Ehhanced Defenses (Dodge)"]));
            AdvantageDB.Add("Enhanced Defenses (Parry) (All Weapons)", 
                new AdvantageModel("Enhanced Defenses (Parry) (All)", 10, false, AdvantageDescription["Enhanced Defenses (Parry) (All Weapons)"]));
            AdvantageDB.Add("Enhanced Defenses (Parry) (Barehands)", 
                new AdvantageModel("Enhanced Defenses (Parry) (Barehands)", 5, false, AdvantageDescription["Enhanced Defenses (Parry) (Barehands)"]));
            AdvantageDB.Add("Enhanced Defenses (Parry) (Single Weapon of Choice Only)", 
                new AdvantageModel("Enhanced Defenses (Parry) (Single)", 5, false, AdvantageDescription["Enhanced Defenses (Parry) (Single Weapon of Choice Only)"]));
            AdvantageDB.Add("Fearlessness", 
                new AdvantageModel("Fearlessness", 2, true, AdvantageDescription["Fearlessness"]));
            AdvantageDB.Add("Flexibility (Basic)", 
                new AdvantageModel("Flexibility (Basic)", 5, false, AdvantageDescription["Flexibility (Basic)"]));
            AdvantageDB.Add("Flexibility (Double-Jointed)", 
                new AdvantageModel("Flexibility (Double-Jointed)", 15, false, AdvantageDescription["Flexibility (Double-Jointed)"]));
            AdvantageDB.Add("Hard to Kill", 
                new AdvantageModel("Hard to Kill", 2, true, AdvantageDescription["Hard to Kill"]));
            AdvantageDB.Add("High Pain Threshold", 
                new AdvantageModel("High Pain Threshold", 10, false, AdvantageDescription["High Pain Threshold"]));
            AdvantageDB.Add("Jumper", 
                new AdvantageModel("Jumper", 100, false, AdvantageDescription["Jumper"]));
            AdvantageDB.Add("Language Talent", 
                new AdvantageModel("Language Talent", 10, false, AdvantageDescription["Language Talent"]));
            AdvantageDB.Add("Luck (Basic)", 
                new AdvantageModel("Luck (Basic)", 15, false, AdvantageDescription["Luck (Basic)"]));
            AdvantageDB.Add("Luck (Extraordinary)", 
                new AdvantageModel("Luck (Extraordinary)", 30, false, AdvantageDescription["Luck (Extraordinary)"]));
            AdvantageDB.Add("Luck (Ridiculous)", 
                new AdvantageModel("Luck (Ridiculous)", 60, false, AdvantageDescription["Luck (Ridiculous)"]));
            AdvantageDB.Add("Night Vision", 
                new AdvantageModel("Night Vision", 1, true, AdvantageDescription["Night Vision"]));
            AdvantageDB.Add("Perfect Balance", 
                new AdvantageModel("Perfect Balance", 15, false, AdvantageDescription["Perfect Balance"]));
            AdvantageDB.Add("Resistant (Poison)", 
                new AdvantageModel("Resistant (Poison)", 5, false, AdvantageDescription["Resistant (Poison)"]));
            AdvantageDB.Add("Resistant (Disease)", 
                new AdvantageModel("Resistant (Disease)", 5, false, AdvantageDescription["Resistant (Disease)"]));
            AdvantageDB.Add("Talent (Artificer)", 
                new AdvantageModel("Talent (Artificer)", 10, true, AdvantageDescription["Talent (Artificer)"]));
            AdvantageDB.Add("Talent (Outdoorsman)", 
                new AdvantageModel("Talent (Outdoorsman)", 10, true, AdvantageDescription["Talent (Outdoorsman)"]));
            AdvantageDB.Add("Talent (Smooth Operator)", 
                new AdvantageModel("Talent (Smooth Operator)", 15, true, AdvantageDescription["Talent (Smooth Operator)"]));
        }
        private void LoadAdvantageDescription()
        {
            AdvantageDescription.Add("Acute Senses (Hearing)", "You have superior senses. Each Acute Sense is a separate advantage that gives +1 per level to all Sense rolls (p. 24) you make – or the GM makes for you – using that one sense.");
            AdvantageDescription.Add("Acute Senses (Taste and Smell)", "You have superior senses. Each Acute Sense is a separate advantage that gives +1 per level to all Sense rolls (p. 24) you make – or the GM makes for you – using that one sense.");
            AdvantageDescription.Add("Acute Senses (Touch)", "You have superior senses. Each Acute Sense is a separate advantage that gives +1 per level to all Sense rolls (p. 24) you make – or the GM makes for you – using that one sense.");
            AdvantageDescription.Add("Acute Senses (Vision)", "You have superior senses. Each Acute Sense is a separate advantage that gives +1 per level to all Sense rolls (p. 24) you make – or the GM makes for you – using that one sense.");
            AdvantageDescription.Add("Ambidexterity", "You can fight or otherwise act equally well with either hand, and never suffer the -4 DX penalty for using the “off” hand (see p. 5). Should some accident befall one of your arms or hands, assume it is the left one.");
            AdvantageDescription.Add("Animal Empathy", "You are unusually talented at reading the motivations of animals. When you meet an animal, the GM rolls against your IQ and tells you what you “feel.” This reveals the beast’s emotional state – friendly, frightened, hostile, hungry, etc. – and whether it is under supernatural control. You may also use your Influence skills (see p. 15) on animals just as you would on sapient beings, which usually ensures a positive reaction.");
            AdvantageDescription.Add("Catfall", "You subtract five yards from a fall automatically (treat this as an automatic Acrobatics success – don’t check again for it). In addition, a successful DX roll halves damage from any fall (see p. 32). To enjoy these benefits, your limbs must be unbound and your body free to twist as you fall.");
            AdvantageDescription.Add("Combat Reflexes", "You have extraordinary reactions, and are rarely surprised for more than a moment. You get +1 to all active defense rolls (see Defending, p. 28) and +2 to Fright Checks (see Fright Checks, p. 24). You never “freeze” in a surprise situation, and get +6 on all IQ rolls to wake up, or to recover from surprise or mental “stun.”");
            AdvantageDescription.Add("Danger Sense", "You can’t depend on it, but sometimes you get this prickly feeling right at the back of your neck, and you know something’s wrong . . .The GM rolls once against your Perception, secretly, in any situation involving an ambush, impending disaster, or similar hazard. On a success, you get enough of a warning that you can take action. A roll of 3 or 4 means you get a little detail as to the nature of the danger.");
            AdvantageDescription.Add("Daredevil", "Fortune seems to smile on you when you take risks! Any time you take an unnecessary risk (in the GM’s opinion), you get a +1 to all skill rolls. Furthermore, you may reroll any critical failure that occurs during such high-risk behavior.");
            AdvantageDescription.Add("Empathy", "You have a “feeling” for people. When you first meet someone – or are reunited after an absence – you may ask the GM to roll against your IQ. He will tell you what you “feel” about that person. On a failed IQ roll, he will lie! This talent is excellent for spotting imposters, possession, etc., and for determining the true loyalties of NPCs.");
            AdvantageDescription.Add("Enhanced Defenses (Block)", "You have +1 to your Block score with Shield skill.");
            AdvantageDescription.Add("Ehhanced Defenses (Dodge)", "You have +1 to your Dodge score.");
            AdvantageDescription.Add("Enhanced Defenses (Parry) (All Weapons)", "You have +1 to your Parry score.");
            AdvantageDescription.Add("Enhanced Defenses (Parry) (Barehands)", "You have +1 to your Parry score.");
            AdvantageDescription.Add("Enhanced Defenses (Parry) (Single Weapon of Choice Only)", "You have +1 to your Parry score.");
            AdvantageDescription.Add("Fearlessness", "You are difficult to frighten or intimidate! Add your level of Fearlessness to your Will whenever you make a Fright Check or must resist the Intimidation skill (p. 15) or a supernatural power that induces fear. You also subtract your Fearlessness level from all Intimidation rolls made against you.");
            AdvantageDescription.Add("Flexibility (Basic)", "You get +3 on Climbing rolls; on Escape rolls to get free of ropes, handcuffs, and similar restraints. You may ignore up to -3 in penalties for working in close quarters (including many Explosives and Mechanic rolls).");
            AdvantageDescription.Add("Flexibility (Double-Jointed)", "(Including Basic) You cannot stretch or squeeze yourself abnormally, but any part of your body may bend any way. You get +5 on Climbing, Escape rolls, and on attempts to break free. You may ignore up to -5 in penalties for close quarters.");
            AdvantageDescription.Add("Hard to Kill", "You are incredibly difficult to kill. Each level of Hard to Kill gives +1 to HT rolls made for survival at -HP or below, and on any HT roll where failure means instant death (due to heart failure, poison, etc.). If this bonus makes the difference between success and failure, you collapse, apparently dead (or disabled), but come to in the usual amount of time – see Recovering from Unconsciousness (p. 30).");
            AdvantageDescription.Add("High Pain Threshold", "You are as susceptible to injury as anyone else, but you don’t feel it as much. You never suffer a shock penalty when you are injured. In addition, you get +3 on all HT rolls to avoid knockdown and stunning – and if you are tortured physically, you get +3 to resist. The GM may let you roll at Will+3 to ignore pain in other situations.");
            AdvantageDescription.Add("Jumper", "You can travel through time or to parallel worlds (sometimes known as “timelines”) merely by willing the “jump.” Decide whether you are a time-jumper or a worldjumper. To do both, you must buy Jumper (Time) and Jumper (World) separately, at full cost." + Environment.NewLine + Environment.NewLine + "To initiate a jump, you must visualize your destination, concentrate for 10 seconds, and make an IQ roll. You may hurry the jump, but your roll will be at -1 per second of concentration omitted. Regardless of IQ, a roll of 14 or more always fails. On a success, you appear at your target destination. On a failure, you go nowhere. On a critical failure, you arrive at the wrong destination, which can be any time or world the GM wishes!" + Environment.NewLine + Environment.NewLine + "You appear at your destination at exactly the same place you left your previous time or world – or as close as possible." + Environment.NewLine + Environment.NewLine + "If there is no corresponding “safe” location within 100 yards of your destination, the jump will fail and you will know why it failed." + Environment.NewLine + Environment.NewLine + "This ability always costs at least 1 Fatigue Point (see p. 31) to use, whether it succeeds or fails. Particularly “distant” times or worlds might cost more, perhaps up to 10 FP, at the GM’s discretion.");
            AdvantageDescription.Add("Language Talent", "You have a knack for languages. When you learn a language at a comprehension level above None, you automatically function at the next higher level.");
            AdvantageDescription.Add("Luck (Basic)", "Once per hour of play, you may reroll a single bad die roll twice and take the best of the three rolls! You must declare that you are using your Luck immediately after you roll the dice." + Environment.NewLine + Environment.NewLine + "Your Luck only applies to your own success, damage, or reaction rolls, or on outside events that affect you or your whole party, or when you are being attacked (in which case you may make the attacker roll three times and take the worst roll!).");
            AdvantageDescription.Add("Luck (Extraordinary)", "Once per 30 mins of play, you may reroll a single bad die roll twice and take the best of the three rolls! You must declare that you are using your Luck immediately after you roll the dice." + Environment.NewLine + Environment.NewLine + "Your Luck only applies to your own success, damage, or reaction rolls, or on outside events that affect you or your whole party, or when you are being attacked (in which case you may make the attacker roll three times and take the worst roll!).");
            AdvantageDescription.Add("Luck (Ridiculous)", "Once per mins of play, you may reroll a single bad die roll twice and take the best of the three rolls! You must declare that you are using your Luck immediately after you roll the dice." + Environment.NewLine + Environment.NewLine + "Your Luck only applies to your own success, damage, or reaction rolls, or on outside events that affect you or your whole party, or when you are being attacked (in which case you may make the attacker roll three times and take the worst roll!).");
            AdvantageDescription.Add("Night Vision", "Your eyes adapt rapidly to darkness. Each level of this ability (maximum nine levels) allows you to ignore -1 in combat or vision penalties due to darkness, provided there is at least some light.");
            AdvantageDescription.Add("Perfect Balance", "You can always keep your footing, no matter how narrow the walking surface (tightrope, ledge, tree limb, etc.), under normal conditions without having to make a die roll. If the surface is wet, slippery, or unstable, you get +6 on all rolls to keep your feet. In combat, you get +4 to DX and DXbased skill rolls to keep your feet or avoid being knocked down. Finally, you get +1 to Acrobatics and Climbing skill.");
            AdvantageDescription.Add("Resistant (Poison)", "You are naturally resistant (or even immune) to diseases or poisons. This gives you a bonus on all HT rolls to resist incapacitation or injury from such things." + Environment.NewLine + Environment.NewLine + "You take a +8 bonus to HT.");
            AdvantageDescription.Add("Resistant (Disease)", "You are naturally resistant (or even immune) to diseases or poisons. This gives you a bonus on all HT rolls to resist incapacitation or injury from such things." + Environment.NewLine + Environment.NewLine + "You have a +3 bonus to HT.");
            AdvantageDescription.Add("Talent (Artificer)", "You have a natural aptitude for a set of closely related skills. “Talents” come in levels, and give a bonus of +1 per level with all affected skills, even for default use. This effectively raises your attribute scores for the purpose of those skills only; thus, this is an inexpensive way to be adept at small class of skills." + Environment.NewLine + Environment.NewLine + "You may never have more than four levels of a particular Talent. However, overlapping Talents can give skill bonuses (only) in excess of +4." + Environment.NewLine + Environment.NewLine + "[Covers] Armoury, Electronics, Repair, Engineer, Mechanic, and Computers.");
            AdvantageDescription.Add("Talent (Outdoorsman)", "You have a natural aptitude for a set of closely related skills. “Talents” come in levels, and give a bonus of +1 per level with all affected skills, even for default use. This effectively raises your attribute scores for the purpose of those skills only; thus, this is an inexpensive way to be adept at small class of skills." + Environment.NewLine + Environment.NewLine + "You may never have more than four levels of a particular Talent. However, overlapping Talents can give skill bonuses (only) in excess of +4." + Environment.NewLine + Environment.NewLine + "[Covers] Camoflage, Naturalist, Navigation, Survival, and Tracking.");
            AdvantageDescription.Add("Talent (Smooth Operator)", "You have a natural aptitude for a set of closely related skills. “Talents” come in levels, and give a bonus of +1 per level with all affected skills, even for default use. This effectively raises your attribute scores for the purpose of those skills only; thus, this is an inexpensive way to be adept at small class of skills." + Environment.NewLine + Environment.NewLine + "You may never have more than four levels of a particular Talent. However, overlapping Talents can give skill bonuses (only) in excess of +4." + Environment.NewLine + Environment.NewLine + "[Covers] Influence skills, Acting, Carousing, Leadership, and Public Speaking.");
        }

        private void LoadDisadvantageDB()
        {
            DisadvantageDB.Add("Bad Sight (Correctable)", 
                new DisadvantageModel("Bad Sight (Correctable)", -10, DisadvantageDescription["Bad Sight (Correctable)"]));
            DisadvantageDB.Add("Bad Sight", 
                new DisadvantageModel("Bad Sight", -25, DisadvantageDescription["Bad Sight"]));
            DisadvantageDB.Add("Bad Temper", 
                new DisadvantageModel("Bad Temper", -10, DisadvantageDescription["Bad Temper"]));
            DisadvantageDB.Add("Bloodlust", 
                new DisadvantageModel("Bloodlust", -10, DisadvantageDescription["Bloodlust"]));
            DisadvantageDB.Add("Code of Honor (Common)", 
                new DisadvantageModel("Code of Honor (Common)", -5, DisadvantageDescription["Code of Honor (Common)"]));
            DisadvantageDB.Add("Code of Honor (Among Peers Only)", 
                new DisadvantageModel("Code of Honor (Among Peers Only)", -10, DisadvantageDescription["Code of Honor (Among Peers Only)"]));
            DisadvantageDB.Add("Code of Honor (Require Suicide if Broken)", 
                new DisadvantageModel("Code of Honor (Require Suicide If Broken)", -15, DisadvantageDescription["Code of Honor (Require Suicide if Broken)"]));
            DisadvantageDB.Add("Curious", 
                new DisadvantageModel("Curious", -5, DisadvantageDescription["Curious"]));
            DisadvantageDB.Add("Delusions (Minor)", 
                new DisadvantageModel("Delusions (Minor)", -5, DisadvantageDescription["Delusions (Minor)"]));
            DisadvantageDB.Add("Delusions (Major)", 
                new DisadvantageModel("Delusions (Major)", -10, DisadvantageDescription["Delusions (Major)"]));
            DisadvantageDB.Add("Delusions (Severe)", 
                new DisadvantageModel("Delusions (Severe)", -15, DisadvantageDescription["Delusions (Severe)"]));
            DisadvantageDB.Add("Gluttony", 
                new DisadvantageModel("Gluttony", -5, DisadvantageDescription["Gluttony"]));
            DisadvantageDB.Add("Greed", 
                new DisadvantageModel("Greed", -15, DisadvantageDescription["Greed"]));
            DisadvantageDB.Add("Hard of Hearing", 
                new DisadvantageModel("Hard of Hearing", -10, DisadvantageDescription["Hard of Hearing"]));
            DisadvantageDB.Add("Honesty", 
                new DisadvantageModel("Honesty", -10, DisadvantageDescription["Honesty"]));
            DisadvantageDB.Add("Impulsiveness", 
                new DisadvantageModel("Impulsiveness", -10, DisadvantageDescription["Impulsiveness"]));
            DisadvantageDB.Add("Intolerance (Large Groups)", 
                new DisadvantageModel("Intolerance", -10, DisadvantageDescription["Intolerance (Large Groups)"]));
            DisadvantageDB.Add("Intolerance (Individuals)", 
                new DisadvantageModel("Intolerance", -5, DisadvantageDescription["Intolerance (Individuals)"]));
            DisadvantageDB.Add("Jealousy", 
                new DisadvantageModel("Jealousy", -10, DisadvantageDescription["Jealousy"]));
            DisadvantageDB.Add("Lecherousness", 
                new DisadvantageModel("Lecherousness", -15, DisadvantageDescription["Lecherousness"]));
            DisadvantageDB.Add("Obsession", 
                new DisadvantageModel("Obsession", -5, DisadvantageDescription["Obsession"]));
            DisadvantageDB.Add("Overconfidence", 
                new DisadvantageModel("Overconfidence", -5, DisadvantageDescription["Overconfidence"]));
            DisadvantageDB.Add("Pacificism (Reluctant Killer)", 
                new DisadvantageModel("Pacificism (Reluctant Killer)", -5, DisadvantageDescription["Pacificism (Reluctant Killer)"]));
            DisadvantageDB.Add("Pacificism (Cannot Harm Innocent)", 
                new DisadvantageModel("Pacificism (Cannot Harm Innocent)", -10, DisadvantageDescription["Pacificism (Cannot Harm Innocent)"]));
            DisadvantageDB.Add("Phobia (Blood)", 
                new DisadvantageModel("Phobia (Blood)", -10, DisadvantageDescription["Phobia (Blood)"]));
            DisadvantageDB.Add("Phobia (Darkness)", 
                new DisadvantageModel("Phobia (Darkness)", -15, DisadvantageDescription["Phobia (Darkness)"]));
            DisadvantageDB.Add("Phobia (Heights)", 
                new DisadvantageModel("Phobia (Heights)", -10, DisadvantageDescription["Phobia (Heights)"]));
            DisadvantageDB.Add("Phobia (#13 or equivalent)", 
                new DisadvantageModel("Phobia (#13 or equivalent)", -5, DisadvantageDescription["Phobia (#13 or equivalent)"]));
            DisadvantageDB.Add("Phobia (Spiders)", 
                new DisadvantageModel("Phobia (Spiders)", -5, DisadvantageDescription["Phobia (Spiders)"]));
            DisadvantageDB.Add("Sense of Duty (Individual)", 
                new DisadvantageModel("Sense of Duty (Individual)", -2, DisadvantageDescription["Sense of Duty (Individual)"]));
            DisadvantageDB.Add("Sense of Duty (Small Group)", 
                new DisadvantageModel("Sense of Duty (Small Group)", -5, DisadvantageDescription["Sense of Duty (Small Group)"]));
            DisadvantageDB.Add("Sense of Duty (Large Group)", 
                new DisadvantageModel("Sense of Duty (Large Group)", -10, DisadvantageDescription["Sense of Duty (Large Group)"]));
            DisadvantageDB.Add("Sense of Duty (Entire Race)", 
                new DisadvantageModel("Sense of Duty (Entire Race)", -15, DisadvantageDescription["Sense of Duty (Entire Race)"]));
            DisadvantageDB.Add("Sense of Duty (Every Living Being)", 
                new DisadvantageModel("Sense of Duty (Every Living Being)", -20, DisadvantageDescription["Sense of Duty (Every Living Being)"]));
            DisadvantageDB.Add("Truthfulness", 
                new DisadvantageModel("Truthfulness", -5, DisadvantageDescription["Truthfulness"]));
            DisadvantageDB.Add("Unluckiness", 
                new DisadvantageModel("Unluckiness", -10, DisadvantageDescription["Unluckiness"]));
            DisadvantageDB.Add("Vow (Minor)", 
                new DisadvantageModel("Vow (Minor)", -5, DisadvantageDescription["Vow (Minor)"]));
            DisadvantageDB.Add("Vow (Major)", 
                new DisadvantageModel("Vow (Major)", -10, DisadvantageDescription["Vow (Major)"]));
            DisadvantageDB.Add("Vow (Great)", 
                new DisadvantageModel("Vow (Great)", -15, DisadvantageDescription["Vow (Great)"]));
        }
        private void LoadDisadvantageDescription()
        {
            DisadvantageDescription.Add("Bad Sight (Correctable)", "You have poor vision, giving -6 to Vision rolls and -2 to hit in combat. This disadvantage costs -10 points at TLs where it is correctable (with glasses or contact lenses), -25 points when it is not.");
            DisadvantageDescription.Add("Bad Sight", "You have poor vision, giving -6 to Vision rolls and -2 to hit in combat. This disadvantage costs -10 points at TLs where it is correctable (with glasses or contact lenses), -25 points when it is not.");
            DisadvantageDescription.Add("Bad Temper", "You are not in full control of your emotions. Make a self-control roll in any stressful situation. If you fail, you lose your temper and must insult, attack, or otherwise act against the cause of the stress.");
            DisadvantageDescription.Add("Bloodlust", "You want to see your foes dead.In battle, you must go for killing blows, and put in an extra shot to make sure of a downed foe. You must make a self-control roll whenever you need to accept a surrender, evade a sentry, take a prisoner, etc.If you fail, you attempt to kill your foe instead – even if that means breaking the law, compromising stealth, wasting ammo, or violating orders. Out of combat, you never forget that a foe is a foe.");
            DisadvantageDescription.Add("Code of Honor (Common)", "You take pride in a set of principles that you follow at all times. The specifics can vary, but they always involve “honorable” behavior. You will do nearly anything – perhaps even risk death – to avoid the label “dishonorable” (whatever that means to you). The point value of a particular Code of Honor depends on how much trouble it is liable to get you into and how arbitrary and irrational its requirements are.");
            DisadvantageDescription.Add("Code of Honor (Among Peers Only)", "You take pride in a set of principles that you follow at all times. The specifics can vary, but they always involve “honorable” behavior. You will do nearly anything – perhaps even risk death – to avoid the label “dishonorable” (whatever that means to you). The point value of a particular Code of Honor depends on how much trouble it is liable to get you into and how arbitrary and irrational its requirements are.");
            DisadvantageDescription.Add("Code of Honor (Require Suicide if Broken)", "You take pride in a set of principles that you follow at all times. The specifics can vary, but they always involve “honorable” behavior. You will do nearly anything – perhaps even risk death – to avoid the label “dishonorable” (whatever that means to you). The point value of a particular Code of Honor depends on how much trouble it is liable to get you into and how arbitrary and irrational its requirements are.");
            DisadvantageDescription.Add("Curious", "You are naturally very inquisitive. This is not the curiosity that affects all PCs (“What’s in that cave? Where did the flying saucer come from?”), but the real thing (“What happens if I push this button?”)." + Environment.NewLine + Environment.NewLine + "Make a self-control roll when presented with an interesting item or situation. If you fail, you examine it even if you know it could be dangerous. Good roleplayers won’t try to make this roll very often . . .");
            DisadvantageDescription.Add("Delusions (Minor)", "You believe something that simply is not true. This may cause others to consider you insane. And they may be right! If you suffer from a Delusion, you must roleplay your belief at all times. The point value of the Delusion depends on its nature." + Environment.NewLine + Environment.NewLine + "A Minor Delusion affects your behavior, and anyone around you will soon notice it (and react at -1), but it does not keep you from functioning more-or-less normally");
            DisadvantageDescription.Add("Delusions (Major)", "You believe something that simply is not true. This may cause others to consider you insane. And they may be right! If you suffer from a Delusion, you must roleplay your belief at all times. The point value of the Delusion depends on its nature." + Environment.NewLine + Environment.NewLine + "A Major Delusion strongly affects your behavior, but does not keep you from living a fairly normal life.Others will react to you at - 2.");
            DisadvantageDescription.Add("Delusions (Severe)", "You believe something that simply is not true. This may cause others to consider you insane. And they may be right! If you suffer from a Delusion, you must roleplay your belief at all times. The point value of the Delusion depends on its nature." + Environment.NewLine + Environment.NewLine + "A Severe Delusion affects your behavior so much that it may keep you from functioning in the everyday world. Others react to you at -3, but they are more likely to fear or pity you than to attack.");
            DisadvantageDescription.Add("Gluttony", "You are overly fond of good food and drink. Given the chance, you must always burden yourself with extra provisions. You should never willingly miss a meal. Make a self-control roll when presented with a tempting morsel or good wine that, for some reason, you should resist. If you fail, you partake – regardless of the consequences.");
            DisadvantageDescription.Add("Greed", "You lust for wealth. Make a self-control roll any time riches are offered – as payment for fair work, gains from adventure, spoils of crime, or just bait. If you fail, you do whatever it takes to get the payoff. Small sums do not tempt you much if you are rich, but if you are poor, you get -5 or more on your self-control roll if a rich prize is in the offing.");
            DisadvantageDescription.Add("Hard of Hearing", "You are not deaf, but you have some hearing loss. You are at -4 on any Hearing roll and on any skill roll where it is important that you understand someone (if you are the one talking, this disadvantage doesn’t affect you).");
            DisadvantageDescription.Add("Honesty", "You must obey the law, and do your best to get others to do so as well. In an area with little or no law, you do not “go wild” – you act as though the laws of your own home were in force. You also assume that others are honest unless you know otherwise." + Environment.NewLine + Environment.NewLine + "This is a disadvantage, because it often limits your options! Make a self-control roll when faced with the “need” to break unreasonable laws; if you fail, you must obey the law, whatever the consequences. If you manage to resist your urges and break the law, make a second self-control roll afterward. If you fail, you must turn yourself in to the authorities!");
            DisadvantageDescription.Add("Impulsiveness", "You hate talk and debate. You prefer action! When you are alone, you act first and think later. In a group, when your friends want to stop and discuss something, you should put in your two cents’ worth quickly – if at all – and then do something. Roleplay it! Make a self-control roll whenever it would be wise to wait and ponder. If you fail, you must act.");
            DisadvantageDescription.Add("Intolerance (Large Groups)", "You dislike and distrust some (or all) people who are different from you. You may be prejudiced on the basis of class, ethnicity, nationality, religion, sex, or species. Victims of your Intolerance will react to you at -1 to -5 (GM’s decision).");
            DisadvantageDescription.Add("Intolerance (Individuals)", "You dislike and distrust some (or all) people who are different from you. You may be prejudiced on the basis of class, ethnicity, nationality, religion, sex, or species. Victims of your Intolerance will react to you at -1 to -5 (GM’s decision).");
            DisadvantageDescription.Add("Jealousy", "You react poorly toward those who seem smarter, more attractive, or better off than you!You resist any plan proposed by a “rival,” and hate it if someone else is in the limelight. If an NPC is jealous, the GM will apply a - 2 to - 4 reaction penalty toward the victim(s) of his jealousy.");
            DisadvantageDescription.Add("Lecherousness", "You have an unusually strong desire for romance. Make a self-control roll whenever in more than the briefest contact with an appealing member of the sex you find attractive – at -5 if this person is Handsome/Beautiful, or at -10 if Very Handsome/Very Beautiful. If you fail, you must make a “pass,” using whatever wiles and skills you can bring to bear.");
            DisadvantageDescription.Add("Obsession", "Your entire life revolves around a single goal, an overpowering fixation that motivates all of your actions." + Environment.NewLine + Environment.NewLine + "Make a self-control roll whenever it would be wise to deviate from your goal. If you fail, you continue to pursue your Obsession, regardless of the consequences.");
            DisadvantageDescription.Add("Overconfidence", "You believe that you are far more powerful, intelligent, or competent than you really are. You may be proud and boastful or just quietly determined, but you must roleplay this trait." + Environment.NewLine + Environment.NewLine + "You must make a self-control roll any time the GM feels you show an unreasonable degree of caution. If you fail, you must go ahead as though you were able to handle the situation! Caution is not an option.");
            DisadvantageDescription.Add("Pacificism (Reluctant Killer)", "You get -4 to hit a person (not a monster, machine, etc.) with a deadly attack, or -2 if you can’t see his face. If you kill someone, roll 3d – you’re morose and useless for that many days.");
            DisadvantageDescription.Add("Pacificism (Cannot Harm Innocent)", "You may fight – you may even start fights – but you may only use deadly force on a foe that is attempting to do you serious harm.");
            DisadvantageDescription.Add("Phobia (Blood)", "A “phobia” is a fear of a specific item, creature, or circumstance. The more common an object or situation, the greater the point value of a fear of it. If you have a phobia, you may temporarily master it by making a successful self-control roll . . . but the fear persists. Even if you master a phobia, you will be at -2 to all IQ, DX, and skill rolls while the cause of your fear is present, and you must roll again every 10 minutes to see if the fear overcomes you. If you fail the self-control roll, you will cringe, flee, panic, or otherwise react in a manner that precludes sensible action.");
            DisadvantageDescription.Add("Phobia (Darkness)", "A “phobia” is a fear of a specific item, creature, or circumstance. The more common an object or situation, the greater the point value of a fear of it. If you have a phobia, you may temporarily master it by making a successful self-control roll . . . but the fear persists. Even if you master a phobia, you will be at -2 to all IQ, DX, and skill rolls while the cause of your fear is present, and you must roll again every 10 minutes to see if the fear overcomes you. If you fail the self-control roll, you will cringe, flee, panic, or otherwise react in a manner that precludes sensible action.");
            DisadvantageDescription.Add("Phobia (Heights)", "A “phobia” is a fear of a specific item, creature, or circumstance. The more common an object or situation, the greater the point value of a fear of it. If you have a phobia, you may temporarily master it by making a successful self-control roll . . . but the fear persists. Even if you master a phobia, you will be at -2 to all IQ, DX, and skill rolls while the cause of your fear is present, and you must roll again every 10 minutes to see if the fear overcomes you. If you fail the self-control roll, you will cringe, flee, panic, or otherwise react in a manner that precludes sensible action.");
            DisadvantageDescription.Add("Phobia (#13 or equivalent)", "A “phobia” is a fear of a specific item, creature, or circumstance. The more common an object or situation, the greater the point value of a fear of it. If you have a phobia, you may temporarily master it by making a successful self-control roll . . . but the fear persists. Even if you master a phobia, you will be at -2 to all IQ, DX, and skill rolls while the cause of your fear is present, and you must roll again every 10 minutes to see if the fear overcomes you. If you fail the self-control roll, you will cringe, flee, panic, or otherwise react in a manner that precludes sensible action.");
            DisadvantageDescription.Add("Phobia (Spiders)", "A “phobia” is a fear of a specific item, creature, or circumstance. The more common an object or situation, the greater the point value of a fear of it. If you have a phobia, you may temporarily master it by making a successful self-control roll . . . but the fear persists. Even if you master a phobia, you will be at -2 to all IQ, DX, and skill rolls while the cause of your fear is present, and you must roll again every 10 minutes to see if the fear overcomes you. If you fail the self-control roll, you will cringe, flee, panic, or otherwise react in a manner that precludes sensible action.");
            DisadvantageDescription.Add("Sense of Duty (Individual)", "You feel a strong sense of commitment toward a particular class of people. You will never betray them, abandon them when they’re in trouble, or let them suffer or go hungry if you can help.");
            DisadvantageDescription.Add("Sense of Duty (Small Group)", "(e.g., Close Friends, companions, or squad) You feel a strong sense of commitment toward a particular class of people. You will never betray them, abandon them when they’re in trouble, or let them suffer or go hungry if you can help.");
            DisadvantageDescription.Add("Sense of Duty (Large Group)", "(e.g., Nation, religious group, etc) You feel a strong sense of commitment toward a particular class of people. You will never betray them, abandon them when they’re in trouble, or let them suffer or go hungry if you can help.");
            DisadvantageDescription.Add("Sense of Duty (Entire Race)", "You feel a strong sense of commitment toward a particular class of people. You will never betray them, abandon them when they’re in trouble, or let them suffer or go hungry if you can help.");
            DisadvantageDescription.Add("Sense of Duty (Every Living Being)", "You feel a strong sense of commitment toward a particular class of people. You will never betray them, abandon them when they’re in trouble, or let them suffer or go hungry if you can help.");
            DisadvantageDescription.Add("Truthfulness", "You hate to tell a lie – or you are just very bad at it. Make a self-control roll whenever you must keep silent about an uncomfortable truth (lying by omission). Roll at -5 if you actually have to tell a falsehood! If you fail, you blurt out the truth, or stumble so much that your lie is obvious. You have a permanent -5 to Fast-Talk skill, and your Acting skill is at -5 when your purpose is to deceive.");
            DisadvantageDescription.Add("Unluckiness", "You have rotten luck. Things go wrong for you – and usually at the worst possible time. Once per play session, the GM will arbitrarily and maliciously make something go wrong for you. You miss a vital die roll, or the enemy (against all odds) shows up at the worst possible time. If the plot of the adventure calls for something bad to happen to someone, it’s you. The GM may not kill you outright with “bad luck,” but anything less than that is fine.");
            DisadvantageDescription.Add("Vow (Minor)", "(e.g., Silence during daylight hours; vegetarianism; chastity) You have sworn an oath to do (or not to do) something. Whatever the oath, you take it seriously; if you didn’t, it would not be a disadvantage. This trait is especially appropriate for knights, holy men, and fanatics.");
            DisadvantageDescription.Add("Vow (Major)", "(e.g., Use no edged weapons; keep silence at all times; never sleep indoors; own no more than your horse can carry) You have sworn an oath to do (or not to do) something. Whatever the oath, you take it seriously; if you didn’t, it would not be a disadvantage. This trait is especially appropriate for knights, holy men, and fanatics.");
            DisadvantageDescription.Add("Vow (Great)", "(e.g., Never refuse any request for aid; always fight with the wrong hand; hunt a given foe until you destroy him; challenge every knight you meet to combat.) You have sworn an oath to do (or not to do) something. Whatever the oath, you take it seriously; if you didn’t, it would not be a disadvantage. This trait is especially appropriate for knights, holy men, and fanatics.");
        }
    }
}
