using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Ninject;
using BE;

namespace PL.Pages
{
    public class PageBase : Page
    {
        protected IAppLogic app;

        public Enums.Auth Auth
        {
            get
            {
                return CurrentWindow.Auth;
            }
            set
            {
                CurrentWindow.Auth = value;
            }
        }

        public int OwnerId {

            get
            {
                return CurrentWindow.OwnerId;
            }
            set
            {
                CurrentWindow.OwnerId = value;
            }
        }


        public  MainWindow CurrentWindow{
            get{
                return (App.Current.MainWindow as MainWindow);
            }
        }
        
        public PageBase()
        {
            var _app = IoC.Kernel.Get<IAppLogic>();
            this.app = _app;
        }


        public void MainNavigate(PageBase p)
        {
            CurrentWindow.MainFrame.Content = p;
        }

        public void BackToMain(){
            Pages.Main main = new Pages.Main();
            MainNavigate(main);
          
        }


       
    }
}
