using System;
using System.Collections.Generic;
using System.Text;

namespace TravelGame
{
    public class Player
    {
        public string Username { get; set; }

        //Create an inventory to hold items from each place
        public List<string> Inventory = new List<string>();

        public bool Trade(Item playerWantedItem, Item npcRequiredItem)
        {
            if (Inventory.Contains(npcRequiredItem.ItemName))
            {
                //Trade is allowed
                Inventory.Remove(npcRequiredItem.ItemName);
                Inventory.Add(playerWantedItem.ItemName);
                return true;
            }
            else
            {
                //Required Item is missing
                return false;

            }


        }


    }
}
