//using System;
//using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class collection
//    {
//        static void Main(string[] args)
//        {
//            Console.InputEncoding = Encoding.UTF8;
//            Console.OutputEncoding = Encoding.UTF8;

//            ////배열
//            //int[] scores1 = new int[5];                     //int 형 메모리를 5개 사용가능
//            //int[] scores2_1 = new int[] { 1, 2, 3, 4, 5 };  //선언과 동시에 int 형 메모리를 5개 사용가능
//            //int[] scores2_2 = { 1, 2, 3, 4, 5 };            //선언과 동시에 int 형 메모리를 5개 사용가능 (new int[] 생략)

//            //scores1[0] = 1;
//            //scores1[1] = 2;
//            //scores1[2] = 3;
//            //scores1[3] = 4;
//            //scores1[4] = 5;

//            //for (int i = 0; i < scores1.Length; i++)
//            //{
//            //    Console.WriteLine(scores1[i]);
//            //}


//            ////인벤토리 시스템
//            //string[] inventory = new string[5];

//            ////아이템 추가
//            //for (int i = 0; i < inventory.Length; i++)
//            //{
//            //    Console.Write($"{i+1}번째 장비를 입력하세요: ");
//            //    inventory[i] = Console.ReadLine();
//            //}

//            //Console.WriteLine("\n=== 인벤토리 ===");
//            //for (int i = 0; i < inventory.Length; i++)
//            //    Console.WriteLine($"[{i+1}] {inventory[i]}");

//            //Console.WriteLine($"\n{inventory[0]}를 사용했습니다!");
//            //inventory[0] = "비어 있음";

//            //Console.WriteLine("\n=== 인벤토리 ===");
//            //for (int i = 0; i < inventory.Length; i++)
//            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");


//            ////캐릭터 스텟

//            //string[] statusString = { "HP", "MP", "공격력", "방어력", "민첩" };
//            //int[] statusInt = { 100, 50, 80, 60, 45 };

//            //Console.WriteLine("=== 캐릭터 스텟 ===");

//            //for (int i = 0; i < statusInt.Length && i < statusString.Length; i++)
//            //{
//            //    Console.WriteLine($"{statusString[i]}: {statusInt[i]}");
//            //}


//            ////일일 퀘스트 진행도
//            //Console.WriteLine("=== 일일 퀘스트 진행도 ===");

//            //string[] targetName = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
//            //int targetHunt = 5;
//            //int[] currentHunt = { 5, 3, 8, 2, 7 };

//            //for (int i = 0; i < targetName.Length; i++) {
//            //    Console.Write($"{targetName[i]}: {currentHunt[i]}/{targetHunt}");
//            //    if (targetHunt <= currentHunt[i])
//            //        Console.WriteLine(" ✅ 완료");
//            //    else
//            //        Console.WriteLine(" ⏳ 진행중");
//            //}


//            ////일일 퀘스트 진행도
//            //int[] score = { 85, 92, 78, 95, 88 };
//            //int sum = 0;

//            //Console.WriteLine("총 점수 개수: " + score.Length);

//            //Console.WriteLine("\n개별 점수");
//            //for (int i = 0; i < score.Length; i++)
//            //{
//            //    Console.WriteLine($"플레이어 {i + 1}: {score[i]}점");
//            //    sum += score[i];
//            //}

//            //Console.WriteLine($"\n총점: {sum}");
//            //Console.WriteLine($"평점: {(float)sum / score.Length}");

//            ////최고점
//            //Console.WriteLine($"\n최고점: {score.Max()}");

//            ////최저점
//            //Console.WriteLine($"\n최저점: {score.Min()}");


//            ////foreach문
//            //foreach (int i in score) {
//            //    Console.WriteLine(i);
//            //}

//            ////Array 클래스 활용
//            //Console.WriteLine("\n=== Array 메서드 ===");

//            ////정렬
//            //int[] sortedScore = (int[])score.Clone();
//            //Array.Sort(sortedScore);

//            //Console.WriteLine("정렬 후: ");
//            //for (int i = 0; i < sortedScore.Length; i++) {
//            //    Console.WriteLine(sortedScore[i]);
//            //}


//            ////다차원 배열
//            //int[,] array = new int[3, 4];       //3행 4열

