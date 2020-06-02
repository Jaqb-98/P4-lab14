using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace lab14
{
    public class MainWindowViewModel
    {
        public RegistrationModel Registration { get; set; }
        public ICommand RegisterCommand { get; private set; }

        public MainWindowViewModel()
        {
            Registration = new RegistrationModel();
            RegisterCommand = new RegisterCommand();
        }
    }
}
