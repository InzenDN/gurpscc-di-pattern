using GurpsCC.Model.Advantages;
using GurpsCC.Model.Disadvantages;
using GurpsCC.Model.Skills;
using GurpsCC.ViewModel;

namespace GurpsCC.Model
{
    public interface ISelectedItem
    {
        AdvantageModel SelectedAdvantage { get; set; }
        ActiveAdvantage SelectedAdvantageRemove { get; set; }
        DisadvantageModel SelectedDisadvantage { get; set; }
        ActiveDisadvantage SelectedDisadvantageRemove { get; set; }
        SkillModel SelectedSkill { get; set; }
        ActiveSkill SelectedSkillRemove { get; set; }
        SelectedDescription SelectedDescription { get; set; }
    }
}