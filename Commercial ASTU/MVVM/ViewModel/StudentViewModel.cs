using Commercial_ASTU.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commercial_ASTU.MVVM.ViewModel
{
    internal class StudentViewModel : ObservableObject
    {
        public ICommand Student2Command { get; }

        public StudentViewModel(NavigationStore navigationStore)
        {
            Student2Command = new NavigationCommand<StudentViewModel2>(navigationStore, () => new StudentViewModel2(navigationStore));
        }
    }
}
