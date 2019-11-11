using GurpsCC.Model;
using GurpsCC.Model.Disadvantages;

namespace GurpsCC.ViewModel
{
    public class ActiveDisadvantage : IActive, IActiveDisadvantage
    {
        public DisadvantageModel Disadvantage { get; }
        public int Cost { get; }

        private IBasePoints BasePoints { get; }

        // Constructor
        public ActiveDisadvantage(ISelectedItem selectedItem, IBasePoints basePoints)
        {
            BasePoints = basePoints;
            this.Disadvantage = selectedItem.SelectedDisadvantage;
            this.Cost = selectedItem.SelectedDisadvantage.PtCost;
        }

        // Commands

        // Methods

    }
}
