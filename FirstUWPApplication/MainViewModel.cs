using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FirstUWPApplication
{
     class MainViewModel : MainViewModelBase
    {
        public CalculatorModel calculator_ = null;
        private int value1_ = 0;
        private int value2_ = 0;
        private int result_ = 0;

        private bool isAddChecked_ = false;
        private bool isSubChecked_ = false;
        private bool isAnyRadioButtonChecked_ = false;


        public bool IsAnyRadioButtonChecked
        {

            get
            {
                return isAnyRadioButtonChecked_;
            }

            set
            {
                if (value != isAnyRadioButtonChecked_)
                {
                    isAnyRadioButtonChecked_ = value;
                    OnPropertyChanged("IsAnyRadioButtonChecked");

                }

            }
        }


        public int Value1
        {

            get
            {
                return value1_;
            }

            set
            {
                if (value != value1_)
                {
                    value1_ = value;
                    OnPropertyChanged("Value1");

                }

            }
        }


        public int Value2
        {

            get
            {
                return value2_;
            }

            set
            {
                if (value != value2_)
                {
                    value2_ = value;
                    OnPropertyChanged("Value2");

                }

            }
        }


        public int Result
        {

            get
            {
                return result_;
            }

            set
            {
                if (value != result_)
                {
                    result_ = value;
                    OnPropertyChanged("Result");

                }

            }
        }

        public bool IsAddChecked
        {

            get
            {
                return isAddChecked_;
            }

            set
            {
                if (value != isAddChecked_)
                {
                    isAddChecked_ = value;
                    IsAnyRadioButtonChecked = true;
                    OnPropertyChanged("IsAddChecked");

                }

            }
        }

        public bool IsSubChecked
        {

            get
            {
                return isSubChecked_;
            }

            set
            {
                if (value != isSubChecked_)
                {
                    isSubChecked_ = value;
                    IsAnyRadioButtonChecked = true;
                    OnPropertyChanged("IsSubChecked");

                }

            }
        }


        public ICommand IsOkChecked {

            get {
                return new DelegateCommand(FindResult);
            }

        }

        private void FindResult()
        {
            calculator_ = new CalculatorModel(Value1, Value2);

            if (IsAddChecked)
            {
                Result = calculator_.Add();
            }
            else if (IsSubChecked)
            {
                Result = calculator_.Sub();
            }

              
        }
    }
}
