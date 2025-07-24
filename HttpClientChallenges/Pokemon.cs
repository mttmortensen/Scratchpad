using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientChallenges
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Base_Experience { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        // The prop name needs to match the JSON response object
        // The type name doesn't matter
        public List<PokeAbilitySlots> Abilities { get; set; } 
    }

    // PokeAbilitySlots is a custom type name and isn't related to the PokeAPI
    public class PokeAbilitySlots() 
    {
        public Ability Ability { get; set; }
    };

    // However Ability is in the PokeAPI and so are it's props. 
    public class Ability()
    {
        public string Name {get; set;} 
        public string URL { get; set; }
    }
}
