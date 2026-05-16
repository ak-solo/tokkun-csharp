public class Exercises
{
    private static int Square(int n)
    {
        return n * n;
    }

    // 問題 6-1: n の 2 乗を返す
    public static int Problem6_1(int n)
    {
        return Square(n);
    }

    private static int Average(int a, int b)
    {
        return (a + b) / 2;
    }

    // 問題 6-2: a と b の平均（整数除算）を返す
    public static int Problem6_2(int a, int b)
    {
        return Average(a, b);
    }

    private static int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    // 問題 6-3: a と b の大きい方を返す
    public static int Problem6_3(int a, int b)
    {
        return Max(a, b);
    }

    private static string Triangle(int size, char ch)
    {
        var lines = new List<string>();
        for (int i = 1; i <= size; i++)
        {
            lines.Add(new string(ch, i));
        }
        return String.Join(Environment.NewLine, lines);
    }

    // 問題 6-4: $ で作った直角三角形を文字列で返す（行を Environment.NewLine で結合）
    public static string Problem6_4(int size)
    {
        return Triangle(size, '$');
    }

    // 問題 6-5: 任意の文字 ch で作った直角三角形を文字列で返す（行を Environment.NewLine で結合）
    public static string Problem6_5(int size, char ch)
    {
        return Triangle(size, ch);
    }

    private static string KukuRow(int n)
    {
        var lines = new List<string>();
        for (int m = 1; m <= 9; m++)
        {
            lines.Add($"{n}×{m}={n * m}");
        }
        return string.Join(Environment.NewLine, lines);
    }

    // 問題 6-6: 九九の n の段を文字列で返す（"n×1=積" 形式、行を Environment.NewLine で結合）
    public static string Problem6_6(int n)
    {
        return KukuRow(n);
    }

    private static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int x = 2; x <= (int)Math.Sqrt(n); x++)
        {
            if (n % x == 0) return false;
        }
        return true;
    }

    // 問題 6-7: n が素数なら true、そうでなければ false を返す
    public static bool Problem6_7(int n)
    {
        return IsPrime(n);
    }

    private static void Swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }

    // 問題 6-8: a と b の値を交換する（ref で呼び出し元の変数を書き換える）
    public static void Problem6_8(ref int a, ref int b)
    {
        Swap(ref a, ref b);
    }

    private static void Sort(int[] numbers)
    {
        for (int i = 0; i <= numbers.Length - 2; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j <= numbers.Length - 1; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }
            Swap(ref numbers[i], ref numbers[minIndex]);
        }
    }

    // 問題 6-9: numbers を昇順に並べ替える（元の配列を直接書き換える）
    public static void Problem6_9(int[] numbers)
    {
        Sort(numbers);
    }
}
