namespace IM_P2;

public partial class GenericList<T>
{
    public class Caller
    {
        static void CallIt()
        {
            var stringList = new GenericList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            Console.WriteLine(stringList.GetItem(0)); // Output: Hello
            Console.WriteLine(stringList.GetItem(1)); // Output: World
            var item = stringList.GetItem(0);
            var strings = item.Split(",");
        }
    }
}