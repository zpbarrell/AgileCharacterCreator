using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileCharacterCreator.Data.Entities
{
    public class PlayerInfoEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuidditchId { get; set; }
        public string ProminentCharacteristics { get; set; }
    }
}
