# 環境構築手順

この教材は **VSCode の Dev Containers** を使って学習環境を構築します。
Docker コンテナの中に .NET SDK が自動でセットアップされるため、手元の PC に .NET をインストールする必要はありません。

---

## 必要なもの

| ツール | 説明 |
|--------|------|
| Dev Containers 拡張機能 | VSCode からコンテナを操作するための拡張機能 |

---

## 手順

### 1. Dev Containers 拡張機能をインストールする

1. VSCode を起動する
2. 左サイドバーの拡張機能アイコン（四角が4つ並んだアイコン）をクリックする
3. 検索欄に `Dev Containers` と入力する
4. 「Dev Containers」（発行者: Microsoft）を選択し、「インストール」をクリックする

   拡張機能 ID: `ms-vscode-remote.remote-containers`

---

### 2. VSCode でフォルダを開く

VSCode のメニューから「ファイル → フォルダーを開く」で `tokkun-csharp` フォルダを選択する。

---

### 3. Dev Container で開き直す

フォルダを開くと、右下に次のようなポップアップが表示される。

> 「フォルダーにデベロッパーコンテナー構成ファイルが含まれています。コンテナーで再度開きますか？」

**「コンテナーで再度開く」** をクリックする。

ポップアップが表示されない場合は、次の手順で操作する。

1. `Ctrl+Shift+P` でコマンドパレットを開く
2. `Dev Containers: Reopen in Container` と入力して選択する

---

### 4. コンテナのビルドを待つ

初回は Docker イメージのダウンロードとビルドが行われます。  
環境によって **5〜15 分**程度かかります。

右下に「Starting Dev Container」と表示され、完了すると VSCode のウィンドウが再起動します。

---

### 5. 動作確認

コンテナが起動したら、VSCode のターミナル（`` Ctrl+@ `` または「ターミナル → 新しいターミナル」）で次のコマンドを実行する。

```bash
dotnet --version
```

`.NET` のバージョンが表示されれば成功です。

テストを実行して環境を確認する。

```bash
dotnet test
```

全テストが `NotImplementedException` で失敗すれば正常です（まだ何も実装していない Red の状態）。

---

## これで準備完了

環境構築は以上です。  
このページ下部の「問題の解き方」を確認したら、[Chapter01](chapter01.md) から始めよう。

---

## トラブルシューティング

### Docker が起動しない

- WSL 2 が有効になっているか確認する
- BIOS で仮想化（Virtualization）が有効になっているか確認する

### コンテナのビルドに失敗する

- Docker Desktop が起動していることを確認する
- Docker Desktop の設定で「Resources → Memory」を 4GB 以上に設定してみる
- ネットワーク接続を確認する（Docker イメージのダウンロードが必要）

### `dotnet test` が実行できない

- ターミナルが Dev Container 内で動いているか確認する（VSCode 左下に「Dev Container: tokkun-csharp」と表示されていれば OK）
- コンテナを再ビルドする: コマンドパレットで `Dev Containers: Rebuild Container` を実行する

---

## 問題の解き方

各問題は次の3ステップで進めよう。

### ステップ 1: 実装する

`src/ChapterXX/Exercises.cs` を開き、該当メソッドに処理を書く。

### ステップ 2: 動作を確認する

実装したら、プレイグラウンドまたは csharprepl で実際に動かして結果を確かめる。

**プレイグラウンドで確認する場合**

`playground/ChapterXX/Program.cs` に呼び出しコードを書いて実行する。

```bash
dotnet run --project playground/Chapter01
```

**csharprepl で確認する場合**

```bash
repl 1   # Chapter01 の場合（番号を変えると他の章も開ける）
```

起動すると Exercises.cs が自動でロード済みの状態になる。あとはメソッドを呼び出すだけ。

```csharp
> Exercises.Problem1_1()
```

### ステップ 3: テストを実行する

VSCode の左サイドバーにあるビーカーアイコン（テストエクスプローラー）をクリックする。

- 章単位で実行: 章名の横にある ▶ をクリック
- 全章まとめて実行: 一番上の ▶ をクリック

グリーン（✓）になれば完了。赤（✗）のテストがあれば実装を見直して修正しよう。

---

## csharprepl — 対話型 C# 実行環境

コンテナ内には **csharprepl** がインストールされています。式やコードをその場で実行して結果をすぐに確認できるツールです。

### 起動・終了

問題を解くときは `repl <章番号>` で起動する。Exercises.cs が自動でロードされた状態で始まるので、すぐにメソッドを呼び出せる。

```bash
repl 1   # Chapter01 を開く（repl 2 なら Chapter02）
```

```bash
exit         # 終了（Ctrl+D でも可）
```

### 基本的な使い方

式を入力して Enter を押すと、即座に結果が表示されます。

```csharp
> 2 + 3
5

> "Hello".ToUpper()
"HELLO"

> Math.Pow(2, 10)
1024
```

### using を追加する

```csharp
> using System.Linq;
> Enumerable.Range(1, 10).Where(x => x % 2 == 0).ToList()
List<int>(5) { 2, 4, 6, 8, 10 }
```

### 複数行のコードを書く

`{` で改行すると複数行モードになります。

```csharp
> for (int i = 1; i <= 5; i++)
. {
.     Console.WriteLine(i);
. }
1
2
3
4
5
```

### 自分の実装を読み込んで試す

`repl <章番号>` で起動すると、`#load` が自動で実行済みの状態になる。起動後すぐにメソッドを呼び出せる。

```bash
repl 1
```

```csharp
> Exercises.Problem1_1()
```

### キーボードショートカット

| キー | 動作 |
|---|---|
| `↑` / `↓` | 入力履歴の移動 |
| `Tab` | 補完候補を表示 |
| `Ctrl+C` | 入力をキャンセル |
| `Ctrl+D` | 終了 |
