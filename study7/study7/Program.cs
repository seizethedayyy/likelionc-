using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 5;
            //bool flag = true;
            //Console.WriteLine(+number); //양수 출력
            //Console.WriteLine(-number); //음수 출력

            //Console.WriteLine(!flag); //논리 부정

            //int num = 10;
            //int result = ~num; //모든 비트 반전: 1111 0101 결과

            //Console.WriteLine("원래 값: " + num);
            //Console.WriteLine("~ 연산자 적용 후: " + result);

            ////캐스팅
            //double pi = 3.14;
            //int integerPi = (int)pi; //실수형 -> 정수형으로 변환

            //Console.WriteLine(integerPi); //3

            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;

            //int sum = 0;
            //float average = 0.0f;

            //sum = iKor + iEng + iMath;

            //average = (float)sum / 3; //평균
            //Console.WriteLine("총점: " +sum);
            //Console.WriteLine("평균: " +average);

            //int a = 10, b = 3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName);

            //int a = 10;
            //a += 5; //a = a + 5;
            //Console.WriteLine(a); //15
            //a -= 5; //a = a - 5;
            //Console.WriteLine(a); //10
            //a *= 5; //a = a*  5;
            //Console.WriteLine(a); //50
            //a /= 5; //a = a / 5;
            //Console.WriteLine(a); //10
            //a %= 5; //a = a % 5;
            //Console.WriteLine(a); //0


            //문제 1
            Console.Write("국어 점수를 입력하세요: ");
            int iKor = int.Parse(Console.ReadLine());
            Console.Write("영어 점수를 입력하세요: ");
            int iEng = int.Parse(Console.ReadLine());
            Console.Write("수학 점수를 입력하세요: ");
            int iMath = int.Parse(Console.ReadLine());

            int sum = 0;
            sum = iKor + iEng + iMath;
            float average = (float)sum / 3;
            Console.WriteLine("총점은 " + sum);
            Console.WriteLine("평균은 " + average.ToString("F2"));

            //문제 2
            int num = int.Parse(Console.ReadLine());
            int result = ~num;

            Console.WriteLine("기존 값은 " + num);
            Console.WriteLine("~ 연산자 적용 값은 " + result);
        }
    }
}
