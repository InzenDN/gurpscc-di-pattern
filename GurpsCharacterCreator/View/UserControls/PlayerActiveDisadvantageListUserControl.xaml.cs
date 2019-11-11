using System.Windows.Controls;
using Autofac;
using GurpsCC.Model;
using GurpsCC.ViewModel;
using GurpsCC.ViewModel.Container;

namespace GurpsCharacterCreator.View.UserControls
{
    /// <summary>
    /// Interaction logic for PlayerActiveDisadvantageListUserControl.xaml
    /// </summary>
    public partial class PlayerActiveDisadvantageListUserControl : UserControl
    {
        private ILifetimeScope Scope { get; set; }
        private IPlayerViewModel PlayerVM { get; set; }
        private ISelectedItem SelectedItem { get; set; }

        public PlayerActiveDisadvantageListUserControl()
        {
            Scope = IoCContainer.Container.BeginLifetimeScope();
            PlayerVM = Scope.Resolve<IPlayerViewModel>();
            SelectedItem = Scope.Resolve<ISelectedItem>();

            InitializeComponent();

            DisadvantageListBox.ItemsSource = PlayerVM.Disadvantages;
            DisadvantageListBox.SelectionChanged += (x, y) =>
            {
                SelectedItem.SelectedDisadvantageRemove = (ActiveDisadvantage)DisadvantageListBox.SelectedItem;
                SelectedItem.SelectedDescription.Name = ((ActiveDisadvantage)DisadvantageListBox.SelectedItem)?.Disadvantage.Name;
                SelectedItem.SelectedDescription.Description = ((ActiveDisadvantage)DisadvantageListBox.SelectedItem)?.Disadvantage.Description;
                PlayerVM.RemoveDisadvantageCommand.OnCanExecuteChanged();
            };

            DisadvantageListBox.PreviewMouseLeftButtonDown += (x, y) => DisadvantageListBox.SelectedIndex = -1;
        }
        ~PlayerActiveDisadvantageListUserControl()
        {
            Scope.Dispose();
        }
    }
}
