# tokkun-csharp — C# ハンズオン学習教材

## プロジェクト概要

C# を題材にした初学者向けプログラミング学習教材。
「基礎説明 → 問題を解く → ユニットテストで自己検証 → プレイグラウンドで体験する」
というサイクルで、手を動かしながら学べることを目指す。

### 学習の流れ

```
1. docs/ の README（基礎説明 + 問題文）を読む
2. src/ の骨格コードに実装を書く
3. dotnet test でユニットテストを実行し、全テストが通るまで修正する
4. dotnet run --project playground/ChapterXX で動作を体感する
```

---

## ディレクトリ構成

```
tokkun-csharp/
├── .devcontainer/
│   ├── devcontainer.json       # VSCode devcontainer 設定
│   └── Dockerfile
├── docs/
│   ├── chapter01.md            # 基礎説明 + 問題文（章ごと）
│   ├── chapter02.md
│   └── ...
├── src/
│   ├── Chapter01/
│   │   ├── Chapter01.csproj
│   │   └── Exercises.cs        # 初学者が実装を書くファイル（骨格のみ）
│   ├── Chapter02/
│   └── ...
├── tests/
│   ├── Chapter01.Tests/
│   │   ├── Chapter01.Tests.csproj
│   │   └── ExercisesTests.cs   # ユニットテスト（変更しない）
│   ├── Chapter02.Tests/
│   └── ...
├── playground/
│   ├── Chapter01/
│   │   ├── Chapter01.Playground.csproj
│   │   └── Program.cs          # 値を変えながら実行できる実験用コード
│   ├── Chapter02/
│   └── ...
├── tokkun-csharp.sln
└── CLAUDE.md
```

---

## 章の構成

| ファイル | 章タイトル | 主なトピック |
|---|---|---|
| chapter01 | 表示・変数・演算 | Console.WriteLine、変数、四則演算、Math.Pow |
| chapter02 | 引数と戻り値 | 引数、戻り値、型、文字列補間 |
| chapter03 | 分岐 | if/else if/else、switch、論理演算子 |
| chapter04 | 繰り返し | for/while/do-while、break/continue、フィボナッチ、素因数分解 |
| chapter05 | 配列 | 1次元・2次元配列、foreach、ソート |
| chapter06 | メソッド | 戻り値あり/なし、引数、ref、bool 返し |
| chapter07 | クラスⅠ | フィールド、プロパティ、コンストラクタ、オーバーロード |
| chapter08 | クラスⅡ | 継承、オーバーライド、ポリモーフィズム |
| chapter09 | LINQ | Where、Select、OrderBy、GroupBy、クエリ構文 |

---

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

---

## ユニットテスト（tests/）

### テストフレームワーク

xUnit を使用する。テストプロジェクトに必要なパッケージ：

```xml
<PackageReference Include="xunit" Version="2.*" />
<PackageReference Include="xunit.runner.visualstudio" Version="2.*" />
<PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.*" />
```

### ファイル構成

```csharp
// tests/Chapter01.Tests/ExercisesTests.cs

using Xunit;

public class Chapter01Tests
{
    // 命名規則: Test_[問題番号]_[何をテストするか]
    [Fact]
    public void Test_1_4_SumOf13And17()
    {
        int result = Exercises.Problem1_4();
        Assert.Equal(30, result);
    }

    // Theory + InlineData でパターンを網羅する
    [Theory]
    [InlineData(3, "6,9,12")]
    [InlineData(5, "10,15,20")]
    public void Test_1_9_Multiples(int x, string expected)
    {
        Assert.Equal(expected, Exercises.Problem1_9(x));
    }
}
```

### テスト作成ルール

- `Assert.True(true)` のような無意味なアサーションは書かない
- **`[Theory]` + `[InlineData]`** を活用し、境界値・典型値・エッジケースを複数検証する
- テスト名は「何の問題の、何を確認するか」が一目でわかるように書く
- テストコードは初学者が変更しない前提で書く（骨格側のメソッドシグネチャに合わせる）

### 初学者が行う作業

- `src/ChapterXX/Exercises.cs` の `throw new NotImplementedException()` を削除し、実装を書く
- `dotnet test tests/ChapterXX.Tests` を実行して結果を確認する
- 全テストが緑になれば完了

---

## プレイグラウンド（playground/）

### 目的

- 引数を変えながらメソッドの動作を確認する「実験の場」
- テストとは別に、自分の実装が直感的に正しいか体感できる

