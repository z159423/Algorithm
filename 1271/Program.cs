using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine(); // 사용자 입력 받기
        string[] numbers = input.Split(' '); // 공백을 기준으로 문자열 분리

        BigInteger money = BigInteger.Parse(numbers[0]);
        BigInteger people = BigInteger.Parse(numbers[1]);

        // BigInteger num1 = Console.Read();
        // BigInteger num2 = Console.Read();

        Console.WriteLine(money / people);
        Console.WriteLine(money % people);
    }
}