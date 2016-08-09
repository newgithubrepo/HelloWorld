using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.IoCContainers
{
    using HelloWorld.Contracts;
    using HelloWorld.PresentationServiceExample;
    using HelloWorld.RepositoryServiceExample;
    using Ninject;
    

    public class ConsoleNinjectLoader: NinjectLoader
    {
        
        public ConsoleNinjectLoader(StandardKernel kernel):base(kernel)
        {
            Load();
        }
       
        public override void Load()
        {
            this._kernel.Bind<IRepositoryService>().To<RepositoryService>().When(x => _provider == DataProvider.Console);
            //TODO: other repository services based on DataProvider in config file

            this._kernel.Bind<IPresentationService>().To<PresentationService>();

        }
       
    }
}
