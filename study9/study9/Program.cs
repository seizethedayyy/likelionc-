﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int day = 1;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일");
            //        break;
            //    default:
            //        Console.WriteLine("주말입니다.");
            //        break;


            //캐릭터를 선택하세요: {1. 검사 2. 마법사 3. 도적)
            //switch

            //Console.Write("캐릭터를 선택하세요: ");
            //int character = int.Parse(Console.ReadLine());
            //switch (character)
            //{
            //    case 1:
            //        Console.WriteLine("검사를 선택했습니다.");
            //        Console.WriteLine("공격력: 100");
            //        Console.WriteLine("방어력: 90");
            //        break;
            //    case 2:
            //        Console.WriteLine("마법사를 선택했습니다.");
            //        Console.WriteLine("공격력: 110");
            //        Console.WriteLine("방어력: 80");
            //        break;
            //    case 3:
            //        Console.WriteLine("도적을 선택했습니다.");
            //        Console.WriteLine("공격력: 115");
            //        Console.WriteLine("방어력: 70");
            //        break;
            //    default:
            //        Console.WriteLine("캐릭터가 존재하지 않습니다.");
            //        break;

            //반복문
            //초기화 / 조건문 / 증감식
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("숫자: " + i);
            //}

            ////무한 반복
            //for (; ; )
            //{
            //    Console.WriteLine("중요한 건 꺾이지 않는 마음");
            //}

            ////0부터 9까지 출력하기
            //for (int i = 0; i <=9; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////1부터 10까지의 합 구하기
            //int sum = 0;
            //for (int i = 1; i <=10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //int count = 1; //초기화
            //while(count <= 5) //조건식
            //{
            //    Console.WriteLine("Count: " + count);
            //    count++; // 증가, 감소

            //    if (count == 3)
            //    {
            //        Console.WriteLine("3일 때 반복문 탈출");
            //        break;
            //    }
            //}
            //Console.WriteLine("Count: " + count);

            //랜덤
            //Random rand = new Random(); //Random 객체 생성

            ////0 이상 10 미만의 랜덤 정수 생성
            //for (int i = 0; i<100; i++)
            //{
            //    int randomNumber = rand.Next(5, 15); //0~9
            //    Console.WriteLine("5 이상 15 미만의 랜덤 정수: " + randomNumber);
            //}

            //대장장이 키우기
            //도끼 등급 SSS  10%
            //도끼 등급 SS   40%
            //도끼 등급 S    50%

            //Random rand = new Random(); //랜덤 값을 뽑는 문장

            //int rnd = 0;

            //for (int i = 0; i<20; i++)
            //{
            //    rnd = rand.Next(1, 101); //1~100

            //    if (rnd >= 1 && rnd <= 10)
            //    {
            //        Console.WriteLine("도끼 등급 SSS");
            //    }
            //    else if (rnd >= 11 && rnd <= 40)
            //    {
            //        Console.WriteLine("도끼 등급 SS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("도끼 등급 S");
            //    }
            //    Thread.Sleep(500); //0.5초 정도로 뽑아라.

            //do while
            //1회 무조건 실행하고 while문과 같이 조건 진행

            //int x = 5;
            //do
            //{
            //    Console.WriteLine("최소 한 번은 실행됩니다.");
            //    x--;
            //}
            //while (x > 0);

            //break 문
            //반복문을 탈출할 수 있다.
            //for(int i = 1; i <=10; i++)
            //{
            //    if(i==5)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}

            //continue
            //현재 반복을 건너뛰고 다음 반복으로 넘어간다.

            //for(int i = 1; i <=10; i++)
            //{
            //    if (i % 2 == 0) continue;
            //    Console.WriteLine(i); //홀수만 출력
            //}

            //goto
            int n = 1;
            start:
            if (n<=5)
            {
                Console.WriteLine(n);
                n++;

                goto start; //레이블로 이동
            }

        }
    }
}
