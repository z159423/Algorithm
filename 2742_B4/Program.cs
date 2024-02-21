using System;
using System.Text;

int N = int.Parse(Console.ReadLine());

StringBuilder s = new StringBuilder();

for(int i = N; i > 0; i--)
{
    s.AppendLine(i.ToString());
}

Console.WriteLine(s.ToString());