# 8章 クラスⅡ

## 基礎知識

### 継承（:）

既存のクラスを**基底クラス（親クラス）**として、その機能を引き継ぐ新しいクラスを作れます。
これを**継承**といい、C# では `: 基底クラス名` で宣言します。

```csharp
public class Animal
{
    public string Name { get; set; } = "";
    public int    Age  { get; set; } = 0;
}

// Animal を継承した Cat クラス
public class Cat : Animal
{
    public string Sleep() => "スースー";
}
```

```csharp
var cat = new Cat();
cat.Name = "タマ";         // Animal のプロパティを Cat でも使える
Console.WriteLine(cat.Name);
Console.WriteLine(cat.Sleep());
```

---

### コンストラクタと base()

派生クラスのコンストラクタでは、`base(...)` で基底クラスのコンストラクタを呼び出します。

```csharp
public class Animal
{
    public Animal(string name, int age)
    {
        Name = name;
        Age  = age;
    }
    public string Name { get; set; }
    public int    Age  { get; set; }
}

public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
        // base(name, age) で Animal のコンストラクタを呼ぶ
    }
}
```

```csharp
var cat = new Cat("タマ", 2);  // name="タマ"、age=2 で初期化
```

---

### オーバーライド（override / virtual）

基底クラスのメソッドを派生クラスで**上書き**できます。

- 基底クラスのメソッドに `virtual` を付ける
- 派生クラスのメソッドに `override` を付ける

```csharp
public class Animal
{
    public virtual string Speak() => "......";  // デフォルトの鳴き声
}

public class Cat : Animal
{
    public override string Speak() => "ニャー";  // Cat 専用の鳴き声
}

public class Dog : Animal
{
    public override string Speak() => "ワンワン";  // Dog 専用の鳴き声
}
```

---

### ポリモーフィズム

基底クラス型の変数に、派生クラスのインスタンスを代入できます。
メソッドを呼び出すと、**実際のインスタンスの型**に応じたメソッドが実行されます。

```csharp
Animal[] animals =
{
    new Cat("タマ", 2),
    new Dog("ポチ", 3),
    new Cat("ミケ", 1)
};

foreach (Animal a in animals)
{
    Console.WriteLine(a.Speak());  // Cat なら "ニャー"、Dog なら "ワンワン"
}
```

`animals` の型は `Animal[]` ですが、実行時には Cat や Dog それぞれの `Speak` が呼ばれます。
これが**ポリモーフィズム（多態性）**です。

---

## 練習問題

> **注意:** 問題 8-1 以降の `Animal` クラスはすでに実装済みです。骨格ファイルの `Animal` を変更せず、`Cat` と `Dog` を実装してください。

### 問題 8-1

`Animal` クラスを継承した `Cat` クラスを実装しなさい。

- コンストラクタ `Cat(string name, int age)` で `base(name, age)` を呼ぶ
- `Sleep()` メソッドを実装し、`"スースー"` を返す

次に、`Problem8_1` で `Cat` をインスタンス化し、`ShowProfile()` と `Sleep()` の結果をカンマ区切りで返しなさい。

**解答例:**

```csharp
public static string Problem8_1(string name, int age)
{
    var cat = new Cat(name, age);
    return cat.ShowProfile() + "," + cat.Sleep();
}
```

---

### 問題 8-2

`Animal` クラスを継承した `Dog` クラスを実装しなさい。

- コンストラクタ `Dog(string name, int age)` で `base(name, age)` を呼ぶ
- `Run()` メソッドを実装し、`"トコトコ"` を返す

次に、`Problem8_2` で `Dog` をインスタンス化し、`ShowProfile()` と `Run()` の結果をカンマ区切りで返しなさい。

**ヒント:** `Problem8_1` と同じパターンで `Dog` を使います。

---

### 問題 8-3

`Cat` クラスに `Speak()` メソッドをオーバーライドして実装しなさい。

- `Animal.Speak()` のデフォルト実装は `"......"` を返す
- `Cat.Speak()` は `"ニャー"` を返す

次に、`Problem8_3` で `Animal` 型の変数に `Cat` を代入して `Speak()` を呼び出しなさい。

**ヒント:** `Animal a = new Cat("タマ", 2);` のように `Animal` 型変数に代入しても、`Speak()` は `Cat` のものが呼ばれます。

---

### 問題 8-4

`Dog` クラスに `Speak()` メソッドをオーバーライドして実装しなさい。

- `Dog.Speak()` は `"ワンワン"` を返す

次に、`Problem8_4` で `Animal` 型の変数に `Dog` を代入して `Speak()` を呼び出しなさい。

**ヒント:** `Problem8_3` と同じパターンで `Dog` を使います。

---

### 問題 8-5

`Animal` 型の配列を使って、`Cat` と `Dog` のインスタンスをまとめて扱いなさい。

- 要素数 4 の `Animal` 配列を作成する
- 偶数インデックス（0、2）に `Cat`、奇数インデックス（1、3）に `Dog` を格納する
- ループで各要素の `ShowProfile()` と `Speak()` を呼ぶ

次に、`Problem8_5` で上記の配列を作成し、ループで各要素の `Speak()` を呼んでカンマ区切りの文字列で返しなさい。

**ヒント:** `Problem8_5` では 4 要素の `Animal` 配列に `Cat` と `Dog` を交互に格納し、`string.Join(",", ...)` などでまとめて返します。

**ポイント:** `Animal` 型の変数に `Cat`/`Dog` を代入しても、`Speak()` は実際のクラスのものが呼ばれます。これがポリモーフィズムです。
