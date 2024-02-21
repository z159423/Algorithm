// See https://aka.ms/new-console-template for more information

using System;

namespace test
{

    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            string input = Console.ReadLine();

            // 입력받은 문자열을 공백으로 분리
            string[] parts = input.Split(' ');

            // 분리된 문자열을 각각 정수로 변환
            a = Convert.ToInt32(parts[0]);
            b = Convert.ToInt32(parts[1]);

            Console.WriteLine(a + b);
        }
    }
}


//닷넷 9.0 최상의 문이 적용되어 Main 메소드 없이 실행됨
// using static System.Console;
// Write(Read() + Read() + Read() - 128);