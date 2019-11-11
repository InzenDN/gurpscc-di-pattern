using GurpsCC.Model.Disadvantages;

namespace GurpsCC.ViewModel
{
    public interface IActiveDisadvantage
    {
        int Cost { get; }
        DisadvantageModel Disadvantage { get; }
    }
}