using UserExample.UserTypes;
using Xunit;
using Xunit.Abstractions;

public class UserTests
{
    [Fact]
    public void Admin_CreateUser_ShouldPrintCorrectMessage()
    {
        // Arrange
        var admin = new Admin();

        // Act
        var output = CaptureConsoleOutput(() => admin.CreateUser());

        // Assert
        Assert.Equal("Create Admin User.", output);
    }

    [Fact]
    public void Normal_CreateUser_ShouldPrintCorrectMessage()
    {
        // Arrange
        var normal = new Normal();

        // Act
        var output = CaptureConsoleOutput(() => normal.CreateUser());

        // Assert
        Assert.Equal("Create Normal User.", output);
    }

    [Fact]
    public void Guest_CreateUser_ShouldPrintCorrectMessage()
    {
        // Arrange
        var guest = new Guest();

        // Act
        var output = CaptureConsoleOutput(() => guest.CreateUser());

        // Assert
        Assert.Equal("Create Guest User.", output);
    }

    private string CaptureConsoleOutput(Action action)
    {
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            action();
            return sw.ToString().Trim();
        }
    }
}