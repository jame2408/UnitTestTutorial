namespace TaiwanIdValidator.Tests;

public class IdValidatorTests
{
    [Test]
    public void Validate_ShouldIndicateInvalidId_WhenIdIsNull()
    {
        // TODO: Implement test
    }

    [Test]
    public void Validate_ShouldIndicateInvalidId_WhenIdIsNot10CharactersLong()
    {
        // TODO: Implement test
    }

    [Test]
    public void Validate_ShouldIndicateInvalidId_WhenFirstCharacterIsNotLetter()
    {
        // TODO: Implement test
    }

    [Test]
    public void Validate_ShouldIndicateInvalidId_WhenSecondCharacterIsNot1Or2()
    {
        // TODO: Implement test
    }

    [Test]
    public void Validate_ShouldIndicateInvalidId_WhenRemainingCharactersAreNotDigits()
    {
        // TODO: Implement test
    }

    [Test]
    [Ignore("Implementing this test case is challenging due to the Validate method's sequence of checks, which validates ID format before city code, preventing us from testing invalid city codes directly.")]
    public void Validate_ShouldIndicateInvalidId_WhenCityCodeIsInvalid()
    {
        // TODO: Implement test
    }

    [Test]
    public void Validate_ShouldIndicateInvalidId_WhenChecksumIsInvalid()
    {
        // TODO: Implement test
    }

    [Test]
    public void Validate_ShouldIndicateValidId_WhenIdIsValid()
    {
        // TODO: Implement test
    }
}