using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace GurpsCC.Model.Player
{
    public class PlayerStat : INotifyPropertyChanged, IPlayerStat
    {
        // Members
        private int _ST = 10;
        private int _DX = 10;
        private int _IQ = 10;
        private int _HT = 10;

        // Properties
        public int ST
        {
            get => _ST;
            set
            {
                _ST = AdjustStat(value, _ST, 10);
                OnPropertyChanged();
            }
        }
        public int DX
        {
            get => _DX;
            set
            {
                _DX = AdjustStat(value, _DX, 20);
                OnPropertyChanged();
            }
        }
        public int IQ
        {
            get => _IQ;
            set
            {
                _IQ = AdjustStat(value, _IQ, 20);
                OnPropertyChanged();
            }
        }
        public int HT
        {
            get => _HT;
            set
            {
                _HT = AdjustStat(value, _HT, 10);
                OnPropertyChanged();
            }
        }

        IBasePoints BasePoints { get; }

        // Constructor
        public PlayerStat(IBasePoints basePoints)
        {
            BasePoints = basePoints;
        }

        // Methods
        public void AddAttribute(object sender)
        {
            switch (((Button)sender).Name)
            {
                case "AddST":
                    IncST();
                    break;
                case "AddDX":
                    IncDX();
                    break;
                case "AddIQ":
                    IncIQ();
                    break;
                case "AddHT":
                    IncHT();
                    break;
            }
        }

        public void SubAttribute(object sender)
        {
            switch (((Button)sender).Name)
            {
                case "SubST":
                    DecST();
                    break;
                case "SubDX":
                    DecDX();
                    break;
                case "SubIQ":
                    DecIQ();
                    break;
                case "SubHT":
                    DecHT();
                    break;
            }
        }

        private void IncST() => ST += 1;
        private void IncDX() => DX += 1;
        private void IncIQ() => IQ += 1;
        private void IncHT() => HT += 1;

        private void DecST() => ST -= 1;
        private void DecDX() => DX -= 1;
        private void DecIQ() => IQ -= 1;
        private void DecHT() => HT -= 1;

        /// <summary>
        /// Validates the Property setter values
        /// </summary>
        /// <param name="value">Receiving value from input</param>
        /// <param name="attribute">Current attribute value</param>
        /// <param name="pointcost">Point cost of the attribute</param>
        /// <returns></returns>
        private int AdjustStat(int value, int attribute, int pointcost)
        {
            if (value > 0)
            {
                if (value > attribute && BasePoints.UnspentPoints >= pointcost)
                {
                    BasePoints.UnspentPoints -= pointcost;
                    BasePoints.UsedPoints += pointcost;
                    return value;
                }
                else if (value < attribute)
                {
                    BasePoints.UnspentPoints += pointcost;
                    BasePoints.UsedPoints -= pointcost;
                    return value;
                }
            }

            // If nothing works, just return the original attribute value
            return attribute;
        }

        // Events
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
