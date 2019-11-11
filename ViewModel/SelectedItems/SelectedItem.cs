using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using GurpsCC.Model.Advantages;
using GurpsCC.Model.Disadvantages;
using GurpsCC.Model.Skills;
using GurpsCC.ViewModel;

namespace GurpsCC.Model
{
    public class SelectedItem : ISelectedItem
    {
        public SkillModel SelectedSkill { get; set; }
        public ActiveSkill SelectedSkillRemove { get; set; }
        public AdvantageModel SelectedAdvantage { get; set; }
        public ActiveAdvantage SelectedAdvantageRemove { get; set; }
        public DisadvantageModel SelectedDisadvantage { get; set; }
        public ActiveDisadvantage SelectedDisadvantageRemove { get; set; }
        public SelectedDescription SelectedDescription { get; set; }

        public SelectedItem()
        {
            //SelectedSkill = new SkillModel("", EStatAttribute.ST, EDifficulty.Easy, "");
            SelectedDescription = new SelectedDescription();
        }        
    }

    public class SelectedDescription : INotifyPropertyChanged
    {
        private string _Name = string.Empty;
        private string _Description = string.Empty;

        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }
        public string Description
        {
            get => _Description;
            set
            {
                _Description = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
