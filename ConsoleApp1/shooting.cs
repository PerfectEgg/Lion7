using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class shooting
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어 함수 가져옴

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.SetWindowSize(80, 25); //콘솔 창 크기 설정
            Console.SetBufferSize(80, 25); //버퍼 크기도 동일하게 설정 (스크롤 방지)

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; // 배열로 우주선 그리기


            int playerX = 0;
            int playerY = 12;

            var missile = new List<(int, int)>();

            Console.CursorVisible = false;
            int dwTime = Environment.TickCount;     // 1ms의 흐름


            while (true)
            {
                //1초 루프: 1초가 아닐 경우, 함수 실행 X
                if (dwTime + 10 < Environment.TickCount)
                {
                    // 1초가 지난 시점에 다시 세팅 -> 이후 다시 1초 기다림
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    // 키 영역
                    int pressKey;       //정수형 변수 선언: 키 값 받음\

                    if (Console.KeyAvailable)
                    {
                        pressKey = _getch();

                        if (pressKey == 224)
                            pressKey = _getch();

                        switch (pressKey)
                        {
                            case 72:  //위쪽방향 아스키코드                    
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1;
                                break;
                            case 75:    //왼쪽 화살표키
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;
                            case 77:    //오른쪽
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;
                            case 80:    //아래
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;
                            case 32:    //스페이스 바
                                missile.Add((playerX, playerY + 1));
                                break;
                        }
                    }

                    if (missile.Count > 0)
                    {
                        for (int i = 0; i < missile.Count; i++)
                        {
                            Console.SetCursorPosition(missile[i].Item1, missile[i].Item2);
                            Console.WriteLine("->");
                            if (missile[i].Item1 > 75)
                            {
                                missile[i] = (-1, -1);
                            }
                            else
                            {
                                missile[i] = (missile[i].Item1 + 1, missile[i].Item2);
                            }
                        }

                        while (missile.Remove((-1, -1))) { }
                    }

                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔 좌표 설정
                        Console.SetCursorPosition(playerX, playerY + i);
                        Console.WriteLine(player[i]);
                    }
                }

            }

        }
    }
}
