using System;

int N = int.Parse(Console.ReadLine());

int result = 0;

for (int i = 1; i < N + 1; i++)
{
    string s = i.ToString();

    //한 자리수 일 경우 등차수열이므로 통과
    if (s.Length == 1)
    {
        result++;
        continue;
    }

    if (Check(s))
        result++;
}

Console.WriteLine(result);


bool Check(string s1)
{
    int def = Convert.ToInt32(s1[0]) - Convert.ToInt32(s1[1]);

    for (int i = 0; i < s1.Length - 1; i++)
    {
        if ((Convert.ToInt32(s1[i]) - Convert.ToInt32(s1[i + 1])) != def)
        {
            return false;
        }
    }

    return true;
}
