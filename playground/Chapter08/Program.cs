// Chapter 08 プレイグラウンド — クラスII
// 実行: dotnet run --project playground/Chapter08
//
// src/Chapter08/Exercises.cs に実装を書いてから実行しよう
// 値を変えながら繰り返し試してみよう

try
{
    var cat = new Cat("タマ", 2);
    Console.WriteLine(cat.ShowProfile());
    Console.WriteLine(cat.Sleep());
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 8-1");
}

try
{
    var dog = new Dog("ポチ", 3);
    Console.WriteLine(dog.ShowProfile());
    Console.WriteLine(dog.Run());
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 8-2");
}

try
{
    var cat2 = new Cat("タマ", 2);
    var dog2 = new Dog("ポチ", 3);
    Console.WriteLine($"Cat.Speak: {cat2.Speak()}");
    Console.WriteLine($"Dog.Speak: {dog2.Speak()}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 8-3");
}

try
{
    Animal[] animals =
    {
        new Cat("タマ", 2),
        new Dog("ポチ", 3),
        new Cat("ミケ", 1),
        new Dog("コロ", 5)
    };

    foreach (Animal a in animals)
        Console.WriteLine($"{a.ShowProfile()} → {a.Speak()}");

    Animal a2 = new Cat("サクラ", 4);
    Console.WriteLine($"変数の型: Animal、実際のインスタンス: Cat");
    Console.WriteLine($"Speak の結果: {a2.Speak()}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 8-4");
}
