using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @file OpenAdressing.cs
 * @author Irem AYDIN
 * @date 12 December 2022
 *
 * @brief <b> HW-4 Functions </b>
 *
 * HW-4 Algo Lib Functions Header
 *
 * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
 *
 */

namespace ce205_hw4_algo_lib
{
    public class OpenAdressing
    {
        public class hash
        {
            public int key;
            public string data;

            public hash(int key, string data)
            {
                this.key = key;
                this.data = data;
            }
        }
        public hash[] hashTable;
        public OpenAdressing(int size)
        {
            hashTable = new hash[size];
        }
        /// <summary>
        /// When there is a collision, the next free index is searched and our value is placed there.
        /// The formula for Linear Probing is " (h(x) + i) % s ".
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="size"></param>
        public void OpenAddressingLinear(int key, string data, int size)
        {
            int index = key % size;
            while (hashTable[index] != null)
            {
                index = (index + 1) % size;
            }
            hashTable[index] = new hash(key, data);
        }
        /// <summary>
        /// Quadratic Probing is the same as linear probing. The only difference is that the value of i becomes i^2.
        /// The formula for Quadratic Probing is " (h(x) + i*i) % s ".
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="size"></param>
        public void OpenAddressingQuadratic(int key, string data, int size)
        {
            int index = key % size;
            int i = 1;
            while (hashTable[index] != null)
            {
                index = (index + i * i) % size;
                i++;
            }
            hashTable[index] = new hash(key, data);
        }
        /// <summary>
        /// There are also two hash functions in this structure.
        /// If the index is full according to the first function, that is, there is a collision, the second function is considered.
        /// The formula for Double Hashing is " h(x)+ i*i(index % (size - 1)) ".
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="size"></param>
        public void OpenAddressingDouble(int key, string data, int size)
        {
            int index = key % size;
            int i = 1;
            int number = 0;
            while (hashTable[index] != null)
            {
                for (int j = 0; j < hashTable.Length; j++)
                {
                    if (hashTable[index] != null)
                    {
                        number++;
                    }
                }
                index = (index + i * (number - (key % number)) % size);
                i++;
            }
            hashTable[index] = new hash(key, data);
        }
    }
}