using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace study8
{
    class Program
    {
        static void Main(string[] args)
        {
            //두 값을 비교하여 관계를 평가한다.
            // == 같다 / != 같지 않다 / a < b / c > d

            //int x = 5, y = 10;
            //Console.WriteLine(x < y); //True
            //Console.WriteLine(x > y); //False
            //Console.WriteLine(x == y); //False
            //Console.WriteLine(x != y); // True
            //Console.WriteLine(x >= y); //False
            //Console.WriteLine(x <= y); //True

            //논리 연산자
            //bool a = true, b = false;
            //Console.WriteLine(a && b);
            ////AND : 1 : 1 t
            ////      1 : 0 f
            ////      0 : 1 f
            ////      0 : 0 f
            //Console.WriteLine(a || b);
            ////OR : 1 : 1 t
            ////   : 1 : 0 t
            ////   : 0 : 1 t
            ////   : 0 : 0 f

            //bool a = false;
            //bool b = false;

            //b = !a;

            //Console.WriteLine(b); //True

            ////비트연산자
            //int x = 5; //0101
            //int y = 3; //0011

            //Console.WriteLine(x & y); //AND : 1 (0001)
            //Console.WriteLine(x | y); //OR : 7 (0111)
            //Console.WriteLine(x ^ y); //XOR : 6 (0110)
            //Console.WriteLine(~x); //NOT : -6
            //Console.WriteLine(~y); //NOT : -4

            //int value = 4; //0100
            //Console.WriteLine(value << 1); //왼쪽 이동 8 {1000}
            //Console.WriteLine(value >> 1); //오른쪽 이동 2 (0010)

            //int a = 10, b = 20;
            //int max;
            //max = (a > b) ? a : b; //삼항 연산자, max = 20;
            ////       f      t   f
            //Console.WriteLine(max);
            ////)(비교) ? 참 : 거짓;

            //int key = 1;
            //string str;
            //str = (key == 1) ? "문이 열렸습니다." : "문이 닫혔습니다.";

            //Console.WriteLine(str);

            //int result = 10 + 2 * 5; //곱셈이 덧셈보다 우선
            //Console.WriteLine(result);

            ////int adjustedResult = (10 + 2) * 5; //괄호 우선순위 먼저 계산
            ////Console.WriteLine(adjustedResult);

            //string GameID = "멋사검존";

            //if(GameID == "멋사검존")
            //{
            //    Console.WriteLine("아이디가 일치합니다.");
            //}
            //else
            //{
            //    Console.WriteLine("아이디가 일치하지 않습니다.");
            //}

            //int score = 95;
            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}

            //else if (score >= 70)
            //{
            //    Console.WriteLine("C 학점");
            //}

            //else
            //{
            //    Console.WriteLine("F 학점");
            //}

            //Console.Write("캐릭터 이름을 입력하세요: ");
            //string name = (Console.ReadLine());
            //Console.Write("가지고 있는 소지금을 입력하세요: ");
            //int cash = int.Parse(Console.ReadLine());
            //int att = 100;
            //string item;

            //if(cash >=700)
            //{
            //    item = "전설의 검";
            //    att += 7;
            //}
            //else if (cash >= 600)
            //{
            //    item = "유령검";
            //    att += 6;
            //}
            //else if (cash >= 500)
            //{
            //    item = "엑스칼리버";
            //    att += 5;
            //}
            //else if (cash >= 400)
            //{
            //    item = "집판검";
            //    att += 4;
            //}
            //else if (cash >= 300)
            //{
            //    item = "진은검";
            //    att += 3;
            //}
            //else if (cash >= 200)
            //{
            //    item = "카타나";
            //    att += 2;
            //}
            //else
            //{
            //    item = "무한의 대검";
            //    att += 1;
            //}
            //Console.WriteLine("캐릭터 이름: " + name);
            //Console.WriteLine("소지 무기: " + item);
            //Console.WriteLine("공격력: " + att);


            //오후 문제 1
            Console.Write("첫 번재 정수를 입력하세요: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("두 번재 정수를 입력하세요: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("세 번재 정수를 입력하세요: ");
            int c = int.Parse(Console.ReadLine());

            int num;

            if (a > b && a > c)
            {
                num = a;
            }
            else if(b > a && b > c)
            {
                num = b;
            }
            else
            {
                num = c;
            }
                Console.WriteLine("최대값: " + num);
            

            //오후 문제 2
            Console.Write("점수를 입력하세요: ");
            int score = int.Parse(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");
            }

            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }

            else if (score >= 60)
            {
                Console.WriteLine("D 학점");
            }

            else
            {
                Console.WriteLine("F 학점");
            }

            //오후 문제 3
            Console.Write("첫 번째 숫자를 입력하세요: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수를 입력하세요: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("연산자를 입력하세요: ");
            string cal = Console.ReadLine();

            int result;
            if (cal == "+")
            {
                result = num1 + num2;
                Console.WriteLine("결과: " + result);
            }
            else if (cal == "-")
            {
                result = num1 - num2;
                Console.WriteLine("결과: " + result);
            }
            else if (cal == "*")
            {
                result = num1 * num2;
                Console.WriteLine("결과: " + result);
            }
            else if (cal == "/")
            {
                if (num1 == 0 | num2 ==0)
                    {
                    Console.WriteLine("에러가 발생했습니다.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("결과: " + result);
                }
            }
        }
    }
}
