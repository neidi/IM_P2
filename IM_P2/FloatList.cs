namespace IM_P2;

public class FloatList
{
    private int nextIndex = 0;
    private float[] items = new float[3];

    public void Add(float item)
    {
        if (nextIndex > items.Length)
        {
            var temp = items.ToArray();
            items = new float[items.Length * 2];
            for (int i = 0; i < temp.Length; i++)
            {
                items[i] = temp[i];
            }
        }

        items[nextIndex] = item;
        nextIndex++;
    }

    public float GetItem(int index)
    {
        return items[index];
    }
}