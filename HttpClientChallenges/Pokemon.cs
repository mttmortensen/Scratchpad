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
        public List<PokeMoveSlots> Moves { get; set; }
        public List<PokeStatSlots> Stats { get; set; }
    }

    // PokeXSlots is a custom type name and isn't related to the PokeAPI
    public class PokeAbilitySlots() 
    {
        public Ability Ability { get; set; }
    };

    public class PokeMoveSlots() 
    {
        public Move Move { get; set; }
    }

    public class PokeStatSlots() 
    {
        public int Base_Stat { get; set; }
        public int Effort { get; set; }
        public Stat Stat { get; set; }
    }

    // However Ability and Move are in the PokeAPI and so are it's props. 
    public class Ability()
    {
        public string Name {get; set;} 
        public string URL { get; set; }
    }

    // I wonder if there's a way I could DRY this single object 
    // for Ability and Move since they both have the same props.
    public class Move() 
    {
        public string Name { get; set; }
        public string  URL { get; set; }
    }

    public class Stat 
    {
        public string Name { get; set; }
        public string URL { get; set; }
    }
}
