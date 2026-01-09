//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class ex2
//    {
//        static void Main(string[] args)
//        {
//            //문제 1
//            int temperature = 0;
//            Console.Write("온도: ");
//            temperature = int.Parse(Console.ReadLine());

//            Console.Write($"\n현재 온도: {temperature}");
//            if (temperature < 0)
//                Console.WriteLine("매우 추워요! 패딩과 목도리가 필요해요.");
//            else if (temperature >= 0 && temperature < 10)
//                Console.WriteLine("추워요! 코트를 입으세요.");
//            else if (temperature >= 10 && temperature < 20)
//                Console.WriteLine("쌀쌀해요! 가디건이나 자켓을 챙기세요.");
//            else if (temperature >= 20 && temperature < 30)
//                Console.WriteLine("적당해요! 긴팔 티셔츠를 입으세요.");
//            else
//                Console.WriteLine("더워요! 반팔과 반바지를 입으세요.");

//            //문제 2
//            int jobChoice = 0;
//            Console.Write("\n직업 선택 (1: 전사, 2: 마법사, 3: 궁수, 4: 도적): ");
//            jobChoice = int.Parse(Console.ReadLine());

//            Console.WriteLine("\n=== 캐릭터 생성 ===");
//            switch (jobChoice)
//            {
//                case 1:
//                    Console.WriteLine("전사 - 높은 체력과 방어력");
//                    Console.WriteLine("시작 스텟: HP +50, 공격력 +10");
//                    break;
//                case 2:
//                    Console.WriteLine("마법사 - 강력한 마법 공격");
//                    Console.WriteLine("시작 스텟: 마나 +100, 마법력 +20");
//                    break;
//                case 3:
//                    Console.WriteLine("궁수 - 원거리 공격 특화");
//                    Console.WriteLine("시작 스텟: 민첩 +15, 크리티컬 +10%");
//                    break;
//                case 4:
//                    Console.WriteLine("도적 - 빠른 속도와 회피");
//                    Console.WriteLine("시작 스텟: 민첩 +20, 회피율 +15%");
//                    break;
//                default:
//                    Console.WriteLine("잘못된 선택입니다. 1~4 중에서 선택하세요.");
//                    break;
//            }
//        }
//    }
//}
