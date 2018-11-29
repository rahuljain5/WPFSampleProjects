using CalcApp.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalcApp.ViewModels
{
    public class CalcViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<String> history = new ObservableCollection<string>();

        public ObservableCollection<String> History
        {
            get { return history; }
            set { { history = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(History))); } }
        }

        public CalcViewModel()
        {
            FindSum = new CalcCommands(ExecuteSum, canExecute);
            FindDiff = new CalcCommands(ExecuteDiff, canExecute);
            FindProd = new CalcCommands(ExecuteProd, canExecute);
            FindQuo = new CalcCommands(ExecuteDiv, canExecute);
        }

        private int number1;

        public int Number1
        {
            get { return number1; }
            set { number1 = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Number1))); }
        }
        private int number2;
        public int Number2
        {
            get { return number2; }
            set { number2 = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Number2))); }
        }
        private double result;
        public double Result
        {
            get { return result; }
            set { result = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result))); }
        }
        public ICommand FindSum { get; set; }
        public ICommand FindDiff { get; set; }
        public ICommand FindProd { get; set; }
        public ICommand FindQuo { get; set; }
   
        public event PropertyChangedEventHandler PropertyChanged;

        private bool canExecute(object parameter)
        {
            if (Number1 == 0 || Number2 == 0)
                return false;
            else
                return true;
        }
        private void ExecuteSum(object parameter)
        {
            Result = Number1 + Number2;
            History.Add(Number1 + "+" + Number2 + "=" + Result);
        }
        private void ExecuteDiff(object parameter)
        {
            Result = Number1 - Number2;
            History.Add(Number1 + "-" + Number2 + "=" + Result);
        }
        private void ExecuteProd(object parameter)
        {
            Result = Number1 * Number2;
            History.Add(Number1 + "*" + Number2 + "=" + Result);
        }
        private void ExecuteDiv(object parameter)
        {
            Result = Number1 / (double)Number2;
            History.Add(Number1 + "/" + Number2 + "=" + Result);
        }


    }
}
