using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class DoublyLinkedListNode
    {
        int data;
        DoublyLinkedListNode previous;
        DoublyLinkedListNode next;

        private DoublyLinkedListNode() { }

        public DoublyLinkedListNode(int data) {
            this.data = data;
        }


        public void SetDoublyLinkedListNodeData(int data) {
            this.data = data;
        }

        public void SetDoublyLinkedListNodePrevious(DoublyLinkedListNode doublyLinkedListNode) {
            this.previous = doublyLinkedListNode;
        }

        public void SetDoublyLinkednodeNext(DoublyLinkedListNode doublyLinkedListNode) {
            this.next = doublyLinkedListNode; 
        }

        public int GetDoublyLinkedListNodeData() {
            return data;
        }

        public DoublyLinkedListNode GetDoublyLinkedListPreviousNode() {
            return previous;
        }

        public DoublyLinkedListNode GetDoublyLinkedListNextNode() {
            return next;
        }
    }
}
