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
        //private CalculatorOperation _operation = CalculatorOperation.None;k
        private int _oper;
        private int _func;



        public ParametrizedRelayCommand Number { get; set; }
        public ParametrizedRelayCommand Operation { get; set; }
        public ParametrizedRelayCommand Function { get; set; }
        public RelayCommand Reset { get; set; }
        public RelayCommand Point { get; set; }

        public RelayCommand Sign { get; set; }
        public RelayCommand Result { get; set; }

        public string Text { get { return _input; } set { _input = value; NotifyPropertyChanged(); } }
        public VjuMoudl()
        {
            Point = new RelayCommand(
                () =>
                {
                    if ((Text.Contains(".")) && Text.Length > 0)
                    {
                        Text += ".";
                    }
                }
                );

            Sign = new RelayCommand(
                () =>
                {
                    if (Text.StartsWith("-"))
                        Text = Text.Substring(1, Text.Length - 1);
                    else
                        Text = "-" + Text;
                }
                );

            Reset = new RelayCommand(
                ()=>
                {
                    Text = "";
                    _storedValue = "";
                }
                );

            Number = new ParametrizedRelayCommand(
                (param) =>
                {
                    Text += param;
                }
                );



            //operace (rychlá akce)
            Operation = new ParametrizedRelayCommand(
                (param) =>
                {
                    _storedValue = Text;
                    Text = "";
                    if (Convert.ToString(param) == "+")
                    {
                        _oper = 1;
                    }
                    if (Convert.ToString(param) == "-")
                    {
                        _oper = 2;
                    }
                    if (Convert.ToString(param) == "*")
                    {
                        _oper = 3;
                    }
                    if (Convert.ToString(param) == "/")
                    {
                        _oper = 4;
                    }
                }
                );

            Function = new ParametrizedRelayCommand(
                (param) =>
                {
                    if (Convert.ToString(param) == "sin")
                    {
                        _func = 1;
                    } 
                    if (Convert.ToString(param) == "cos")
                    {
                        _func = 2;
                    } 
                    if (Convert.ToString(param) == "log")
                    {
                        _func = 3;
                    } 
                    if (Convert.ToString(param) == "moc")
                    {
                        _func = 4;
                    }
                }
                );

            Result = new RelayCommand(
                () =>
                {
                    if(_oper == 1)
                    {
                        Text = Convert.ToString(Convert.ToDouble(_storedValue) + Convert.ToDouble(Text));
                        _oper = 0;
                    }
                    if(_oper == 2)
                    {
                        Text = Convert.ToString(Convert.ToDouble(_storedValue) - Convert.ToDouble(Text));
                        _oper = 0;
                    }
                    if(_oper == 3)
                    {
                        Text = Convert.ToString(Convert.ToDouble(_storedValue) * Convert.ToDouble(Text));
                        _oper = 0;
                    }
                    if(_oper == 4)
                    {
                        if (Text == "0")
                        {
                            Text = "Nulou ne, takhle to nefunguje kamo bracho";
                        }
                        else
                        {
                            Text = Convert.ToString(Convert.ToDouble(_storedValue) / Convert.ToDouble(Text));
                        }
                    }



                    if(_func == 1)
                    {
                        Text = Convert.ToString(Math.Sin(Convert.ToDouble(Text)));
                    }
                    if(_func == 2)
                    {
                        Text = Convert.ToString(Math.Cos(Convert.ToDouble(Text)));
                    }
                    if(_func == 3)
                    {
                        Text = Convert.ToString(Math.Log(Convert.ToDouble(Text)));
                    }
                    if(_func == 4)
                    {
                        Text = Convert.ToString(Convert.ToDouble(Text) * Convert.ToDouble(Text));
                    }
                }
                );

        }



        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
}
}
