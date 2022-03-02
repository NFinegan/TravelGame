using System;
using System.Collections.Generic;
using System.Text;

namespace TravelGame
{
    public class NPC
    {
        public string NPCName { get; set; }

        public string NPCDescription { get; set; }

        public string ImagePath { get; set; }

        public Item Item { get; set; }

        public Item RequiredItem { get; set; }

    }
}
