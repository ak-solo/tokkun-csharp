# 9章 文字列・日付操作

## 基礎知識

### 文字列メソッド

C# の `string` 型には、文字列を操作するための便利なメソッドが多く用意されています。
文字列は**イミュータブル（不変）**なので、メソッドを呼び出しても元の文字列は変わらず、常に新しい文字列が返ります。

---

#### Length（文字数）

`Length` プロパティは文字列の文字数を返します。スペースや記号も 1 文字として数えます。

```csharp
string s = "Hello";
Console.WriteLine(s.Length);  // 5

string empty = "";
Console.WriteLine(empty.Length);  // 0
```

---

#### Trim / ToUpper / ToLower

`Trim()` は文字列の**先頭と末尾にある空白文字**（スペース・タブ・改行）を取り除いた新しい文字列を返します。
`TrimStart()` は先頭のみ、`TrimEnd()` は末尾のみ取り除きます。

`ToUpper()` はすべての文字を**大文字**に、`ToLower()` は**小文字**に変換した新しい文字列を返します。

```csharp
string s = "  Hello World  ";

Console.WriteLine(s.Trim());          // "Hello World"（前後の空白を削除）
Console.WriteLine(s.TrimStart());     // "Hello World  "（先頭の空白のみ削除）
Console.WriteLine(s.TrimEnd());       // "  Hello World"（末尾の空白のみ削除）

Console.WriteLine("hello".ToUpper()); // "HELLO"
Console.WriteLine("HELLO".ToLower()); // "hello"
```

---

#### Contains / StartsWith / EndsWith

いずれも `bool` を返す検索メソッドです。大文字・小文字を**区別**します。

- `Contains(value)` ― `value` が文字列内に含まれているか
- `StartsWith(value)` ― 文字列が `value` で始まっているか
- `EndsWith(value)` ― 文字列が `value` で終わっているか

```csharp
string s = "Hello, C# World";

Console.WriteLine(s.Contains("C#"));       // true
Console.WriteLine(s.StartsWith("Hello"));  // true
Console.WriteLine(s.EndsWith("World"));    // true
Console.WriteLine(s.StartsWith("world"));  // false（大文字・小文字を区別する）
```

---

#### IndexOf / Substring

`IndexOf(value)` は、`value` が**最初に現れる位置**（0 始まりのインデックス）を `int` で返します。
見つからなかった場合は `-1` を返します。

`Substring(startIndex)` は `startIndex` 文字目以降をすべて切り出します。
`Substring(startIndex, length)` は `startIndex` 文字目から `length` 文字分を切り出します。

```csharp
string s = "user@example.com";

int idx = s.IndexOf('@');              // 4
string user   = s.Substring(0, idx);  // "user"（0文字目から idx 文字分）
string domain = s.Substring(idx + 1); // "example.com"（idx+1 文字目以降すべて）

// 見つからない場合
int notFound = s.IndexOf('!');  // -1
```

---

#### Replace

`Replace(oldValue, newValue)` は、文字列内で `oldValue` に**一致するすべての箇所**を `newValue` に置き換えた新しい文字列を返します。
一致する箇所がなければ元の文字列をそのまま返します。

```csharp
string s = "Hello World";

Console.WriteLine(s.Replace("World", "C#")); // "Hello C#"
Console.WriteLine(s.Replace("l", "L"));      // "HeLLo WorLd"（一致するすべてを置換）
Console.WriteLine(s.Replace("x", "Y"));      // "Hello World"（一致なし → そのまま）
```

---

#### Split / string.Join

`Split(separator)` は、区切り文字で文字列を分割した `string[]` を返します。
区切り文字自体は結果に含まれません。

`string.Join(separator, values)` は配列やコレクションの要素を `separator` で連結した文字列を返します。

```csharp
string csv = "apple, banana, cherry";

string[] parts = csv.Split(',');  // ["apple", " banana", " cherry"]（',' で分割）

// 区切り文字列でも分割できる
string[] lines = "a::b::c".Split("::");

// string.Join で再結合
string joined = string.Join(" / ", new[] { "a", "b", "c" }); // "a / b / c"
```

---

#### string.IsNullOrEmpty / IsNullOrWhiteSpace

文字列が「空かどうか」を調べる静的メソッドです。

- `string.IsNullOrEmpty(s)` ― `s` が `null` または空文字列 `""` のとき `true`
- `string.IsNullOrWhiteSpace(s)` ― `null`・空文字列・空白文字のみのとき `true`

```csharp
Console.WriteLine(string.IsNullOrEmpty(""));        // true
Console.WriteLine(string.IsNullOrEmpty("  "));      // false（空白文字がある）
Console.WriteLine(string.IsNullOrWhiteSpace("  ")); // true（空白のみ）
Console.WriteLine(string.IsNullOrWhiteSpace("hi")); // false
```

---

### DateTime（日付・時刻）

`DateTime` 型は日付と時刻を表します。

---

#### DateTime の作成とプロパティ

```csharp
DateTime dt = new DateTime(2024, 3, 15);  // 2024年3月15日

Console.WriteLine(dt.Year);       // 2024
Console.WriteLine(dt.Month);      // 3
Console.WriteLine(dt.Day);        // 15
Console.WriteLine(dt.DayOfWeek);  // Friday
```

