using System;
using System.Collections.Generic;
using System.Text;

namespace GurpsCC.Model.Advantages
{
    public class AdvantageModel : IModel
    {
        public string Name { get; }
        public int PtPerLvl { get; }
        public bool CanLevel { get; }
        public string Description { get; }

        public AdvantageModel(string name, int ptCostPerLvl, bool canLevel, string description)
        {
            this.Name = name;
            this.PtPerLvl = ptCostPerLvl;
            this.CanLevel = canLevel;
            this.Description = description;
        }        
    }
}
