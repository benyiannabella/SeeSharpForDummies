using System;

namespace SeeSharpForDummies
{
     class Indexer
    {
        static void Indexing()
        {
            //create an array with rooms
            KeyedArray ka = new KeyedArray(100);
            //save the ages of the Smpson kids
            ka["Bart"] = 10;
            ka["Lisa"] = 8;
            ka["Maggie"] = 2;

            // Look up the age of Lisa.
            Console.WriteLine("Let's find Lisa's age");
            int age = (int)ka["Lisa"];
            Console.WriteLine("Lisa is {0}", age);
            Console.Read();
        }
    }

    public class KeyedArray
    {
        //string to be used to identify the element
        private string[] keys;

        //elemennts of the arrays, associated with the key
        private object[] arrayElements;

        //constructor, fix sized array
        public KeyedArray(int size)
        {
            keys = new string[size];
            arrayElements = new object[size];
        }

        //return the index of the elment coresponding to the key
        private int Find(string targetKey)
        {
            for(int i = 0; i < keys.Length; i++)
            {
                if(String.Compare(keys[i], targetKey) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        // FindEmpty -- Find room in the array for a new entry.
        private int FindEmpty()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i] == null)
                {
                    return i;
                }
            }
            throw new Exception("Array is full");
        }

        // Look up contents by string key -- this is the indexer.
        public object this[string key]
        {
            set
            {
                // See if the string is already there.
                int index = Find(key);
                if (index < 0)
                {
                    // It isn't -- find a new spot.
                    index = FindEmpty();
                    keys[index] = key;
                }
                // Save the object in the corresponding spot.
                arrayElements[index] = value;
            }
            get
            {
                int index = Find(key);
                if (index < 0)
                {
                    return null;
                }
                return arrayElements[index];
            }
        }
    }
}
