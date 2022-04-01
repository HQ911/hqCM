using Caliburn.Micro;
using hqCmWpfCore1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace hqCmWpfCore1
{
    public class MyBoot:BootstrapperBase
    {
        private SimpleContainer con;
        public MyBoot()
        {
             Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override void Configure()
        {
            //base.Configure();
            con = new SimpleContainer();
            con.Singleton<IWindowManager,WindowManager>();
            con.PerRequest<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return con.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        { 
            return con.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            //con.BuildUp(instance);
        }

    }
}
