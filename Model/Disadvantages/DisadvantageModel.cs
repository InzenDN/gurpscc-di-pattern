using System;
using System.Collections.Generic;
using System.Text;

namespace GurpsCC.Model.Disadvantages
{
    public class DisadvantageModel : IModel
    {
        public string Name { get; }
        public int PtCost { get; }
        public string Description { get; }

        public DisadvantageModel(string name, int ptCost, string description)
        {
            this.Name = name;
            this.PtCost = ptCost;
            this.Description = description;
        }
    }
}
