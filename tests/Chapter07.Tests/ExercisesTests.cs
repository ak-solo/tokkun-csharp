using Xunit;

public class Chapter07Tests
{
    // ===== 問題 7-1: Name プロパティ =====

    [Fact]
    public void Test_7_1_NameGetSet()
    {
        var dog = new Dog();
        dog.Name = "ポチ";
        Assert.Equal("ポチ", dog.Name);
    }

    [Fact]
    public void Test_7_1_NameCanBeUpdated()
    {
        var dog = new Dog();
        dog.Name = "コロ";
        dog.Name = "タロ";
        Assert.Equal("タロ", dog.Name);
    }

    [Fact]
    public void Test_7_1_DefaultNameIsEmpty()
    {
        var dog = new Dog();
        Assert.Equal("", dog.Name);
    }

    // ===== 問題 7-2: Age プロパティ =====

    [Fact]
    public void Test_7_2_AgeGetSet()
    {
        var dog = new Dog();
        dog.Age = 3;
        Assert.Equal(3, dog.Age);
    }

    [Fact]
    public void Test_7_2_DefaultAgeIsZero()
    {
        var dog = new Dog();
        Assert.Equal(0, dog.Age);
    }

    // ===== 問題 7-3: インスタンスの独立性 =====

    [Fact]
    public void Test_7_3_TwoInstancesAreIndependent()
    {
        var dog1 = new Dog();
        dog1.Name = "ポチ";
        dog1.Age = 3;

        var dog2 = new Dog();
        dog2.Name = "コロ";
        dog2.Age = 5;

        Assert.Equal("ポチ", dog1.Name);
        Assert.Equal(3, dog1.Age);
        Assert.Equal("コロ", dog2.Name);
        Assert.Equal(5, dog2.Age);
    }

    [Fact]
    public void Test_7_3_ChangingOneDoesNotAffectOther()
    {
        var dog1 = new Dog();
        dog1.Name = "ポチ";
        var dog2 = new Dog();
        dog2.Name = "コロ";

        dog1.Name = "タロ";

        Assert.Equal("タロ", dog1.Name);
        Assert.Equal("コロ", dog2.Name);   // dog2 は影響を受けない
    }

    // ===== 問題 7-4: コンストラクタ・Breed・ShowProfile =====

    [Fact]
    public void Test_7_4_BreedSetByConstructor()
    {
        var dog = new Dog("柴犬");
        Assert.Equal("柴犬", dog.Breed);
    }

    [Fact]
    public void Test_7_4_ShowProfile()
    {
        var dog = new Dog("柴犬");
        dog.Name = "ポチ";
        dog.Age = 3;
        Assert.Equal("柴犬: ポチ (3歳)", dog.ShowProfile());
    }

    [Fact]
    public void Test_7_4_ShowProfileDifferentDog()
    {
        var dog = new Dog("トイプードル");
        dog.Name = "モコ";
        dog.Age = 1;
        Assert.Equal("トイプードル: モコ (1歳)", dog.ShowProfile());
    }

    [Fact]
    public void Test_7_4_MultipleBreeds()
    {
        var dog1 = new Dog("柴犬");
        var dog2 = new Dog("ゴールデンレトリバー");
        Assert.Equal("柴犬", dog1.Breed);
        Assert.Equal("ゴールデンレトリバー", dog2.Breed);
    }

    // ===== 問題 7-5: CoinCase 基本機能 =====

    [Fact]
    public void Test_7_5_AddCoinsAndGetCount()
    {
        var cc = new CoinCase();
        cc.AddCoins(500, 2);
        cc.AddCoins(100, 5);
        Assert.Equal(2, cc.GetCount(500));
        Assert.Equal(5, cc.GetCount(100));
    }

    [Fact]
    public void Test_7_5_InitialCountIsZero()
    {
        var cc = new CoinCase();
        foreach (int d in new[] {500, 100, 50, 10, 5, 1})
            Assert.Equal(0, cc.GetCount(d));
    }

    [Fact]
    public void Test_7_5_AddCoinsAccumulates()
    {
        var cc = new CoinCase();
        cc.AddCoins(10, 3);
        cc.AddCoins(10, 4);
        Assert.Equal(7, cc.GetCount(10));
    }

