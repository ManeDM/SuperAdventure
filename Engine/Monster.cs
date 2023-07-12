using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    internal class Monster
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int MaximunHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaximunDamage {get; set; }
        public int RewardEXperiencePoints { get; set; }
        public int RewardGold { get; set; }
    }
}
