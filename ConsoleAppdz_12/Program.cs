using ConsoleAppdz_12;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppdz_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            while (true)
            {
                Console.Write("\nEnter task (1 - 5): ");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Task1<double> task1 = new Task1<double>();
                        Console.Write("Enter  a: ");
                        double a = int.Parse(Console.ReadLine());
                        Console.Write("Enter  b: ");
                        double b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Before Swap method: a = {a}, b = {b}");
                        task1.Swap(ref a, ref b);
                        Console.WriteLine($"After Swap method: a = {a}, b = {b}");
                        break;
                    case 2:
                        Task2<int> priorityQueue = new Task2<int>((x, y) => x.CompareTo(y));
                        priorityQueue.Enqueue(5);
                        priorityQueue.Enqueue(10);
                        priorityQueue.Enqueue(3);
                        priorityQueue.Enqueue(8);
                        int peekItem = priorityQueue.Peek();
                        Console.WriteLine("with higher priority: " + peekItem);
                        while (priorityQueue.Count_element > 0)
                        {
                            int deleteItem = priorityQueue.Dequeue();
                            Console.WriteLine("Dequeued element: " + deleteItem);
                        }
                        priorityQueue.Dequeue();
                        break;
                    case 3:
                        Task3<int> circularQueue = new Task3<int>(5);
                        circularQueue.Enqueue(10);
                        circularQueue.Enqueue(20);
                        circularQueue.Enqueue(30);
                        circularQueue.Enqueue(40);
                        circularQueue.Enqueue(50);
                        Console.WriteLine("\nCount: " + circularQueue.Count);
                        int frontItem = circularQueue.Peek();
                        Console.WriteLine("Front element: " + frontItem);
                        while (circularQueue.Count > 0)
                        {
                            int dequeuedItem = circularQueue.Dequeue();
                            Console.WriteLine("Dequeued element: " + dequeuedItem);
                        }
                        circularQueue.Dequeue();
                        break;
                    case 4:
                        Task4<int> singleList = new Task4<int>();
                        singleList.AddFirst(10);
                        singleList.AddLast(20);
                        singleList.AddLast(30);
                        singleList.AddFirst(5);
                        Console.WriteLine("Count: " + singleList.count);
                        Console.WriteLine("List:");
                        singleList.Print();
                        singleList.RemoveFirst();
                        singleList.RemoveLast();
                        Console.WriteLine("New count: " + singleList.count);
                        Console.WriteLine("Updated list:");
                        singleList.Print();
                        break;
                    case 5:
                        Task5<int> doubleList = new Task5<int>();
                        doubleList.AddFirst(1);
                        doubleList.AddFirst(45);
                        doubleList.RemoveLast();
                        doubleList.AddLast(6);
                        doubleList.AddLast(2);
                        doubleList.RemoveFirst();
                        Console.WriteLine("Original list:");
                        doubleList.PrintForward();
                        Console.WriteLine("Reverse list:");
                        doubleList.PrintBackward();
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
        }
    }
}