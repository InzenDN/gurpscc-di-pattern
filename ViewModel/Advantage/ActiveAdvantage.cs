using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GurpsCC.Model;
using GurpsCC.Model.Advantages;

namespace GurpsCC.ViewModel
{
    public class ActiveAdvantage : IActive, IActiveAdvantage, INotifyPropertyChanged
    {
        // Members
        private int _Rank;
        private int _Cost;

        // Properties
        public AdvantageModel Advantage { get; set; }
        public int Rank
        {
            get => _Rank;
            set
            {
                _Rank = value;
                OnPropertyChanged();
            }
        }
        public int Cost
        {
            get => _Cost;
            set
            {
                _Cost = value;
                OnPropertyChanged();
            }
        }

        private IBasePoints BasePoints { get; }

        public ActiveAdvantage(ISelectedItem selectedItem, IBasePoints basePoints)
        {
            this.BasePoints = basePoints;
            this.Advantage = selectedItem.SelectedAdvantage;
            this.Rank = 1;
            this.Cost = selectedItem.SelectedAdvantage.PtPerLvl;

            IncRankCommand = new DelegateCommand(x => IncrementRank(), x => selectedItem.SelectedAdvantage.CanLevel);
            DecRankCommand = new DelegateCommand(x => DecrementRank(), x => selectedItem.SelectedAdvantage.CanLevel);
        }

        // Commands
        public ICommand IncRankCommand { get; set; }
        public ICommand DecRankCommand { get; set; }

        // Events
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        // Methods
        public void IncrementRank()
        {
            if (Advantage.PtPerLvl > BasePoints.UnspentPoints)
                return;

            Rank += 1;
            Cost = CalculateCost();
            BasePoints.UsedPoints += Advantage.PtPerLvl; 
        }
        public void DecrementRank()
        {
            if (Rank == 1)
                return;

            Rank -= 1;
            Cost = CalculateCost();
            BasePoints.UsedPoints -= Advantage.PtPerLvl;
        }

        private int CalculateCost() => Advantage.PtPerLvl * Rank;
    }
}
