﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    //When Written: when requesting a ship at another station be transported to this station
    //Parameters:
    //•	ShipType: type of ship
    //•	ShipID
    //•	System: where it is
    //•	Distance: how far away
    //•	TransferPrice: cost of transfer   
    public class JournalShipyardTransfer : JournalEntry
    {
        public JournalShipyardTransfer(JObject evt, EDJournalReader reader) : base(evt, JournalTypeEnum.ShipyardTransfer, reader)
        {
            ShipType = Tools.GetStringDef("ShipType");
            ShipId = Tools.GetInt("ShipID");
            System = Tools.GetStringDef("System");
            Distance = Tools.GetDouble("Distance");
            TransferPrice = Tools.GetInt("TransferPrice");


        }
        public string ShipType { get; set; }
        public int ShipId { get; set; }
        public string System { get; set; }
        public double Distance { get; set; }
        public int TransferPrice { get; set; }

    }
}