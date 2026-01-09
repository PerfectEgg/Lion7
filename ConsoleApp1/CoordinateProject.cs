//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class CoordinateProject
//    {
//        static void blacksmith() {
//            var rand = new Random();
//            string input;

//            int pmoney = 100;
//            int sssCount = 0;
//            int rnd;

//            Console.WriteLine("┌─────────────────┐");
//            Console.WriteLine("│ 대장장이 키우기 │");
//            Console.WriteLine("└─────────────────┘");

//            Thread.Sleep(1500);

//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("1. 나무 캐기");
//                Console.WriteLine("2. 장비 뽑기");
//                Console.WriteLine("3. SSS 횟수 확인하기");
//                Console.WriteLine("4. 나가기");

//                Console.Write("\n입력: ");
//                input = Console.ReadLine();
//                Console.WriteLine();

//                switch (input)
//                {
//                    case "1":
//                        while (true)
//                        {
//                            Console.WriteLine("나무캐기(엔터)");
//                            Console.WriteLine("뒤로가기 x");

//                            string str = Console.ReadLine();
//                            if (str == "x")
//                                break;
//                            else
//                            {
//                                pmoney += 100;
//                                Console.WriteLine($"소지금: {pmoney}");
//                            }
//                        }
//                        break;
//                    case "2":
//                        while (true)
//                        {
//                            if (pmoney >= 1000)
//                            {
//                                pmoney -= 1000;

//                                Console.WriteLine("\n20연차 시작!\n");
//                                for (int i = 0; i < 20; i++)
//                                {
//                                    rnd = rand.Next(1, 101);
//                                    if (rnd == 1)
//                                    {
//                                        Console.WriteLine("┌");
//                                        Console.WriteLine("   도끼 등급 SSS!!");
//                                        Console.WriteLine("                    ┘");
//                                        sssCount++;
//                                        Thread.Sleep(150);
//                                    }
//                                    else if (rnd >= 2 && rnd <= 6)
//                                        Console.WriteLine("도끼 등급 SS");
//                                    else if (rnd >= 7 && rnd <= 17)
//                                        Console.WriteLine("도끼 등급 S");
//                                    else if (rnd >= 18 && rnd <= 38)
//                                        Console.WriteLine("도끼 등급 A");
//                                    else if (rnd >= 39 && rnd <= 69)
//                                        Console.WriteLine("도끼 등급 B");
//                                    else
//                                        Console.WriteLine("도끼 등급 C");

//                                    Thread.Sleep(150);
//                                }
//                            }
//                            else
//                            {
//                                Console.WriteLine("돈이 부족합니다.\n");
//                                Thread.Sleep(2000);
//                                break;
//                            }
//                        }
//                        Console.WriteLine();
//                        break;
//                    case "3":
//                        Console.WriteLine($"현재까지 뜬 SSS 횟수는 {sssCount}회 입니다!");
//                        Thread.Sleep(2000);
//                        break;
//                    case "4":
//                        Console.WriteLine("게임을 종료합니다.");
//                        Environment.Exit(0);
//                        break;
//                    default:
//                        Console.WriteLine("잘못된 입력입니다.");
//                        Thread.Sleep(2000);
//                        break;
//                }
//            }
//        }

//        static void Main(string[] args)
//        {
//            Console.InputEncoding = Encoding.UTF8;
//            Console.OutputEncoding = Encoding.UTF8;

//            const int targetX = 50;
//            const int targetY = 20;

//            Console.SetWindowSize(80, 25);      // 콘솔 창 크기 설정
//            Console.SetBufferSize(80, 25);      // 콘솔 버퍼 크기 설정

//            int x = 10, y = 10;
            
//            ConsoleKeyInfo keyInfo;             // 키 입력 정보

//            Console.CursorVisible = false;        // 커서 숨기기

//            while (true)
//            {
//                Console.Clear();

//                Console.SetCursorPosition(targetX, targetY);
//                Console.Write("🏠");

//                Console.SetCursorPosition(x, y);    // 좌표

//                Console.Write("★");                 // 캐릭터 출력

                

//                if (targetX == x && targetY == y) { 
//                    Console.Clear();
//                    blacksmith();
//                    break;
//                }


//                keyInfo = Console.ReadKey(true);    // 키 입력 대기

//                switch (keyInfo.Key)
//                {
//                    case ConsoleKey.UpArrow: if (y > 0) y--; break;
//                    case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
//                    case ConsoleKey.LeftArrow: if (x > 0) x--; break;
//                    case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
//                    case ConsoleKey.Spacebar:  Console.Write("미사일 발사");  break;
//                    case ConsoleKey.Escape: return; // 프로그램 종료
//                }
//            }
//        }
//    }
//}
