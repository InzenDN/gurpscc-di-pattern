using System.Windows.Controls;
using Autofac;
using GurpsCC.Model;
using GurpsCC.ViewModel;
using GurpsCC.ViewModel.Container;

namespace GurpsCharacterCreator.View.UserControls
{
    /// <summary>
    /// Interaction logic for PlayerActiveAdvantageListUserControl.xaml
    /// </summary>
    public partial class PlayerActiveAdvantageListUserControl : UserControl
    {
        private ILifetimeScope Scope { get; set; }
        private IPlayerViewModel PlayerVM { get; set; }
        private ISelectedItem SelectedItem { get; set; }

        public PlayerActiveAdvantageListUserControl()
        {
            Scope = IoCContainer.Container.BeginLifetimeScope();
            PlayerVM = Scope.Resolve<IPlayerViewModel>();
            SelectedItem = Scope.Resolve<ISelectedItem>();

            InitializeComponent();

            AdvantageListBox.ItemsSource = PlayerVM.Advantages;
            AdvantageListBox.SelectionChanged += (x, y) =>
            {
                SelectedItem.SelectedAdvantageRemove = (ActiveAdvantage)AdvantageListBox.SelectedItem;
                SelectedItem.SelectedDescription.Name = ((ActiveAdvantage)AdvantageListBox.SelectedItem)?.Advantage.Name;
                SelectedItem.SelectedDescription.Description = ((ActiveAdvantage)AdvantageListBox.SelectedItem)?.Advantage.Description;
                PlayerVM.RemoveAdvantageCommand.OnCanExecuteChanged();
            };

            AdvantageListBox.PreviewMouseLeftButtonDown += (x, y) => AdvantageListBox.SelectedIndex = -1;
        }
        ~PlayerActiveAdvantageListUserControl()
        {
            Scope.Dispose();
        }
    }
}
