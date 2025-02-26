using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _250226quest
{
    class Program
    {
        static void Main(string[] args)
        {
            ////문제 1: 크기가 5인 정수 배열을 만들고, {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.
            //int[] iNum = new int[5] { 10, 20, 30, 40, 50 };
            //for (int i =0; i<iNum.Length;i++)
            //{
            //    Console.WriteLine(iNum[i] + " ");
            //}

            //Console.WriteLine();

            ////문제 2: 사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.
            //int[] iNum = new int[5];
            //int sum = 0;
            //Console.WriteLine("숫자를 다섯 개 입력하세요.");
            //for (int i = 0; i < iNum.Length; i++)
            //{
            //    iNum[i] = int.Parse(Console.ReadLine());
            //    sum += iNum[i];
            //}
            //Console.WriteLine($"입력하신 숫자의 총합은 {sum}입니다.");

            ////문제 3: 정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.
            //int[] iNum = { 3, 8, 15, 6, 2 };
            //int max = iNum[0];

            //for (int i = 1; i < iNum.Length; i++)
            //{
            //    if (iNum[i] > max)
            //    {
            //        if (iNum[i] > max)
            //        {
            //            max = iNum[i];
            //        }
            //    }
            //}
            //Console.WriteLine($"최댓값은 {max}입니다.");

            ////문제 4: for문을 사용하여 1부터 10까지 출력하세요.
            //for (int i =1; i < 11; i++)
            //{
            //    Console.Write(i + " ");
            //}

            ////문제 5: while문을 사용하여 1부터 10까지 중 짝수만 출력하세요.
            //int i = 1;
            //while(i < 11)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    i++;
            //}

            ////문제 6: foreach문을 사용하여 배열 {1, 2, 3, 4, 5}의 요소를 출력하세요.
            //int[] iNum = { 1, 2, 3, 4, 5 };
            //foreach (int i in iNum)
            //{
            //    Console.Write(i + " ");
            //}

            //    //문제 7: 두 개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.
            //    Console.Write("첫 번째 정수를 입력하세요: ");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.Write("두 번째 정수를 입력하세요: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = Add(num1, num2);
            //    Console.WriteLine($"{num1}과 {num2}의 합은 {result}입니다.");
            //}
            //static int Add(int num1, int num2)
            //{
            //    return num1 + num2;
            //}

            //    //문제 8: 문자열을 입력받아 길이를 반환하는 함수를 작성하세요.
            //    Console.WriteLine("문자열을 입력하세요: ");
            //    string sentence = Console.ReadLine();

            //    int result = calculate(sentence);
            //    Console.WriteLine($"{sentence}의 길이는 {result}입니다.");
            //}
            //static int calculate(string sentence)
            //{
            //    return sentence.Length;
            //}

            //문제 9: 세 개의 정수를 입력받아 가장 큰 값을 반환하는 함수를 작성하세요.
            Console.Write("첫 번째 정수를 입력하세요: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수를 입력하세요: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("세 번째 정수를 입력하세요: ");
            int num3 = int.Parse(Console.ReadLine());

            int result = Max(num1, num2, num3);
            Console.WriteLine($"최댓값은 {result}입니다.");
        }
        static int Max(int num1, int num2, int num3)
        {
            int maxnum = 0;
            if (num1 > num2 && num1 > num3)
            {
                maxnum = num1;
            }
            else if (num2 > num1 && num2>num3)
            {
                maxnum = num2;
            }
            else
            {
                maxnum = num3;
            }
            return maxnum;
        }
    }
}
