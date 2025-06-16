using System.Text;
using IM_P2.CleanCodeExamples;

namespace IM_P2.Tests;

public class FakeFile : IFile
{
    public StringBuilder FileContent { get; } = new();
    
    public void AppendAllText(string filePath, string? contents)
    {
        FileContent.Append(contents);
    }
}