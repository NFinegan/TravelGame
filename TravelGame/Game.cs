using System;
using System.Collections.Generic;
using System.Text;

namespace TravelGame
{
   public class Game
    {
        //Get Title
        public string Title { get; set; }

        //List of places player can visit
        public List<Places> Places = new List<Places>();

        //Player property
        public Player CurrentPlayer = new Player();

        //property helps store information on certain pages
        public Places CurrentPlaces { get; set; }

        public List<NPC> NPCs = new List<NPC>();

        //default constructer
        //assign values to title, places, player
        public Game()
        {
            //Add Items for inventory
            Item GajaLeather = new Item()
            {
                ItemName = "Gaja Leather",
            };

            Item ElpisFlower = new Item()
            {
                ItemName = "Elpis Flower",
            };

            Item Moonrock = new Item()
            {
                ItemName = "Moon Rock",
            };

            Item MagitekArmor = new Item()
            {
                ItemName = "Magitek Armor",
            };

            Item Rarebook = new Item()
            {
                ItemName = "Rare Book",
            };

            Item SamuraiSword = new Item()
            {
                ItemName = "Samurai Sword",
            };

            Item Rustedkey = new Item()
            {
                ItemName = "Rusted Key",
            };

            Item StrangeCrystal = new Item()
            {
                ItemName = "Strange Crystal"
            };

            Item AntiqueSword = new Item()
            {
                ItemName = "Antique Sword"
            };

            Item Gil = new Item()
            {
                ItemName = "Gil"
            };

            //NPC's
            //NPC trades Elpis Flower for a strange crystal
            NPC Florist = new NPC()
            {
                NPCName = "Florist",
                NPCDescription = "A Florist at first glance, but you feel there is something more to them",
                ImagePath = "Media/",
                Item = StrangeCrystal,
                RequiredItem = ElpisFlower

            };
            NPCs.Add(Florist);

            //NPC trades Magitek Armor for an antique sword
            NPC Adventurer = new NPC()
            {
                NPCName = "Adventurer",
                NPCDescription = "A long time adventurer. They've been staring at an overpriced armor set for a while now.",
                ImagePath = "Media/",
                Item = AntiqueSword,
                RequiredItem = MagitekArmor
            };
            NPCs.Add(Adventurer);


            //NPC trades Moonrock for some gil
            NPC Citizen = new NPC()
            {
                NPCName = "Thavnair Local",
                NPCDescription = "A Thavnair local. They've been browsing the marketboard. Looking for something new.",
                ImagePath = "Media/",
                Item = Gil,
                RequiredItem = Moonrock
            };
            NPCs.Add(Citizen);



            //Add Thavnair Place
            Places Thavnair = new Places()
            {
                Placename = "Thavnair",
                Description = "Across the Sea of Jade lies the island of Thavnair. It is the largest landmass on the Bounty and city-state of Radz-at-Han governs the island.",
                ImagePath = "Media/Thavnair.png",
                Item = GajaLeather
            };
            Places.Add(Thavnair);

            //Add Elpis Place
            Places Elpis = new Places()
            {
                Placename = "Elpis",
                Description = "Across the globe sits a series of floating islands. Only a rare few are allowed on it's surface. It is said creation of new living things thrive here.",
                ImagePath = "Media/Elpis.png",
                Item = ElpisFlower
            };
            Places.Add(Elpis);

            //Add Garlemald Place
            Places Garlemald = new Places()
            {
                Placename = "Garlemald",
                Description = "On the far north continent of Lisabard sits the empire of Garlemald. A city bent on war that specialzes on machinery and airships.",
                ImagePath = "Media/Garlemald.png",
                Item = MagitekArmor
            };
            Places.Add(Garlemald);

            //Add Kugane Place
            Places Kugane = new Places()
            {
                Placename = "Kugane",
                Description = "A port town of Hingashi. It is the only open port for foreign trade vessels. All violence is strictly prohibited within the city walls.",
                ImagePath = "Media/Kugane.png",
                Item = SamuraiSword
            };
            Places.Add(Kugane);

            //Add Labyrinthos Place
            Places Labyrinthos = new Places()
            {
                Placename = "Labyrinthos",
                Description = "Below the streets of Sharlayan lies a vast subterranean evironment created to protect the priceless and irreplaceable.",
                ImagePath = "Media/Labyrinthos.png",
                Item = Rarebook
            };
            Places.Add(Labyrinthos);

            //Add Sharlayan
            Places Sharlayan = new Places()
            {
                Placename = "Sharlayan",
                Description = "A nation of scholars located on the island to the north of Eorzea",
                ImagePath = "Media/Sharlayan.png",
                Item = Rustedkey
            };
            Places.Add(Sharlayan);

            //Add Mare Lamentorum Place
            Places MareLamentorum = new Places()
            {
                Placename = "MareLamentorum",
                Description = "Located on the moon. An unknown civilization once made it's home here. Shades of its former occupants wander aimlessly.",
                ImagePath = "Media/Mare Lamentorum.png",
                Item = Moonrock
            };
            Places.Add(MareLamentorum);

          
        }

    }
}
