using System.Collections.Generic;
using System.Reflection.Metadata;

// 問題 7-1 〜 7-4: Dog クラス
public class Dog
{
    // フィールド（ヒント: private string _name = ""; など）
    private string mName = "";
    private int mAge = 0;
    private string mBreed = "";

    // 問題 7-1: 引数なしコンストラクタ
    public Dog() { }

    // 問題 7-4: 犬種を引数に取るコンストラクタ
    public Dog(string breed)
    {
        mBreed = breed;
    }

    // 問題 7-1: 名前プロパティ
    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }

    // 問題 7-2: 年齢プロパティ
    public int Age
    {
        get { return mAge; }
        set { mAge = value; }
    }

    // 問題 7-4: 犬種プロパティ（読み取り専用）
    public string Breed
    {
        get { return mBreed; }
    }

    // 問題 7-4: "犬種: 名前 (年齢歳)" の形式で返す
    public string ShowProfile()
    {
        return $"{mBreed}: {mName} ({mAge}歳)";
    }
}


// 問題 7-5 〜 7-6: CoinCase クラス
public class CoinCase
{
    // 対応する硬貨の種類: 500, 100, 50, 10, 5, 1
    // ヒント: Dictionary<int, int> で硬貨の種類と枚数を管理する
    Dictionary<int, int> mCounts = new Dictionary<int, int>();

    // コンストラクタ: 6 種類の硬貨を 0 枚で初期化する
    public CoinCase()
    {
        foreach (int denomination in new int[] { 500, 100, 50, 10, 5, 1 })
        {
            mCounts.Add(denomination, 0);
        }
    }

    // 問題 7-5: 指定した種類の硬貨を枚数分追加する（無効な種類は無視）
    public void AddCoins(int denomination, int count)
    {
        if (mCounts.ContainsKey(denomination))
        {
            mCounts[denomination] += count;
        }
    }

    // 問題 7-5: 指定した種類の硬貨の枚数を返す
    public int GetCount(int denomination)
    {
        if (mCounts.ContainsKey(denomination))
        {
            return mCounts[denomination];
        }
        else
        {
            return 0;
        }
    }

    // 問題 7-5: 全硬貨の合計金額を返す
    public int GetAmount()
    {
        int amount = 0;
        foreach (var pair in mCounts)
        {
            amount += pair.Key * pair.Value;
        }
        return amount;
    }

    // 問題 7-6: 全硬貨の合計枚数を返す（オーバーロード）
    public int GetCount()
    {
        int count = 0;
        foreach (var pair in mCounts)
        {
            count += pair.Value;
        }
        return count;
    }

    // 問題 7-6: 指定した種類の硬貨の合計金額を返す（オーバーロード）
    public int GetAmount(int denomination)
    {
        if (mCounts.ContainsKey(denomination))
        {
            return denomination * mCounts[denomination];
        }
        else
        {
            return 0;
        }
    }
}


public class Exercises
{
    // 問題 7-1: Dog をインスタンス化し、Name に name をセットして返す
    public static string Problem7_1(string name)
    {
        Dog dog = new Dog();
        dog.Name = name;
        return dog.Name;
    }

    // 問題 7-2: Dog に name と age をセットし、"{Name},{Age}" を返す
    public static string Problem7_2(string name, int age)
    {
        Dog dog = new Dog();
        dog.Name = name;
        dog.Age = age;
        return $"{dog.Name},{dog.Age}";
    }

    // 問題 7-3: dog1.Name="ポチ"→"タロ"、dog2.Name="コロ" のまま → "タロ,コロ" を返す
    public static string Problem7_3()
    {
        Dog dog1 = new Dog();
        Dog dog2 = new Dog();
        dog1.Name = "ポチ";
        dog2.Name = "コロ";

        // dog2のNameを"タロ"に変更
        dog1.Name = "タロ";

        return $"{dog1.Name},{dog2.Name}";
    }

    // 問題 7-4: new Dog(breed) を生成し name/age をセットして ShowProfile() を返す
    public static string Problem7_4(string breed, string name, int age)
    {
        Dog dog = new Dog(breed);
        dog.Name = name;
        dog.Age = age;
        return dog.ShowProfile();
    }

    // 問題 7-5: CoinCase に denomination を count 枚追加し、合計金額を返す
    public static int Problem7_5(int denomination, int count)
    {
        CoinCase coinCase = new CoinCase();
        coinCase.AddCoins(denomination, count);
        return coinCase.GetAmount();
    }

    // 問題 7-6: CoinCase に denomination を count 枚追加し、"{合計枚数},{指定種の合計金額}" を返す
    public static string Problem7_6(int denomination, int count)
    {
        CoinCase coinCase = new CoinCase();
        coinCase.AddCoins(denomination, count);
        return $"{coinCase.GetCount()},{coinCase.GetAmount(denomination)}";
    }
}
