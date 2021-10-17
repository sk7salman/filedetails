using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Utility;

namespace FileData.Tests
{
    [TestClass]
    public class FileDetailsUnitTest
    {
        private static Factory factory = new FileDetailsManager();
         

        [TestMethod]
        public void No_InPutIsProvided()
        {
            //arrange
            var fileDetailsManager = factory.GetInstance();
            // main prototype
           

            //Act
            var result = fileDetailsManager.GetFileDetails(null, null);

            //Assert
            Assert.AreEqual("", result);

        }
        [TestMethod]
        public void FileDetails_Success()
        {
            //arrange
            var fileDetailsManager = factory.GetInstance();

            //Act
            var result = fileDetailsManager.GetFileDetails("-v", "c\fdds");

            //Assert
            Assert.AreEqual(false, string.IsNullOrEmpty(result));

        }

    }
}
