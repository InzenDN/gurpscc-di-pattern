using System.Windows.Controls;
using Autofac;
using GurpsCC.Model;
using GurpsCC.Model.Disadvantages;
using GurpsCC.ViewModel;
using GurpsCC.ViewModel.Container;

namespace GurpsCharacterCreator.View
{
    /// <summary>
    /// Interaction logic for DisadvantagesSettingUserControl.xaml
    /// </summary>
    public partial class DisadvantagesSetting : UserControl
    {
        private ILifetimeScope Scope { get; set; }
        private IGurpsMainDatabase Database { get; set; }
        private ISelectedItem SelectedItem { get; set; }
        private IPlayerViewModel PlayerVM { get; set; }

        public DisadvantagesSetting()
        {
            InitializeComponent();

            Scope = IoCContainer.Container.BeginLifetimeScope();

            Database = Scope.Resolve<IGurpsMainDatabase>();
            SelectedItem = Scope.Resolve<ISelectedItem>();
            PlayerVM = Scope.Resolve<IPlayerViewModel>();

            DisadvantageListDataGrid.SelectionChanged += (x, y) =>
            {
                SelectedItem.SelectedDisadvantage = (DisadvantageModel)DisadvantageListDataGrid.SelectedItem;
                SelectedItem.SelectedDescription.Name = ((DisadvantageModel)DisadvantageListDataGrid.SelectedItem)?.Name;
                SelectedItem.SelectedDescription.Description = ((DisadvantageModel)DisadvantageListDataGrid.SelectedItem)?.Description;
                PlayerVM.AddDisadvantageCommand.OnCanExecuteChanged();
            };

            DataContext = PlayerVM;
            DisadvantageListDataGrid.ItemsSource = Database.DisadvantageDB;

            DisadvantageListDataGrid.PreviewMouseLeftButtonDown += (x, y) => DisadvantageListDataGrid.SelectedIndex = -1;
        }
    }
}
