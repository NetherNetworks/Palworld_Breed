using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palworld_Breed.classes
{
    public class Pal
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public int TB_Nr { get; set; }
        public int Combi_Rank { get; set; }
        public int Price { get; set; }
        public int Flame { get; set; }
        public int Watering { get; set; }
        public int Seeding { get; set; }
        public int Electricity { get; set; }
        public int Handcraft { get; set; }
        public int Collection { get; set; }
        public int Deforest { get; set; }
        public int Mining { get; set; }
        public int Oil_Extraction { get; set; }
        public int Medicine { get; set; }
        public int Cool { get; set; }
        public int Transport { get; set; }
        public int Farm { get; set; }
        public byte[] Picture { get; set; }

    }
}
