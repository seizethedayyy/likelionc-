using System;
using System.Diagnostics;
using System.Threading;

namespace ShootingGame1
{
    class Program
    {
        static string[] player = new string[]
        {
            "->",
            ">>>",
            "->",
        }; // 플레이어 모양

        static int playerX = 0;
        static int playerY = 12;
        static Stopwatch stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)
            Console.CursorVisible = false; // 커서 숨김

            stopwatch.Start(); // 스톱워치 시작
            GameLoop(); // 게임 루프 실행
        }

        static void GameLoop()
        {
            long prevSecond = stopwatch.ElapsedMilliseconds; // 이전 시간 기록

            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; // 현재 시간 확인

                if (currentSecond - prevSecond >= 100) // 0.1초마다 갱신
                {
                    Console.Clear(); // 화면 지우기
                    HandleInput();   // 입력 처리
                    DrawPlayer();    // 플레이어 출력
                    prevSecond = currentSecond; // 시간 업데이트
                }
            }
        }

        static void HandleInput()
        {
            if (Console.KeyAvailable) // 키가 눌렸을 때만 처리
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); // 키 입력 받기

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                    case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                    case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                    case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                    case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                    case ConsoleKey.Escape: Environment.Exit(0); break; // ESC키로 종료
                }
            }
        }

        static void DrawPlayer()
        {
            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i); // 콘솔 좌표 설정
                Console.WriteLine(player[i]); // 플레이어 출력
            }
        }
    }
}
