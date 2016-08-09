using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Contracts
{
    public interface IRepositoryService
    {
        void SaveData(dynamic data);
    }
}
