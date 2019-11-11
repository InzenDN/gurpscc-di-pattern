using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GurpsCC.Model
{
    public class BasePoints : IBasePoints, INotifyPropertyChanged
    {
        private int _MaxPoints;
        private int _MaxDisadvantagePoints;
        private int _UsedPoints;
        private int _UsedDisadvantagePoints;
        private int _UnspentPoints;

        public int MaxPoints
        {
            get => _MaxPoints;
            set
            {
                _MaxPoints = value;
                UnspentPoints = (value + (-1 * UsedDisadvantagePoints)) - UsedPoints;
                OnPropertyChanged();
            }
        }
        public int MaxDisadvantagePoints
        {
            get => _MaxDisadvantagePoints;
            set
            {
                if (value > 0)
                    value *= -1;
                _MaxDisadvantagePoints = value;
                OnPropertyChanged();
            }
        }
        public int UsedPoints
        {
            get => _UsedPoints;
            set
            {
                _UsedPoints = value;
                UnspentPoints = (MaxPoints + (-1 * UsedDisadvantagePoints)) - value;
                OnPropertyChanged();
            }
        }
        public int UsedDisadvantagePoints
        {
            get => _UsedDisadvantagePoints;
            set
            {
                _UsedDisadvantagePoints = value;
                UnspentPoints = (MaxPoints + (-1 * value)) - UsedPoints; 
                OnPropertyChanged();
            }
        }
        public int UnspentPoints
        {
            get => _UnspentPoints;
            set
            {
                _UnspentPoints = value;
                OnPropertyChanged();
            }
        }

        public BasePoints()
        {
            MaxPoints = 75;
            MaxDisadvantagePoints = 40;
            UsedPoints = 0;
            UsedDisadvantagePoints = 0;
            UnspentPoints = MaxPoints;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
