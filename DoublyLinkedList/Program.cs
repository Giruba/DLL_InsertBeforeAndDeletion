using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doubly Linked List!");
            Console.WriteLine("-------------------");

            DoublyLinkedList doublyLinkedList = GetDoublyLinkedlistFromInput();

            //Prints InsertBefore order of DLL
            Console.WriteLine("---Printing Doubly Linked list---");
            doublyLinkedList.PrintDoublyLinkedList();
            Console.WriteLine();
            Console.WriteLine("Enter the element to be deleted");
            try
            {
                int element = int.Parse(Console.ReadLine());
                doublyLinkedList.SetDoublyLinkedListHead(doublyLinkedList.DeleteANodeInDoublyLinkedList(element));
                Console.WriteLine();
                doublyLinkedList.PrintDoublyLinkedList();
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is " +
                    ""+exception.Message);
            }
            Console.ReadLine();
        }

        private static DoublyLinkedList GetDoublyLinkedlistFromInput() {
            DoublyLinkedList doublyLinkedList = null;

            Console.WriteLine("Enter the number of elements in the " +
                "doubly linked list");
            try
            {
                int numberElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space, comma" +
                    " or semi-colon");
                String[] elements = Console.ReadLine().Split(' ', ',', ';');
                doublyLinkedList = new DoublyLinkedList(null);
                DoublyLinkedListNode node = null;
                for (int index = 0; index < numberElements; index++) {
                    node = doublyLinkedList.InsertBefore(node,
                        int.Parse(elements[index]));
                }
                doublyLinkedList.SetDoublyLinkedListHead(node);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return doublyLinkedList;
        }
    }
}
