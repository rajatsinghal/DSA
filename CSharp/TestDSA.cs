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

        static void testPowerSet() {
            List<string> input = new List<string> { "a", "b", "c", "d" };
            List<List<string>> power_set = PowerSet.generate(input);
            Console.WriteLine("PowerSet: ");
            foreach(List<string> subset in power_set)
                Console.WriteLine("{" + String.Join(", ", subset) + "}");
        }

        static void testKnapsack() {
            int[] values = { 60, 700, 820, 1000 };
            int[] weights = { 10, 20, 30, 100 };
            int max_weight = 150;
            Console.WriteLine(
                "Max Knapsack value for values: {" + String.Join(", ", values) + 
                "} with weights: {" + String.Join(", ", weights) + "} for max_weight: " + 
                max_weight + " is: " + Knapsack.solve(values, weights, max_weight)
            );
        }

        static void testLRU() {
            LRUCache cache = new LRUCache(2);
            cache.set(1, 10);
            cache.set(2, 20);
            Console.WriteLine("Value for the key: 1 is " + cache.get(1)); // Should return 10 
            
            cache.set(3, 30); // Evicts key 2 and store a key (3) with value 30 in the cache. 

            Console.WriteLine("Value for the key: 2 is " + cache.get(2)); // Should return -1 (not found)
            
            cache.set(4, 40); // Evicts key 1 and store a key (4) with value 40 in the cache. 
            Console.WriteLine("Value for the key: 1 is " + cache.get(1)); // Should return -1 (not found)
            Console.WriteLine("Value for the key: 3 is " + cache.get(3)); // Should return 30 
            Console.WriteLine("Value for the key: 4 is " + cache.get(4)); // Should return 40
        }

        public static void Main(string[] args) {
            Console.WriteLine("Starting Test Suite!!");
            //testDoublyLinkedList();
            //testZeroOneArraySegregation();
            //testZeroOneTwoArraySegregation();
            //testWordOccurencesCount();
            //testDetectAndRemoveLoop();
            //testLinkedListReversal();
            //testPowerSet();
            //testKnapsack();
            testLRU();
        }
    }
}