using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace _06___Pokemon_Midterm
{
    internal class Item
    {
        public int id;
        public string name;
        //Lists
        public Category category;
        public Effects[] effect_entries;

        public override string ToString()
        {
            //string effectString = effect_entries != null ? effect_entries.FirstOrDefault(e => e.language?.name == "en");
            //Find first instance of english
            if (name != null) {
                var effectString = effect_entries?.FirstOrDefault(e => e.language?.name == "en")?.effect ?? "No English effect found.";

                return $"--{name}--\n Category: {category.name}\n {effectString}";
            } else {
                return "Item does not exist.";
            }
        }
    }

    internal class Category
    {
        public string name;
        public string url;

    }

    internal class Effects
    {
        public string effect {  get; set; }
        public string short_effect { get; set; }
        
        public Language language { get; set; }
    }

    internal class Language 
    {
        public string name { get; set; }
        public string url {  get; set; }
    }
}
