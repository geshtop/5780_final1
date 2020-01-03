using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Ninject;

namespace PL.Controls
{
    public class UserControlBase : UserControl
    {
        protected IAppLogic app;
        public  MainWindow CurrentWindow{
            get{
                return (App.Current.MainWindow as MainWindow);
            }
        }

         

        public UserControlBase()
        {
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            {
                //code producing exception  
                var _app = IoC.Kernel.Get<IAppLogic>();
                this.app = _app;
            }
           
        }

        public void MainNavigate(Pages.PageBase p)
        {
            CurrentWindow.MainFrame.Content = p;
        }
    }
}
