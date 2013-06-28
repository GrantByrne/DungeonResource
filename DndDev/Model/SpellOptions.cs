using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DndDev.Repository;

namespace DndDev.Model
{
    public class SpellOptions
    {
        public string[] SpellRange;

        public string[] SpellType;

        public string[] SpellComponent;

        public SpellOptions()
        {

            this.SpellRange = Enum.GetNames(typeof(SpellRange));
            this.SpellType = Enum.GetNames(typeof(SpellType));
            this.SpellComponent = Enum.GetNames(typeof(DndDev.Repository.SpellComponent));

        }

    }
}