//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Operator
//    {
//        static void Main(string[] args)
//        {
//            ////연산자
//            //int a = 5, b = 3;
//            //int sum = a + b; //산술연산자 사용 +
//            //bool isEqual = (a == b); //관계형 연산자 사용

//            //Console.WriteLine($"합 : {sum}");
//            //Console.WriteLine($"a와 b가 같은가? {isEqual}");


//            ////단항 연산자
//            //int num = 10;
//            //Console.WriteLine(+num);
//            //Console.WriteLine(-num);

//            //bool flag = false;
//            //Console.WriteLine(!flag);


//            ////산술 연산자
//            //int a = 10, b = 3;

//            //Console.WriteLine(a + b);
//            //Console.WriteLine(a - b);
//            //Console.WriteLine(a * b);
//            //Console.WriteLine(a / b);
//            //Console.WriteLine(a % b);


//            ////문자열 연결 연산자
//            //string str1 = "Alice";
//            //string str2 = "Smith";

//            //Console.WriteLine(str1 + str2);


//            //int a = 5;
//            //int b = 4;

//            ////할당 연산자
//            ////a = a + b;
//            //a += b;         // 두 식은 동일하다.
//            //Console.WriteLine($"a += b: {a}");
//            //a = 5;

//            //a -= b;
//            //Console.WriteLine($"a -= b: {a}");
//            //a = 5;

//            //a *= b;
//            //Console.WriteLine($"a *= b: {a}");
//            //a = 5;

//            //a /= b;
//            //Console.WriteLine($"a /= b: {a}");
//            //a = 5;


//            ////캐릭터 스탯 계산
//            //int baseAttack = 50;
//            //int weaponAttack = 30;
//            //int totalAttack = baseAttack + weaponAttack;

//            //Console.WriteLine("=== 공격력 계산 ===");
//            //Console.WriteLine($"기본 공격력: {baseAttack}");
//            //Console.WriteLine($"무기 공격력: {weaponAttack}");
//            //Console.WriteLine($"총 공격력: {totalAttack}");

//            ////데미지 계산
//            //int playerHealth = 100;
//            //int damage = 25;
//            //playerHealth -= damage;

//            //Console.WriteLine("\n=== 데미지 계산 ===");
//            //Console.WriteLine($"받은 데미지: {damage}");
//            //Console.WriteLine($"남은 체력: {playerHealth}");

//            ////경험치 계산
//            //int monstersKilled = 5;
//            //int expPerMonster = 100;
//            //int totalExp = monstersKilled * expPerMonster;

//            //Console.WriteLine("\n=== 경험치 획득 ===");
//            //Console.WriteLine($"처치한 몬스터: {monstersKilled}마리");
//            //Console.WriteLine($"몬스터 당 경험치: {expPerMonster}");
//            //Console.WriteLine($"총 경험치: {totalExp}");

//            ////아이템 분배
//            //int totalGold = 1000;
//            //int playerCount = 4;
//            //int goldPerPlayer = totalGold / playerCount;
//            //int remainingGold = totalGold % playerCount;

//            //Console.WriteLine("\n=== 골드 분배 ===");
//            //Console.WriteLine($"총 골드: {totalGold}");
//            //Console.WriteLine($"플레이어 수: {playerCount}명");
//            //Console.WriteLine($"1인당 당 골드: {goldPerPlayer}");
//            //Console.WriteLine($"남은 골드: {remainingGold}");


//            ////증감 연산자
//            //int b = 3;
//            //b++;    //후위 증가
//            //Console.WriteLine(b);

//            //--b;    //전위 감소
//            //Console.WriteLine(b);


//            //Console.WriteLine("=== 몬스터 처치 ===");
//            //int killCount = 0;
//            //Console.WriteLine($"고블린 처치! (킬 카운트: {++killCount})");
//            //Console.WriteLine($"오크 처치! (킬 카운트: {++killCount})");
//            //Console.WriteLine($"드래곤 처치! (킬 카운트: {++killCount})");
//            //Console.WriteLine($"총 처치 수: {killCount}마리");

//            //Console.WriteLine("\n=== 사격 ===");
//            //int ammo = 30;
//            //Console.WriteLine($"남은 탄약: {ammo}");
//            //Console.WriteLine($"사격! 남은 탄약: {--ammo}");
//            //Console.WriteLine($"사격! 남은 탄약: {--ammo}");
//            //Console.WriteLine($"사격! 남은 탄약: {--ammo}");

