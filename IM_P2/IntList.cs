namespace IM_P2;

public class IntList
{
    private int nextIndex = 0;
    private int[] items = new int[3];

    public void Add(int item)
    {
        if (nextIndex > items.Length)
        {
            var temp = items.ToArray();
            items = new int[items.Length * 2];
            for (int i = 0; i < temp.Length; i++)
            {
                items[i] = temp[i];
            }
        }

        items[nextIndex] = item;
        nextIndex++;
    }

    public int GetItem(int index)
    {
        return items[index];
    }
}