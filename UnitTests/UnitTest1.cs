using Guiosoft;
using Guiosoft.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    /// <summary>
    /// Well, I know that this unittest is wrong, with no asserts
    /// Use this to know how to use the classes
    /// </summary>
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

        [TestMethod]
        public void TestExtensions()
        {            
            Console.WriteLine(Math.PI + " = " + Math.PI.ToSQL());

            double dou = 0.001;
            Console.WriteLine(dou + " = " + dou.IsZero());
            Console.WriteLine(dou + " = " + dou.IsZero(3));

            decimal dec = 0.0004M;
            Console.WriteLine(dec + " = " + dec.IsZero());
            Console.WriteLine(dec + " = " + dec.IsZero(3));
            Console.WriteLine(dec + " = " + dec.IsZero(4));

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt + " = " + dt.ToSQL());
            
        }
    }
}