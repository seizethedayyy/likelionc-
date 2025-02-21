using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace likelion4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////            // 문자열
            ////            string greeting; // 문자열 변수를 선언
            ////            greeting = "Hello, World!"; // 변수에 값을 저장

            ////            // 변수의 값을 사용
            ////            Console.WriteLine(greeting); // 출력 : Hello, World!

            //// 변수 선언과 초기화를 한번에 수행
            //int score = 100; // 정수형 변수 선언과 동시에 100으로 초기화
            //double temperature = 36.5; // 실수형 변수 선언과 초기화
            //string city = "Seoul"; // 문자여 ㄹ변수 선언과 초기화

            //// 변수 출력
            //Console.WriteLine(score); // 출력 100
            //Console.WriteLine(temperature); // 출력 36.5
            //Console.WriteLine(city); // 출력 : Seoul

            //int x = 10, y = 20, z = 30; // 정수형 변수 x, y, z를 선언하고 초기화

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //const double Pi = 3.14159; // 상수 pi 선언 및 초기화
            //const int MaxScore = 100; // 정수형 상수 선언

            //// 출력
            //Console.WriteLine("Pi: " + Pi); // 출력 Pi: 3.14159
            //Console.WriteLine("Max Score: " + MaxScore); // 출력 MaxScore: 100

            const int att = 16755;
            const int hp = 78103;
            const int hurt = 36;
            const int sp = 1017;
            const int protect = 41;
            const int speed = 611;
            const int stand = 22;
            const int practice = 39;

            Console.WriteLine("공격력: " + att);
            Console.WriteLine("최대 생명력: " + hp);
            Console.WriteLine("치명: " + hurt);
            Console.WriteLine("특화: " + sp);
            Console.WriteLine("제압: " + protect);
            Console.WriteLine("신속: " + speed);
            Console.WriteLine("인내: " + stand);
            Console.WriteLine("숙련: " + practice);
        }
    }
}
