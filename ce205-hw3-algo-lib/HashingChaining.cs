using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @file HashingChaining.cs
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
    public class HashingChaining
    {
        public class hash_c
        {
            public int key;
            public string data;
            public hash_c(int key, string data)
            {
                this.key = key;
                this.data = data;
            }
        }
        public LinkedList<hash_c>[] hashTable;
        public HashingChaining(int size)
        {
            hashTable = new LinkedList<hash_c>[size];
        }
        /// <summary>
        /// Chained HashTable data structure uses hashing with chaining to store data as an array of lists.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        public void hashing_chaining(int key, string data)
        {
            int index = key % hashTable.Length;
            while (hashTable[index] != null)
            {
                index = (index + 1) % hashTable.Length;
            }
            hashTable[index] = new LinkedList<hash_c>();
            hashTable[index].AddFirst(new hash_c(key, data));
        }
    }
}