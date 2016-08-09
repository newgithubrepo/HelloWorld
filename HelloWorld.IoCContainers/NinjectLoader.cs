using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.IoCContainers
{
    using HelloWorld.Contracts;
    using HelloWorld.RepositoryServiceExample;
    using Ninject;
    using Ninject.Modules;
    using System.Reflection;
    using System.Configuration;

    public abstract class NinjectLoader:NinjectModule
    {
        protected readonly StandardKernel _kernel;
        protected readonly DataProvider _provider;

        public NinjectLoader(StandardKernel kernel)
        {
            _kernel = kernel;
            _kernel.Load(Assembly.GetExecutingAssembly());
            _provider = (DataProvider)Enum.Parse(typeof(DataProvider), ConfigurationManager.AppSettings["DataProvider"], true);
            

        }

     

        public IPresentationService GetPresentaionService()
        {
            return _kernel.Get<IPresentationService>();
        }
        
    }
}
