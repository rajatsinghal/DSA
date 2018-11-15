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
            //int[] input = { 0, 1, 0, 1, 0, 0, 1, 1, 0 };
            int[] input = { 1, 1, 1 };
            Console.WriteLine("Input: " + String.Join(" ", input));
            int[] output = ZeroOneArraySegregation.segregate(input);
            Console.WriteLine("Output: " + String.Join(" ", output));
        }

        static void testZeroOneTwoArraySegregation() {
            //int[] input = { 2, 2, 2 };
            int[] input = { 0, 1, 0, 1, 2, 1, 0, 2, 1 };
            Console.WriteLine("Input: " + String.Join(" ", input));
            int[] output = ZeroOneTwoArraySegregation.segregate(input);
            Console.WriteLine("Output: " + String.Join(" ", output));
        }

        static void testWordOccurencesCount() {
            string input = "serkgransrajgsgrajgsrgra raj";
            string word = "raj";
            int occurences_count = WordOccurencesCount.countWordOccurences(input, word);
            Console.WriteLine("Word: " + word + " found " + occurences_count + " times in string: " + input);
        }

        static void testDetectAndRemoveLoop() {
            SimpleLinkedList ll = new SimpleLinkedList();
            int[] insert_vals = {50, 20, 15, 4, 10};
            foreach(int insert_val in insert_vals)
                ll.insert(insert_val);
            ll.createLoopForTest();
            Console.WriteLine("Loop Found: " + ll.detectAndRemoveLoop());
            Console.WriteLine("Linked List after removing loop : " + String.Join(" ", ll.read()));
        }

        static void testLinkedListReversal() {
            SimpleLinkedList ll = new SimpleLinkedList();
            int[] insert_vals = { 50, 20, 15, 4, 10 };
            foreach (int insert_val in insert_vals)
                ll.insert(insert_val);
            Console.WriteLine("Linked List before reversal : " + String.Join(" ", ll.read()));
            ll.reverse();
            Console.WriteLine("Linked List before reversal : " + String.Join(" ", ll.read()));
        }

        public static void Main(string[] args) {
            Console.WriteLine("Starting Test Suite!!");
            //testDoublyLinkedList();
            //testZeroOneArraySegregation();
            //testZeroOneTwoArraySegregation();
            //testWordOccurencesCount();
            //testDetectAndRemoveLoop();
            testLinkedListReversal();
        }
    }
}