using System;
using System.Windows.Input;

namespace GurpsCC.ViewModel
{
    public class DelegateCommand : ICommand
    {
        private readonly Predicate<object> _CanExecute;
        private readonly Action<object> _Execute;

        public DelegateCommand(Action<object> Execute, Predicate<object> CanExecute)
        {
            this._CanExecute = CanExecute;
            this._Execute = Execute;
        }        
        
        public bool CanExecute(object parameter)
        {
            if (_CanExecute == null)
                return true;
            return _CanExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _Execute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
