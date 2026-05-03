using Xunit;

public class Chapter08Tests
{
    // ===== 問題 8-1: Cat クラス（継承・コンストラクタ・Sleep） =====

    [Fact]
    public void Test_8_1_CatInheritsNameFromAnimal()
    {
        var cat = new Cat("タマ", 2);
        Assert.Equal("タマ", cat.Name);
    }

    [Fact]
    public void Test_8_1_CatInheritsAgeFromAnimal()
    {
        var cat = new Cat("タマ", 2);
        Assert.Equal(2, cat.Age);
    }

    [Fact]
    public void Test_8_1_CatShowProfile()
    {
        var cat = new Cat("タマ", 2);
        Assert.Equal("タマ,2歳", cat.ShowProfile());
    }

    [Fact]
    public void Test_8_1_CatSleep()
    {
        var cat = new Cat("タマ", 2);
        Assert.Equal("スースー", cat.Sleep());
    }

    // ===== 問題 8-2: Dog クラス（継承・コンストラクタ・Run） =====

    [Fact]
    public void Test_8_2_DogInheritsNameFromAnimal()
    {
        var dog = new Dog("ポチ", 3);
        Assert.Equal("ポチ", dog.Name);
    }

    [Fact]
    public void Test_8_2_DogInheritsAgeFromAnimal()
    {
        var dog = new Dog("ポチ", 3);
        Assert.Equal(3, dog.Age);
    }

    [Fact]
    public void Test_8_2_DogShowProfile()
    {
        var dog = new Dog("ポチ", 3);
        Assert.Equal("ポチ,3歳", dog.ShowProfile());
    }

    [Fact]
    public void Test_8_2_DogRun()
    {
        var dog = new Dog("ポチ", 3);
        Assert.Equal("トコトコ", dog.Run());
    }

    // ===== 問題 8-3: Cat.Speak オーバーライド =====

    [Fact]
    public void Test_8_3_CatSpeak()
    {
        var cat = new Cat("タマ", 2);
        Assert.Equal("ニャー", cat.Speak());
    }

    [Fact]
    public void Test_8_3_CatSpeakDifferentFromAnimalDefault()
    {
        var cat = new Cat("ミケ", 5);
        Assert.NotEqual("......", cat.Speak());
    }

    // ===== 問題 8-4: Dog.Speak オーバーライド =====

    [Fact]
    public void Test_8_4_DogSpeak()
    {
        var dog = new Dog("ポチ", 3);
        Assert.Equal("ワンワン", dog.Speak());
    }

    [Fact]
    public void Test_8_4_DogSpeakDifferentFromAnimalDefault()
    {
        var dog = new Dog("コロ", 1);
        Assert.NotEqual("......", dog.Speak());
    }

    // ===== 問題 8-5: ポリモーフィズム =====

    [Fact]
    public void Test_8_5_AnimalArrayHoldsCatAndDog()
    {
        Animal[] animals = {
            new Cat("タマ", 2),
            new Dog("ポチ", 3),
            new Cat("ミケ", 1),
            new Dog("コロ", 5)
        };
        Assert.Equal(4, animals.Length);
        Assert.IsType<Cat>(animals[0]);
        Assert.IsType<Dog>(animals[1]);
        Assert.IsType<Cat>(animals[2]);
        Assert.IsType<Dog>(animals[3]);
    }

    [Fact]
    public void Test_8_5_PolymorphicSpeakCallsCorrectOverride()
    {
        Animal[] animals = {
            new Cat("タマ", 2),
            new Dog("ポチ", 3),
            new Cat("ミケ", 1),
            new Dog("コロ", 5)
        };
        Assert.Equal("ニャー", animals[0].Speak());
        Assert.Equal("ワンワン", animals[1].Speak());
        Assert.Equal("ニャー", animals[2].Speak());
        Assert.Equal("ワンワン", animals[3].Speak());
    }

    [Fact]
    public void Test_8_5_PolymorphicShowProfileUsesActualNameAndAge()
    {
        Animal[] animals = {
            new Cat("タマ", 2),
            new Dog("ポチ", 3)
        };
        Assert.Equal("タマ,2歳", animals[0].ShowProfile());
        Assert.Equal("ポチ,3歳", animals[1].ShowProfile());
    }

    // ===== Problem8_1 =====

    [Theory]
    [InlineData("タマ", 2, "タマ,2歳,スースー")]
    [InlineData("ミケ", 5, "ミケ,5歳,スースー")]
    public void Test_8_1_Problem(string name, int age, string expected)
    {
        Assert.Equal(expected, Exercises.Problem8_1(name, age));
    }

    // ===== Problem8_2 =====

    [Theory]
    [InlineData("ポチ", 3, "ポチ,3歳,トコトコ")]
    [InlineData("コロ", 1, "コロ,1歳,トコトコ")]
    public void Test_8_2_Problem(string name, int age, string expected)
    {
        Assert.Equal(expected, Exercises.Problem8_2(name, age));
    }

    // ===== Problem8_3 =====

    [Fact]
    public void Test_8_3_Problem_CatSpeaksThroughAnimalRef()
    {
        Assert.Equal("ニャー", Exercises.Problem8_3());
    }

    // ===== Problem8_4 =====

    [Fact]
    public void Test_8_4_Problem_DogSpeaksThroughAnimalRef()
    {
        Assert.Equal("ワンワン", Exercises.Problem8_4());
    }

    // ===== Problem8_5 =====

    [Fact]
    public void Test_8_5_Problem_PolymorphicSpeak()
    {
        Assert.Equal("ニャー,ワンワン,ニャー,ワンワン", Exercises.Problem8_5());
    }
}
