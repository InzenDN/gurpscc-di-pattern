using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GurpsCC.Model;
using GurpsCC.Model.Skills;

namespace GurpsCC.ViewModel
{
    public class ActiveSkill : IActive, IActiveSkill, INotifyPropertyChanged
    {
        private int _Rank;
        private int _Modifier;
        private int _Cost;

        public SkillModel Skill { get; }
        public int Rank
        {
            get => _Rank;
            private set
            {
                _Rank = value;
                OnPropertyChanged();
            }
        }
        public int Modifier
        {
            get => _Modifier;
            private set
            {
                _Modifier = value;
                OnPropertyChanged();
            }
        }
        public int Cost
        {
            get => _Cost;
            private set
            {
                _Cost = value;
                OnPropertyChanged();
            }
        }

        private IBasePoints BasePoints { get; }

        // Constructor
        public ActiveSkill(ISelectedItem selectedItem, IBasePoints basePoints)
        {
            BasePoints = basePoints;

            this.Skill = selectedItem.SelectedSkill;
            this.Rank = 0;
            this.Modifier = selectedItem.SelectedSkill.BaseModifier;
            this.Cost = 0;

            IncRankCommand = new DelegateCommand(x => IncrementRank(), null);
            DecRankCommand = new DelegateCommand(x => DecrementRank(), null);
        }

        // Commands
        public ICommand IncRankCommand { get; set; }
        public ICommand DecRankCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        // Methods
        private void IncrementRank()
        {
            if (CalcIncCost() > BasePoints.UnspentPoints)
                return;

            Rank += 1;
            IncrementModifier();
            Cost = Cost + CalcIncCost();
            BasePoints.UsedPoints += CalcIncCost();
        }

        private void DecrementRank()
        {
            if (Rank == 0)
                return;

            Rank -= 1;
            DecrementModifier();
            Cost = Cost - CalcDecCost();
            BasePoints.UsedPoints -= CalcDecCost();
        }

        private void IncrementModifier() => Modifier += 1;
        private void DecrementModifier() => Modifier -= 1;

        private int CalcIncCost()
        {
            if (Rank >= 4)
                return 4;
            else if (Rank == 3)
                return 2;
            else if (Rank == 2)
                return 1;
            else if (Rank <= 1)
                return 1;
            else
                return 0;
        }

        private int CalcDecCost()
        {
            if (Rank >= 4)
                return 4;
            else if (Rank == 3)
                return 4;
            else if (Rank == 2)
                return 2;
            else if (Rank <= 1)
                return 1;
            else
                return 0;
        }

        public override string ToString()
        {
            return Skill.Name.ToString();
        }
    }
}
