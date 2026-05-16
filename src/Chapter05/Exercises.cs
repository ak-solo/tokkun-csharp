using System.Globalization;
using System.Runtime.InteropServices;

public class Exercises
{
    // 問題 5-1: 各要素を 2 倍にした新しい配列を返す
    public static int[] Problem5_1(int[] numbers)
    {
        int[] result = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            result[i] = numbers[i] * 2;
        }
        return result;
    }

    // 問題 5-2: 逆順にした新しい配列を返す
    public static int[] Problem5_2(int[] numbers)
    {
        int[] result = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            result[i] = numbers[numbers.Length - 1 - i];
        }
        return result;
    }

    // 問題 5-3: 偶数と奇数に分類して返す（ジャグ配列）
    //           result[0] = 偶数配列、result[1] = 奇数配列（入力順を保つ）
    public static int[][] Problem5_3(int[] numbers)
    {
        var even = new List<int>();
        var odd = new List<int>();
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                even.Add(num);
            }
            else
            {
                odd.Add(num);
            }
        }
        int[][] result = new int[2][];
        result[0] = even.ToArray();
        result[1] = odd.ToArray();
        return result;
    }

    // 問題 5-4: 合計が 100 を超えるか 10 個収集するまで要素を集めて返す
    public static int[] Problem5_4(int[] numbers)
    {
        var result = new List<int>();
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            result.Add(numbers[i]);
            if (sum > 100 || result.Count == 10)
            {
                return result.ToArray();
            }
        }
        return result.ToArray();
    }

    // 問題 5-5: value の 16 桁 2 進数表現を int 配列で返す
    //           result[0] = MSB（最上位ビット）、result[15] = LSB（最下位ビット）
    public static int[] Problem5_5(int value)
    {
        int[] result = new int[16];
        for (int i = 15; i >= 0; i--)
        {
            if (value == 0) break;
            result[i] = value % 2;
            value /= 2;
        }
        return result;
    }

    // 問題 5-6: 九九表を 9×9 の 2 次元配列で返す
    //           result[i, j] = (i+1) × (j+1)
    public static int[,] Problem5_6()
    {
        int[,] result = new int[9, 9];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                result[i, j] = (i + 1) * (j + 1);
            }
        }
        return result;
    }

    // 問題 5-7: 九九配列を内部で使用して x × y を返す（1 ≤ x, y ≤ 9）
    public static int Problem5_7(int x, int y)
    {
        int[,] kuku = Problem5_6();
        return kuku[x - 1, y - 1];
    }

    // 問題 5-8: 昇順に並べ替えた新しい配列を返す
    public static int[] Problem5_8(int[] numbers)
    {
        int[] result = (int[])numbers.Clone();
        for (int i = 0; i < result.Length; i++)
        {
            for (int j = 1; j < result.Length; j++)
            {
                if (result[j - 1] > result[j])
                {
                    int tmp = result[j - 1];
                    result[j - 1] = result[j];
                    result[j] = tmp;
                }
            }
        }
        return result;
    }

    // 問題 5-9: 配列の平均値（整数）を返す
    public static int Problem5_9(int[] numbers)
    {
        int count = numbers.Length;
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum / count;
    }

    // 問題 5-10: 勝ち(1)/負け(0) の配列から {勝ち数, 負け数} を返す
    public static int[] Problem5_10(int[] results)
    {
        int win = 0;
        int lose = 0;
        foreach (int r in results)
        {
            if (r == 1)
            {
                win++;
            }
            else
            {
                lose++;
            }
        }
        return new int[] { win, lose };
    }

    // 問題 5-11: 各回の得点配列の合計を返す
    public static int Problem5_11_TotalScore(int[] scores)
    {
        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        return sum;
    }

    // 問題 5-12: 配列の最大値を返す
    public static int Problem5_12(int[] numbers)
    {
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    // 問題 5-13: 配列の {最大値, 最小値} を返す
    public static int[] Problem5_13(int[] numbers)
    {
        int max = numbers[0];
        int min = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
        return new int[] { max, min };
    }

    // 問題 5-14: 合計が 100 を超えた時点の合計値を返す
    public static int Problem5_14(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
            if (sum > 100)
            {
                return sum;
            }
        }
        return sum;
    }

    // 問題 5-15: 3 ストライクまたは 4 ボールで停止し "Nストライク,Mボール" を返す
    //            pitches: 1=ストライク、2=ボール
    public static string Problem5_15(int[] pitches)
    {
        int strikes = 0;
        int balls = 0;
        foreach (int pitch in pitches)
        {
            if (pitch == 1)
            {
                strikes++;
            }
            else if (pitch == 2)
            {
                balls++;
            }
            if (strikes == 3 || balls == 4)
            {
                return $"{strikes}ストライク,{balls}ボール";
            }
        }
        return $"{strikes}ストライク,{balls}ボール";
    }

    // 問題 5-16: 5-15 にファウル(3)を追加。2 ストライクまでファウルはストライク扱い
    //            pitches: 1=ストライク、2=ボール、3=ファウル
    public static string Problem5_16(int[] pitches)
    {
        int strikes = 0;
        int balls = 0;
        foreach (int pitch in pitches)
        {
            if (pitch == 1)
            {
                strikes++;
            }
            else if (pitch == 2)
            {
                balls++;
            }
            else if (pitch == 3 && strikes < 2)
            {
                strikes++;
            }
            if (strikes == 3 || balls == 4)
            {
                return $"{strikes}ストライク,{balls}ボール";
            }
        }
        return $"{strikes}ストライク,{balls}ボール";
    }

    // 問題 5-17: 最初の 0 の手前までの合計を返す（0 は含めない）
    public static int Problem5_17(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            if (num == 0)
            {
                return sum;
            }
            sum += num;
        }
        return sum;
    }

    // 問題 5-18: 最初の 0 の手前までの平均値（整数）を返す（0 は含めない）
    public static int Problem5_18(int[] numbers)
    {
        int count = 0;
        int sum = 0;
        foreach (int num in numbers)
        {
            if (num == 0)
            {
                if (count == 0) return 0;
                return sum / count;
            }
            count++;
            sum += num;
        }
        return sum / count;
    }
}
