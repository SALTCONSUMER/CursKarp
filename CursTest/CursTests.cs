using Microsoft.VisualStudio.TestTools.UnitTesting;
using CursKarp;
using System;

namespace CursTest
{
    [TestClass]
    public class CursTests
    {
        [TestMethod]
        public void BuildMatr_CreateTriangulaMatrixFromSequenceAndCompareWithRigthTriangularMatrix_CreatedMaxtrixIsEqualToRigthTriangularMatrix()
        {
            int[,] Matr = new int[3, 3];
            int[] nums = { 3, 4, 5 };//������������������
            int[,] test1 = { { 3, 7, 12 }, { 0, 4, 9 }, { 0, 0, 5 } };//���������� �������
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
        public void SortMatr_SortingMatrixAndCompareWithWrongSortedMatrix_CreatedMatrixIsNotEqualToWrongSortedMatrix()//��������� ����
        {
            int[,] Matr = { { 1, 3, 6 }, { 0, 2, 5 }, { 0, 0, 3 } };
            int[] nums = { 1, 2, 3 };//������������������
            int[,] test1 = { { 6, 1, 3 }, { 5, 2, 0 }, { 3, 0, 0 } };//���������� �������
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
