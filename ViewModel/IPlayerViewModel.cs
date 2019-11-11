using System.Collections.ObjectModel;
using GurpsCC.Model;
using GurpsCC.Model.Player;

namespace GurpsCC.ViewModel
{
    public interface IPlayerViewModel
    {
        DelegateCommand AddAdvantageCommand { get; set; }
        DelegateCommand AddAttributeCommand { get; set; }
        DelegateCommand AddDisadvantageCommand { get; set; }
        DelegateCommand AddSkillCommand { get; set; }
        ObservableCollection<IActiveAdvantage> Advantages { get; set; }
        IBasePoints BasePoints { get; }
        ObservableCollection<IActiveDisadvantage> Disadvantages { get; set; }
        IPlayerStat PlayerStat { get; set; }
        DelegateCommand RemoveAdvantageCommand { get; set; }
        DelegateCommand RemoveDisadvantageCommand { get; set; }
        DelegateCommand RemoveSkillCommand { get; set; }
        ObservableCollection<IActiveSkill> Skills { get; set; }
        DelegateCommand SubAttributeCommand { get; set; }
    }
}