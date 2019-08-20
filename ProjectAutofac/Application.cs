using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAutofac
{
    public class Application : IApplication
    {
        IBusinessLogic businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            this.businessLogic = businessLogic;
        }

        public void Run()
        {
            businessLogic.ProcessData();
        }
    }
}