### 実行方法

```bash
dotnet run --project playground/Chapter01   # Chapter01 を実行
dotnet run --project playground/Chapter02   # Chapter02 を実行
```

### ファイル構成

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

### プレイグラウンドの原則

- `Program.cs` の変数の値（コメントで `← 変えて試そう` と示した箇所）を書き換えて実行する
- C# 9 以降のトップレベルステートメントを使う（`class Program` / `Main` 不要）
- 未実装の問題は `NotImplementedException` を catch して `[未実装]` と表示する
- 同じ変数名が複数必要な場合はサフィックスで区別する（例: `x9`, `x10`, `x13`）

---

## 骨格コード（src/）

### ファイルの書き方

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

### 骨格コードの原則

- メソッドシグネチャ（名前・引数・戻り値の型）は変えない
- `throw new NotImplementedException` をそのまま残す（テストが `NotImplementedException` で失敗するのが「Red」の状態）
- 問題のコメントに問題番号と概要を明記する
- 入力値は Console.ReadLine() から取ることは **しない**（引数で受け取る）

---

## devcontainer（.devcontainer/）

### 含める環境

- .NET 10 SDK
- VSCode 拡張機能
  - `ms-dotnettools.csdevkit`
  - `ms-dotnettools.vscode-dotnet-runtime`

### 確認コマンド

```bash
dotnet --version                            # SDK の確認
dotnet test                                 # 全テストを実行
dotnet test tests/Chapter01.Tests          # 特定の章のみ
dotnet run --project playground/Chapter01  # プレイグラウンドを実行
```

---

## docs/（問題文 + 基礎説明）

### 構成テンプレート

```markdown
# X章 章タイトル

## 基礎知識

[概念の説明]

## 構文例

[コードサンプル]

## 練習問題

### 問題 X-1

[問題文]

**ヒント:** [ヒント]

### 問題 X-2
...
```

---

## 命名規則

| 要素 | 規則 | 例 |
|---|---|---|
| 実装クラス | `Exercises` | `public class Exercises` |
| メソッド名 | `Problem[章]_[番号]` + 補足 | `Problem1_4()`, `Problem9_7_HasNegative()` |
| テストクラス | `Chapter[章番号]Tests` | `Chapter01Tests` |
| テストメソッド | `Test_[問題番号]_[説明]` | `Test_1_4_SumOf13And17` |
| プロジェクト | `ChapterXX` / `ChapterXX.Tests` / `ChapterXX.Playground` | `Chapter01`, `Chapter01.Tests`, `Chapter01.Playground` |

---

## 問題追加の手順

新しい問題・章を追加するときの手順：

1. `docs/chapterXX.md` に基礎説明と問題文を書く
2. `src/ChapterXX/Exercises.cs` に骨格メソッド（`NotImplementedException`）を追加する
3. `tests/ChapterXX.Tests/ExercisesTests.cs` にユニットテストを書く（複数の InlineData で検証）
4. `playground/ChapterXX/Program.cs` に実験用コードを追加する
5. `tokkun-csharp.sln` にプロジェクトを追加する

---

## 制約・注意事項

- テストを通すためだけの**ハードコード**（`return 30;` など）は禁止。汎用的なロジックで実装すること
- 骨格コードの**メソッドシグネチャは変えない**（テストが壊れる）
- 入力は必ず**引数**で受け取る（Console.ReadLine() をメソッド内で使わない）
- Chapter01〜Chapter03 の問題は戻り値ありのメソッドとして設計する
- Chapter04 以降のループ・配列は、結果を返す形（配列・文字列など）で設計する

---

## Git コミット方針

- コミットは **変更理由（目的）ごとに分割**すること
- 1コミット = 1つの論理的な変更（機能追加・バグ修正・リファクタリングを混在させない）
- コミット前に変更内容を確認し、複数の目的が混在していれば必ず分割する
- ファイルをまとめて `git add .` せず、目的ごとに `git add <ファイル>` で個別にステージングすること
- コミットメッセージは「何をしたか」ではなく「**なぜ**その変更をしたか」を書く

### 分割の例

| 悪い例（1コミット） | 良い例（分割） |
|---------------------|----------------|
| 問題追加 + テスト追加 + CLAUDE.md 更新 | ① 問題ファイル追加 ② テスト追加 ③ CLAUDE.md 更新 |
| バグ修正 + 新機能追加 | ① バグ修正 ② 新機能追加 |
