using System;
using CSharp.LinkedList;
using CSharp.Problems;
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

        static void testZeroOneArraySegregation() {
            int[] input = { 0, 1, 0, 1, 0, 0, 1, 1, 0 };
            Console.WriteLine("Input: " + String.Join(" ", input));
            int[] output = ZeroOneArraySegregation.segregate(input);
            Console.WriteLine("Output: " + String.Join(" ", output));
        }

        public static void Main(string[] args) {
            Console.WriteLine("Starting Test Suite!!");
            //testDoublyLinkedList();
            testZeroOneArraySegregation();
        }
    }
}