---

#### 日付の演算

```csharp
DateTime dt = new DateTime(2024, 1, 1);

DateTime nextWeek  = dt.AddDays(7);    // 2024/1/8
DateTime nextMonth = dt.AddMonths(1);  // 2024/2/1
DateTime nextYear  = dt.AddYears(1);   // 2025/1/1
```

---

#### 日付の差分

```csharp
DateTime from = new DateTime(2024, 1, 1);
DateTime to   = new DateTime(2024, 1, 10);

TimeSpan diff = to - from;
Console.WriteLine(diff.Days);  // 9
```

---

#### 日付のフォーマット

```csharp
DateTime dt = new DateTime(2024, 3, 5);

Console.WriteLine(dt.ToString("yyyy/MM/dd"));    // "2024/03/05"
Console.WriteLine(dt.ToString("yyyy年M月d日"));  // "2024年3月5日"
Console.WriteLine(dt.ToString("MM/dd"));         // "03/05"
```

`M` は月を 1 桁/2 桁で、`MM` は常に 2 桁で出力します（`d`/`dd` も同様）。

---

## 練習問題

### 問題 9-1

文字列 `input` を受け取り、前後の空白を取り除いてから **すべて大文字** に変換した文字列を返す関数を実装しなさい。

例: `"  hello world  "` → `"HELLO WORLD"`

**ヒント:** `Trim()` → `ToUpper()` の順に適用します。

---

### 問題 9-2

文字列 `text` と区切り文字 `delimiter` を受け取り、**最初に区切り文字が現れる位置より前** の部分文字列を返す関数を実装しなさい。区切り文字が存在しない場合は `text` をそのまま返すこと。

例: `"user@example.com", '@'` → `"user"`
例: `"hello", '@'` → `"hello"`

**ヒント:** `IndexOf` で位置を取得し、`-1` の場合は元の文字列を、それ以外は `Substring` で切り出します。

---

### 問題 9-3

カンマ区切りの文字列 `csv` を受け取り、各要素の前後の空白を除去した `string` 配列を返す関数を実装しなさい。

例: `"apple, banana, cherry"` → `["apple", "banana", "cherry"]`

**ヒント:** `Split(',')` で分割した後、各要素に `Trim()` を適用します。

---

### 問題 9-4

文字列 `text` 内に含まれる `oldWord` をすべて `newWord` に置き換えた文字列を返す関数を実装しなさい。

例: `"Hello World World", "World", "C#"` → `"Hello C# C#"`

**ヒント:** `Replace` は一致するすべての箇所を置換します。

---

### 問題 9-5

文字列の検索に関する次の 3 つの関数を実装しなさい。

- `Problem9_5_StartsWith` ― `text` が `prefix` で始まっていれば `true` を返す
- `Problem9_5_EndsWith` ― `text` が `suffix` で終わっていれば `true` を返す
- `Problem9_5_Contains` ― `text` に `keyword` が含まれていれば `true` を返す

例（StartsWith）: `"Hello, World", "Hello"` → `true`
例（EndsWith）: `"Hello, World", "World"` → `true`
例（Contains）: `"Hello, World", "C#"` → `false`

---

### 問題 9-6

`DateTime` 型の日付 `date` を受け取り、その曜日を **日本語**（`"月曜日"`〜`"日曜日"`）で返す関数を実装しなさい。

例: `new DateTime(2024, 1, 1)` （月曜日）→ `"月曜日"`
例: `new DateTime(2024, 1, 7)` （日曜日）→ `"日曜日"`

**ヒント:** `date.DayOfWeek` は `DayOfWeek` 列挙型（`Monday`, `Tuesday`, ...）を返します。`switch` 文で変換しましょう。

---

### 問題 9-7

2 つの `DateTime` 型の日付 `from` と `to` を受け取り、その差の **日数**（`int`）を返す関数を実装しなさい。`to` は常に `from` 以降の日付が渡されると仮定してよい。

例: `from=2024/1/1, to=2024/1/10` → `9`
例: `from=2024/1/1, to=2024/3/1` → `60`

**ヒント:** `(to - from).Days` で `TimeSpan` の日数部分を取得できます。

---

### 問題 9-8

`DateTime` 型の日付 `date` を受け取り、`"yyyy年M月d日"` の形式に整形した文字列を返す関数を実装しなさい。

例: `new DateTime(2024, 3, 5)` → `"2024年3月5日"`
例: `new DateTime(2024, 12, 31)` → `"2024年12月31日"`

**ヒント:** `date.ToString("yyyy年M月d日")` を使います。

---

### 問題 9-9

`DateTime` 型の日付 `date` と整数 `days` を受け取り、`days` 日後の日付を `"yyyy/MM/dd"` の形式に整形した文字列を返す関数を実装しなさい。

例: `new DateTime(2024, 1, 1), 30` → `"2024/01/31"`
例: `new DateTime(2024, 1, 31), 1` → `"2024/02/01"`

**ヒント:** `AddDays(days)` で日付を進め、`ToString("yyyy/MM/dd")` で整形します。
