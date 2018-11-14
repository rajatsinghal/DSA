using System;
using CSharp.LinkedList;
using System.Collections.Generic;

namespace CSharp{
    public class TestDSA {

        static void testDoublyLinkedList() {
            Console.WriteLine("Test Doubly Linked List");
            CSharp.LinkedList.DoublyLinkedList<int> dll = new CSharp.LinkedList.DoublyLinkedList<int>();
            dll.insert(2);
            dll.insert(1);
            dll.insert(5);
            dll.insert(3);
            Console.WriteLine("Resultant Doubly Linked List: " + String.Join(" ", dll.traverse()));
        }

        public static void Main(string[] args) {
            Console.WriteLine("Starting Test Suite!!");
            testDoublyLinkedList();
        }
    }
}