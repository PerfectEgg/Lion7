//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace ConsoleApp1
//{
//    internal class BlacksmithProject
//    {
//        static void Main(string[] args)
//        {
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
//    }
//}
