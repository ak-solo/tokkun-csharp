// Chapter 07 プレイグラウンド — クラスI
// 実行: dotnet run --project playground/Chapter07
//
// src/Chapter07/Exercises.cs に実装を書いてから実行しよう
// 値を変えながら繰り返し試してみよう

try
{
    var dog = new Dog();
    dog.Name = "ポチ";
    dog.Age = 3;
    Console.WriteLine($"名前: {dog.Name}");
    Console.WriteLine($"年齢: {dog.Age}歳");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 7-1");
}

try
{
    var dog1 = new Dog();
    dog1.Name = "ポチ";
    dog1.Age = 3;

    var dog2 = new Dog();
    dog2.Name = "コロ";
    dog2.Age = 5;

    Console.WriteLine($"dog1 → 名前: {dog1.Name}, 年齢: {dog1.Age}歳");
    Console.WriteLine($"dog2 → 名前: {dog2.Name}, 年齢: {dog2.Age}歳");

    dog1.Name = "タロ";
    Console.WriteLine($"dog1.Name を変更後 → dog2.Name = {dog2.Name}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 7-2");
}

try
{
    var dog3 = new Dog("柴犬");
    dog3.Name = "ポチ";
    dog3.Age = 3;
    Console.WriteLine(dog3.ShowProfile());

    string[] breeds = { "柴犬", "トイプードル", "ゴールデンレトリバー" };
    string[] names = { "ポチ", "モコ", "ゴールド" };
    int[] ages = { 3, 1, 5 };

    for (int i = 0; i < 3; i++)
    {
        var d = new Dog(breeds[i]);
        d.Name = names[i];
        d.Age = ages[i];
        Console.WriteLine(d.ShowProfile());
    }
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 7-3");
}

try
{
    var cc = new CoinCase();
    cc.AddCoins(500, 1);
    cc.AddCoins(100, 2);
    cc.AddCoins(50, 3);
    cc.AddCoins(10, 4);
    cc.AddCoins(5, 5);
    cc.AddCoins(1, 6);

    foreach (int d in new[] { 500, 100, 50, 10, 5, 1 })
        Console.WriteLine($"{d,4}円: {cc.GetCount(d),3}枚");
    Console.WriteLine($"合計金額: {cc.GetAmount()}円");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 7-4");
}

try
{
    var cc2 = new CoinCase();
    cc2.AddCoins(500, 2);
    cc2.AddCoins(100, 5);
    cc2.AddCoins(10, 3);

    Console.WriteLine($"合計枚数: {cc2.GetCount()}枚");
    Console.WriteLine($"500円の合計: {cc2.GetAmount(500)}円");
    Console.WriteLine($"100円の合計: {cc2.GetAmount(100)}円");
    Console.WriteLine($" 10円の合計: {cc2.GetAmount(10)}円");
    Console.WriteLine($"全体の合計: {cc2.GetAmount()}円");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 7-5");
}
