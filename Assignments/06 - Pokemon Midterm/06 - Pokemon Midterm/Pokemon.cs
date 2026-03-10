using System;
using System.Collections.Generic;
using System.Text;

namespace _06___Pokemon_Midterm
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

        //Types Array of types
        public Types[] types { get; set; }
        //Abilities is a array of abilities 
        public Abilities[] abilities { get; set; }

        public override string ToString()
        {
            string abilitiesString = "Abilities:\n";
            string typeString = "Types:\n";
            //Create type string
            if (types != null)
            {
                for (int i = 0; i < types.Length; i++)
                {
                    typeString += $"- {types[i].type.name}";
                }
            }
            //create variable
            if (types != null)
            {
                foreach (var ability in abilities)
                {
                    abilitiesString += $"- {ability.ability.name} (Hidden: {ability.is_hidden}, Slot: {ability.slot})\n";
                }
            }

            if (name == null || id == 0) {
                Console.WriteLine("Object couldn't be found!");
                return "Pokemon does not exist.";
            }
            
            return $"ID: {id}\nName: {name}\nBase Experience: {base_experience}\nHeight: {height} Weight: {weight}\n{typeString} \n{abilitiesString}";
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

    //types break down
    internal class Types 
    {
        public int slot { get; set; }
        //type object
        public Type type { get; set; }
    }
    
    internal class Type
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
