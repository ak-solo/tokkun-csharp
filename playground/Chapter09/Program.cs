// Chapter 09 プレイグラウンド — LINQ
// 実行: dotnet run --project playground/Chapter09
//
// src/Chapter09/Exercises.cs に実装を書いてから実行しよう

int[] nums = { 5, 1, 8, 3, 9, 2 };
int threshold = 4;
int[] result = Exercises.Problem9_1(nums, threshold);
Console.WriteLine(string.Join(", ", result));
