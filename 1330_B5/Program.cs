using System;

int A, B;

string s = Console.ReadLine();
string[] s1 = s.Split(' ');

A = int.Parse(s1[0]);
B = int.Parse(s1[1]);

if(A > B)
{
    Console.WriteLine(">");
}
else if(A < B)
{
    Console.WriteLine("<");
}
else if(A == B)
{
    Console.WriteLine("==");
}