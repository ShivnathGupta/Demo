using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //It is recommended to use ArrayList type of variable for ArrayList object
            //because ArrayList class contains some additional methods
            //which are not the members of "IList" interface 
            //such as "AddRange()", "BinarySearch()", "Repeat()", "Reverse()", etc.
            //ArrayList is a non - generic type of collection in C#.
            
            //Declaring ArrayList
            ArrayList myArryList = new ArrayList(); // Recommended
            myArryList.Add(1);

            //Creating IList
            IList arryList2 = new ArrayList() { 100, 200 };
            //Adding entire collection using ArrayList.AddRange() method.
            myArryList.AddRange(arryList2);

            //insert a single item at the specified index.
            myArryList.Insert(2, 800);

            IList arryList1 = new ArrayList();
            arryList1.Add(1080);
            arryList1.Add(20640);

            //insert all the values from another collection into ArrayList at the specfied index.
            myArryList.InsertRange(2, arryList1);

            //Display ArrayList
            foreach (var i in myArryList)
            {
                Console.WriteLine("Display data "+i);
            }


            //Remove a specified element from an ArrayList.
            myArryList.Remove(100);

            //Display ArrayList
            foreach (var i in myArryList)
            {
                Console.WriteLine("Removing 100 "+i);
            }

            //remove an element from the specified index location.
            myArryList.RemoveAt(1);

            //Display ArrayList
            foreach (var i in myArryList)
            {
                Console.WriteLine("Removing index 1 "+i);
            }

            // or - with some limitations
            IList myArryList1 = new ArrayList();



            // or - with some limitations
            ICollection myArryList2 = new ArrayList();
            myArryList2 = arryList2;

            //You can't Print Like this Because Indexing is not apply on IColletion and IEnumerable
            //Console.WriteLine("dsf" + myArryList2[0]);

            // or - with some limitations
            IEnumerable myArryList3 = new ArrayList();




       
            //SortedList
            SortedList sortedList1 = new SortedList();

            //Adding Value in SortedList
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");
            string data = (string)sortedList1[1];
            Console.WriteLine("Display Specific value "+data) ;
            //SortedList includes key-value pairs.
            //So, the type of element would be DictionaryEntry rather than the type of a key or a value.
            foreach (DictionaryEntry val in sortedList1)
            {
                Console.WriteLine(val.Key + " " + val.Value);
            }
            //It Will not give any Error if the value is not present on that Index
            Console.WriteLine("Assing With Key "+sortedList1[0]);
            Console.WriteLine("Assing With Key " + sortedList1[1]);
            Console.WriteLine("Assing With Key " + sortedList1[2]);

            //You can't pass the value directly it give an error message
            //Console.WriteLine("Assing With Key " + sortedList1["One"]);



            Console.WriteLine("\n");

            //Hashtable
            Hashtable ht = new Hashtable();
            //Adding value in Hashtable
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, null);
            ht.Add("Fv", "Five");
            ht.Add(8.5F, 8.5);
            //Display data
            foreach (DictionaryEntry item in ht)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);


            //unboing the type
            string strValue1 = (string)ht[2];
            Console.WriteLine(strValue1);

            //For New Line
            Console.WriteLine("\n");

            //Hashtable store data in object
            Hashtable hte = new Hashtable()
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 5, null },
                    { "Fv", "Five" },
                    { 8.5F, 8.5 }
                };
            //Display data
            foreach (var key in hte.Keys)
            {
                Console.WriteLine("Hashtable Key:{0}, Value:{1}", key, hte[key]);

            }

            //Hashtable is a non - generic collection so it can contains a key and a value of any data type.
            //So values must be cast to an appropriate data type otherwise it will give compile - time error.
            //Hashtable can include all the elements of Dictionary as shown below.
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            //adding Dictionary to Hashtable
            Hashtable ht1 = new Hashtable(dict);

            //Display data
            foreach (var key in ht1.Keys)
            {
                Console.WriteLine("Key:{0}, Value:{1}", key, ht1[key]);

            }





            //Stack
            Stack myStack = new Stack();
            myStack.Push("Hello!!");
            myStack.Push(null);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            foreach (var itm in myStack)
                Console.WriteLine("Stack "+itm);

            //The Peek() method returns the last (top-most) value from the stack.
            Console.WriteLine("Peek "+myStack.Peek());

            //Queue
            Queue queue = new Queue();
            //Add elements of any datatype into a queue using the Enqueue() method.
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue("Four");
            foreach(var item in queue)
            {
                Console.WriteLine("Queue "+item);
            }


           
            Console.Read();

        }
    }
}