    [Fact]
    public void Test_7_5_InvalidDenominationIsIgnored()
    {
        var cc = new CoinCase();
        cc.AddCoins(200, 10);   // 200 円は無効
        cc.AddCoins(0, 5);      // 0 円は無効
        Assert.Equal(0, cc.GetCount(500));
        Assert.Equal(0, cc.GetCount(100));
    }

    [Fact]
    public void Test_7_5_GetAmount_Total()
    {
        var cc = new CoinCase();
        cc.AddCoins(500, 1);
        cc.AddCoins(100, 2);
        cc.AddCoins(50, 3);
        cc.AddCoins(10, 4);
        cc.AddCoins(5, 5);
        cc.AddCoins(1, 6);
        // 500 + 200 + 150 + 40 + 25 + 6 = 921
        Assert.Equal(921, cc.GetAmount());
    }

    [Fact]
    public void Test_7_5_GetAmount_EmptyIsZero()
    {
        var cc = new CoinCase();
        Assert.Equal(0, cc.GetAmount());
    }

    // ===== 問題 7-6: オーバーロード =====

    [Fact]
    public void Test_7_6_GetCountNoArgs_Total()
    {
        var cc = new CoinCase();
        cc.AddCoins(500, 2);
        cc.AddCoins(100, 3);
        cc.AddCoins(10, 5);
        Assert.Equal(10, cc.GetCount());   // 2 + 3 + 5 = 10
    }

    [Fact]
    public void Test_7_6_GetCountNoArgs_EmptyIsZero()
    {
        var cc = new CoinCase();
        Assert.Equal(0, cc.GetCount());
    }

    [Fact]
    public void Test_7_6_GetAmountByDenomination()
    {
        var cc = new CoinCase();
        cc.AddCoins(100, 4);
        cc.AddCoins(50, 3);
        Assert.Equal(400, cc.GetAmount(100));
        Assert.Equal(150, cc.GetAmount(50));
    }

    [Fact]
    public void Test_7_6_GetAmountByDenomination_EmptyIsZero()
    {
        var cc = new CoinCase();
        Assert.Equal(0, cc.GetAmount(500));
    }

    // ===== Problem7_1 =====

    [Theory]
    [InlineData("ポチ")]
    [InlineData("コロ")]
    [InlineData("")]
    public void Test_7_1_Problem(string name)
    {
        Assert.Equal(name, Exercises.Problem7_1(name));
    }

    // ===== Problem7_2 =====

    [Theory]
    [InlineData("ポチ", 3, "ポチ,3")]
    [InlineData("コロ", 5, "コロ,5")]
    public void Test_7_2_Problem(string name, int age, string expected)
    {
        Assert.Equal(expected, Exercises.Problem7_2(name, age));
    }

    // ===== Problem7_3 =====

    [Fact]
    public void Test_7_3_Problem_IndependentInstances()
    {
        Assert.Equal("タロ,コロ", Exercises.Problem7_3());
    }

    // ===== Problem7_4 =====

    [Theory]
    [InlineData("柴犬", "ポチ", 3, "柴犬: ポチ (3歳)")]
    [InlineData("トイプードル", "モコ", 1, "トイプードル: モコ (1歳)")]
    public void Test_7_4_Problem(string breed, string name, int age, string expected)
    {
        Assert.Equal(expected, Exercises.Problem7_4(breed, name, age));
    }

    // ===== Problem7_5 =====

    [Theory]
    [InlineData(500, 2, 1000)]
    [InlineData(100, 5, 500)]
    [InlineData(10, 3, 30)]
    public void Test_7_5_Problem(int denomination, int count, int expected)
    {
        Assert.Equal(expected, Exercises.Problem7_5(denomination, count));
    }

    // ===== Problem7_6 =====

    [Theory]
    [InlineData(100, 4, "4,400")]
    [InlineData(500, 3, "3,1500")]
    public void Test_7_6_Problem(int denomination, int count, string expected)
    {
        Assert.Equal(expected, Exercises.Problem7_6(denomination, count));
    }
}
