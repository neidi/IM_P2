using IM_P2.Abgabearbeit;

namespace IM_P2.Tests.Abgabearbeit;

public class DateTimeProviderMock: IDateTimeProvider
{
    internal void PassTime(TimeSpan offset)
    {
        Now += offset;
    }

    public DateTime Now { get; private set; } = DateTime.Parse("2025-05-05 17:51:31");
}