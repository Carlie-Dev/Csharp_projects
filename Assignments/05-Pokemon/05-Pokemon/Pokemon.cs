using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Pokemon
{
    internal class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public bool is_default { get; set; }
        public int order { get; set; }
        public int weight { get; set; }

        //Abilities is a array of abilities 
        public Abilities[] abilities { get; set; }

        public override string ToString()
        {
            string abilitiesString = "Abilities:\n";
            foreach(var ability in abilities)
            {
                abilitiesString += $"- {ability.ability.name} (Hidden: {ability.is_hidden}, Slot: {ability.slot})\n";
            }
            return $"ID: {id}\nName: {name}\nBase Experience: {base_experience}\nHeight: {height}\nIs Default: {is_default}\nOrder: {order}\nWeight: {weight}\n{abilitiesString}";
        }

    }

    //Abilites break down
    internal class Abilities
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public Ability ability { get; set; }

    }
    internal class Ability
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    //Form break down

    //internal class Form { 
    //    string name { get; set; }
    //    string url { get; set; }
    //}


}