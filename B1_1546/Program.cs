using System.Linq;
using System;

int count = int.Parse(Console.ReadLine());
string[] s1 = Console.ReadLine().Split().OrderByDescending((n) => int.Parse(n)).ToArray();

int max = int.Parse(s1[0]);

float sum = 0;

// Console.WriteLine(max);

for (int i = 0; i < count; i++)
// {
    // Console.WriteLine((float.Parse(s1[i]) / max) * 100);
    sum += (float.Parse(s1[i]) / max) * 100;
// }

Console.WriteLine(sum / count);

// Console.WriteLine(sum);
// Console.WriteLine(count);
