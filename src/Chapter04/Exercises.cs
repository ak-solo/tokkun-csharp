using System.ComponentModel;
using System.Globalization;

public class Exercises
{
    // 問題 4-1: "SPAM" を 10 個カンマ区切りで並べた文字列を返す
    public static string Problem4_1()
    {
        string result = "";
        for (int i = 1; i <= 10; i++)
        {
            result += "SPAM";
            if (i < 10) result += ",";
        }
        return result;
    }

    // 問題 4-2: 九九の三の段 (3,6,9,...,27) をカンマ区切りの文字列で返す
    public static string Problem4_2()
    {
        string result = "";
        for (int i = 1; i <= 9; i++)
        {
            result += 3 * i;
            if (i < 9) result += ",";
        }
        return result;
    }

    // 問題 4-3: 2^1 〜 2^8 をカンマ区切りの文字列で返す
    public static string Problem4_3()
    {
        string result = "";
        for (int i = 1; i <= 8; i++)
        {
            result += Math.Pow(2, i);
            if (i < 8) result += ",";
        }
        return result;
    }

    // 問題 4-4: 7! を返す
    public static int Problem4_4()
    {
        int result = 1;
        for (int i = 2; i <= 7; i++)
        {
            result *= i;
        }
        return result;
    }

    // 問題 4-5: "*" を n 個並べた文字列を返す
    public static string Problem4_5(int n)
    {
        string result = "";
        for (int i = 1; i <= n; i++)
        {
            result += "*";
        }
        return result;
    }

    // 問題 4-6: 0〜9 を繰り返す n 文字の文字列を返す
    //            例: n=14 → "01234567890123"
    public static string Problem4_6(int n)
    {
        string result = "";
        int num = 0;
        for (int i = 1; i <= n; i++)
        {
            result += num;
            num++;
            if (num > 9) num = 0;
        }
        return result;
    }

    // 問題 4-7: n を素因数分解した結果をカンマ区切りの文字列で返す
    //            例: n=20100 → "2,2,3,5,5,67"
    public static string Problem4_7(int n)
    {
        string result = "";
        int d = 2;
        while (n > 1)
        {
            if (n % d == 0)
            {
                n /= d;
                result += d;
                if (n > 1) result += ",";
            }
            else
            {
                d += 1;
            }
        }
        return result;
    }

    // 問題 4-8: n が素数なら true を返す
    public static bool Problem4_8(int n)
    {
        if (n <= 1) return false;

        for (int d = 2; d <= (int)Math.Sqrt(n); d++)
        {
            if (n % d == 0)
            {
                return false;
            }
        }
        return true;
    }

    // 問題 4-9: "$" で作った三角形を改行区切りの文字列で返す
    public static string Problem4_9(int size)
    {
        string result = "";
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                result += "$";
            }
            if (i < size) result += Environment.NewLine;
        }
        return result;
    }

    // 問題 4-10: "X" で作った × 印を改行区切りの文字列で返す
    public static string Problem4_10(int size)
    {
        string result = "";
        for (int i = 1; i <= size; i++)
        {
            int left = i;
            int right = size + 1 - i;
            for (int j = 1; j <= size; j++)
            {
                if (j == left || j == right)
                {
                    result += "X";
                }
                else
                {
                    result += " ";
                }
            }
            if (i < size) result += Environment.NewLine;
        }
        return result;
    }

    // 問題 4-11: フィボナッチ数列の 1000 以下の項をカンマ区切りの文字列で返す
    //             先頭は 0, 1 とする
    public static string Problem4_11()
    {
        string result = "";
        int a = 0;
        int b = 1;
        result = a + "," + b;
        do
        {
            int nxt = a + b;
            a = b;
            b = nxt;
            if (nxt > 1000) break;
            result += "," + nxt;
        } while (true);
        return result;
    }
}
