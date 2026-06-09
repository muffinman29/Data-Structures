namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedLists.LinkedList<string> list = new LinkedLists.LinkedList<string>();
            list.Add("Hello!");
            list.Add("World!");
            list.Print();            
        }       
    }
}
