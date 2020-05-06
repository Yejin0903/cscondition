using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscondition
{
    class Program
    {
        static void Main(string[] args)
        {
            //홀수, 짝수 구분
            Console.Write("숫자를 입력하세요 : ");
            int input = int.Parse(Console.ReadLine());

            /*
            if (input % 2 == 0)
            {
                Console.WriteLine("짝수 입니다!");
            }else
            { 
                Console.WriteLine("홀수 입니다!");
            }
            */
            /*
            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수 입니다!");
                    break;
                case 1:
                    Console.WriteLine("홀수 입니다!");
                    break;
            }
            */
            
            //삼항 연산자
            Console.WriteLine(input % 2==0 ? "짝수 입니다" : " 홀수 입니다.");
            Console.WriteLine(input > 0 ? "자연수 입니다" : "자연수가 아닙니다.");

            //현재 시간 구하기
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            //오전, 오후 구분
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다!");
            }
            else if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간입니다!");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다!");
            }
            Console.Write("이번 달은 몇 월 인가요?");
            int input2 = int.Parse(Console.ReadLine());
            switch (input2)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울 입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄 입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름 입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을 입니다.");
                    break;
                default:
                    Console.WriteLine("대체 어느 행성에 살고 계십니까?");
                    break;
            }

            Console.Write("입력 : ");
            String line = Console.ReadLine();
            if(line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요!");
            }
            else
            {
                Console.WriteLine("인사 안 하네요?");
            }
        }
    }
}