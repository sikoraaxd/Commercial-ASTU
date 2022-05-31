using Commercial_ASTU.Core;
using Commercial_ASTU.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commercial_ASTU.MVVM.ViewModel
{
    internal class AuthViewModel : ObservableObject
    {
        public ICommand StudentCommand { get; }
        public ICommand TeacherCommand { get; }

        public RelayCommand TryLogin { get; }

        public string Login { get; set; }
        public string Password { get; set; }

        public AuthViewModel(NavigationStore navigationStore)
        {
            StudentCommand = new NavigationCommand<StudentViewModel>(navigationStore, () => new StudentViewModel(navigationStore));
            TeacherCommand = new NavigationCommand<TeacherViewModel>(navigationStore, () => new TeacherViewModel(navigationStore));

            using (ApplicationContext context = new ApplicationContext())
            {
                if (context.Teachers.ToList().Count == 0)
                {
                    Teacher adminTeacher = new Teacher();
                    adminTeacher.ID = Guid.NewGuid();
                    adminTeacher.Name = "admin";
                    adminTeacher.Login = "admin";
                    adminTeacher.Password = "admin";
                    context.Teachers.Add(adminTeacher);
                    context.SaveChanges();
                }
            }

            TryLogin = new RelayCommand(o =>
            {
                if (Login == "" || Password == "")
                    return;
                using (ApplicationContext context = new ApplicationContext())
                {
                    foreach (var teacher in context.Teachers.ToList())
                    {
                        if (teacher.Login == Login && teacher.Password == Password)
                        {
                            TeacherCommand.Execute(this);
                            return;
                        }
                    }
                }
            });

            
        }
    }
}
