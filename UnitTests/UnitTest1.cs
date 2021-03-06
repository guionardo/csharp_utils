﻿using Guiosoft;
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

            double d2 = 0.01;
            Console.WriteLine(dou + " = " + d2 + " => " + dou.IsEqual(d2));
            Console.WriteLine(dou + " = " + d2 + " => " + dou.IsEqual(d2, 1));

            decimal de2 = 0.0003M;
            Console.WriteLine(dec + " = " + de2 + " => " + dec.IsEqual(de2));
            Console.WriteLine(dec + " = " + de2 + " => " + dec.IsEqual(de2, 4));
        }

        [TestMethod]
        public void TestStringExtensions()
        {
            string s = "Testing string to Test if this unit test is working";
            string[] search = new string[] { "test", "unit" };
            string[] replace = new string[] { "TESTE", "UNIDADE" };
            string s2 = s.Replace(search, replace, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(s);
            Console.WriteLine(s.Length + " : " + s2.Length);
        }
    }
}