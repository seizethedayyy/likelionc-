using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 콘솔좌표배우기
{
    class Program
    {
        static void Main(string[] args)
        {
            ////콘솔 버퍼 크기도 설정 (스크롤 없이 고정된 창 유지)
            //Console.SetBufferSize(80, 25);
            //Console.CursorVisible = false; //커서 숨기기
            //Console.Clear(); //화면 지우기
            //Console.SetCursorPosition(0, 0);
            //Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            //Console.SetCursorPosition(0, 1);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 2);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 3);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 4);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 5);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 6);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 7);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 8);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 9);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 10);
            //Console.Write("┃           대장장이 키우기           ┃");
            //Console.SetCursorPosition(0, 11);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 12);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 13);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 14);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 15);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 15);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 16);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 17);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 18);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 19);
            //Console.Write("┃                                     ┃");
            //Console.SetCursorPosition(0, 20);
            //Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            //Thread.Sleep(3000);

            //Console.Clear();

            //for (int x = 0; x < 30; x++) // 0~29 이동
            //{
            //    Console.Clear();
            //    Console.SetCursorPosition(x, 10);
            //    Console.Write("◎");
            //    Thread.Sleep(100);
            //}


            //250525
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);
            Random rand = new Random();
            int hp = 100;
            int battery = 100;
            int money = 1000;
            int input;
            bool isAlive = true;

            //콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);

            //콘솔 버퍼 크기도 설정 (스크롤 없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false; //커서 숨기기
            Console.Clear(); //화면 지우기
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 2);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 3);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 5);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 6);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 7);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 8);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 9);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 10);
            Console.Write("┃            어둠의 방탈출            ┃");
            Console.SetCursorPosition(0, 11);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 12);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 13);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 14);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 16);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 17);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                     ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Thread.Sleep(3000);

            Console.Clear();

            for (int x = 0; x < 30; x++) // 0~29 이동
            {
                Console.Clear();
                Console.SetCursorPosition(x, 10);
                Console.Write("👻");
                Thread.Sleep(100);
            }

            Console.Clear();

            while (isAlive)
            {
                Console.WriteLine($"현재 상태: 체력 {hp} | 캐시 {money} | 손전등 배터리 {battery}");
                Console.WriteLine("\n🌃 1. 둘러보기 🌃");
                Console.WriteLine("💰 2. 상점 들리기 💰");
                Console.WriteLine("🔚 3. 종료하기 🔚");
                Console.Write("무엇을 하시겠습니까? ");

                input = int.Parse(Console.ReadLine());

                if (input == 1) //둘러보기
                {
                    Console.Clear();
                    Console.WriteLine("어둠의 방을 둘러봅시다!");
                    Thread.Sleep(500);
                    Console.WriteLine("깊숙이...");
                    Thread.Sleep(500);
                    Console.WriteLine("깊숙...");
                    Thread.Sleep(500);
                    Console.WriteLine("깊...");
                    Thread.Sleep(500);
                    Console.WriteLine("...");

                    int gameEvent = rand.Next(1, 101);

                    if (gameEvent <= 20) //20% 확률 (캐시 잃음)
                    {
                        int minus = rand.Next(100, 501);
                        Console.WriteLine($"정체 불명의 사람을 만났습니다. 어두워 앞을 보지 못하는 사이 {minus} 캐시를 뺏기고 말았습니다!");
                        money -= minus;
                    }
                    else if (gameEvent <= 30) //10% 확률 (손전등 배터리 충전)
                    {
                        int plus = rand.Next(10, 101);
                        Console.WriteLine($"배터리를 주웠습니다. 끼워 보니 손전등이 {plus}만큼 충전되었습니다.");
                        battery += plus;
                    }
                    else if (gameEvent <= 50) //20% 확률 (체력 충전)
                    {
                        int energy = rand.Next(10, 51);
                        Console.WriteLine($"안전해 보이는 곳을 찾았습니다. 몇 분 눈을 붙여도 될 것 같습니다. (체력 +{energy}");
                        hp += energy;
                    }
                    else if (gameEvent <= 70) //20% 확률 (캐시 획득)
                    {
                        int saving = rand.Next(10, 101);
                        Console.WriteLine($"{saving} 캐시가 든 캐시 주머니를 주웠습니다.");
                        money += saving;
                    }
                    else
                    {
                        int tired = rand.Next(10, 51);
                        Console.WriteLine($"큰 소득이 없었습니다... (체력이 {tired}만큼 감소했습니다.");
                        hp -= tired;
                    }

                    if (hp <= 0)
                    {
                        Console.WriteLine("체력을 소진했습니다. 탈출에 실패했습니다.");
                    }
                }
                else if (input == 2)
                {
                    if (money >= 500)
                    {
                        money -= 500;
                        Console.Clear();
                        Console.WriteLine("아이템 뽑는 중...");
                        Thread.Sleep(700);

                        int rnd = rand.Next(1, 101);
                        if (rnd <= 40)
                        {
                            Console.WriteLine("체력이 10 늘었습니다!");
                            hp += 40;
                        }
                        else if (rnd <= 80)
                        {
                            Console.WriteLine("캐시가 30 늘었습니다!");
                            money += 30;
                        }
                        else
                        {
                            Console.WriteLine("체력이 20, 캐시가 10 늘었습니다!");
                            hp += 20;
                            money += 10;
                        }
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("캐시가 부족합니다. (기본 500 캐시 필요)");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("게임을 종료합니다!");
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
