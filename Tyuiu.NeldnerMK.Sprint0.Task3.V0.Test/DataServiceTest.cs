﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint0.Task3.V0.Lib;

namespace Tyuiu.NeldnerMK.Sprint0.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetValid()
        {      
            Assert.AreEqual(10, DataService.Sum(5,5));
        }
    }
}