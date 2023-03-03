using Shouldly;

namespace Garden.Tests;

public class Tests
{
    [Test]
    public void AcceptsWellFormattedValues()
    {
        var ok = "1234567";


        var result = GardenId.Check(ok);

        result.ShouldBeTrue();
    }

    [Test]
    public void RejectsValuesThatAreTooShort()
    {
        var tooShort = "123456";

        var result = GardenId.Check(tooShort);

        result.ShouldBeFalse();
    }



    [Test]
    public void RejectsValuesThatAreTooBig()
    {
        var tooBig = "123456789";

        var result = GardenId.Check(tooBig);

        result.ShouldBeFalse();
    }

    [Test]
    public void RejectsValuesThatContainsNonDigitsCharacters()
    {
        var withInvalidCharacters = "123A567";

        var result = GardenId.Check(withInvalidCharacters);

        result.ShouldBeFalse();
    }

}