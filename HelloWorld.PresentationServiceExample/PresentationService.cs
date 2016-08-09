using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld.PresentationServiceExample
{
    using HelloWorld.Contracts;

    public class PresentationService: IPresentationService
    {
        private readonly IRepositoryService _respositoryService;

        public PresentationService(IRepositoryService respositoryService)
        {
            _respositoryService = respositoryService;
        }

        public string GetHelloWorld()
        {
            return "Hello World!";
        }

        public void SaveData(dynamic data)
        {
            _respositoryService.SaveData(data);
        }
    }
}
