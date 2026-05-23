---
paths:
  - "playground/**"
---

# プレイグラウンド（playground/）

## 目的

- 実装したメソッドを自分の手で呼び出し、動作を体感する「実験の場」
- 1問目の呼び出し例を起点に、自分でコードを自由に追加・改造して試す

## 実行方法

```bash
dotnet run --project playground/Chapter01   # Chapter01 を実行
dotnet run --project playground/Chapter02   # Chapter02 を実行
```

## ファイル構成

各章の `Program.cs` には、**1問目の呼び出し例だけ**を記載する。
それ以外の問題は最初から書かない（学習者が自分で追加する余地を残す）。

```csharp
// playground/Chapter01/Program.cs（トップレベルステートメント）

Console.WriteLine(Exercises.Problem1_1());
```

## プレイグラウンドの原則

- 1問目の呼び出しのみ記載する（2問目以降は学習者が自分で書く）
- C# 9 以降のトップレベルステートメントを使う（`class Program` / `Main` 不要）
- `try/catch` は書かない（テンプレートコードを最小限にして自由な使い方を促す）
- 引数を取るメソッドは変数を宣言してから渡す（値を変えて試しやすくするため）
