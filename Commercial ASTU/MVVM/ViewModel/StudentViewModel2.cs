using Commercial_ASTU.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commercial_ASTU.MVVM.ViewModel
{
    internal class StudentViewModel2 : ObservableObject
    {
        public ICommand GoToHomeCommand { get; }
        public StudentViewModel2(NavigationStore navigationStore)
        {
            GoToHomeCommand = new NavigationCommand<AuthViewModel>(navigationStore, () => new AuthViewModel(navigationStore));
        }
    }
}
