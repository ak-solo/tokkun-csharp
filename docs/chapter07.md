# 7章 クラスⅠ

## 基礎知識

### オブジェクト指向とは

これまでは変数とメソッドを別々に扱ってきました。しかし現実のものごとは「データ」と「操作」がセットになっています。

たとえば「犬」を考えると、
- **データ:** 名前・年齢・犬種
- **操作:** 吠える・プロフィールを表示する

**オブジェクト指向プログラミング**（OOP）とは、こうした「データ」と「操作」をひとまとめにして**オブジェクト**として扱う考え方です。

```
┌────────────────────────────┐
│          Dog オブジェクト   │
│  データ: name, age, breed  │
│  操作: Speak(), ShowProfile() │
└────────────────────────────┘
```

こうすることで、関連するものが一か所にまとまりコードが整理されます。また、同じ種類のオブジェクトを何個でも独立して作れます。

---

### クラスとインスタンス

**クラス**は「もののひな型（設計図）」です。クラスから作られた実体を**インスタンス**（オブジェクト）といいます。

```
クラス（設計図）         インスタンス（実体）
┌──────────┐    new    ┌──────────┐  ┌──────────┐
│   Dog    │ ────────▶ │  pochi   │  │  koro    │
│  name    │           │ name=ポチ│  │ name=コロ│
│  age     │           │ age=3   │  │ age=5   │
└──────────┘           └──────────┘  └──────────┘
```

```csharp
// クラス定義（設計図）
public class Dog
{
    // ...
}

// インスタンスの生成（new で実体を作る）
var pochi = new Dog();
var koro  = new Dog();
// pochi と koro は独立した別々のオブジェクト
// 一方を変更しても、もう一方には影響しない
```

---

### フィールド（メンバー変数）

クラスが持つデータを**フィールド**（メンバー変数）として宣言します。フィールドはインスタンスごとに独立した値を持ちます。

外部から直接アクセスさせないために `private` にするのが基本です（後述のカプセル化）。

```csharp
public class Dog
{
    private string mName = "";  // 名前（初期値は空文字）
    private int    mAge  = 0;   // 年齢（初期値は 0）
}
```

`private` にすると、クラスの外から `dog.mName = "ポチ"` のように直接書き換えることができなくなります。

---

### カプセル化とプロパティ

フィールドを `private` にして外から直接アクセスできないようにする考え方を**カプセル化**といいます。代わりに**プロパティ**を通じて読み書きを制御します。

なぜカプセル化するのかというと、たとえば年齢に `-5` のような不正な値が入るのを防いだり、値が変わったときに他の処理を連動させたりできるからです。

```csharp
public int Age
{
    get { return mAge; }
    set
    {
        if (value >= 0)
        {
            mAge = value;  // 負の値は無視する
        }
    }
}
```

`get`（読み取り）と `set`（書き込み）をまとめて定義します。

```csharp
public string Name
{
    get { return mName; }
    set { mName = value; }
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
    // set を書かないと読み取り専用になる
}
```

---

### コンストラクタ

`new Dog()` と書いたときに**自動で呼ばれる**特別なメソッドが**コンストラクタ**です。クラスと同じ名前で定義します。インスタンスの初期設定に使います。

```csharp
public class Dog
{
    private string mBreed = "";

    // 引数なしコンストラクタ（デフォルト）
    public Dog() { }

    // 引数ありコンストラクタ（犬種を指定して生成）
    public Dog(string breed)
    {
        mBreed = breed;
    }
}
```

```csharp
var dog1 = new Dog();         // 引数なしで生成 → mBreed = ""
var dog2 = new Dog("柴犬");   // 引数ありで生成 → mBreed = "柴犬"
```

コンストラクタを定義しない場合、引数なしのコンストラクタが自動的に用意されます。

---

### this キーワード

`this` はそのメソッドを呼び出している**自分自身のインスタンス**を指します。フィールド名と引数名が同じときなど、どちらを指すか明確にしたい場面で使います。

```csharp
public Dog(string mName)
{
    this.mName = mName;  // this.mName = フィールド、mName = 引数
}
```

---

### メソッド

クラスの動作を定義するのが**メソッド**です。フィールドやプロパティを使って処理します。クラスの外からは `インスタンス名.メソッド名()` で呼び出します。

```csharp
public string ShowProfile()
{
    return $"{mBreed}: {mName} ({mAge}歳)";
}
```

```csharp
var dog = new Dog("柴犬");
dog.Name = "ポチ";
dog.Age = 3;
Console.WriteLine(dog.ShowProfile());  // → "柴犬: ポチ (3歳)"
```

---

### Dictionary（辞書型）

`Dictionary<TKey, TValue>` はキーと値のペアを管理するコレクションです。配列が「インデックス（0, 1, 2…）→ 値」なのに対し、Dictionary は**任意のキー → 値**で管理できます。

```csharp
// 宣言・生成（キーが int、値が int の例）
var d = new Dictionary<int, int>();

// 要素の追加
d.Add(100, 0);    // キー=100、値=0 を追加
d.Add(500, 0);    // キー=500、値=0 を追加

// 値の読み書き（配列と同じように [] で指定）
d[100] = 3;                    // キー 100 の値を 3 に上書き
d[100] += 1;                   // キー 100 の値を +1
Console.WriteLine(d[100]);     // → 4

// キーの存在確認
if (d.ContainsKey(50))
{
    Console.WriteLine("50 円はある");
}
```

```csharp
// foreach でキーと値を順番に取り出す
foreach (var kvp in d)
{
    Console.WriteLine($"キー={kvp.Key}, 値={kvp.Value}");
}
```

存在しないキーにアクセスしようとすると実行時エラーになるため、`ContainsKey` で確認してから使うのが安全です。

---

### メソッドのオーバーロード

同じ名前で**引数のリストが異なる**メソッドを複数定義できます。これを**オーバーロード**といいます。呼び出し側は渡す引数によって自動的に適切なメソッドが選ばれます。

```csharp
// 引数なし → 全硬貨の合計枚数を返す
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

```csharp
var c = new CoinCase();
c.GetCount();     // 引数なし版が呼ばれる
c.GetCount(100);  // 引数あり版が呼ばれる
```

引数の型か数が異なれば別のメソッドとして定義できます。戻り値の型だけが違うオーバーロードはできません。

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
