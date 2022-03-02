using System;
using System.Collections.Generic;
using System.Text;

namespace TravelGame
{
    public class Places
    {
        public string Placename { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public Item Item { get; set; }
        public NPC Npc { get; set; }
    }
}
