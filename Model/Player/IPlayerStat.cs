using System.ComponentModel;

namespace GurpsCC.Model.Player
{
    public interface IPlayerStat
    {
        int DX { get; set; }
        int HT { get; set; }
        int IQ { get; set; }
        int ST { get; set; }

        event PropertyChangedEventHandler PropertyChanged;

        void AddAttribute(object sender);
        void SubAttribute(object sender);
    }
}