using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhoneApp1
{
    public class IncreasePriceCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        PhoneViewModel viewModel;
        public IncreasePriceCommand(PhoneViewModel vm)
        {
            viewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return viewModel.Price < 100000;
        }

        public void Execute(object parameter)
        {
            if (CanExecute(parameter))
                viewModel.IncreasePrice();
        }
    }
}
