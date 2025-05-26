namespace IM_P2.CleanCodeExamples;

public interface IFile
{
    void AppendAllText(string filePath, string? contents);
}