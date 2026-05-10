# 8章 クラスⅡ

## 基礎知識

### 継承とは

7 章では 1 つのクラスを設計しました。しかし複数のクラスが共通のデータや操作を持つことはよくあります。

たとえば `Cat` クラスと `Dog` クラスを別々に作ると、`Name`・`Age` プロパティや `ShowProfile()` メソッドを両方に書かなければなりません。

```csharp
// 同じコードを二か所に書くのは非効率
public class Cat
{
    public string Name { get; set; }
    public int    Age  { get; set; }
    public string ShowProfile() { ... }
    public string Sleep() { ... }  // Cat 固有
}

public class Dog
{
    public string Name { get; set; }        // Cat と全く同じ
    public int    Age  { get; set; }        // Cat と全く同じ
    public string ShowProfile() { ... }     // Cat と全く同じ
    public string Run() { ... }   // Dog 固有
}
```

**継承**を使うと、共通部分を**基底クラス（親クラス）**に一か所だけ書き、各クラス固有の部分だけを**派生クラス（子クラス）**に追加できます。

```
        Animal（基底クラス）
        Name, Age, ShowProfile()
           ↙            ↘
    Cat（派生）       Dog（派生）
    Sleep()          Run()
```

この関係を「Cat は Animal の一種（Cat is-a Animal）」と表現します。継承が自然に使えるのは、この「is-a 関係」が成立するときです。

---

### 継承（:）

既存のクラスを**基底クラス（親クラス）**として、その機能を引き継ぐ新しいクラスを作れます。
これを**継承**といい、C# では `: 基底クラス名` で宣言します。派生クラスは基底クラスのプロパティ・メソッドをそのまま使えます。

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
cat.Name = "タマ";          // Animal のプロパティを Cat でも使える
Console.WriteLine(cat.Name);
Console.WriteLine(cat.Sleep());
```

---

### コンストラクタと base()

派生クラスのコンストラクタでは、`base(...)` で基底クラスのコンストラクタを呼び出します。`base` は基底クラス自身を指すキーワードです。

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
        // base(name, age) で Animal のコンストラクタに処理を委ねる
    }
}
```

```csharp
var cat = new Cat("タマ", 2);
Console.WriteLine(cat.Name);  // → "タマ"（Animal のコンストラクタが設定した）
```

---

### オーバーライド（override / virtual）

基底クラスのメソッドを派生クラスで**上書き**することを**オーバーライド**といいます。

- 基底クラス側: 上書きを許可するメソッドに `virtual` を付ける
- 派生クラス側: 上書きするメソッドに `override` を付ける

```csharp
public class Animal
{
    public virtual string Speak() => "......";  // デフォルトの実装
}

public class Cat : Animal
{
    public override string Speak() => "ニャー";  // Cat 専用の実装で上書き
}

public class Dog : Animal
{
    public override string Speak() => "ワンワン";  // Dog 専用の実装で上書き
}
```

> **オーバーライドとオーバーロードの違い:**
> - **オーバーライド（override）:** 継承関係にある親のメソッドを子で上書きする（同じ名前・同じ引数）
> - **オーバーロード:** 同じクラス内に引数が異なる同名メソッドを複数定義する

---

### ポリモーフィズム（多態性）

**ポリモーフィズム**とは「同じ操作を型によって異なる動作にできる」性質です。

基底クラス型の変数に派生クラスのインスタンスを代入できます。メソッドを呼び出すと、変数の型（`Animal`）ではなく**実際のインスタンスの型**（`Cat` や `Dog`）に応じたメソッドが実行されます。

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

ポリモーフィズムの強みは、**新しい動物クラスを追加してもループのコードを変えなくてよい**点です。

```csharp
// Bird クラスを追加しても、上のループはそのまま動く
public class Bird : Animal
{
    public override string Speak() => "チュンチュン";
}
```

ポリモーフィズムがない場合は、型ごとに `if` で分岐するコードを書かなければならず、種類が増えるたびに修正が必要になります。

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
