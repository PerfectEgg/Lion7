//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class ex
//    {
//        static void Main(string[] args)
//        {
//            //문제 1
//            int currentHP1 = 80;
//            int maxHP1 = 100;

//            Console.WriteLine($"=== 문제 1 ===");
//            Console.WriteLine($"초기 체력: {currentHP1}/{maxHP1}");
//            currentHP1 -= 25;
//            Console.WriteLine($"데미지 -25: {currentHP1}/{maxHP1}");
//            currentHP1 += 30;
//            Console.WriteLine($"회복 +30: {currentHP1}/{maxHP1}");
//            currentHP1 -= 5;
//            Console.WriteLine($"독 데미지 -25: {currentHP1}/{maxHP1}");

//            //문제 2
//            int expPerMonster = 150;
//            int monstersKilled = 3;
//            int expForLevelUp = 500;

//            int getExp = expPerMonster * monstersKilled;

//            Console.WriteLine($"\n=== 문제 2 ===");
//            Console.WriteLine($"처치한 몬스터: {monstersKilled}마리");
//            Console.WriteLine($"획득 경험치: {getExp}");
//            Console.WriteLine($"레벨업까지 필요: {expForLevelUp - getExp}");

//            //문제 3
//            int totalGold = 1234;
//            int partyMembers = 5;

//            Console.WriteLine($"\n=== 문제 3 ===");
//            Console.WriteLine($"총 골드: {totalGold}");
//            Console.WriteLine($"파티원: {partyMembers}");
//            Console.WriteLine($"1인당 골드: {totalGold / partyMembers}");
//            Console.WriteLine($"남은 골드: {totalGold % partyMembers}");

//            //문제 4
//            int playerLevel = 35;
//            int requiredLevel = 30;
//            bool hasKey = true;
//            int currentHP4 = 60;
//            int maxHP4 = 100;

//            Console.WriteLine($"\n=== 문제 4 ===");
//            Console.WriteLine($"===== 던전 입장 조건 =====");
//            Console.WriteLine($"레벨 조건 (30 이상): {playerLevel >= requiredLevel}");
//            Console.WriteLine($"열쇠 보유: {hasKey}");
//            Console.WriteLine($"체력 조건 (50% 이상): {((double)currentHP4  / maxHP4) >= 0.5}");
//            Console.WriteLine($"입장 가능: {playerLevel >= requiredLevel && hasKey && ((double)currentHP4 / maxHP4) >= 0.5}");

//            //문제 5
//            int originalPrice = 5000;
//            bool isVIP = true;
//            bool hasCoupon = true;

//            Console.WriteLine($"\n=== 문제 5 ===");
//            Console.WriteLine($"원가: {originalPrice * 0.8}");
//            if (isVIP)
//                originalPrice = (int)(((originalPrice)) * 0.8);
//            Console.WriteLine($"VIP 할인 (20%): {originalPrice}");
//            if (hasCoupon)
//                originalPrice -= 500;
//            Console.WriteLine($"쿠폰 할인 (-500): {originalPrice}");
//            Console.WriteLine($"남은 골드: {originalPrice}");
//        }
//    }
//}
