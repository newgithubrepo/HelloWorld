using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{
    using HelloWorld.PresentationServiceExample;
    using HelloWorld.Contracts;



    [TestClass]
    public class PresentationServiceUnitTest
    {
        private IRepositoryService _mockRepository;
        private PresentationService _service;

        [TestInitialize]
        public void TestInit()
        {
            _mockRepository = new MockRepositoryService();
            _service = new PresentationService(_mockRepository);
           
        }


        [TestMethod]
        public void SayHelloWorldTest()
        {
            Assert.AreEqual("Hello World!", _service.GetHelloWorld());

        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void SaveDataTest()
        {
            var testData = new { A = "A", B = "B" };
            _service.SaveData(testData);
           
        }

    }
}
