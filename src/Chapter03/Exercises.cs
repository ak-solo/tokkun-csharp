public class Exercises
{
    // 問題 3-1: x > y のとき "xはyより大きい。"、それ以外は "" を返す
    public static string Problem3_1(int x, int y)
    {
        if (x > y)
        {
            return "xはyより大きい。";
        }
        else
        {
            return "";
        }
    }

    // 問題 3-2: x > y → "xはyより大きい"、x < y → "xはyより小さい"、x = y → ""
    public static string Problem3_2(int x, int y)
    {
        if (x > y)
        {
            return "xはyより大きい";
        }
        else if (x < y)
        {
            return "xはyより小さい";
        }
        else
        {
            return "";
        }
    }

    // 問題 3-3: x と y の大きい方を返す
    public static int Problem3_3(int x, int y)
    {
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }

    // 問題 3-4: x > y → "xはyより大きい"、x < y → "xはyより小さい"、x = y → "xとyは等しい"
    public static string Problem3_4(int x, int y)
    {
        if (x > y)
        {
            return "xはyより大きい";
        }
        else if (x < y)
        {
            return "xはyより小さい";
        }
        else
        {
            return "xとyは等しい";
        }
    }

    // 問題 3-5: 偶数なら "偶数"、奇数なら "奇数" を返す
    public static string Problem3_5(int x)
    {
        if (x % 2 == 0)
        {
            return "偶数";
        }
        else
        {
            return "奇数";
        }
    }

    // 問題 3-6: "正の偶数" / "正の奇数" / "負の偶数" / "負の奇数" を返す（0 は "正の偶数"）
    public static string Problem3_6(int x)
    {
        if (x >= 0)
        {
            if (x % 2 == 0)
            {
                return "正の偶数";
            }
            else
            {
                return "正の奇数";
            }
        }
        else
        {
            if (x % 2 == 0)
            {
                return "負の偶数";
            }
            else
            {
                return "負の奇数";
            }
        }
    }

    // 問題 3-7 ケース1: 60点以上 → "合格"、未満 → "不合格"
    public static string Problem3_7_Case1(int score)
    {
        if (score >= 60)
        {
            return "合格";
        }
        else
        {
            return "不合格";
        }
    }

    // 問題 3-7 ケース2: 80点以上 → "たいへんよくできました。"
    //                   60点以上 → "よくできました。"
    //                   60点未満 → "ざんねんでした。"
    public static string Problem3_7_Case2(int score)
    {
        if (score >= 80)
        {
            return "たいへんよくできました。";
        }
        else if (score >= 60)
        {
            return "よくできました。";
        }
        else
        {
            return "ざんねんでした。";
        }
    }

    // 問題 3-7 ケース3: 80点以上 → "優"、70点以上 → "良"、60点以上 → "可"、未満 → "不可"
    public static string Problem3_7_Case3(int score)
    {
        if (score >= 80)
        {
            return "優";
        }
        else if (score >= 70)
        {
            return "良";
        }
        else if (score >= 60)
        {
            return "可";
        }
        else
        {
            return "不可";
        }
    }

    // 問題 3-8: 中間・期末の点数から合否を返す
    //   合格条件: 両方60点以上 / 合計130点以上 / 合計100点以上かつどちらかが90点以上
    public static string Problem3_8(int midterm, int final)
    {
        if ((midterm >= 60 && final >= 60) ||
            (midterm + final >= 130) ||
            (midterm + final >= 100 && (midterm >= 90 || final >= 90)))
        {
            return "合格";
        }
        else
        {
            return "不合格";
        }
    }

    // 問題 3-9: 曜日(0=日〜6=土)と時間帯(0=午前,1=午後,2=夜間)から "○" または "休診" を返す
    public static string Problem3_9(int dayOfWeek, int timeOfDay)
    {
        switch (dayOfWeek)
        {
            case 0:             // 日曜日
                return "休診";
            case 1:
            case 4:     // 月曜日／木曜日
                return "○";
            case 2:
            case 5:     // 火曜日／金曜日
                if (timeOfDay == 0)     // 午前中
                {
                    return "休診";
                }
                else
                {
                    return "○";
                }
            case 3:             // 水曜日
                if (timeOfDay == 2)     // 夜間
                {
                    return "休診";
                }
                else
                {
                    return "○";
                }
            default:             // 土曜日
                if (timeOfDay == 0)     // 午前中
                {
                    return "○";
                }
                else
                {
                    return "休診";
                }
        }
    }

    // 問題 3-10 条件1: x < y かつ x と y がともに偶数
    public static bool Problem3_10_Cond1(int x, int y)
    {
        return x < y && x % 2 == 0 && y % 2 == 0;
    }

    // 問題 3-10 条件2: x = y かつ負の数
    public static bool Problem3_10_Cond2(int x, int y)
    {
        return x == y && x < 0;
    }

    // 問題 3-10 条件3: x < y または x が偶数
    public static bool Problem3_10_Cond3(int x, int y)
    {
        return x < y || x % 2 == 0;
    }

    // 問題 3-10 条件4: (x ≤ 10 または x ≥ 100) かつ (y ≥ 10 かつ y ≤ 100)
    public static bool Problem3_10_Cond4(int x, int y)
    {
        return (x <= 10 || x >= 100) && (y >= 10 && y <= 100);
    }

    // 問題 3-10 条件5: 「x も y も負の数」ではない（否定）
    public static bool Problem3_10_Cond5(int x, int y)
    {
        return !(x < 0 && y < 0);
    }

    // 問題 3-11: 寿司占い（switch を使うこと）
    //   1=まぐろ, 2=えび, 3=こはだ, 4=いくら, 5=たまご, その他 → エラーメッセージ
    public static string Problem3_11(int choice)
    {
        switch (choice)
        {
            case 1:     // まぐろ
                return "大吉！今日は積極的に行動しよう。";
            case 2:     // えび
                return "中吉。慎重に進めば良い結果が待っている。";
            case 3:     // こはだ
                return "吉。こつこつ続けることで道が開ける。";
            case 4:     // いくら
                return "小吉。意外なところからチャンスがやってくる。";
            case 5:     // たまご
                return "末吉。今日はゆったり過ごすと吉。";
            default:    // その他
                return "選択肢は 1〜5 の数字で入力してください。";
        }
    }

    // 問題 3-12: 月の大小判定（switch を使うこと）
    //   大の月(1,3,5,7,8,10,12) → "{n}月は大の月です"
    //   小の月(2,4,6,9,11)      → "{n}月は小の月です"
    //   1〜12 以外              → "そんな月はありません"
    public static string Problem3_12(int month)
    {
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                return $"{month}月は大の月です";
            case 2:
            case 4:
            case 6:
            case 9:
            case 11:
                return $"{month}月は小の月です";
            default:
                return "そんな月はありません";
        }
    }
}
