﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            ////사용자 입력을 문자열로 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); // 사용자로부터 입력 받기

            //Console.WriteLine($"안녕하세요. {userName} 님!");

            //문자열을 정수로 변환
            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine(); // 사용자로부터 입력 받기
            //int age = int.Parse(input); //문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요!"); //변환된 값 사용
            //Console.WriteLine("내년에는 " + (age+1) + "살이 되겠군요!"); //문자열 + 정수
            //Console.WriteLine("내년에는 {0} 살이 되겠군요!", age+1);

            Console.Write("루인 스킬 피해 정도를 입력하세요: ");
            double ruin = double.Parse(Console.ReadLine());

            Console.Write("카드 게이지 획득량을 입력하세요: ");
            double card = double.Parse(Console.ReadLine());

            Console.Write("각성기 피해 정도를 입력하세요: ");
            double awakening = double.Parse(Console.ReadLine());

            Console.Write("최대 마나를 입력하세요: ");
            double mana = double.Parse(Console.ReadLine());

            Console.Write("전투 중 마나 회복량을 입력하세요: ");
            double plusmana = double.Parse(Console.ReadLine());

            Console.Write("비전투 중 마나 회복량을 입력하세요: ");
            double plusmana1 = double.Parse(Console.ReadLine());

            Console.Write("이동 속도를 입력하세요: ");
            double speed = double.Parse(Console.ReadLine());

            Console.Write("탈 것 속도를 입력하세요: ");
            double vehicle = double.Parse(Console.ReadLine());

            Console.Write("운반 속도를 입력하세요: ");
            double speed2 = double.Parse(Console.ReadLine());

            Console.Write("스킬 재사용 대기시간 감소를 입력하세요: ");
            double cooldownReduction = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- 입력된 값 ---");
            Console.WriteLine($"루인 스킬 피해: {ruin}%");
            Console.WriteLine($"카드 게이지 획득량: {card}%");
            Console.WriteLine($"각성기 피해: {awakening}%");
            Console.WriteLine($"최대 마나: {mana}");
            Console.WriteLine($"전투 중 마나 회복량: {plusmana}");
            Console.WriteLine($"비전투 중 마나 회복량: {plusmana1}");
            Console.WriteLine($"이동 속도: {speed}%");
            Console.WriteLine($"탈 것 속도: {vehicle}%");
            Console.WriteLine($"운반 속도: {speed2}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소: {cooldownReduction}%");
        }
    }
}