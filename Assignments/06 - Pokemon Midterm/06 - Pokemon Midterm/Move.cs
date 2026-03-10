using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _06___Pokemon_Midterm
{
    internal class Move
    {
        public int id { get; set; }
        public string name { get; set; }
        public string power { get; set; }
        public DamageClass damage_class { get; set; }

        public TypeClass type {  get; set; }
        public MoveEffects[] effect_entries { get; set; }

        public PokeList[] learned_by_pokemon { get; set; }

        public override string ToString()
        {
            if (name != null)
            {
                string learningPoke = "Pokemon: ";
                for (int i = 0; i < 3; i++)
                {
                    learningPoke += $"- {learned_by_pokemon[i].name}";
                }
                var moveEffectString = effect_entries?.FirstOrDefault(e => e.language?.name == "en")?.short_effect ?? "No English effect found.";
                return $"--{name}-- \n Power: {power}\n Damage Class: {damage_class.name}\n Effect: {moveEffectString}\n Type: {type.name} \n {learningPoke}";
            }
            else
            {
                return "Move does not exist";
            }
        }
    }

    //Damage class with name and Url
    internal class DamageClass
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    //effects for move
    internal class MoveEffects
    {
        public string effect { get; set; }
        public string short_effect { get; set; }

        public MoveLanguage language { get; set; }
    }

    //getting the language
    internal class MoveLanguage
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    //List of pokemon that can learn this move
    internal class PokeList 
    { 
        public string name { get; set; }
        public string url { get; set; }
    }

    //type class
    internal class TypeClass
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
