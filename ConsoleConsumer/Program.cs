using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConsumer
{
    using HelloWorld.IoCContainers;
    using HelloWorld.Contracts;

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleNinjectLoader loader = new ConsoleNinjectLoader(new Ninject.StandardKernel());
            IPresentationService _service = (IPresentationService)loader.GetPresentaionService();

            Console.WriteLine(_service.GetHelloWorld());

            dynamic data = new{ PropertyA = "Just a string", PropertyB = 100 };
            _service.SaveData(data);
            _service.SaveData(null);

            Console.ReadLine();
           

        }
    }

  
}
