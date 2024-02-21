using System;
using System.Text;

int count = int.Parse(Console.ReadLine());

int successCount = 0;
string[] words = new string[count];

for (int i = 0; i < count; i++)
{
    words[i] = Console.ReadLine();
}

//문자열 확인
for (int i = 0; i < count; i++)
{
    List<char> checkedWord = new List<char>();
    char lastChar = ' ';

    for (int j = 0; j < words[i].Length; j++)
    {
        if (!lastChar.Equals(words[i][j]))
        {
            if (!checkedWord.Contains(words[i][j]))
            {
                lastChar = words[i][j];
                checkedWord.Add(words[i][j]);
            }
            else
            {
                break;
            }
        }

        if (j == words[i].Length - 1)
            successCount++;
    }
}

Console.WriteLine(successCount);