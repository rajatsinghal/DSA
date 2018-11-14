using System;
using CSharp.LinkedList;

namespace CSharp{
    public class TestDSA {

        static void testDoublyLinkedList() {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.insert(2);
            dll.insert(1);
            dll.insert(5);
            dll.insert(3);
            Console.WriteLine("Resultant Doubly Linked List: " + String.Join(" ", dll.traverse()));
        }

        public static void Main(string[] args) {
            testDoublyLinkedList();
        }
    }
}