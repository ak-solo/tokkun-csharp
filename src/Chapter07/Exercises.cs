using System.Collections.Generic;

// 問題 7-1 〜 7-4: Dog クラス
public class Dog
{
    // フィールド（ヒント: private string _name = ""; など）

    // 問題 7-1: 引数なしコンストラクタ
    public Dog() { }

    // 問題 7-4: 犬種を引数に取るコンストラクタ
    public Dog(string breed)
    {
        throw new NotImplementedException("問題 7-4 を実装してください");
    }

    // 問題 7-1: 名前プロパティ
    public string Name
    {
        get => throw new NotImplementedException("問題 7-1 を実装してください");
        set => throw new NotImplementedException("問題 7-1 を実装してください");
    }

    // 問題 7-2: 年齢プロパティ
    public int Age
    {
        get => throw new NotImplementedException("問題 7-2 を実装してください");
        set => throw new NotImplementedException("問題 7-2 を実装してください");
    }

    // 問題 7-4: 犬種プロパティ（読み取り専用）
    public string Breed
    {
        get => throw new NotImplementedException("問題 7-4 を実装してください");
    }

    // 問題 7-4: "犬種: 名前 (年齢歳)" の形式で返す
    public string ShowProfile()
    {
        throw new NotImplementedException("問題 7-4 を実装してください");
    }
}


// 問題 7-5 〜 7-6: CoinCase クラス
public class CoinCase
{
    // 対応する硬貨の種類: 500, 100, 50, 10, 5, 1
    // ヒント: Dictionary<int, int> で硬貨の種類と枚数を管理する

    // コンストラクタ: 6 種類の硬貨を 0 枚で初期化する
    public CoinCase()
    {
        throw new NotImplementedException("問題 7-5 の CoinCase コンストラクタを実装してください");
    }

    // 問題 7-5: 指定した種類の硬貨を枚数分追加する（無効な種類は無視）
    public void AddCoins(int denomination, int count)
    {
        throw new NotImplementedException("問題 7-5 を実装してください");
    }

    // 問題 7-5: 指定した種類の硬貨の枚数を返す
    public int GetCount(int denomination)
    {
        throw new NotImplementedException("問題 7-5 を実装してください");
    }

    // 問題 7-5: 全硬貨の合計金額を返す
    public int GetAmount()
    {
        throw new NotImplementedException("問題 7-5 を実装してください");
    }

    // 問題 7-6: 全硬貨の合計枚数を返す（オーバーロード）
    public int GetCount()
    {
        throw new NotImplementedException("問題 7-6 を実装してください");
    }

    // 問題 7-6: 指定した種類の硬貨の合計金額を返す（オーバーロード）
    public int GetAmount(int denomination)
    {
        throw new NotImplementedException("問題 7-6 を実装してください");
    }
}


public class Exercises
{
    // 問題 7-1: Dog をインスタンス化し、Name に name をセットして返す
    public static string Problem7_1(string name)
    {
        throw new NotImplementedException("問題 7-1 を実装してください");
    }

    // 問題 7-2: Dog に name と age をセットし、"{Name},{Age}" を返す
    public static string Problem7_2(string name, int age)
    {
        throw new NotImplementedException("問題 7-2 を実装してください");
    }

    // 問題 7-3: dog1.Name="ポチ"→"タロ"、dog2.Name="コロ" のまま → "タロ,コロ" を返す
    public static string Problem7_3()
    {
        throw new NotImplementedException("問題 7-3 を実装してください");
    }

    // 問題 7-4: new Dog(breed) を生成し name/age をセットして ShowProfile() を返す
    public static string Problem7_4(string breed, string name, int age)
    {
        throw new NotImplementedException("問題 7-4 を実装してください");
    }

    // 問題 7-5: CoinCase に denomination を count 枚追加し、合計金額を返す
    public static int Problem7_5(int denomination, int count)
    {
        throw new NotImplementedException("問題 7-5 を実装してください");
    }

    // 問題 7-6: CoinCase に denomination を count 枚追加し、"{合計枚数},{指定種の合計金額}" を返す
    public static string Problem7_6(int denomination, int count)
    {
        throw new NotImplementedException("問題 7-6 を実装してください");
    }
}
