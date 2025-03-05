using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study24
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            //names.Add("Dave");
            //names.Remove("Bob");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(list[1]);
            //list.Insert(1, 100);
            //Console.WriteLine(list[1]);

            //Console.WriteLine(list[0]);

            //list.Insert(1, 100);
            //Console.WriteLine(list.Count);

            //list[2] = 200;

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //Queue queue = new Queue();

            //queue.Enqueue("q");
            //queue.Enqueue("w");
            //queue.Enqueue("e");
            //queue.Enqueue("r");
            //queue.Enqueue("점멸");
            //queue.Enqueue("평타");


            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            //Queue queue = new Queue();

            //queue.Enqueue("→");
            //queue.Enqueue("↓");
            //queue.Enqueue("↘");
            //queue.Enqueue("→");
            //queue.Enqueue("풍신권");



            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}


            //Console.WriteLine(queue.Count);

            //ArrayList 생성
            //크기가 동적으로 조정되는 배열, 다양한 형식의 데이터를 저장할수있다.
            //ArrayList arrayList = new ArrayList();

            ////요소추가
            //arrayList.Add(1);  //정수
            //arrayList.Add("Hello");  //문자열
            //arrayList.Add(3.14);    //실수


            ////요소 접근
            //Console.WriteLine("ArrayList 요소: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            ////요소 제거
            //arrayList.Remove(1);

            //Console.WriteLine("\n ArrayList요소 제거 후: ");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> stack = new Stack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");


            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Dictionary<string, int> ages = new Dictionary<string, int>();

            //ages["금도끼"] = 10;
            //ages["은도끼"] = 5;
            //ages["돌도끼"] = 1;

            //foreach (var pair in ages)
            //{
            //    Console.WriteLine($"{pair.Key} : {pair.Value}");
            //}

            //int? nullableInt = null;

            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //nullableInt = 10;

            //Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //null 값을 다루는 연산자 소개하기 ??, ? 연산자
            //?? 연산자를 사용해 null인 경우 대체값을 제공하고 ?.은 null안전 접근을 합니다.

            //string str = null;

            //if (str == null)
            //{
            //    Console.WriteLine("DefaultValue"); //str이 null이면 DefaultValue 출력
            //}

            //Console.WriteLine(str ?? "DefaultValue");//str이 null이면 "Default Value

            ////LINQ는 확장메서드 형태로 제공된다. 
            ////LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수있습니다.
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //var evenNumbers = numbers.Where(n => n % 2 == 0);

            //foreach (var num in evenNumbers)
            //{
            //    Console.WriteLine(num);
            //}
        }
    }
}


