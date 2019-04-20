using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class DoublyLinkedList
    {
        DoublyLinkedListNode head;

        private DoublyLinkedList() { }

        public DoublyLinkedList(DoublyLinkedListNode doublyLinkedListNode)
        {
            head = doublyLinkedListNode;
        }

        public void SetDoublyLinkedListHead(DoublyLinkedListNode doublyLinkedListNode)
        {
            head = doublyLinkedListNode;
        }

        public DoublyLinkedListNode GetdoublyLinkedListHead()
        {
            return head;
        }


        public DoublyLinkedListNode InsertBefore(DoublyLinkedListNode head, int data)
        {
            if (head == null)
            {
                head = new DoublyLinkedListNode(data);
                return head;
            }

            DoublyLinkedListNode doublyLinkedListNode = new DoublyLinkedListNode(data);
            doublyLinkedListNode.SetDoublyLinkednodeNext(head);
            head.SetDoublyLinkedListNodePrevious(doublyLinkedListNode);
            head = doublyLinkedListNode;
            return head;
        }

        public void PrintDoublyLinkedList() {
            if (this.head == null) {
                Console.WriteLine("Doubly linked list is null! Cannot print anything!");
                return;
            }
            DoublyLinkedListNode doublyLinkedListNode = this.head;
            while (doublyLinkedListNode != null) {
                Console.Write(doublyLinkedListNode.GetDoublyLinkedListNodeData()+" ");
                doublyLinkedListNode = doublyLinkedListNode.GetDoublyLinkedListNextNode();
            }
        }

        public DoublyLinkedListNode DeleteANodeInDoublyLinkedList(int data) {
            DoublyLinkedListNode node = this.head;

            Console.WriteLine("---Printing DLL after removing the element---");
            while (node != null && node.GetDoublyLinkedListNodeData() != data) {
                node = node.GetDoublyLinkedListNextNode();
            }

            DoublyLinkedListNode nodeToBeDeleted = node;

            node.GetDoublyLinkedListPreviousNode()
                .SetDoublyLinkednodeNext(node.GetDoublyLinkedListNextNode());
            node.GetDoublyLinkedListNextNode()
                .SetDoublyLinkedListNodePrevious(node.GetDoublyLinkedListPreviousNode());

            return this.head;
        }
    }
}