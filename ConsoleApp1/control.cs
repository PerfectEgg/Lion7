//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;
//using System.Security.Cryptography.X509Certificates;
//using System.Security.Cryptography;

//namespace ConsoleApp1
//{
//    internal class control
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.UTF8;

//            //int score = 85;
//            //if (score >= 90)
//            //{
//            //    Console.WriteLine("A 학점");
//            //}
//            //else {
//            //    Console.WriteLine("90점 미만");
//            //}


//            //int num = 10;
//            //if (num > 15)
//            //{
//            //    Console.WriteLine("15보다 큽니다");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("15보다 작거나 같습니다");
//            //}


//            //int score = 75;
//            //if (score >= 90)
//            //{
//            //    Console.WriteLine("A 학점");
//            //}
//            //else if (score >= 80)
//            //{
//            //    Console.WriteLine("B 학점");
//            //}
//            //else if (score >= 70)
//            //{
//            //    Console.WriteLine("C 학점");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("F 학점");
//            //}


//            ////if문 코드 한 줄
//            //int a = 10;

//            //if (a == 10)
//            //    Console.WriteLine("A가 " + a + "입니다.");


//            //Console.OutputEncoding = Encoding.UTF8;

//            //int health = 30;
//            //int maxHealth = 100;

//            //Console.WriteLine($"현재 체력: {health}/{maxHealth}");
//            //if ((double)health / maxHealth <= 0.3)
//            //{
//            //    Console.WriteLine($"⚠️ 경고: 체력이 위험합니다!");
//            //    Console.WriteLine("회복 아이템을 사용하세요!");
//            //}

//            //if ((double)health / maxHealth <= 0.5)
//            //{
//            //    Console.WriteLine($"💊 체력이 50% 이하입니다.");
//            //}

//            //if (health <= 0)
//            //{
//            //    Console.WriteLine($"💀 게임 오버!");
//            //    Console.WriteLine("부활 지점에서 다시 시작합니다.");
//            //}

//            //Console.WriteLine("");
//            //int enemyDistance = 5;
//            //int attackRange = 3;

//            //if (attackRange >= enemyDistance)
//            //{
//            //    Console.WriteLine($"⚔️ 적이 사거리 안에 있습니다!");
//            //    Console.WriteLine("공격 가능!");
//            //}
//            //else
//            //{
//            //    Console.WriteLine($"🏃 적이 사거리 밖에 있습니다.");
//            //    Console.WriteLine("공격 불가능");
//            //}


//            ////아이템 구매 시스템
//            //int playerGold = 500;
//            //int itemPrice = 250;
//            //string itemName = "강철 검";

//            //Console.WriteLine("=== 상점 ===");
//            //Console.WriteLine($"아이템: {itemName}");
//            //Console.WriteLine($"가격: {itemPrice} 골드");
//            //Console.WriteLine($"소지 골드: {playerGold} 골드\n");

//            //if (itemPrice <= playerGold)
//            //{
//            //    //구매 가능
//            //    playerGold -= itemPrice;
//            //    Console.WriteLine("구매 성공!");
//            //    Console.WriteLine($"{itemName}을 획득했습니다!");
//            //    Console.WriteLine($"남은 골드: {playerGold} 골드");
//            //}
//            //else
//            //{
//            //    //구매 불가
//            //    int needGold = itemPrice - playerGold;
//            //    Console.WriteLine("골드가 부족합니다!");
//            //    Console.WriteLine($"필요한 골드: {needGold} 골드 더 필요");
//            //}

//            //Console.WriteLine("\n=== 던전 입장 ===");

//            //int playerLevel = 48;
//            //int requiredLevel = 50;

//            //if (playerLevel >= requiredLevel)
//            //{
//            //    Console.WriteLine("던전에 입장합니다!");
//            //    Console.WriteLine("전투 준비");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("레벨이 부족합니다!");
//            //    Console.WriteLine($"필요 레벨: {requiredLevel}");
//            //    Console.WriteLine($"현재 레벨: {playerLevel}");
//            //    Console.WriteLine($"레벨 업이 필요합니다!: {requiredLevel - playerLevel}레벨");
//            //}


//            ////점수에 따른 등급 판정
//            //int score = 0;
//            //string rank;

