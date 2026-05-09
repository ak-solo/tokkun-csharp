# 環境構築手順

この教材は **VSCode の Dev Containers** を使って学習環境を構築します。
Docker コンテナの中に .NET SDK が自動でセットアップされるため、手元の PC に .NET をインストールする必要はありません。

---

## 必要なもの

| ツール | 説明 |
|--------|------|
| Git | リポジトリのクローンに使用 |
| Docker Desktop | コンテナを動かすためのソフトウェア |
| Visual Studio Code | コードエディタ |
| Dev Containers 拡張機能 | VSCode からコンテナを操作するための拡張機能 |

---

## 手順

### 1. Git をインストールする

1. https://git-scm.com/download/win を開く
2. インストーラーをダウンロードして実行する
3. 設定はすべてデフォルトのまま「Next」を押し続けてインストールする
4. コマンドプロンプトまたは PowerShell を開き、次のコマンドで確認する

```
git --version
```

---

### 2. Docker Desktop をインストールする

1. https://docs.docker.com/desktop/install/windows-install/ を開く
2. 「Docker Desktop for Windows」をダウンロードしてインストールする
3. インストール後、PC を再起動する
4. タスクバーに Docker のクジラアイコンが表示されれば起動成功

> **注意:** WSL 2 が必要です。インストーラーの指示に従って有効化してください。

---

### 3. Visual Studio Code をインストールする

1. https://code.visualstudio.com/ を開く
2. 自分の OS に合ったインストーラーをダウンロードして実行する

---

### 4. Dev Containers 拡張機能をインストールする

1. VSCode を起動する
2. 左サイドバーの拡張機能アイコン（四角が4つ並んだアイコン）をクリックする
3. 検索欄に `Dev Containers` と入力する
4. 「Dev Containers」（発行者: Microsoft）を選択し、「インストール」をクリックする

   拡張機能 ID: `ms-vscode-remote.remote-containers`

---

### 5. リポジトリをクローンする

ターミナル（Windows はコマンドプロンプトまたは PowerShell）で次のコマンドを実行する。

```
git clone https://github.com/ak-solo/tokkun-csharp.git
cd tokkun-csharp
```

---

### 6. VSCode でフォルダを開く

コマンドプロンプトまたは PowerShell で次のコマンドを実行する。

```
code .
```

または VSCode のメニューから「ファイル → フォルダーを開く」で `tokkun-csharp` フォルダを選択する。

---

### 7. Dev Container で開き直す

フォルダを開くと、右下に次のようなポップアップが表示される。

> 「フォルダーにデベロッパーコンテナー構成ファイルが含まれています。コンテナーで再度開きますか？」

**「コンテナーで再度開く」** をクリックする。

ポップアップが表示されない場合は、次の手順で操作する。

1. `Ctrl+Shift+P` でコマンドパレットを開く
2. `Dev Containers: Reopen in Container` と入力して選択する

---

### 8. コンテナのビルドを待つ

初回は Docker イメージのダウンロードとビルドが行われます。  
環境によって **5〜15 分**程度かかります。

右下に「Starting Dev Container」と表示され、完了すると VSCode のウィンドウが再起動します。

---

### 9. 動作確認

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
学習の進め方は [README.md](../README.md) を参照してください。

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

## csharprepl — 対話型 C# 実行環境

コンテナ内には **csharprepl** がインストールされています。式やコードをその場で実行して結果をすぐに確認できるツールです。

### 起動・終了

```bash
csharprepl   # 起動
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

`#load` で `src/` のファイルを読み込めます。実装したメソッドをその場で動かして確認できます。

```csharp
> #load "src/Chapter01/Exercises.cs"
> var ex = new Exercises();
> ex.Problem1_1()
```

### キーボードショートカット

| キー | 動作 |
|---|---|
| `↑` / `↓` | 入力履歴の移動 |
| `Tab` | 補完候補を表示 |
| `Ctrl+C` | 入力をキャンセル |
| `Ctrl+D` | 終了 |
