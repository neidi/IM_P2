namespace IM_P2;

public class StringList
{
    private int nextIndex = 0;
    private string[] items = new string[3];

    public void Add(string item)
    {
        if (nextIndex > items.Length)
        {
            var temp = items.ToArray();
            items = new string[items.Length * 2];
            for (int i = 0; i < temp.Length; i++)
            {
                items[i] = temp[i];
            }
        }

        items[nextIndex] = item;
        nextIndex++;
    }

    public string GetItem(int index)
    {
        return items[index];
    }
}