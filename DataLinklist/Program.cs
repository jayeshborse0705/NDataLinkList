using DataLinklist;
using System;
namespace DatastructureLinkList
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linklist operation:");
            Linklist list = new Linklist();
            list.Add(70);
            list.Add(56);
            list.Add(36);

            list.Display();


        }

    }
}