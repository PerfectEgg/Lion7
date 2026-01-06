//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class readString
//    {
//        static void Main(string[] args)
//        {
//            //// 사용자 입력을 문자열로 받기
//            //Console.Write("이름을 입력하세요: ");
//            //string userName = Console.ReadLine();           //사용자로부터 입력 받기

//            //Console.WriteLine($"안녕하세요, {userName}님!"); //출력


//            ////문자열을 정수로 변환
//            //Console.Write("나이을 입력하세요: ");
//            //string input = Console.ReadLine();           //사용자로부터 입력 받기
//            //int age = int.Parse(input);                  //문자열을 정수로 변환

//            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");


//            ////이진수를 정수로 변환
//            //Console.Write("2진수를 입력하세요: ");
//            //string binaryInput = Console.ReadLine();                    //사용자로부터 입력 받기
//            //int decimalValue = Convert.ToInt32(binaryInput, 2);         //2진수를 10진수로 변환
//            //string binaryOutput = Convert.ToString(decimalValue, 2);    //10진수를 2진수로 변환

//            //Console.WriteLine($"입력된 2진수 값: {decimalValue}");
//            //Console.WriteLine($"10진수로 변환: {decimalValue}");
//            //Console.WriteLine($"다시 2진수로 변환: {binaryOutput}");


//            //Console.WriteLine("=== 캐릭터 생성 ===");
//            //Console.Write("캐릭터 이름을 입력하세요: ");
//            //string characterName = Console.ReadLine();
//            //Console.WriteLine($"환영합니다, {characterName}님!");
//            //Console.Write("시작 레벨을 입력하세요: ");
//            //int startLevel = int.Parse(Console.ReadLine());
//            //Console.WriteLine($"{characterName}님의 시작 레벨은 {startLevel}입니다.");


//            ////var을 사용하여 변수 선언
//            //var name = "Alice";     //문자열로 추론
//            //var age = 25;           //정수로 추론
//            //var isStudent = true;   //논리형으로 추론

//            //Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");


//            ////default 키워드
//            //int defaultInt = default;       //0
//            //string defaultString = default; //null
//            //bool defaultBool = default;     //false

//            //Console.WriteLine($"정수 기본값: {defaultInt}");
//            //Console.WriteLine($"문자열 기본값: {defaultString}");
//            //Console.WriteLine($"논리값 기본값: {defaultBool}");


//            ////1. 암시적 변환 (작은 타입 -> 큰 타입)
//            //int smallNumber = 100;
//            //long bigNumber = smallNumber;       //int -> long (자동 변환)
//            //double doubleNumber = smallNumber;  //int -> double (자동 변환)

//            //Console.WriteLine("=== 암시적 형변환 ===");
//            //Console.WriteLine($"int: {smallNumber.GetType()}");
//            //Console.WriteLine($"long: {bigNumber.GetType()}");
//            //Console.WriteLine($"double: {doubleNumber.GetType()}");

//            ////2. 명시적 변환 (큰 타입 -> 작은 타입)
//            //double pi = 3.14159;
//            //int intPi = (int)pi;                //double -> int (명시적 변환) [소수점은 날라감!]
//            //Console.WriteLine("\n=== 명시적 형변환 ===");
//            //Console.WriteLine($"double: {pi}");
//            //Console.WriteLine($"int: {intPi}");

//        }
//    }
//}