//            //Console.WriteLine("=== 게임 랭크 시스템 ===");
//            //Console.Write("스코어를 입력해주세요: ");
//            //score = int.Parse(Console.ReadLine());
//            //Console.WriteLine($"점수: {score}");

//            //if (score >= 10000) {
//            //    rank = "SSS";
//            //    Console.WriteLine($"등급: {rank} (레전드)");
//            //    Console.WriteLine("보상: 전설 아이템 + 골드 10000");
//            //}
//            //else if (score >= 8000)
//            //{
//            //    rank = "SS";
//            //    Console.WriteLine($"등급: {rank} (마스터)");
//            //    Console.WriteLine("보상: 영웅 아이템 + 골드 5000");
//            //}
//            //else if (score >= 6000)
//            //{
//            //    rank = "S";
//            //    Console.WriteLine($"등급: {rank} (다이아)");
//            //    Console.WriteLine("보상: 희귀 아이템 + 골드 3000");
//            //}
//            //else if (score >= 4000)
//            //{
//            //    rank = "A";
//            //    Console.WriteLine($"등급: {rank} (플레티넘)");
//            //    Console.WriteLine("보상: 고급 아이템 + 골드 1500");
//            //}
//            //else
//            //{
//            //    rank = "B";
//            //    Console.WriteLine($"등급: {rank} (골드)");
//            //    Console.WriteLine("보상: 일반 아이템 + 골드 500");
//            //}


//            ////캐릭터 상태 판정
//            //Console.WriteLine("\n=== 캐릭터 상태 ===");
//            //int health = 0;
//            //Console.Write("체력를 입력해주세요: ");
//            //health = int.Parse(Console.ReadLine());

//            //if (health >= 80)
//            //{
//            //    Console.WriteLine($"💚 상태: 매우 좋음");
//            //}
//            //else if (health >= 60)
//            //{
//            //    Console.WriteLine($"🟢 상태: 좋음");
//            //}
//            //else if (health >= 40)
//            //{
//            //    Console.WriteLine($"🟡 상태: 보통");
//            //}
//            //else if(health >= 20)
//            //{
//            //    Console.WriteLine($"🟠 상태: 위험");
//            //}
//            //else
//            //{
//            //    Console.WriteLine($"🔴 상태: 매우 위험!");
//            //}


//            ////switch문
//            //int day = 1;

//            //switch (day)
//            //{
//            //    case 1:
//            //    case 2:
//            //    case 3:
//            //        Console.WriteLine("수요일");
//            //        break;
//            //    default:
//            //        Console.WriteLine("유효하지 않은 요일");
//            //        break;
//            //}


//            ////캐릭터 선택 화면
//            //int jobChice = 2;

//            //Console.WriteLine("=== 캐릭터 생성 ===");
//            //switch (jobChice) { 
//            //    case 1:
//            //        Console.WriteLine("직업: 전사");
//            //        Console.WriteLine("특성: 강력한 물리 공격");
//            //        Console.WriteLine("주 무기: 검, 방패");
//            //        Console.WriteLine("스탯: 체력 + 100, 물리력 + 20");
//            //        break;
//            //    case 2:
//            //        Console.WriteLine("직업: 마법사");
//            //        Console.WriteLine("특성: 강력한 마법 공격");
//            //        Console.WriteLine("주 무기: 지팡이, 마법서");
//            //        Console.WriteLine("스탯: 마나 + 100, 마법력 + 20");
//            //        break;
//            //    case 3:
//            //        Console.WriteLine("직업: 궁수");
//            //        Console.WriteLine("특성: 빠른 원거리 공격");
//            //        Console.WriteLine("주 무기: 활, 석궁");
//            //        Console.WriteLine("스탯: 물리력 + 35, 공격 속도 + 25");
//            //        break;
//            //    case 4:
//            //        Console.WriteLine("직업: 도적");
//            //        Console.WriteLine("특성: 민첩한 암살");
//            //        Console.WriteLine("주 무기: 단검, 표창");
//            //        Console.WriteLine("스탯: 물리력 + 50, 이동 속도 + 25");
//            //        break;
//            //    default:
//            //        Console.WriteLine("잘못된 선택입니다.");
//            //        Console.WriteLine("1~4 중에서 선택하세요");
//            //        break;
//            //}


