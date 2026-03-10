using System;
using System.Collections.Generic;
using System.Text;

namespace _06___Pokemon_Midterm
{
    internal class Berry
    {
        public int id { get; set; }
        public string name { get; set; }
        public int growth_time { get; set; }
        public int max_harvest { get; set; }

        public BerryItem item { get; set; }

        //*note remember to set up Effect for this tonight


        public override string ToString()
        {
            if (item != null)
            {
                var berryEffectString = item?.effect_entries?.FirstOrDefault(e => e.language?.name == "en")?.short_effect ?? "No English effect found.";
                return $"--{name}--\n Growth Time: {growth_time}\n Max Harvest: {max_harvest}\nEffect(s): {berryEffectString}";
            } else { return "Berry does not exist"; }
        }

        //Stupid berry item requirement
        public class BerryItem
        {
            public string name { get; set; }
            public List<BerryEffectEntry> effect_entries { get; set; }
            public string url { get; set; }

        }

        public class BerryEffectEntry{
            public string short_effect{ get; set; } 
            public Language language { get; set; }
  
        }

        public class Language
        {
            public string name { get; set; }
        }

    }
}
