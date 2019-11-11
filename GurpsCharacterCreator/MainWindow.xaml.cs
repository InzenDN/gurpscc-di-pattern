using System.Windows;
using System.Windows.Input;
using Autofac;
using GurpsCC.Model;
using GurpsCC.ViewModel;
using GurpsCC.ViewModel.Container;

namespace GurpsCharacterCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ILifetimeScope Scope { get; set; }
        private ISelectedItem SelectedItem { get; set; }

        public MainWindow()
        {
            IoCContainer.Configure();
            Scope = IoCContainer.Container.BeginLifetimeScope();
            SelectedItem = Scope.Resolve<ISelectedItem>();
            DataContext = Scope.Resolve<IPlayerViewModel>();

            InitializeComponent();

            LabelDescription.DataContext = SelectedItem.SelectedDescription;

            MouseLeftButtonDown += (x, y) => Keyboard.ClearFocus();
        }
        ~MainWindow()
        {
            Scope.Dispose();
        }
    }
}
