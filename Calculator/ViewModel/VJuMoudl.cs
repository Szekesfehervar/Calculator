using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel
{
    class VjuMoudl : INotifyPropertyChanged
    {
        private string _input;
        private string _storedValue;
        //private CalculatorOperation _operation = CalculatorOperation.None;
        private string _message;

        public ParametrizedRelayCommand Number { get; set; }
        public ParametrizedRelayCommand Operation { get; set; }
        public ParametrizedRelayCommand Function { get; set; }
        public RelayCommand Reset { get; set; }
        public RelayCommand Point { get; set; }

        public VjuMoudl()
        {

        }






        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
