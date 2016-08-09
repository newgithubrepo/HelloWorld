using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Contracts
{
    public interface IPresentationService
    {
        string GetHelloWorld();
        void SaveData(dynamic data);
    }

}
