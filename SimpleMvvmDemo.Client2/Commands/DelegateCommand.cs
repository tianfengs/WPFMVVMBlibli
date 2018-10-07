using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleMvvmDemo.Client2.Commands
{
    class DelegateCommand : ICommand
    {
        /// <summary>
        /// 告诉命令调用者，命令可以执行
        /// </summary>
        public event EventHandler CanExecuteChanged; 

        /// <summary>
        /// 帮助命令的呼叫者判断，命令能不能执行
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            if (this.CanExecuteFunc == null)
            {
                return true;
            }
            return this.CanExecuteFunc(parameter);
        }

        /// <summary>
        /// 命令执行代码
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            if (this.ExecuteAction == null)
            {
                return;
            }
            this.ExecuteAction(parameter); // 当命令调用时，委托给这个委托指向的方法
        }

        public Action<object> ExecuteAction { get; set; }
        public Func<object,bool> CanExecuteFunc { get; set; }
    }
}
