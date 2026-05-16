public class Exercises
{
    // 問題 1-1: "Hello World" を返す
    public static string Problem1_1()
    {
        return "Hello World";
    }

    // 問題 1-2: 変数 x に 11 を代入し、"x=11" を返す
    public static string Problem1_2()
    {
        int x = 11;
        return $"x={x}";
    }

    // 問題 1-3: 変数 x=13, y=17 を代入し、"x=13,y=17" を返す
    public static string Problem1_3()
    {
        int x = 13;
        int y = 17;
        return $"x={x},y={y}";
    }

    // 問題 1-4: 13 と 17 の和を返す
    public static int Problem1_4()
    {
        int x = 13 + 17;
        return x;
    }

    // 問題 1-5: 13 と 17 の積を返す（変数を使わないこと）
    public static int Problem1_5()
    {
        return 13 * 17;
    }

    // 問題 1-6: x=7 を 3 倍した値と、さらに整数除算で半分にした値をカンマ区切りで返す
    public static string Problem1_6()
    {
        int x = 7;
        x = x * 3;
        return $"{x},{x / 2}";
    }

    // 問題 1-7: x=3, y=7 の値を入れ替えた結果を "x=7,y=3" の形式で返す
    public static string Problem1_7()
    {
        int x = 3;
        int y = 7;
        int tmp = x;
        x = y;
        y = tmp;
        return $"x={x},y={y}";
    }

    // 問題 1-8: 変数 x=19, y=23 の積を変数 z に代入して返す
    public static int Problem1_8()
    {
        int x = 19;
        int y = 23;
        int z = x * y;
        return z;
    }

    // 問題 1-9: int 変数 x=10, y=3 を宣言し、x / y の結果（double）を返す
    public static double Problem1_9()
    {
        int x = 10;
        int y = 3;
        return (double)x / y;
    }

    // 問題 1-10: 10 / 3 の整数除算の結果を int 変数に代入して返す
    public static int Problem1_10()
    {
        int x = 10 / 3;
        return x;
    }
}
