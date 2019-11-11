using System;
using System.Windows.Controls;
using Autofac;
using GurpsCC.Model;
using GurpsCC.Model.Skills;
using GurpsCC.ViewModel;
using GurpsCC.ViewModel.Container;

namespace GurpsCharacterCreator.View
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class SkillsSetting : UserControl
    {
        private ILifetimeScope Scope { get; set; }
        private IGurpsMainDatabase Database { get; set; }
        private ISelectedItem SelectedItem { get; set; }
        private IPlayerViewModel PlayerVM { get; set; }

        public SkillsSetting()
        {
            InitializeComponent();

            Scope = IoCContainer.Container.BeginLifetimeScope();

            Database = Scope.Resolve<IGurpsMainDatabase>();
            SelectedItem = Scope.Resolve<ISelectedItem>();
            PlayerVM = Scope.Resolve<IPlayerViewModel>();

            SkillListDataGrid.SelectionChanged += (x, y) =>
            {
                SelectedItem.SelectedSkill = (SkillModel)SkillListDataGrid.SelectedItem;
                SelectedItem.SelectedDescription.Name = ((SkillModel)SkillListDataGrid.SelectedItem)?.Name;
                SelectedItem.SelectedDescription.Description = ((SkillModel)SkillListDataGrid.SelectedItem)?.Description;
                PlayerVM.AddSkillCommand.OnCanExecuteChanged();
            };

            DataContext = PlayerVM;

            SkillListDataGrid.ItemsSource = Database.SkillDB;

            SkillListDataGrid.PreviewMouseLeftButtonDown += (x, y) => SkillListDataGrid.SelectedIndex = -1; 
        }
        ~SkillsSetting()
        {
            Scope.Dispose();
        }
    }
}
