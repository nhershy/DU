using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DU
{
    [TestFixture]
    class HelperTest
    {
        [Test]
        public void humanReadableSizeTest()
        {
            string actual = Helper.humanReadableSize(999);
            Assert.AreEqual("999B", actual);

            actual = Helper.humanReadableSize(1555);
            Assert.AreEqual("1KB", actual);

            actual = Helper.humanReadableSize(2555999);
            Assert.AreEqual("2MB", actual);

            actual = Helper.humanReadableSize(2555999444);
            Assert.AreEqual("2.5GB", actual);
        }

        [Test]
        public void getSizeTest()
        {
            string actual = Helper.getSize(876543);
            Assert.AreEqual("[876KB] ", actual);
        }

        [Test]
        public void getBytesTest()
        {
            string pathToTestFile = @"C:\Users\TEST\source\repos\DU\DU\Resources\TestFile.txt";
            long actual = Helper.getBytes(pathToTestFile);
            Assert.AreEqual(24, actual);
        }
    }
}
