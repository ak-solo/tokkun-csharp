---
paths:
  - "src/**"
---

# 骨格コード（src/）

## ファイルの書き方

```csharp
// src/Chapter01/Exercises.cs

public class Exercises
{
    // 問題 1-1: "Hello World" を返す
    public static string Problem1_1()
    {
        throw new NotImplementedException("問題 1-1 を実装してください");
    }

    // 問題 1-4: 13 と 17 の和を返す
    public static int Problem1_4()
    {
        throw new NotImplementedException("問題 1-4 を実装してください");
    }
}
```

## 骨格コードの原則

- メソッドシグネチャ（名前・引数・戻り値の型）は変えない
- `throw new NotImplementedException` をそのまま残す（テストが `NotImplementedException` で失敗するのが「Red」の状態）
- 問題のコメントに問題番号と概要を明記する
- 入力値は Console.ReadLine() から取ることは **しない**（引数で受け取る）

## 実装設計の原則

### テスト可能な構造にする

コンソール I/O に依存する問題でも、**計算ロジックは引数・戻り値で表現できるメソッド**として切り出す。

```csharp
// NG: テストできない
static void Problem1_4()
{
    int x = 13 + 17;
    Console.WriteLine(x);
}

// OK: ロジックをメソッドに切り出す
static int Problem1_4()
{
    return 13 + 17;
}
```

入力が必要な問題（chapter02 以降）も、入力値を引数として受け取る形にする。

```csharp
// NG: Console.ReadLine() をそのまま使う
static string Problem2_3()
{
    int x = int.Parse(Console.ReadLine());
    return $"{x},{x * x},{x * x * x}";
}

// OK: 入力値を引数にする
static string Problem2_3(int x)
{
    return $"{x},{x * x},{x * x * x}";
}
```

### 表示系の問題

文字列を**返す** メソッドとして実装し、Main から Console.WriteLine で出力する。
これにより、テストでは戻り値を Assert するだけでよくなる。
