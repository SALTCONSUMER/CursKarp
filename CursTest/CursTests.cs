using Microsoft.VisualStudio.TestTools.UnitTesting;
using CursKarp;
using System;

namespace CursTest
{
    [TestClass]
    public class CursTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] Matr = new int[3, 3];
            int[] nums = { 3, 4, 5 };//последовательность
            int[,] test1 = { { 3, 7, 12 }, { 0, 4, 9 }, { 0, 0, 5 } };//правильная матрица
            Program.BuildMatr(3, nums, ref Matr);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(test1[i, j], Matr[i, j]);
                }
            }



        }
        [TestMethod]
        public void TestMethod2()//завальный тест
        {
            int[,] Matr = { { 1, 3, 6 }, { 0, 2, 5 }, { 0, 0, 3 } };
            int[] nums = { 1, 2, 3 };//последовательность
            int[,] test1 = { { 6, 3, 1 }, { 5, 2, 0 }, { 3, 0, 0 } };//правильная матрица
            Program.SortMatr(3, ref Matr);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(test1[i, j], Matr[i, j]);
                }
            }
        }
       
    }
}
