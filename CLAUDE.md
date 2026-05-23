# tokkun-csharp — C# ハンズオン学習教材

## プロジェクト概要

C# を題材にした初学者向けプログラミング学習教材。
「基礎説明 → 問題を解く → ユニットテストで自己検証 → プレイグラウンドで体験する」
というサイクルで、手を動かしながら学べることを目指す。

### 学習の流れ

```
1. docs/ の README（基礎説明 + 問題文）を読む
2. src/ の骨格コードに実装を書く
3. playground または csharprepl で動作を確認する
4. dotnet test でテストを実行し、グリーンになるまで修正する
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
│   │   └── Program.cs          # 1問目の呼び出し例（2問目以降は学習者が自分で追加する）
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
4. `playground/ChapterXX/Program.cs` に1問目の呼び出し例を記載する
5. `tokkun-csharp.sln` にプロジェクトを追加する

---

## 制約・注意事項

- テストを通すためだけの**ハードコード**（`return 30;` など）は禁止。汎用的なロジックで実装すること
- 骨格コードの**メソッドシグネチャは変えない**（テストが壊れる）
- 入力は必ず**引数**で受け取る（Console.ReadLine() をメソッド内で使わない）
- Chapter01〜Chapter03 の問題は戻り値ありのメソッドとして設計する
- Chapter04 以降のループ・配列は、結果を返す形（配列・文字列など）で設計する

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

## ブランチ構成

| ブランチ | 用途 |
|---|---|
| `main` | 骨格コードのみ（学習者が実装を書く） |
| `answer` | 解答例を実装済みの状態 |

### main の変更を answer に反映する手順

`main` にコミットが追加されたら、以下の手順で `answer` に反映する。

```bash
git checkout answer
git merge main --no-edit
git push origin answer
git checkout main
```

---

## Git コミット方針

- コミットは **変更理由（目的）ごとに分割**すること
- 1コミット = 1つの論理的な変更（機能追加・バグ修正・リファクタリングを混在させない）
- コミット前に変更内容を確認し、複数の目的が混在していれば必ず分割する
- ファイルをまとめて `git add .` せず、目的ごとに `git add <ファイル>` で個別にステージングすること
- コミットメッセージは「何をしたか」ではなく「**なぜ**その変更をしたか」を書く
- コミットメッセージには必ず以下のプレフィックスをつけること

### コミットメッセージのプレフィックス

| プレフィックス | 用途 |
|---|---|
| `feat:` | 新機能の追加 |
| `fix:` | バグ修正 |
| `docs:` | ドキュメントのみの変更 |
| `style:` | コードの見た目の変更（機能に影響しない空白・セミコロン等） |
| `refactor:` | バグ修正でも機能追加でもないコード変更（リファクタリング） |
| `chore:` | ビルド設定・ライブラリ更新・CI 設定など |

### 分割の例

| 悪い例（1コミット） | 良い例（分割） |
|---------------------|----------------|
| 問題追加 + テスト追加 + CLAUDE.md 更新 | ① 問題ファイル追加 ② テスト追加 ③ CLAUDE.md 更新 |
| バグ修正 + 新機能追加 | ① バグ修正 ② 新機能追加 |
