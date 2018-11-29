using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AuthenticationApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public ICommand Login { get; set; }
        public LoginViewModel()
        {
            Login = new Commands.LoginCommands(execute, canExecute);
        }

        private string username;
        private string password;
        private string message;
        private bool loginSuccessful;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Username { get => username; set { username = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Username))); } }
        public string Password { get => password; set { password = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password))); } }
        public string Message { get => message; set { message = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Message))); } }
        public bool LoginSuccessful { get => loginSuccessful; set { loginSuccessful = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LoginSuccessful))); } }


        private bool canExecute(object parameter)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) )
            {
                return false;
            }
            else return true;
        }
        private void execute(object parameter)
        {
            if (Username != "abc" && Password != "xyz")
            {
                Message = "Invalid UserName or Password";
            }
            else
            {
                LoginSuccessful = true;
                Message = "Welcome " + Username;
            }
        }
    }
}
