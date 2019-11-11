using System.Windows.Controls;
using Autofac;
using GurpsCC.Model;
using GurpsCC.Model.Advantages;
using GurpsCC.ViewModel;
using GurpsCC.ViewModel.Container;

namespace GurpsCharacterCreator.View
{
    /// <summary>
    /// Interaction logic for AdvantagesSettingUserControl.xaml
    /// </summary>
    public partial class AdvantagesSetting : UserControl
    {
        private ILifetimeScope Scope { get; set; }
        private IGurpsMainDatabase Database { get; set; }
        private ISelectedItem SelectedItem { get; set; }
        private IPlayerViewModel PlayerVM { get; set; }

        public AdvantagesSetting()
        {
            InitializeComponent();

            Scope = IoCContainer.Container.BeginLifetimeScope();

            Database = Scope.Resolve<IGurpsMainDatabase>();
            SelectedItem = Scope.Resolve<ISelectedItem>();
            PlayerVM = Scope.Resolve<IPlayerViewModel>();

            AdvantageListDataGrid.SelectionChanged += (x, y) =>
            {
                SelectedItem.SelectedAdvantage = (AdvantageModel)AdvantageListDataGrid.SelectedItem;
                SelectedItem.SelectedDescription.Name = ((AdvantageModel)AdvantageListDataGrid.SelectedItem)?.Name;
                SelectedItem.SelectedDescription.Description = ((AdvantageModel)AdvantageListDataGrid.SelectedItem)?.Description;
                PlayerVM.AddAdvantageCommand.OnCanExecuteChanged();
            };

            DataContext = PlayerVM;
            AdvantageListDataGrid.ItemsSource = Database.AdvantageDB;

            AdvantageListDataGrid.PreviewMouseLeftButtonDown += (x, y) => AdvantageListDataGrid.SelectedIndex = -1;
        }
    }
}
