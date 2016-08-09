using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Tests
{
    using HelloWorld.Contracts;

    public class MockRepositoryService:IRepositoryService
    {
        public void SaveData(dynamic data)
        {
            throw new NotImplementedException();
        }
    }
}
