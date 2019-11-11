using System.Windows.Input;
using GurpsCC.Model.Advantages;

namespace GurpsCC.ViewModel
{
    public interface IActiveAdvantage
    {
        AdvantageModel Advantage { get; set; }
        int Cost { get; set; }
        ICommand DecRankCommand { get; set; }
        ICommand IncRankCommand { get; set; }
        int Rank { get; set; }

        void DecrementRank();
        void IncrementRank();
    }
}