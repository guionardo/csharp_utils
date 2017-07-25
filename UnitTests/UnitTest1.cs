using Guiosoft;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAntivirus()
        {
            Console.WriteLine(Antivirus.AVInfo());
        }

        [TestMethod]
        public void TestFirewall()
        {
            Console.WriteLine(Firewall.FWInfo());
        }
    }
}