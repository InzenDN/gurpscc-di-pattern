using GurpsCC.Model;
using GurpsCC.Model.Advantages;
using GurpsCC.Model.Disadvantages;
using GurpsCC.Model.Skills;

namespace GurpsCC.ViewModel
{
    public interface IGurpsMainDatabase
    {
        GurpsDatabase<AdvantageModel> AdvantageDB { get; set; }
        GurpsDatabase<DisadvantageModel> DisadvantageDB { get; set; }
        GurpsDatabase<SkillModel> SkillDB { get; set; }
    }
}