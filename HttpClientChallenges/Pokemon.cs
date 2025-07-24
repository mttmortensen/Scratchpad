using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientChallenges
{
    public class Pokemon
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Base_Experience { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public List<PokeAbilities> Abilities { get; set; } 
    }
}
