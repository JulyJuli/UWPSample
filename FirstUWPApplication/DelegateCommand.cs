using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace FirstUWPApplication
{
    public class DelegateCommand : ICommand
    {

        private SimpleEventHandler handler;
        private bool isEnabled_ = true;
        public delegate void SimpleEventHandler();


        public event EventHandler CanExecuteChanged;

        public DelegateCommand(SimpleEventHandler eventHandler)
        {
            this.handler = eventHandler;
        }



        public bool IsEnable
        {

            get
            {
                return this.isEnabled_;
            }

        }


        public void OnExecuteChanged()
        {

            this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public bool CanExecute(object parameter)
        {
            return this.IsEnable;
        }

        public void Execute(object parameter)
        {
            this.handler();
        }


        //Action<object> executeMethod;
        //Func<object,bool> canExecuteMethod;


        //DelegateCommand(Action<object> executeMethod_, Func<object,bool> canExecuteMethod_) {
        //    this.executeMethod = executeMethod_;
        //    this.canExecuteMethod = canExecuteMethod_;
        //}


        //public event EventHandler CanExecuteChanged {

        //    add { CommandManager.RequerySuggested += value; }
        //    remove { CommandManager.RequerySuggested -= value; }
        //}

        //public bool CanExecute(object parameter)
        //{
        //    return this.canExecuteMethod == null || this.canExecuteMethod(parameter);
        //}

        //public void Execute(object parameter)
        //{
        //    this.executeMethod(parameter);
        //}
    }
}
