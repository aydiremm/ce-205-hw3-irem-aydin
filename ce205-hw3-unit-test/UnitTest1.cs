using Microsoft.VisualStudio.TestTools.UnitTesting;
using ce205_hw4_algo_lib;
using System;

/**
 * @file UnitTest1
 * @author Irem AYDIN
 * @date 12 December 2022
 *
 * @brief <b> HW-4 Functions </b>
 *
 * HW-4 Algo Test Functions Header
 *
 * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
 *
 */

namespace ce205_hw4_unit_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpenAddressingLinearTest()
        {
            OpenAdressing hash = new OpenAdressing(100);
            int size = 5;

            string[] loremArray = { "Proin et fermentum ex. Etiam fringilla.",
                "Suspendisse lorem eros, fermentum a nibh.",
                "Nunc euismod quam et tempor ornare.",
                "Integer ultricies ac purus non suscipit.",
                "Etiam convallis, enim quis ultricies pellentesque." };
            int[] keyArray = { 6, 21, 49, 72, 25 };
            for (int i = 0; i < loremArray.Length; i++)
            {
                hash.OpenAddressingLinear(keyArray[i], loremArray[i], size);
            }
            Assert.AreEqual("Proin et fermentum ex. Etiam fringilla.", hash.hashTable[1].data);
        }
        [TestMethod]
        public void OpenAddressingQuadraticTest()
        {
            OpenAdressing hash = new OpenAdressing(100);
            int size = 7;

            string[] loremArray = { "Quisque pretium lorem.",
                "Suspendisse potenti. Cras.",
                "Nulla facilisis, quam.",
                "Pellentesque aliquet eu.",
                "Vivamus porta justo." };
            int[] keyArray = { 5, 40, 48, 55, 76 };
            for (int i = 0; i < loremArray.Length; i++)
            {
                hash.OpenAddressingQuadratic(keyArray[i], loremArray[i], size);
            }
            Assert.AreEqual("Vivamus porta justo.", hash.hashTable[1].data);
        }
        [TestMethod]
        public void OpenAddressingDoubleTest()
        {
            OpenAdressing hash = new OpenAdressing(100);
            int size = 10;

            string[] loremArray = { "Quisque pretium eleifend enim. Quisque quis feugiat.",
                "Phasellus maximus id lectus eu convallis. Maecenas.",
                "Nulla lacinia rutrum ornare. Integer id massa.",
                "Suspendisse semper scelerisque magna, eu venenatis tortor.",
                "Maecenas auctor, risus id venenatis fringilla, tellus." };
            int[] keyArray = { 21, 31, 41, 51, 61 };
            for (int i = 0; i < loremArray.Length; i++)
            {
                hash.OpenAddressingDouble(keyArray[i], loremArray[i], size);
            }
            Assert.AreEqual("Quisque pretium eleifend enim. Quisque quis feugiat.", hash.hashTable[1].data);
        }

        [TestMethod]
        public void HashingChainingTest()
        {
            HashingChaining hash = new HashingChaining(10);
            hash.hashing_chaining(45, "Aliquam ");
            hash.hashing_chaining(23, "fermentum");
            hash.hashing_chaining(12, " egestas");
            hash.hashing_chaining(56, "Praesent");
            hash.hashing_chaining(34, "porttitor");
            hash.hashing_chaining(82, "ultricies");

            Assert.AreEqual("fermentum", hash.hashTable[3].First.Value.data);
        }
    }
}

