using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250224review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("2진수를 입력하세요: ");
            //이진수를 정수로 변환
            string binaryInput = Console.ReadLine(); //문자열로 입력 받기
            int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수 -> 10진수 변환
            //응용! 4진수에서 10진수로 변환하려면 Convert.ToInt32(quaternaryInput, 4)

           string binaryOutput = Convert.ToString(decimalValue, 2); //10진수 -> 2진수 변환

            Console.WriteLine($"입력한 이진수: {binaryInput}");
            Console.WriteLine($"10진수로 변환: {decimalValue}");
            Console.WriteLine($"다시 2진수로 변환: {binaryOutput}");


            //
            //
            //

            //var를 사용하여 변수 선언하기
            //var은 변수를 자동으로 추론해 주는 것!

            var name = "Jaemin"; //문자열으로 추론 (var가 string 역할 수행)
            var age = 26; //정수로 추론 (int 역할)
            var isStudent = false; //논리값으로 추론 (bool 역할)

            Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");

            //
            //
            //

            //*default 키워드 설정
            int defaultInt = default; //int의 기본값은 0이기 때문에 0으로 세팅
            string defaultString = default; //string의 기본값은 null이기 때문에 null으로 세팅
            bool defaultBool = default; //bool의 기본값은 false이기 때문에 false로 세팅

            Console.WriteLine($"정수의 기본값은 {defaultInt}이고 문자열의 기본값은 {defaultString}이며, 논리값의 기본값은 {defaultBool}입니다.");

            //
            //
            //

            //*변환 연산자
            double pi = 3.14;
            int integerPi = (int)pi; //실수형을 정수형으로 변환
            string strPi = integerPi.ToString(); //정수형을 문자열로 변환

            int kor = 90;
            int eng = 75;
            int math = 58;

            int sum = 0; float avr = 0; float avrFloat1 = 0; float avrFloat2 = 0;
            sum = kor + eng + math; avr = sum / 3; avrFloat1 = (float)sum / 3; avrFloat2 = sum / 3f;

            Console.WriteLine($"합계: {sum}");
            Console.WriteLine($"평균: {avr}");
            Console.WriteLine($"합계: {avrFloat1}");
            Console.WriteLine($"합계: {avrFloat2}");

            //
            //
            //

            //*할당 연산자
            int a, b, c, d, e;
            a = b = c = d = e = 10;
            a += 5;
            Console.WriteLine(a); //a = a + 5 , a = 15
            b -= 5;
            Console.WriteLine(b); //b = b - 5, b = 5
            c *= 5;
            Console.WriteLine(c); //c = c * 5, c = 50
            d /= 5;
            Console.WriteLine(d); //d = d / 5, d = 2
            e %= 5;
            Console.WriteLine(e); //e = e % 5, e = 0

            int iKor, iEng, iMath;
            iKor = iEng = iMath = 0;
            float avg = 0;

            Console.Write("국어 점수를 입력하세요: ");
            iKor = int.Parse(Console.ReadLine());
            Console.Write("수학 점수를 입력하세요: ");
            iMath = int.Parse(Console.ReadLine());
            Console.Write("영어 점수를 입력하세요: ");
            iEng = int.Parse(Console.ReadLine());

            sum = iKor + iMath + iEng;
            avg = (float)sum / 3;

            Console.WriteLine($"총점은 {sum}점입니다. 평균은 {avg:F2}점입니다.");

            int numA, numB = 0;
            Console.Write("정수를 입력하세요: ");
            numA = int.Parse(Console.ReadLine());
            numB = ~numA;
            Console.WriteLine($"입력 받은 정수 값: {numA}");
            Console.WriteLine($"비트 반전 후 정수 값: {numB}");

            int z = 3;
            Console.WriteLine(z--); //z = 3
            Console.WriteLine(--z); //z = 1

            bool ab = true; bool ba = false;
            Console.WriteLine(ab && ba);
            Console.WriteLine(ab || ba);
            Console.WriteLine(!ab);

            int number1, number2 = 0;
            string sign = "";
            int add, minus, multiply, div = 0;

            Console.Write("첫 번째 숫자를 입력하세요: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력하세요: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("연산자를 입력하세요: ");
            sign = Console.ReadLine();

            if (sign == "+")
            {
                add = number1 + number2;
                Console.Write($"결과: {add}");
            }
            else if (sign == "-")
            {
                minus = number1 - number2;
                Console.Write($"결과: {minus}");
            }
            else if (sign == "*")
            {
                multiply = number1 * number2;
                Console.Write($"결과: {multiply}");
            }
            else if(sign == "/"){
                if (number1 == 0 | number2 == 0)
                {
                    Console.Write("오류입니다.");
                }
                else
                {
                    div = number1 / number2;
                    Console.Write($"결과: {div}");
                }
            }

        }
    }
}