//            ////전체 길이
//            //int totalElement = array.Length;

//            ////행 길이
//            //int rows = array.GetLength(0);
//            ////열 길이
//            //int cols = array.GetLength(1);

//            ////배열 차원수
//            //int dimensions = array.Rank;


//            ////좌석 배치도
//            //string[,] sit = new string[3, 3];
//            //Console.WriteLine("=== 좌석 배치도 ===");

//            //for (int i = 0; i < sit.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < sit.GetLength(1); j++)
//            //    {
//            //        Console.Write($"[{(char)('A'+i)}{j}]");
//            //        sit[i, j] = $"[{(char)('A' + i)}{j}]";
//            //    }
//            //    Console.WriteLine();
//            //}

//            //Console.WriteLine($"\n첫번째 좌석: {sit[0, 0]}");
//            //Console.WriteLine($"중앙 좌석: {sit[1, 1]}");
//            //Console.WriteLine($"마지막 좌석: {sit[2, 2]}");


//            ////2D 게임 맵
//            //int[,] map = new int[5, 5]
//            //{
//            //    {0,0,1,0,0},
//            //    {0,2,1,0,3},
//            //    {0,0,1,0,0},
//            //    {1,1,1,0,0},
//            //    {0,0,0,0,9}
//            //};

//            //Console.WriteLine("=== 던전맵 ===");
//            //Console.WriteLine("0: 통로, 1: 벽, 2: 몬스터, 3: 보물, 9: 출구\n");

//            //for (int i = 0; i < map.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < map.GetLength(1); j++)
//            //    {
//            //        switch (map[i, j])
//            //        {
//            //            case 0:
//            //                Console.Write("⬜ ");
//            //                break;
//            //            case 1:
//            //                Console.Write("⬛ ");
//            //                break;
//            //            case 2:
//            //                Console.Write("👹 ");
//            //                break;
//            //            case 3:
//            //                Console.Write("💎 ");
//            //                break;
//            //            case 9:
//            //                Console.Write("🚪 ");
//            //                break;
//            //            default:
//            //                break;
//            //        }
//            //    }
//            //    Console.WriteLine();
//            //}


//            //string[] name = { "김철수", "이영희", "박민수" };
//            //string[] subjects = { "국어", "영어", "수학", "과학" };
//            //int[] subjectsSum = { 0, 0, 0, 0 };

//            //int[][] score = new int[3][];
//            //score[0] = new int[4] { 85, 90, 88, 92 };
//            //score[1] = new int[4] { 78, 85, 90, 87 };
//            //score[2] = new int[4] { 92, 88, 95, 90 };


//            //Console.WriteLine("=== 성적표 ===\n");

//            //Console.WriteLine("이름    국어    영어    수학    과학   평균");
//            //Console.WriteLine("---------------------------------------------");
//            //for (int i = 0; i < score.Length; i++)
//            //{
//            //    Console.Write(name[i] + "    ");
//            //    for (int j = 0; j < score[i].Length; j++)
//            //    {
//            //        Console.Write($"{score[i][j]}      ");
//            //        subjectsSum[j] += score[i][j];
//            //    }
//            //    Console.WriteLine(score[i].Average());
//            //}

//            //Console.WriteLine("\n=== 과목별 평균 ===");
//            //for (int i = 0; i < subjects.Length; i++)
//            //{
//            //    Console.WriteLine($"{subjects[i]}: {(double)subjectsSum[i] / score.GetLength(0):F1}점");
//            //}


//            ////가변 배열
//            //string[][] raid = new string[3][];

//            //raid[0] = new string[] { "전사", "힐러", "마법사", "마법사"};
//            //raid[1] = new string[] { "도적", "전사", "힐러" };
//            //raid[2] = new string[] { "마법사", "궁수", "힐러", "전사", "탱커" };

//            //Console.WriteLine("=== 레이드 파티 구성 ===");

//            //for (int i = 0; i < raid.Length; i++)
//            //{
//            //    Console.WriteLine($"파티{i + 1} ({raid[i].Length}명)");
//            //    for (int j = 0; j < raid[i].Length; j++)
//            //    {
//            //        Console.WriteLine($" - {raid[i][j]}");
//            //    }
//            //    Console.WriteLine();
//            //}


