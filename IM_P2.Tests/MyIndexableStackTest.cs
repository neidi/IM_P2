namespace IM_P2.Tests;

public class MyIndexableStackTest
{
    [Fact]
    public void Pop_ShouldGetItemsLastInFirstOut()
    {
        // Arrange
        var myIndexableStack = new MyIndexableStack<string>();
        myIndexableStack.Push("in C#");
        myIndexableStack.Push("a stack");
        myIndexableStack.Push("I am");
        myIndexableStack.Push("hello world");

        // Act
        var lastStackedElement = myIndexableStack.Pop();
        var thirdStackedElement = myIndexableStack.Pop();
        var secondStackedElement = myIndexableStack.Pop();
        var firstStackedElement = myIndexableStack.Pop();

        // Assert
        Assert.Equal("hello world", lastStackedElement);
        Assert.Equal("I am", thirdStackedElement);
        Assert.Equal("a stack", secondStackedElement);
        Assert.Equal("in C#", firstStackedElement);
    }

    [Fact]
    public void Indexer_ShouldReturnElementsInReversedOrder()
    {
        // Arrange
        var myIndexableStack = new MyIndexableStack<string>();
        myIndexableStack.Push("in C#");
        myIndexableStack.Push("a stack");
        myIndexableStack.Push("I am");
        myIndexableStack.Push("hello world");

        // Act
        var lastStackedElement = myIndexableStack[0];
        var thirdStackedElement = myIndexableStack[1];
        var secondStackedElement = myIndexableStack[2];
        var firstStackedElement = myIndexableStack[3];

        // Assert
        Assert.Equal("hello world", lastStackedElement);
        Assert.Equal("I am", thirdStackedElement);
        Assert.Equal("a stack", secondStackedElement);
        Assert.Equal("in C#", firstStackedElement);
    }
}