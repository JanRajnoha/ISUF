﻿using ISUF.Base.Template;
using ISUF.Storage.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ISUF.Storage.Templates
{
    public class HistoryItem : BaseItem
    {
        public int ItemID { get; set; }
        public DbTypeOfChange TypeOfChange { get; set; }
        public string ModuleType { get; set; }

        [XmlIgnore]
        public bool ChangeSaved { get; set; }

        [XmlIgnore]
        public bool InMemoryChange { get; set; }

        public HistoryItem(int itemID, DbTypeOfChange typeOfChange, string moduleType)
        {
            ItemID = itemID;
            TypeOfChange = typeOfChange;
            ModuleType = moduleType;
        }

        public HistoryItem(HistoryItem historyItem) : base(historyItem)
        {
            ItemID = historyItem.ItemID;
            TypeOfChange = historyItem.TypeOfChange;
            ModuleType = historyItem.ModuleType;
        }

        public override object Clone()
        {
            return new HistoryItem(this);
        }
    }
}