
namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedLists.LinkedList(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Print();
        }
    }
}
