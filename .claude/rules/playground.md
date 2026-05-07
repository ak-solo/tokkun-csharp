---
paths:
  - "playground/**"
---

# プレイグラウンド（playground/）

## 目的

- 引数を変えながらメソッドの動作を確認する「実験の場」
- テストとは別に、自分の実装が直感的に正しいか体感できる

## 実行方法

```bash
dotnet run --project playground/Chapter01   # Chapter01 を実行
dotnet run --project playground/Chapter02   # Chapter02 を実行
```

## ファイル構成

```csharp
// playground/Chapter01/Program.cs（トップレベルステートメント）

try
{
    Console.WriteLine(Exercises.Problem1_1());

    int x9 = 3;   // ← この値を変えて実行してみよう
    Console.WriteLine($"{x9} の 2 倍・3 倍・4 倍: {Exercises.Problem1_9(x9)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 1-1");
}
```

## プレイグラウンドの原則

- `Program.cs` の変数の値（コメントで `← 変えて試そう` と示した箇所）を書き換えて実行する
- C# 9 以降のトップレベルステートメントを使う（`class Program` / `Main` 不要）
- 未実装の問題は `NotImplementedException` を catch して `[未実装]` と表示する
- 同じ変数名が複数必要な場合はサフィックスで区別する（例: `x9`, `x10`, `x13`）
