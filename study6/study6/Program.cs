using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace study6
{
    class Program
    {
        static void Main(string[] args)
        {
            ////이진수를 정수로 변환
            //Console.Write("2진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine(); //문자열 입력 받음
            //int decimalValue = Convert.ToInt32(binaryInput, 2); // 2진수 -> 10진수 변환

            ////정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2); //10진수 -> 2진수 변환

            //Console.WriteLine($"입력한 이진수: {binaryInput}");
            //Console.WriteLine($"10진수로 변환: {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환: {binaryOutput}");

            //var를 사용하여 변수 선언
            //var name = "Alice"; //문자열로 추론
            //var age = 25; //정수로 추론
            //var isStudent = true;

            //Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");

            ////default 키워드 사용한 기본값 설정
            //int defaultInt = default;
            //string defaultString = default;
            //bool defaultBool = default;

            //Console.WriteLine($"정수 기본값: {defaultInt}");
            //Console.WriteLine($"문자열 기본값: {defaultString}");
            //Console.WriteLine($"논리값 기본값: {defaultBool}");

            //int a = 5, b = 3;

            //int sum = 0;
            //sum = a + b; //산술 연산자 사용
            //Console.WriteLine($"합은 {sum}");
            //sum = a - b;
            //Console.WriteLine($"차는 {sum}");
            //sum = a / b;
            //Console.WriteLine($"나눈 몫은 {sum}");

            //int c = 2, d = 5;

            //sum = d % c;
            //Console.WriteLine($"나눈 나머지는 {sum}");

            //int number = 7;
            //int sum = 0;

            //sum = number % 2; //0 나오면 짝수 1 나오면 홀수

            //Console.WriteLine("짝수 홀수 판별: " + sum);

            bool isEqual = false;
            int a = 5;
            int b = 2;

            //관계형 연사나
            isEqual = (a == b); //a랑 b가 같은가?

            Console.WriteLine("같은가?: " + isEqual);
        }
    }
}
