//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;
//using System.Diagnostics;


//namespace ConsoleApp1
//{
//    internal class ex3
//    {
//        static void Main(string[] args) {
//            Console.InputEncoding = Encoding.UTF8;
//            Console.OutputEncoding = Encoding.UTF8;

//            Random rand = new Random();

//            int randomTiming = 0;
//            randomTiming = rand.Next(1000, 10001);
//            Stopwatch sw = new Stopwatch();

//            bool isInputReceived = false;

//            bool isTiming = false;

//            bool isMyShoot = false;
//            bool isMyDead = false;

//            bool isEnemyShoot = false;
//            bool isEnemyDead = false;

//            ConsoleKeyInfo keyInfo;

//            Console.CursorVisible = false;

//            while (true)
//            {

//                Console.Clear();
//                Console.WriteLine("=============== Quick Draw ===============");

//                Console.WriteLine("\n게임 시작을 위해 Enter을 눌러주세요");
//                string input = Console.ReadLine();

//                for (int i = 3; i >= 1; i--)
//                {
//                    Console.WriteLine(i + "...");
//                    Thread.Sleep(1000);
//                }
                

//                Console.WriteLine("게임 시작!");
//                Thread.Sleep(1000);

//                Task inputTask = Task.Run(() =>
//                {
//                    input = Console.ReadLine();
//                    isInputReceived = true;
//                });
//                sw.Start();

//                while (true)
//                {
//                    Console.Clear();

//                    if (randomTiming <= sw.ElapsedMilliseconds) {
//                        isTiming = true;
//                        sw.Stop();
//                        sw.Restart();
//                    }

//                    if (isTiming && 500 <= sw.ElapsedMilliseconds) {
//                        isEnemyShoot = true;
//                    }

//                    if (!isTiming)
//                        Console.WriteLine("Ready...");
//                    else
//                        Console.WriteLine("Shoot!");
//                    Console.WriteLine("Ready가 Shoot으로 바뀌면 보이면 총을 쏘세요!");
//                    Console.WriteLine("총을 쏠라면 아무키나 누르세요.");

//                    if (isInputReceived)
//                        isMyShoot = true;

//                    Console.WriteLine("\n\n\n\n\n\n\n\n");



//                    if (!isMyShoot && !isEnemyShoot)
//                    {
//                        // 평시 상태
//                        Console.WriteLine("  ___                                   ___");
//                        Console.WriteLine(" (___)                                 (___)");
//                        Console.WriteLine("   O                                     O");
//                        Console.WriteLine(" --|===>                             <===|--");
//                        Console.WriteLine("  / \\                                   / \\");
                        
//                    }
//                    else if (isMyShoot && isTiming)
//                    {
//                        // 타이밍에 내가 발사한 경우
//                        Console.WriteLine("  ___                                   ___");
//                        Console.WriteLine(" (___)                                 (___)");
//                        Console.WriteLine("   O                                     O");
//                        Console.WriteLine(" --|===>💥                          <===|--");
//                        Console.WriteLine("  / \\                                   / \\");
//                        Thread.Sleep(1500);
//                        isEnemyDead = true;
//                        break;
//                    }
//                    else if (isEnemyShoot && isTiming)
//                    {
//                        // 타이밍에 상대가 발사한 경우
//                        Console.WriteLine("  ___                                   ___");
//                        Console.WriteLine(" (___)                                 (___)");
//                        Console.WriteLine("   O                                     O");
//                        Console.WriteLine(" --|===>                          💥<===|--");
//                        Console.WriteLine("  / \\                                   / \\");
//                        Thread.Sleep(1500);
//                        isMyDead = true;
//                        break;
//                    }
//                    else if (isMyShoot && !isTiming)
//                    {
//                        // 타이밍이 아닌데 내가 발사한 경우
//                        Console.WriteLine("  ___                                   ___");
//                        Console.WriteLine(" (___)                                 (___)");
//                        Console.WriteLine("   O                                     O");
//                        Console.WriteLine(" --|===>❌                          <===|--");
//                        Console.WriteLine("  / \\                                   / \\");
//                        Thread.Sleep(1000);
//                        isMyShoot = true;
//                        isMyDead = true;
//                        break;
//                    }
//                }

//                if (isMyShoot && isMyDead)
//                {
//                    Console.Clear();
//                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
//                    Console.WriteLine("  ___                                   ___");
//                    Console.WriteLine(" (___)                                 (___)");
//                    Console.WriteLine("   O                                     O");
//                    Console.WriteLine(" --|===>❌                       💥<===|--");
//                    Console.WriteLine("  / \\                                   / \\");
//                    Thread.Sleep(1500);
                    
//                }
                
//                if (isMyDead)
//                {
//                    Console.Clear();
//                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
//                    Console.WriteLine("  x_x                                   ___");
//                    Console.WriteLine("   |                                   (___)");
//                    Console.WriteLine(" --|                                     O ");
//                    Console.WriteLine("  / \\                               <===|--");
//                    Console.WriteLine("                                        / \\");
//                    Thread.Sleep(2000);
//                    break;
//                }
//                else if (isEnemyDead)
//                {
//                    Console.Clear();
//                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
//                    Console.WriteLine("  ___                                   x_x");
//                    Console.WriteLine(" (___)                                   | ");
//                    Console.WriteLine("   O                                   --| ");
//                    Console.WriteLine(" --|===>                                / \\");
//                    Console.WriteLine("  / \\                                     ");
//                    Thread.Sleep(2000);
//                    break;
//                }

//            }

//            if (isMyDead)
//            {
//                Console.Clear();
//                Console.WriteLine("\n\n┏      \n            당신은 게임에서 졌습니다.\n                                              ┛\n\n");
//            }
//            else {
//                Console.Clear();
//                Console.WriteLine("\n\n┏      \n            당신은 게임에서 이겼습니다!!!\n                                                ┛\n\n");
//            }
//        } 
//    }
//}