//            //Console.WriteLine("=== 몬스터 웨이브 시작 ===");
//            //for (int i = 1; i <= 5; i++)
//            //    Console.WriteLine($"    고블린 #{i} 생성!");


//            //Console.WriteLine("=== 게임 시작 카운트다운 ===");
//            //for (int i = 5; i >= 1; i--)
//            //    Console.WriteLine($"{i}...");
//            //Console.WriteLine("🎮 게임 시작!");


//            //for (; ; ) {
//            //    Console.WriteLine("한무 반복");
//            //    Thread.Sleep(1000);
//            //}


//            //// 랜덤 객체 생성
//            //Random random = new Random();   //사용법

//            ////사용 방법
//            //int num = random.Next(1, 7);    //주사위


//            ////검의 종류
//            ////무한의 대검(10), 카타나(20), 엑스칼리버(30), 정기점검(40)

//            //string sword = "무한의 대검";

//            //Random rand = new Random();
//            //int random = 0;

//            //Console.WriteLine("당신은 20연차 뽑기가 가능합니다. 지금 실행됩니다.");

//            //for (int i = 0; i < 20; i++)
//            //{
//            //    random = rand.Next(1, 101);

//            //    if (random >= 1 && random <= 10)
//            //    {
//            //        sword = "무한의 대검";
//            //    }
//            //    else if (random >= 11 && random <= 30)
//            //    {
//            //        sword = "카타나";
//            //    }
//            //    else if (random >= 31 && random <= 60)
//            //    {
//            //        sword = "엑스칼리버";
//            //    }
//            //    else
//            //    {
//            //        sword = "정기점검";
//            //    }

//            //    Console.WriteLine(sword);
//            //}


//            ////while 문
//            //int i = 0;

//            //while (i < 5)
//            //{
//            //    Console.WriteLine(i);
//            //    i++;
//            //}


//            //// 예제 2: 10부터 1까지 카운트다운
//            //Console.WriteLine("=== 예제 2: 카운트다운 ===");
//            //int countdown = 10;

//            //while (countdown > 0)
//            //{
//            //    Console.WriteLine(countdown);
//            //    countdown--;
//            //}


//            //// 예제 3: 합계 구하기
//            //Console.WriteLine("=== 예제 3: 합계 구하기 ===");
//            //int sum = 0;
//            //int i = 1;

//            //while (i <= 5)
//            //{
//            //    sum += i;
//            //    Console.WriteLine(sum);
//            //    i++;
//            //}


//            //// 예제 4: 특정 값까지 반복하기
//            //Console.WriteLine("=== 예제 4: 목표 달성하기 ===");
//            //int coins = 0;
//            //int target = 50;
//            //int day = 0;

//            //while (coins < target)
//            //{
//            //    day++;
//            //    coins += 10;
//            //    Console.WriteLine($"{day}일차: 코인 {coins}개");
//            //}

//            //Console.WriteLine($"목표 달성! {day}일 걸렸습니다.");


//            //int x = 5;
//            //do
//            //{
//            //    Console.WriteLine("최소 한 번 실행");
//            //    x--;
//            //}
//            //while (x > 0);


//            //string choice;
//            //int totalPrice = 0;

//            //do {
//            //    Console.WriteLine("메뉴판");
//            //    Console.WriteLine("1. 짜장면 - 5,000원");
//            //    Console.WriteLine("2. 짬뽕 - 6,000원");
//            //    Console.WriteLine("3. 탕수육 - 15,000원");
//            //    Console.WriteLine("4. 볶음밥 - 7,000원");
//            //    Console.WriteLine("0. 주문 완료");

//            //    Console.WriteLine("\n====================");
//            //    Console.Write("메뉴 번호를 선택하세요");

//            //    choice = Console.ReadLine();
//            //    Console.Clear();

