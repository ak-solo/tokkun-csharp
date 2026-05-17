// ベースクラス（変更しない）
public class Animal
{
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public string ShowProfile() => $"{Name},{Age}歳";

    public virtual string Speak() => "......";
}


// 問題 8-1 / 8-3: Animal を継承した Cat クラス
public class Cat : Animal
{
    // 問題 8-1: base(name, age) を呼ぶコンストラクタ
    public Cat(string name, int age) : base(name, age) { }

    // 問題 8-1: "スースー" を返す
    public string Sleep()
    {
        return "スースー";
    }

    // 問題 8-3: "ニャー" を返す（Animal.Speak のオーバーライド）
    public override string Speak()
    {
        return "ニャー";
    }
}


// 問題 8-2 / 8-4: Animal を継承した Dog クラス
public class Dog : Animal
{
    // 問題 8-2: base(name, age) を呼ぶコンストラクタ
    public Dog(string name, int age) : base(name, age) { }

    // 問題 8-2: "トコトコ" を返す
    public string Run()
    {
        return "トコトコ";
    }

    // 問題 8-4: "ワンワン" を返す（Animal.Speak のオーバーライド）
    public override string Speak()
    {
        return "ワンワン";
    }
}


public class Exercises
{
    // 問題 8-1: Cat をインスタンス化し ShowProfile と Sleep の結果をカンマ区切りで返す
    public static string Problem8_1(string name, int age)
    {
        var cat = new Cat(name, age);
        return $"{cat.ShowProfile()},{cat.Sleep()}";
    }

    // 問題 8-2: Dog をインスタンス化し ShowProfile と Run の結果をカンマ区切りで返す
    public static string Problem8_2(string name, int age)
    {
        var dog = new Dog(name, age);
        return $"{dog.ShowProfile()},{dog.Run()}";
    }

    // 問題 8-3: Animal 型変数に Cat を代入して Speak を呼び出す
    public static string Problem8_3()
    {
        Animal cat = new Cat("タマ", 2);
        return cat.Speak();
    }

    // 問題 8-4: Animal 型変数に Dog を代入して Speak を呼び出す
    public static string Problem8_4()
    {
        Animal dog = new Dog("ポチ", 3);
        return dog.Speak();
    }

    // 問題 8-5: Animal 配列に Cat と Dog を交互に格納しループで Speak をカンマ区切りで返す
    public static string Problem8_5()
    {
        Animal[] animals = {
            new Cat("タマ", 2),
            new Dog("ポチ", 3),
            new Cat("ミケ", 1),
            new Dog("ハチ", 1)
        };
        List<string> speaks = new List<string>();
        foreach (Animal animal in animals)
        {
            speaks.Add(animal.Speak());
        }
        return string.Join(",", speaks);
    }
}
