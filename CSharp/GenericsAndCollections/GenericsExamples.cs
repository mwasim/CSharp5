using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GenericsAndCollections
{
    public class GenericsExamples
    {
        public static void GenericSwap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        public static void ListExample()
        {
            var lst = new List<string> { "Apple", "Mango", "Orange", "Banana", "Pineapple" };

            Console.WriteLine("List Capacity: {0}", lst.Capacity);
            Console.WriteLine("List Elements");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nElements Count: {0}", lst.Count);
            Console.WriteLine("Elements:");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }

            lst.Remove("Orange");
            Console.WriteLine("\nAfter removing Orange, elements Count: {0}", lst.Count);
            Console.WriteLine("Elements:");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }

            lst.Insert(2, "Grapes");
            Console.WriteLine("\nAfter inserting Grapes, elements Count: {0}", lst.Count);
            Console.WriteLine("Elements:");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }

            lst.Sort();
            Console.WriteLine("\nAfter sorting, elements Count: {0}", lst.Count);
            Console.WriteLine("Elements:");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }

            Console.Write("\n\nEnter name to search:");
            var searchTerm = Console.ReadLine();

            var index = lst.IndexOf(searchTerm);
            if (index != -1)
            {
                Console.WriteLine("Element found at index: {0}, Element: {1}", index, lst[index]);
            }
            else
            {
                Console.WriteLine("The element {0} not found in the list.", searchTerm);
            }

            lst.Clear();
            Console.WriteLine("After clearing the list, elements count is {0}", lst.Count);

        }

        public static void ListOfObjects()
        {
            var empList = new List<Employee> {
                new Employee(103, 4500, "Laura"),
                new Employee(101, 5000, "John"),
                new Employee(102, 6500, "Kelly"),
            };

            Console.WriteLine("Unsorted List of employees.");
            Console.WriteLine("Code\tName\tBasic Salary");
            foreach (var emp in empList)
            {
                Console.WriteLine("{0}\t{1}\t{2}", emp.Code, emp.Name, emp.BasicSalary);
            }

            var filteredEmpList = empList.FindAll(delegate (Employee emp) { return emp.BasicSalary < 6000; });
            //var filteredEmpList2 = empList.FindAll(emp => emp.BasicSalary < 6000);
            Console.WriteLine("Employees with salary less than $6000");
            filteredEmpList.ForEach(delegate (Employee emp)
            {
                Console.WriteLine("{0}\t{1}\t{2}", emp.Code, emp.Name, emp.BasicSalary);
            });

            //filteredEmpList.ForEach(emp =>
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}", emp.Code, emp.Name, emp.BasicSalary);
            //});

            empList.Sort(delegate (Employee emp1, Employee emp2)
            {
                return emp1.Name.CompareTo(emp2.Name);
            });

            //empList.Sort((emp1, emp2) =>
            //{
            //    return emp1.Name.CompareTo(emp2.Name);
            //});

            Console.WriteLine("Sorted List of employees by name.");
            Console.WriteLine("Code\tName\tBasic Salary");
            foreach (var emp in empList)
            {
                Console.WriteLine("{0}\t{1}\t{2}", emp.Code, emp.Name, emp.BasicSalary);
            }

        }

        public static void QueueExample()
        {
            var queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine("Dequeued first element: {0}", queue.Dequeue());
            Console.WriteLine("First element: {0}", queue.Peek());
            Console.WriteLine("Dequeued first element: {0}", queue.Dequeue());
            Console.WriteLine("Queue elements count: {0}", queue.Count);
        }

        public static void StackExample()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Pop top element: {0}", stack.Pop());
            Console.WriteLine("Last element: {0}", stack.Peek());
            Console.WriteLine("Pop top element: {0}", stack.Pop());
            Console.WriteLine("Stack elements count: {0}", stack.Count);
        }

        public static void SortedSetExample()
        {
            var foodItems = new SortedSet<string>() { "Hot Dog", "Pizza", "Burger", "Noodles", "Hot Dog" };
            var foodList = new List<string>();

            Console.WriteLine("Food Items Count: {0}", foodItems.Count);
            Console.WriteLine("Food Items");
            foreach (var item in foodItems)
            {
                Console.WriteLine(item);
            }

            foodItems.Remove("Burger");
            foodItems.RemoveWhere(item => item.StartsWith("N"));

            Console.WriteLine("\n\nAfter Removing, Rest of the Food Items Are");
            foreach (var item in foodItems)
            {
                Console.WriteLine(item);
            }

            foodList.Add("Pizza");
            foodList.Add("Taco");
            foodList.Add("French Fries");
            foodList.Add("Hot Dog");

            foodItems.UnionWith(foodList);
            Console.WriteLine("\n\nAfter Removing, Rest of the Food Items Are, with count: {0}", foodItems.Count);
            foreach (var item in foodItems)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\nMin Item: {0}", foodItems.Min);
            Console.WriteLine("\n\nMax Item: {0}", foodItems.Max);

            var foodItems2 = new SortedSet<string> { "Pizza", "Taco" };

            Console.WriteLine("\n\nFood Items 2");
            foreach (var item in foodItems2)
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine("\n\nFood Items is superset of food items 2: {0}", foodItems.IsSupersetOf(foodItems2));
            Console.WriteLine("Food Items 2 is subset of food items: {0}", foodItems2.IsSubsetOf(foodItems2));
            Console.WriteLine("Food Items 2 is a proper subset of food items: {0}", foodItems2.IsProperSubsetOf(foodItems2));

            //foodItems.SymmetricExceptWith(foodItems2);
            //Console.WriteLine("\n\nAfter SymmetricExceptWith, Rest of the Food Items Are, with count: {0}", foodItems.Count);
            //foreach (var item in foodItems)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("\n\nFood Items overlaps food items 2: {0}", foodItems.Overlaps(foodItems2));
            foodItems.IntersectWith(foodItems2);
            Console.WriteLine("\n\nAfter IntersectWith, Rest of the Food Items Are, with count: {0}", foodItems.Count);
            foreach (var item in foodItems)
            {
                Console.WriteLine(item);
            }

            foodItems.Clear();
            Console.WriteLine("\n\nAfter clearing, items count: {0}", foodItems.Count);
        }

        public static void DictionaryExample()
        {
            var priceList = new Dictionary<string, int>();

            priceList.Add("Pizza", 15);
            priceList.Add("Burger", 6);
            priceList.Add("Noodles", 5);
            priceList.Add("Hot Dog", 2);

            Console.WriteLine("Items Count: {0}", priceList.Count);
            Console.Write("\nEnter Item Name:");
            var str = Console.ReadLine();
            if (priceList.ContainsKey(str))
            {
                Console.WriteLine("Price of searched item based on term '{0}' is {1}", str, priceList[str]);
            }
            else
            {
                Console.WriteLine("Item based on term '{0}' is not found.", str);
            }

            var foodNameList = new List<string>(priceList.Keys);
            Console.WriteLine("\n\nFood Items are");
            foreach (var item in foodNameList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\nComplete Price List:");
            foreach (KeyValuePair<string, int> pair in priceList)
            {
                Console.WriteLine("Item: {0}, Price: {1}", pair.Key, pair.Value);
            }


            priceList.Remove("Pizza");
            Console.WriteLine("\n\nAfter removing an item, items count: {0}", priceList.Count);
        }

        public static void LinkedListExample()
        {
            var list = new LinkedList<int>();

            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            Console.WriteLine("Elements in the Linked List");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.AddFirst(8);
            list.AddFirst(3);

            Console.WriteLine("\n\nAfter adding two elements in the beginning.");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            var node = list.Find(20);
            list.AddBefore(node, 15);

            Console.WriteLine("\n\nAfter adding 15 before 20, elements in the beginning.");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.AddLast(80);
            Console.WriteLine("\n\nAfter adding 80 at the end, elements in the beginning.");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Employee
    {
        public int Code { get; set; }
        public int BasicSalary { get; set; }
        public string Name { get; set; }

        public Employee(int c, int basicSalary, string name)
        {
            Code = c;
            BasicSalary = basicSalary;
            Name = name;
        }
    }
}
