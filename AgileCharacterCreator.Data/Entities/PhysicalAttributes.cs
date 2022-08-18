using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileCharacterCreator.Data.Entities
{
    public class PhysicalAttributes
    {
        public int PlayerId { get; set; }
        public int QuidditchTeamId { get; set; }
        public Enum? Hair { get; set; }
        public decimal HeightCm { get; set; }
        public decimal WeightKg { get; set; }
        public Enum? Ethinicity { get; set; }
        public Enum? EyeColor { get; set; }

    }
}
