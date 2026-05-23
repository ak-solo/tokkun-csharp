public class Exercises
{
    // 問題 9-1: 前後の空白を除去して大文字変換
    public static string Problem9_1(string input)
    {
        return input.Trim().ToUpper();
    }

    // 問題 9-2: 区切り文字より前の部分文字列を返す（なければ元の文字列）
    public static string Problem9_2(string text, char delimiter)
    {
        int idx = text.IndexOf(delimiter);
        if (idx == -1) return text;
        return text.Substring(0, idx);
    }

    // 問題 9-3: CSV 文字列を分割して各要素をトリムした配列を返す
    public static string[] Problem9_3(string csv)
    {
        string[] values = csv.Split(',');
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = values[i].Trim();
        }
        return values;
    }

    // 問題 9-4: text 内の oldWord をすべて newWord に置換
    public static string Problem9_4(string text, string oldWord, string newWord)
    {
        return text.Replace(oldWord, newWord);
    }

    // 問題 9-5: text が prefix で始まれば true
    public static bool Problem9_5_StartsWith(string text, string prefix)
    {
        return text.StartsWith(prefix);
    }

    // 問題 9-5: text が suffix で終わっていれば true
    public static bool Problem9_5_EndsWith(string text, string suffix)
    {
        return text.EndsWith(suffix);
    }

    // 問題 9-5: text に keyword が含まれていれば true
    public static bool Problem9_5_Contains(string text, string keyword)
    {
        return text.Contains(keyword);
    }

    // 問題 9-6: 曜日を日本語で返す
    public static string Problem9_6(DateTime date)
    {
        switch (date.DayOfWeek)
        {
            case DayOfWeek.Monday:
                return "月曜日";
            case DayOfWeek.Tuesday:
                return "火曜日";
            case DayOfWeek.Wednesday:
                return "水曜日";
            case DayOfWeek.Thursday:
                return "木曜日";
            case DayOfWeek.Friday:
                return "金曜日";
            case DayOfWeek.Saturday:
                return "土曜日";
            case DayOfWeek.Sunday:
                return "日曜日";
            default:
                throw new ArgumentOutOfRangeException(nameof(date));
        }
    }

    // 問題 9-7: 2 つの日付の差分（日数）を返す
    public static int Problem9_7(DateTime from, DateTime to)
    {
        TimeSpan diff = to - from;
        return diff.Days;
    }

    // 問題 9-8: "yyyy年M月d日" 形式で日付を返す
    public static string Problem9_8(DateTime date)
    {
        return date.ToString("yyyy年M月d日");
    }

    // 問題 9-9: days 日後の日付を "yyyy/MM/dd" 形式で返す
    public static string Problem9_9(DateTime date, int days)
    {
        return date.AddDays(days).ToString("yyyy/MM/dd");
    }
}
