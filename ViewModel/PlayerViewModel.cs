using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Autofac;
using GurpsCC.Model;
using GurpsCC.Model.Player;
using GurpsCC.ViewModel.Container;

namespace GurpsCC.ViewModel
{
    public class PlayerViewModel : IPlayerViewModel, INotifyPropertyChanged
    {
        // Properties
        public ObservableCollection<IActiveSkill> Skills { get; set; }
        public ObservableCollection<IActiveAdvantage> Advantages { get; set; }
        public ObservableCollection<IActiveDisadvantage> Disadvantages { get; set; }

        public IPlayerStat PlayerStat { get; set; }
        public IBasePoints BasePoints { get; }

        private ILifetimeScope Scope { get; set; }

        // Constructor
        public PlayerViewModel(IBasePoints basePoints, IPlayerStat playerStat)
        {
            this.BasePoints = basePoints;
            this.PlayerStat = playerStat;

            this.Skills = new ObservableCollection<IActiveSkill>();
            this.Advantages = new ObservableCollection<IActiveAdvantage>();
            this.Disadvantages = new ObservableCollection<IActiveDisadvantage>();

            AddAttributeCommand = new DelegateCommand(PlayerStat.AddAttribute, null);
            SubAttributeCommand = new DelegateCommand(PlayerStat.SubAttribute, null);

            Scope = IoCContainer.Container.BeginLifetimeScope();

            AddSkillCommand = new DelegateCommand(
                x => {
                    Skills.Add(Scope.Resolve<IActiveSkill>());
                    AddSkillCommand.OnCanExecuteChanged();
                }, 
                x => AddSkillCanExecute()
            );
            RemoveSkillCommand = new DelegateCommand(
                x => {
                    var SelectedItem = Scope.Resolve<ISelectedItem>();
                    IActiveSkill z = Skills.First(p => p.Skill.Name == SelectedItem.SelectedSkillRemove.Skill.Name);
                    BasePoints.UsedPoints -= z.Cost;
                    RemoveSkillCommand.OnCanExecuteChanged();
                    Skills.Remove(SelectedItem.SelectedSkillRemove);
                }, 
                x => Scope.Resolve<ISelectedItem>().SelectedSkillRemove != null);

            AddAdvantageCommand = new DelegateCommand(
                x => {
                    IActiveAdvantage z = Scope.Resolve<IActiveAdvantage>();
                    if (z.Advantage.PtPerLvl > BasePoints.UnspentPoints)
                        return;
                    Advantages.Add(z);
                    BasePoints.UsedPoints += z.Advantage.PtPerLvl;
                    AddAdvantageCommand.OnCanExecuteChanged();
                }, 
                x => AddAdvantageCanExecute()
            );
            RemoveAdvantageCommand = new DelegateCommand(
                x => {
                    var SelectedItem = Scope.Resolve<ISelectedItem>();
                    IActiveAdvantage z = Advantages.First(p => p.Advantage.Name == SelectedItem.SelectedAdvantageRemove.Advantage.Name);
                    BasePoints.UsedPoints -= z.Cost;
                    RemoveAdvantageCommand.OnCanExecuteChanged();
                    Advantages.Remove(SelectedItem.SelectedAdvantageRemove);
                },
                x => Scope.Resolve<ISelectedItem>().SelectedAdvantageRemove != null
            );

            AddDisadvantageCommand = new DelegateCommand(
                x => {
                    IActiveDisadvantage z = Scope.Resolve<IActiveDisadvantage>();

                    if ((z.Disadvantage.PtCost + BasePoints.UsedDisadvantagePoints) < BasePoints.MaxDisadvantagePoints)
                        return;

                    Disadvantages.Add(z);
                    BasePoints.UsedDisadvantagePoints += z.Disadvantage.PtCost;
                    AddDisadvantageCommand.OnCanExecuteChanged();
                },
                x => AddDisadvantageCanExecute()
            );
            RemoveDisadvantageCommand = new DelegateCommand(
                x => {
                    var SelectedItem = Scope.Resolve<ISelectedItem>();
                    IActiveDisadvantage z = Disadvantages.First(p => p.Disadvantage.Name == SelectedItem.SelectedDisadvantageRemove.Disadvantage.Name);
                    BasePoints.UsedDisadvantagePoints -= z.Cost;
                    RemoveDisadvantageCommand.OnCanExecuteChanged();
                    Disadvantages.Remove(SelectedItem.SelectedDisadvantageRemove);
                }, 
                x => Scope.Resolve<ISelectedItem>().SelectedDisadvantageRemove != null
            ); 
        }
        ~PlayerViewModel()
        {
            Scope.Dispose();
        }

        // Methods
        public bool AddSkillCanExecute()
        {
            return !Skills.Any(p => p.Skill.Name == Scope.Resolve<ISelectedItem>().SelectedSkill?.Name);
        }
        public bool AddAdvantageCanExecute()
        {
            return !Advantages.Any(p => p.Advantage.Name == Scope.Resolve<ISelectedItem>().SelectedAdvantage?.Name);
        }
        public bool AddDisadvantageCanExecute()
        {
            return !Disadvantages.Any(p => p.Disadvantage.Name == Scope.Resolve<ISelectedItem>().SelectedDisadvantage?.Name);
        }

        // Commands
        public DelegateCommand AddAttributeCommand { get; set; }
        public DelegateCommand SubAttributeCommand { get; set; }

        public DelegateCommand AddSkillCommand { get; set; }
        public DelegateCommand RemoveSkillCommand { get; set; }

        public DelegateCommand AddAdvantageCommand { get; set; }
        public DelegateCommand RemoveAdvantageCommand { get; set; }

        public DelegateCommand AddDisadvantageCommand { get; set; }
        public DelegateCommand RemoveDisadvantageCommand { get; set; }

        // Events
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
