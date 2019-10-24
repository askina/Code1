using MVVM.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MVVM.ViewModels
{
    class MainWindowViewModel:NotificationObject
    {
        private double input1;

        public double Input1
        {
            get { return input1; }
            set { input1 = value;
                this.RaisePropertyChanged("Input1");
            }
        }
        private double input2;

        public double Input2
        {
            get { return input2; }
            set { input2 = value;
                this.RaisePropertyChanged("Input2");
            }
        }
        private Brush result_color;

        public Brush Result_color
        {
            get { return result_color; }
            set { result_color = value;
                this.RaisePropertyChanged("Result_color");
            }
        }

        private double result;

        public double Result
        {
            get { return result; }
            set { result = value;
                this.RaisePropertyChanged("Result");
            }
        }
        private void Add(object parameter)
        {
            this.Result = this.Input1 + this.Input2;           
            this.Result_color = new SolidColorBrush(Colors.Red);
        }
        public DelegateCommand AddCommand { get; set; }

        public MainWindowViewModel()
        {
            this.AddCommand = new DelegateCommand();
            AddCommand.ExcuteAction = new Action<object>(this.Add);
    }

    }
}

