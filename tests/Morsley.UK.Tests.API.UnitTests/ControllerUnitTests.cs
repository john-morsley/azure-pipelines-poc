namespace Morsley.UK.Tests.API.UnitTests;

public class ControllerUnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // Arrange
        var logger = Substitute.For<ILogger<TestController>>();
        var controller = new Morsley.UK.Test.API.Controllers.TestController(logger);

        // Act
        var result = controller.Get();

        // Assert
        result.ShouldNotBeNull();
        result.Count().ShouldBe(5);
    }
}