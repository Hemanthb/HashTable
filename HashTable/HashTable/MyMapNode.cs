using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class MyMapNode<K, V>
    {
        public int size;
        public LinkedList<KeyValue<K, V>>[] hashMap;

        public MyMapNode(int size)
        {
            this.size = size;
            this.hashMap = new LinkedList<KeyValue<K, V>>[size];
        }

        //Generates a hashcode based on the key which acts as an array position
        public int GetArrayPosition(K key)
        {
            int pos = key.GetHashCode() % this.size;
            return Math.Abs(pos);
        }

        //Adds a key value pair into hashtable
        public void Add(K key,V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K,V>> list = GetLinkedList(position);
            KeyValue<K,V> items = new KeyValue<K, V> { Key=key, Value=value };
            list.AddLast(items);
        }

        // Method to Get Linked List
        public LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = hashMap[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                hashMap[position] = linkedList;
            }
            return linkedList;
        }
        //Calculates the frequency of a given word 
        public int GetFrequencyOfWords(V word)
        {
            int count = 0;
            if(hashMap == null)
            {
                Console.WriteLine("hashTable is empty!!");
                return 0;
            }
            for(int i = 0; i < hashMap.Length; i++)
            {
                LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(i);
                foreach(KeyValue < K, V > item in linkedList)
                {
                    if (item.Value.Equals(word)) { count++; }
                        
                }
            }
            return count;
        }

        public Boolean CheckKey(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K,V>> keyValues = hashMap[position];
            if (keyValues != null)
            {
                foreach (KeyValue<K, V> item in keyValues)
                {
                    if (item.Key.Equals(key))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> keyValues = hashMap[position];
            foreach (KeyValue<K, V> item in keyValues)
            {
                if (item.Key.Equals(key))
                {
                    keyValues.Remove(item);
                    return;
                }
            }
        }

        public V FindValue(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> keyValues = hashMap[position];
            foreach (KeyValue<K, V> item in keyValues)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        
        public struct KeyValue<K, V>
        {
            public K Key { get; set; }
            public V Value { get; set; }
        }

    }
}
