using IM_P2.Abgabearbeit;
using Shouldly;

namespace IM_P2.Tests.Abgabearbeit;

public class VetTest
{
    [Fact]
    public void Treat_WhenAnimalsAreNotImmune_ExposeNotImmune()
    {
        // Arrange
        var vet = new Vet();
        var chicken = new Chicken();
        var cat = new Cat(new DateTimeProviderMock());
        var dog = new Dog(3);
        IAnimal[] animals = [chicken, cat, dog];

        // Act
        foreach (var animal in animals)
        {
            vet.Treat(animal);
        }

        // Assert
        chicken.IsImmune.ShouldBeFalse();
        cat.IsImmune.ShouldBeFalse();
        dog.IsImmune.ShouldBeFalse();
    }

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    public void Treat_WhenDogsAreVaccinatedLikeTheirImmunizationNeeds_AreImmune(int immunizationCount)
    {
        var vet = new Vet();
        var dog = new Dog(immunizationCount);

        for (int i = 0; i < immunizationCount - 1; i++)
        {
            vet.Treat(dog);
            dog.IsImmune.ShouldBeFalse();
        }

        vet.Treat(dog);

        dog.IsImmune.ShouldBeTrue();
    }

    [Fact]
    public void Treat_WhenCatsAreVaccinatedLikeTheirImmunizationNeeds_AreImmune()
    {
        // Arrange
        var vet = new Vet();
        var dateTimeProviderMock = new DateTimeProviderMock();
        var cat = new Cat(dateTimeProviderMock);

        vet.Treat(cat);
        cat.IsImmune.ShouldBeFalse();
        vet.Treat(cat);

        cat.IsImmune.ShouldBeTrue();
    }
    
    [Fact]
    public void Treat_WhenCatsAreVaccinatedAndMoreThanAYearPassed_ShouldNoLongerBeImmune()
    {
        var vet = new Vet();
        var dateTimeProviderMock = new DateTimeProviderMock();
        var cat = new Cat(dateTimeProviderMock);

        vet.Treat(cat);
        cat.IsImmune.ShouldBeFalse();
        vet.Treat(cat);
        cat.IsImmune.ShouldBeTrue();

        dateTimeProviderMock.PassTime(TimeSpan.FromDays(366));
        cat.IsImmune.ShouldBeFalse();
    }
}