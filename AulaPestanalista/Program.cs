using System.Net.Http.Headers;
using AulaPestanalista;

internal class Program
{
    private static void Main(string[] args)
    {
        ListIten list = new ListIten();

        Item item = new(21);

        list.Insert(item);
        list.Print();

        item = new(25);
        list.Insert(item);
        list.Print();

        item = new(40);
        list.Insert(item);
        list.Print();

        item = new(33);
        list.Insert(item);
        list.Print();

        item = new(44);
        list.Insert(item);
        list.Print();

        item = new(17);
        list.Insert(item);
        list.Print();

    }
}