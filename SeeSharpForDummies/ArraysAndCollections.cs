
namespace SeeSharpForDummies
{
    class ArraysAndCollections
    {
        static void Colect()
        {
            int[] myArr = new int[10];
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var myArray = new int[] { 1, 2, 3, 4, 5, 6 };

            var arr2 = new string[] { "Hello", "Bye", "Pa" };
            Array.Sort(arr2);
            //Console.WriteLine("After alphabetical sort:");
            //foreach (string s in arr2)
            //{
            //    Console.WriteLine(s);
            //}


            //Console.WriteLine("After element length sort:");
            //String temp = "";
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    for (int j = i + 1; j < arr2.Length; j++)
            //    {
            //        if (arr2[i].Length > arr2[j].Length)
            //        {
            //            temp = arr2[i];
            //            arr2[i] = arr2[j];
            //            arr2[j] = temp;
            //        }
            //    }
            //}
            //foreach (string s in arr2)
            //{
            //    Console.WriteLine(s);
            //}

            //List<string> mylist = new List<string> { "Hello", "Bye", "Pa" };
            //List<string> list1 = new List<string>(arr2);
            ////list1.AddRange(arr2);
            //Console.WriteLine("List element size: " + list1.Count);

            //string[] newArr = list1.ToArray();
            //list1.Insert(1, "Cheers");
            //list1.RemoveAt(3);
            ////list1.Reverse();
            //foreach (string s in list1)
            //{
            //    Console.WriteLine(s);
            //}

            //Dictionary<string, string> dict = new Dictionary<string, string>();
            //Dictionary<int, string> dict2 = new Dictionary<int, string> { { 1, "Sam" }, { 2, "Jane" } };

            //dict.Add("Java", "coolest");
            //dict.Add("C#", "good");
            //dict.Add("VB", "wordy");
            //dict.Add("Norton", "antient");

            //Console.WriteLine(dict.ContainsKey("Java"));
            //Console.WriteLine(dict.ContainsValue("worst"));

            //foreach(KeyValuePair<string,string> pair in dict)
            //{
            //    Console.WriteLine("Key = " + pair.Key + ", Value = " + pair.Value);
            //}

            //Dictionary<string,string>.KeyCollection keys = dict.Keys;
            //Console.WriteLine("Just the keys:");
            //foreach(string key in keys) Console.Write(key + " ,");
            //Console.WriteLine();
            //Dictionary<string, string>.ValueCollection values = dict.Values;
            //Console.WriteLine("Just the values: ");
            //foreach (string value in values) Console.Write(value + " ,");
            //Console.WriteLine();

            List<string> l1 = new List<string> { "donna", "brenda", "andrea" };
            string[] names = new string[] { "donna", "jane", "gigi", "dana" };
            ISet<string> mySet = new HashSet<string>(l1);
            //mySet.UnionWith(names); //combines the two list
            //mySet.IntersectWith(names);//just the common from the two list
            mySet.SymmetricExceptWith(names);//just the uncomon elements from both

            foreach (string s in mySet) Console.WriteLine(s);
        }


    }
}
