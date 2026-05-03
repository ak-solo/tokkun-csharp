# 7章 クラスⅠ

## 基礎知識

### クラスとインスタンス

**クラス**は「もののひな型（設計図）」です。クラスから作られた実体を**インスタンス**といいます。

```csharp
// クラス定義（設計図）
public class Dog
{
    // ...
}

// インスタンスの生成（実体を作る）
var pochi = new Dog();
var koro  = new Dog();
// pochi と koro は独立した別々のオブジェクト
```

---

### フィールド（メンバー変数）

クラスが持つデータを**フィールド**（メンバー変数）として宣言します。
外部から直接アクセスさせないために `private` にするのが基本です。

```csharp
public class Dog
{
    private string mName = "";  // 名前（初期値は空文字）
    private int    mAge  = 0;   // 年齢（初期値は 0）
}
```

---

### プロパティ

フィールドへの読み書きを制御する仕組みが**プロパティ**です。
`get`（読み取り）と `set`（書き込み）をまとめて定義します。

```csharp
public string Name
{
    get { return mName; }     // 読み取り
    set { mName = value; }    // 書き込み
}
```

```csharp
var dog = new Dog();
dog.Name = "ポチ";           // set が呼ばれる
Console.WriteLine(dog.Name); // get が呼ばれる → "ポチ"
```

読み取り専用にするときは `set` を省略します。

```csharp
public string Breed
{
    get { return mBreed; }
}
```

---

### コンストラクタ

インスタンス生成時に自動で呼ばれるメソッドが**コンストラクタ**です。
クラスと同じ名前のメソッドとして定義します。

```csharp
public class Dog
{
    private string mBreed = "";

    // 引数なしコンストラクタ
    public Dog() { }

    // 引数ありコンストラクタ
    public Dog(string breed)
    {
        mBreed = breed;
    }
}
```

```csharp
var dog1 = new Dog();         // 引数なしで生成
var dog2 = new Dog("柴犬");   // 犬種を指定して生成
```

---

### メソッド

クラスの動作を定義するのが**メソッド**です。フィールドやプロパティを使って処理します。

```csharp
public string ShowProfile()
{
    return $"{mBreed}: {mName} ({mAge}歳)";
}
```

---

### メソッドのオーバーロード

同じ名前で**引数のリストが異なる**メソッドを複数定義できます。これを**オーバーロード**といいます。

```csharp
// 引数なし → 合計枚数を返す
public int GetCount()
{
    // ...
}

// 引数あり → 指定した種類の枚数を返す
public int GetCount(int denomination)
{
    // ...
}
```

---

## 練習問題

### 問題 7-1

`Dog` クラスに `Name`（`string`）プロパティを実装しなさい。

- `private` フィールド `mName` を `""` で初期化する
- `Name` プロパティで `mName` を読み書きできるようにする

また、`Problem7_1(string name) : string` を実装しなさい。`Dog` をインスタンス化し、`Name` に `name` をセットして `Name` を返します。

**解答例:**

```csharp
public static string Problem7_1(string name)
{
    var dog = new Dog();
    dog.Name = name;
    return dog.Name;
}
```

---

### 問題 7-2

`Dog` クラスに `Age`（`int`）プロパティを追加しなさい。

- `private` フィールド `mAge` を `0` で初期化する
- `Age` プロパティで `mAge` を読み書きできるようにする

また、`Problem7_2(string name, int age) : string` を実装しなさい。`Dog` をインスタンス化し、`Name` と `Age` をセットして `"{Name},{Age}"` 形式で返します。

例: `name="ポチ"`, `age=3` → `"ポチ,3"`

---

### 問題 7-3

`Dog` インスタンスを 2 つ作成し、それぞれ独立したデータを持てることを確認しなさい。

- 1 つ目に `Name = "ポチ"`、2 つ目に `Name = "コロ"` を設定する
- 1 つ目の `Name` を `"タロ"` に変更しても、2 つ目には影響しないことを確認する

**ポイント:** クラスから生成したインスタンスはそれぞれ独立したデータを持ちます。

また、`Problem7_3() : string` を実装しなさい。上記の手順を実行し、変更後の `"{dog1.Name},{dog2.Name}"` を返します。インスタンスが独立していれば `"タロ,コロ"` が返ります。

---

### 問題 7-4

`Dog` クラスに以下を追加しなさい。

- `private` フィールド `mBreed`（犬種、`string`）を `""` で初期化する
- 犬種を引数に取るコンストラクタ `Dog(string breed)` を実装する
- 犬種を読み取り専用で返す `Breed` プロパティを実装する
- `ShowProfile()` を実装し、`"犬種: 名前 (年齢歳)"` 形式の文字列を返す

また、`Problem7_4(string breed, string name, int age) : string` を実装しなさい。`new Dog(breed)` でインスタンスを生成し、`Name` と `Age` をセットして `ShowProfile()` の結果を返します。

例: `breed="柴犬"`, `name="ポチ"`, `age=3` → `"柴犬: ポチ (3歳)"`

---

### 問題 7-5

硬貨の入れ物を表す `CoinCase` クラスを実装しなさい。

対応する硬貨: **500 円・100 円・50 円・10 円・5 円・1 円**

| メソッド | 引数 | 戻り値 | 説明 |
|---------|------|--------|------|
| `AddCoins` | `int denomination`、`int count` | なし | 指定種類の硬貨を枚数分追加する。無効な種類は無視する |
| `GetCount` | `int denomination` | `int` | 指定種類の硬貨の枚数を返す |
| `GetAmount` | なし | `int` | 全硬貨の合計金額を返す |

**ヒント:** `Dictionary<int, int>` で硬貨の種類と枚数を管理すると便利です。コンストラクタで 6 種類の硬貨を 0 枚で初期化しておきましょう。

また、`Problem7_5(int denomination, int count) : int` を実装しなさい。`CoinCase` をインスタンス化して指定の硬貨を追加し、合計金額を返します。

例: `denomination=100`, `count=5` → `500`

---

### 問題 7-6

`CoinCase` クラスにオーバーロードメソッドを追加しなさい。

| メソッド | 引数 | 戻り値 | 説明 |
|---------|------|--------|------|
| `GetCount` | なし | `int` | 全硬貨の合計枚数を返す |
| `GetAmount` | `int denomination` | `int` | 指定種類の硬貨の合計金額を返す |

問題 7-5 の `GetCount(denomination)` と `GetAmount()` と同名ですが、引数が異なるオーバーロードとして実装します。

また、`Problem7_6(int denomination, int count) : string` を実装しなさい。`CoinCase` をインスタンス化して指定の硬貨を追加し、`"{合計枚数},{指定種の合計金額}"` を返します。

例: `denomination=100`, `count=4` → `"4,400"`
