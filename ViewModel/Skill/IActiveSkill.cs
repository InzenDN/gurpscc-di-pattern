using System.Windows.Input;
using GurpsCC.Model.Skills;

namespace GurpsCC.ViewModel
{
    public interface IActiveSkill
    {
        int Cost { get; }
        ICommand DecRankCommand { get; set; }
        ICommand IncRankCommand { get; set; }
        int Modifier { get; }
        int Rank { get; }
        SkillModel Skill { get; }
    }
}