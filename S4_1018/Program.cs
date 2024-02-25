using System;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Linq;

int M, N;


string[] s1 = Console.ReadLine().Split();

M = int.Parse(s1[0]);
N = int.Parse(s1[1]);


string[] chessBoard = new string[M];

for (int i = 0; i < M; i++)
{
    chessBoard[i] = Console.ReadLine();
}

int minCount = int.MaxValue;
char firstColor = ' ';

//시작 지점 
for (int i = 0; i < (M + 1) - 8; i++)
{
    for (int j = 0; j < (N + 1) - 8; j++)
    {
        int missedCount = 0;

        //체스판 순환
        for (int x = 0; x < 8; x++)
        {
            for (int z = 0; z < 8; z++)
            {
                if (x == 0 && z == 0)
                {
                    firstColor = chessBoard[x + i][z + j];
                }

                if (!Check(x, z, chessBoard[x + i][z + j]))
                    missedCount++;
            }
        }

        //최솟값 변경
        if (missedCount < minCount)
            minCount = missedCount;
    }
}

bool Check(int x, int y, char color)
{
    if (firstColor == 'W')
    {
        if (x % 2 == 0)
        {
            if (y % 2 == 0)
            {
                if (color == 'W')
                    return true;
                else
                    return false;
            }
            else
            {
                if (color == 'B')
                    return true;
                else
                    return false;
            }
        }
        else if (x % 2 == 1)
        {
            if (y % 2 == 0)
            {
                if (color == 'B')
                    return true;
                else
                    return false;
            }
            else
            {
                if (color == 'W')
                    return true;
                else
                    return false;
            }
        }
    }
    else if (firstColor == 'B')
    {
        if (x % 2 == 0)
        {
            if (y % 2 == 0)
            {
                if (color == 'B')
                    return true;
                else
                    return false;
            }
            else
            {
                if (color == 'W')
                    return true;
                else
                    return false;
            }
        }
        else if (x % 2 == 1)
        {
            if (y % 2 == 0)
            {
                if (color == 'W')
                    return true;
                else
                    return false;
            }
            else
            {
                if (color == 'B')
                    return true;
                else
                    return false;
            }
        }
    }

    return false;
}

// Console.WriteLine(W);
// Console.WriteLine(B);

Console.WriteLine(minCount);
