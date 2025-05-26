namespace IM_P2.CleanCodeExamples;

public class FileWrapper : IFile
{
    public void AppendAllText(string filePath, string? contents)
    {
        File.AppendAllText(filePath, contents);
    }
}