using System;
using CSharp.LinkedList;

namespace CSharp{
    public class TestDSA {

        void testDoublyLinkedList() {
            DoublyLinkedList dll = new DoublyLinkedList();
            dll.insert(2);
            dll.insert(1);
            dll.insert(5);
            dll.insert(3);
            Console.WriteLine("Resultant Doubly Linked List: " + dll.traverse().toString());
        }

        public static void Main(string[] args) {
            testDoublyLinkedList();
        }
    }
}