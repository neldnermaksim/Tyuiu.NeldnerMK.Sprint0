using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NeldnerMK.Sprint0.Task7.V0.Lib;

namespace Tyuiu.NeldnerMK.Sprint0.Task7.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionArrayValid()
        {
            int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
            int[] nums2 = new int[] { 1, 2, 3, 4, 5 };
            int[] nums3 = new int[] { 1, 2, 3, 4, 5 };

            int[] res = DataService.AdditionArrays(nums1, nums2);
            CollectionAssert.AreEqual(nums3, res);
        }      
    }
}