//            //Console.WriteLine("\n=== 카운트다운 ===");
//            //int countdown = 3;
//            //Console.WriteLine($"{countdown--}");
//            //Console.WriteLine($"{countdown--}");
//            //Console.WriteLine($"{countdown--}");
//            //Console.WriteLine("발사!");


//            ////관계형 연산자
//            //int x = 5;
//            //int y = 10;

//            //Console.WriteLine(x > y);
//            //Console.WriteLine(x < y);
//            //Console.WriteLine(x >= y);
//            //Console.WriteLine(x <= y);
//            //Console.WriteLine(x == y);
//            //Console.WriteLine(x != y);


//            ////논리 연산자
//            //bool a, b;

//            ////AND
//            //a = true; b = true;
//            //Console.WriteLine(a && b);
//            //a = true; b = false;
//            //Console.WriteLine(a && b);
//            //a = false; b = true;
//            //Console.WriteLine(a && b);
//            //a = false; b = false;
//            //Console.WriteLine(a && b);

//            ////OR
//            //a = true; b = true;
//            //Console.WriteLine(a || b);
//            //a = true; b = false;
//            //Console.WriteLine(a || b);
//            //a = false; b = true;
//            //Console.WriteLine(a || b);
//            //a = false; b = false;
//            //Console.WriteLine(a || b);

//            ////NOT
//            //a = true;
//            //Console.WriteLine(!a);


//            ////비트 연산자
//            //int x = 5;      // 0101
//            //int y = 3;      // 0011

//            //string binary = Convert.ToString(x & y, 2).PadLeft(8, '0');
//            //Console.WriteLine($"8비트 AND 연산: {binary}");     // 0000 0001

//            //binary = Convert.ToString(x | y, 2).PadLeft(8, '0');
//            //Console.WriteLine($"8비트 OR 연산: {binary}");      // 0000 0111

//            //binary = Convert.ToString(x ^ y, 2).PadLeft(8, '0');
//            //Console.WriteLine($"8비트 XOR 연산: {binary}");     // 0000 0110

//            //binary = Convert.ToString(~x, 2).PadLeft(8, '0');
//            //Console.WriteLine($"8비트 OR 연산: {binary}");      // 1111 1010


//            ////시프트 연산자
//            //int value = 4;              // 0100

//            //string binary = Convert.ToString(value << 1, 2).PadLeft(4, '0');
//            //Console.WriteLine(binary);  // 1000

//            //binary = Convert.ToString(value >> 1, 2).PadLeft(4, '0');
//            //Console.WriteLine(binary);  // 0010


//            ////기타 연산자
//            //int a = 10, b = 20;
//            //int max = (a > b) ? a : b;
//            //Console.WriteLine(max);

//            ////사용법
//            //int score = 85;
//            //string result = (score >= 60) ? "합격" : "불합격";

//            //Console.WriteLine("=== 시험 결과 ===");
//            //Console.WriteLine($"점수: {score}");
//            //Console.WriteLine($"결과: {result}");


//            ////예제 2
//            //int level = 45;
//            //string rank = (level > 50) ? "고급" : (level > 30) ? "중급" : "초급";

//            //Console.WriteLine("=== 플레이어 등급 ===");
//            //Console.WriteLine($"레벨: {level}");
//            //Console.WriteLine($"등급: {rank}");


//            ////예제 3
//            //int health = 30;
//            //int maxHealth = 100;
//            //string status = ((double)health / maxHealth * 100 >= 70) ? "안정" : ((double)health / maxHealth * 100 >= 30) ? "주의" : "위험";

//            //Console.WriteLine("=== 플레이어 체력 ===");
//            //Console.WriteLine($"현재 체력: {(double)health / maxHealth * 100}%");
//            //Console.WriteLine($"상태: {status}");


//            ////연산자 우선순위
//            //int result = 10 + 5 * 2;           //곱셈이 덧셈보다 우선
//            //Console.WriteLine(result);

//            //int adjustedResult = (10 + 5) * 2; //괄호로 우선순위 변경
//            //Console.WriteLine(adjustedResult);


//            //// 예제 2: 데미지 계산
//            //int baseDamage = 50;
//            //int bonusDamage = 20;
//            //double criticalMultiplier = 1.5;

//            //// 잘못된 계산
//            //double damage1 = baseDamage + bonusDamage * criticalMultiplier;
//            //// 올바른 계산
//            //double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

//            //Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
//            //Console.WriteLine($"기본 데미지: {baseDamage}");
//            //Console.WriteLine($"보너스 데미지: {bonusDamage}");
//            //Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
//            //Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
//            //Console.WriteLine($"올바른 계산: {damage2}");  // 105.0
//        }
//    }
//}
