﻿/*
 * Copyright © 2016 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 *
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */
using Newtonsoft.Json.Linq;
using System.Linq;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    //When written: when delivering powerplay commodities
    //Parameters:
    //•	Power
    //•	Type
    //•	Count
    [JournalEntryType(JournalTypeEnum.PowerplayDeliver)]
    public class JournalPowerplayDeliver : JournalEntry
    {
        public JournalPowerplayDeliver(JObject evt) : base(evt, JournalTypeEnum.PowerplayDeliver)
        {
            Power = evt["Power"].Str();
            Type = evt["Type"].Str();
            Count = evt["Count"].Int();

        }
        public string Power { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }

        public override System.Drawing.Bitmap Icon { get { return EDDiscovery.Properties.Resources.powerplaydeliver; } }

        public override void FillInformation(out string summary, out string info, out string detailed) //V
        {
            summary = EventTypeStr.SplitCapsWord();
            info = Tools.FieldBuilder("", Power, "Type:", Type, "Count:", Count);
            detailed = "";
        }
    }
}