//            ////List

//            ////선언 방법
//            //List<int> numbers = new List<int>();        // 빈 정수
//            //List<string> names = new List<string>();    // 빈 문자열
//            //List<float> prices = new List<float>();     // 빈 실수

//            ////초기화 선언
//            //List<int> scores = new List<int> { 85, 90, 78, 95 };
//            //List<string> itmes = new List<string> { "검", "방패", "포션" };

//            ////C# 3.0 이후 간단한 초기화
//            //var player = new List<string> { "철수", "영희", "민수" };
//            //List<string> item = new List<string>();

//            ////Add로 추가 가능
//            //item.Add("회복 포션");
//            //item.Add("마나 포션");


//            ////예제 1: 인벤토리 시스템
//            //List<string> inventory = new List<string>();

//            //Console.WriteLine("=== 도적 인벤토리 시스템 ===");

//            ////아이템 추가 (Add)
//            //inventory.Add("회복 포션");
//            //inventory.Add("마나 포션");
//            //inventory.Add("강철 검");
//            //Console.WriteLine("아이템 3개 추가");

//            ////현재 인벤토리
//            //Console.WriteLine($"인벤토리 ({inventory.Count}개)");

//            //foreach (var total in inventory.Select((value, index) => (value, index)))
//            //{
//            //    var index = total.index;
//            //    var item = total.value;

//            //    Console.WriteLine($"[{index}] {item}");
//            //}

//            //Console.WriteLine();
//            //inventory[0] = "초록 포션";

//            //foreach (var total in inventory.Select((value, index) => (value, index)))
//            //{
//            //    var index = total.index;
//            //    var item = total.value;

//            //    Console.WriteLine($"[{index}] {item}");
//            //}

//            //Console.WriteLine();
//            //inventory.Insert(1, "전설 검");

//            //foreach (var total in inventory.Select((value, index) => (value, index)))
//            //{
//            //    var index = total.index;
//            //    var item = total.value;

//            //    Console.WriteLine($"[{index}] {item}");
//            //}

//            //Console.WriteLine();
//            //inventory.Remove("초록 포션");

//            //foreach (var total in inventory.Select((value, index) => (value, index)))
//            //{
//            //    var index = total.index;
//            //    var item = total.value;

//            //    Console.WriteLine($"[{index}] {item}");
//            //}


//            //Dictionary<string, int> stats = new Dictionary<string, int>();

//            ////데이터추가
//            //stats.Add("HP", 150);
//            //stats.Add("MP", 80);
//            //stats.Add("공격력", 75);
//            //stats.Add("방어력", 50);
//            //stats.Add("민첩", 60);


//            //Console.WriteLine("=== 캐릭터 스탯 ===");

//            //foreach (KeyValuePair<string, int> stat in stats)
//            //{
//            //    Console.WriteLine($"{stat.Key}: {stat.Value}");
//            //}

//            ////키 존재 확인
//            //string searchStat = "방어력";

//            //if (stats.ContainsKey(searchStat))
//            //{
//            //    Console.WriteLine(stats[searchStat]);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("해당스탯이 없습니다.");
//            //}


//            ////예제 2. 상점 아이템
//            //int haveGold = 600;

//            //Dictionary<string, int> store = new Dictionary<string, int>();
//            //store.Add("회복 포션", 50);
//            //store.Add("마나 포션", 40);
//            //store.Add("강철 검", 500);
//            //store.Add("가죽 갑옷", 300);
//            //store.Add("마법 반지", 1000);

//            //Console.WriteLine("=== 상점 아이템 ===");
//            //foreach (var item in store)
//            //{
//            //    Console.WriteLine($"{item.Key}: {item.Value}");
//            //}

//            //if (store.ContainsKey("강철 검"))
//            //{
//            //    if (haveGold >= store["강철 검"])
//            //    {
//            //        haveGold -= store["강철 검"];
//            //        Console.WriteLine("\n✅ '강철 검' 구매 성공!");
//            //        Console.WriteLine($"남은 골드: {haveGold}");
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("골드가 부족합니다!");
//            //    }
//            //}
//            //else {
//            //    Console.WriteLine("강철 검이라는 아이템이 존재하지 않습니다!");
//            //}
//        }
//    }
//}
