using System.Windows.Controls;
using Autofac;
using GurpsCC.Model;
using GurpsCC.ViewModel;
using GurpsCC.ViewModel.Container;

namespace GurpsCharacterCreator.View.UserControls
{
    /// <summary>
    /// Interaction logic for PlayerActiveSkillListUserControl.xaml
    /// </summary>
    public partial class PlayerActiveSkillListUserControl : UserControl
    {
        private ILifetimeScope Scope { get; set; }
        private IPlayerViewModel PlayerVM { get; set; }
        private ISelectedItem SelectedItem { get; set; }

        public PlayerActiveSkillListUserControl()
        {
            Scope = IoCContainer.Container.BeginLifetimeScope();
            PlayerVM = Scope.Resolve<IPlayerViewModel>();
            SelectedItem = Scope.Resolve<ISelectedItem>();

            InitializeComponent();

            SkillListBox.ItemsSource = PlayerVM.Skills;
            SkillListBox.SelectionChanged += (x, y) =>
            {
                SelectedItem.SelectedSkillRemove = (ActiveSkill)SkillListBox.SelectedItem;
                SelectedItem.SelectedDescription.Name = ((ActiveSkill)SkillListBox.SelectedItem)?.Skill.Name;
                SelectedItem.SelectedDescription.Description = ((ActiveSkill)SkillListBox.SelectedItem)?.Skill.Description;
                PlayerVM.RemoveSkillCommand.OnCanExecuteChanged();
            };

            SkillListBox.PreviewMouseLeftButtonDown += (x, y) => SkillListBox.SelectedIndex = -1;
        }
        ~PlayerActiveSkillListUserControl()
        {
            Scope.Dispose();
        }
    }
}
