using System.Reflection;
using Shouldly;

namespace IM_P2.Tests;

public class UserTests
{
    [Fact]
    public void Password_WhenCorrectlyImplemented_ShouldBePrivate()
    {
        var publicFields = typeof(User).GetFields(BindingFlags.Public | BindingFlags.Instance);

        publicFields.ShouldNotContain(info => info.Name == "password");
        publicFields.ShouldBeEmpty();
    }

    [Fact]
    public void User_WhenCorrectlyImplemented_ShouldExposeCtorWhichTakesParametersForAccountHolderName()
    {
        var constructorInfo = typeof(User).GetConstructor(BindingFlags.Public | BindingFlags.Instance,
            [typeof(string), typeof(string)]);

        constructorInfo.ShouldNotBeNull();
    }

    [Fact]
    public void User_WhenCorrectlyImplemented_ShouldExposeUsernameAsProperty()
    {
        var user = new User("admin", "V3rY_s3c|_|Re");

        user.Username.ShouldBe("admin");
    }
}