using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileCharacterCreator.Data.Entities
{
    public class PlayerAttributesEntity
    {
        public int Id { get; set; }   
        public int PhysicalAttributesId { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Agility { get; set; }
        public int BroomHandling { get; set; }
        public int FieldVision { get; set; }
        public string BroomType { get; set; }
    }
}