//            //    switch (choice) { 
//            //        case "1":
//            //            totalPrice += 5000;
//            //            Console.WriteLine("짜장면이 추가! (5,000원)");
//            //            break;
//            //        case "2":
//            //            totalPrice += 6000;
//            //            Console.WriteLine("짬뽕이 추가! (6,000원)");
//            //            break;
//            //        case "3":
//            //            totalPrice += 15000;
//            //            Console.WriteLine("탕수육이 추가! (15,000원)");
//            //            break;
//            //        case "4":
//            //            totalPrice += 7000;
//            //            Console.WriteLine("볶음밥이 추가! (7,000원)");
//            //            break;
//            //        case "0":
//            //            Console.WriteLine("주문을 완료합니다.");
//            //            break;
//            //        default:
//            //            Console.WriteLine("잘못된 선택입니다.");
//            //            break;
//            //    }

//            //    if (choice != "0")
//            //        Console.WriteLine($"현재 금액: {totalPrice:N0}원");
//            //    else
//            //        Console.WriteLine($"최종 결제 금액: {totalPrice:N0}원");
//            //} while(choice != "0");


//            //for (int i = 0; i <= 10; i++)
//            //{
//            //    if (i == 5)
//            //        break;
//            //    Console.WriteLine(i);
//            //}


//            //for (int i = 0; i <= 10; i++)
//            //{
//            //    if (i == 5)
//            //        continue;
//            //    Console.WriteLine(i);
//            //}


//            //while (true)
//            //{
//            //    Console.WriteLine("무 한 루 프");
//            //    goto TELEPORT;

//            //}
//            //TELEPORT:;
//            //Console.WriteLine("텔포 성공");


//            ////이차원 for문
//            //for (int i = 1; i <= 3; i++)
//            //{
//            //    for (int j = 1; j <= 3; j++)
//            //    {
//            //        Console.WriteLine($"i: {i}, j: {j}\n");
//            //    }
//            //}


//            ////예제 1: 사각형 그리기
//            //Console.WriteLine("=== 예제 1: 사각형 그리기 ===");
//            //for (int i = 0; i < 3; i++) {
//            //    for (int j = 0; j < 3; j++) {
//            //        Console.Write("⬜");
//            //    }
//            //    Console.WriteLine();
//            //}

//            ////예제 2: 숫자 표 만들기
//            //Console.WriteLine("=== 예제 2: 숫자 표 만들기 ===");
//            //for (int i = 0; i < 3; i++)
//            //{
//            //    for (int j = 1; j <= 3; j++)
//            //    {
//            //        Console.Write(j + " ");
//            //    }
//            //    Console.WriteLine();
//            //}

//            ////예제 3: 좌표 찍기
//            //Console.WriteLine("=== 예제 3: 좌표 찍기 ===");
//            //for (int i = 0; i < 3; i++)
//            //{
//            //    for (int j = 1; j <= 3; j++)
//            //    {
//            //        Console.Write($"({i}, {j}) ");
//            //    }
//            //    Console.WriteLine();
//            //}

//            ////예제 4: 계단 모양
//            //Console.WriteLine("=== 예제 4: 계단 모양 ===");
//            //for (int i = 0; i < 5; i++)
//            //{
//            //    for (int j = 0; j <= i; j++)
//            //    {
//            //        Console.Write("*");
//            //    }
//            //    Console.WriteLine();
//            //}

//            //for (int i = 3; i >= 0; i--)
//            //{
//            //    for (int j = 0; j <= i; j++)
//            //    {
//            //        Console.Write("*");
//            //    }
//            //    Console.WriteLine();
//            //}

//            ////예제 6: 2단 곱셈표
//            //Console.WriteLine("=== 예제 6: 2단 곱셈표 ===");
//            //for (int i = 1; i <= 3; i++)
//            //{
//            //    for (int j = 1; j <= 3; j++)
//            //    {
//            //        Console.Write($"{i}x{j}={i*j} ");
//            //    }
//            //    Console.WriteLine();
//            //}

//            ////예제 9: 미니 게임 맵
//            //Console.WriteLine("=== 예제 9: 미니 게임 맵 ===");
//            //for (int i = 0; i < 4; i++)
//            //{
//            //    for (int j = 0; j < 4; j++)
//            //    {
//            //        if(i == 0 && j == 0)
//            //            Console.Write("🏠");
//            //        else if (i == 3 && j == 3)
//            //            Console.Write("🎯");
//            //        else Console.Write("🟩");
//            //    }
//            //    Console.WriteLine();
//            //}
//        }
//    }
//}
