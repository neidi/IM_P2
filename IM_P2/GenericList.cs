namespace IM_P2;

public partial class GenericList<T>
{
    private int nextIndex = 0;
    private T[] items = new T[3];

    public void Add(T item)
    {
        if (nextIndex > items.Length)
        {
            var temp = items.ToArray();
            items = new T[items.Length * 2];
            for (int i = 0; i < temp.Length; i++)
            {
                items[i] = temp[i];
            }
        }

        items[nextIndex] = item;
        nextIndex++;
    }

    public T GetItem(int index)
    {
        return items[index];
    }
}