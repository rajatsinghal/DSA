using System;
using CSharp.LinkedList;
using CSharp.Problems;
using CSharp.Tree;
using System.Collections.Generic;

namespace CSharp{
    public class TestDSA {

        static void testStack() {
            CSharp.Stack.Stack<int> stack = new CSharp.Stack.Stack<int>(4);
            int[] insert_items = { 3, 6, 8, 2 };
            foreach(int item in insert_items)
                stack.push(item);
            Console.WriteLine("peek: " + stack.peek());
            Console.WriteLine("pop: " + stack.pop());
            Console.WriteLine("peek: " + stack.peek());
        }

        static void testKStacksInArray() {
            int max_stacks_count = 3;
            int max_size = 10;
            CSharp.Stack.KStacksInArray ks = new CSharp.Stack.KStacksInArray(max_stacks_count, max_size);
            ks.push(15, 2);
            ks.push(45, 2);
            ks.push(35, 2);

            ks.push(17, 1);
            ks.push(49, 1);
            ks.push(39, 1);

            ks.push(11, 0);
            ks.push(9, 0);
            ks.push(7, 0);
            ks.push(17, 0);

            Console.WriteLine("Popped element from stack 2 is " + ks.pop(2));
            ks.push(27, 0);
            Console.WriteLine("Popped element from stack 1 is " + ks.pop(1));
            ks.push(127, 1);
            Console.WriteLine("Popped element from stack 1 is " + ks.pop(1));
            Console.WriteLine("Popped element from stack 0 is " + ks.pop(0));
            Console.WriteLine("Popped element from stack 1 is " + ks.pop(2));
        }

        static void testDoublyLinkedList() {
            Console.WriteLine("Test Doubly Linked List");
            CSharp.LinkedList.DoublyLinkedList<int> dll = new CSharp.LinkedList.DoublyLinkedList<int>();
            dll.insert(2);
            dll.insert(1);
            dll.insert(5);
            dll.insert(3);
            Console.WriteLine("Resultant Doubly Linked List: " + System.String.Join(" ", dll.traverse()));
        }

        static void testZeroOneArraySegregation() {
            //int[] input = { 0, 1, 0, 1, 0, 0, 1, 1, 0 };
            int[] input = { 1, 1, 1 };
            Console.WriteLine("Input: " + System.String.Join(" ", input));
            int[] output = ZeroOneArraySegregation.segregate(input);
            Console.WriteLine("Output: " + System.String.Join(" ", output));
        }

        static void testZeroOneTwoArraySegregation() {
            //int[] input = { 2, 2, 2 };
            int[] input = { 0, 1, 0, 1, 2, 1, 0, 2, 1 };
            Console.WriteLine("Input: " + System.String.Join(" ", input));
            int[] output = ZeroOneTwoArraySegregation.segregate(input);
            Console.WriteLine("Output: " + System.String.Join(" ", output));
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
            Console.WriteLine("Linked List after removing loop : " + System.String.Join(" ", ll.read()));
        }

        static void testLinkedListReversal() {
            SimpleLinkedList ll = new SimpleLinkedList();
            int[] insert_vals = { 50, 20, 15, 4, 10 };
            foreach (int insert_val in insert_vals)
                ll.insert(insert_val);
            Console.WriteLine("Linked List before reversal : " + System.String.Join(" ", ll.read()));
            ll.reverse();
            Console.WriteLine("Linked List before reversal : " + System.String.Join(" ", ll.read()));
        }

        static void testLinkedListIntersection() {
            SimpleLinkedList ll1 = new SimpleLinkedList();
            int[] ll1_vals = { 50, 20, 15, 4, 10 };
            foreach (int insert_val in ll1_vals)
                ll1.insert(insert_val);

            SimpleLinkedList ll2 = new SimpleLinkedList();
            int[] ll2_vals = { 150, 30, 19 };
            foreach (int insert_val in ll2_vals)
                ll2.insert(insert_val);
            
            Console.WriteLine("Before - Intersection Found: " + SimpleLinkedList.findIntersection(ll1, ll2));
            ll2.attachIntersectionForTest(ll1);
            Console.WriteLine("Before - Intersection Found: " + SimpleLinkedList.findIntersection(ll1, ll2));
        }

        static void testPowerSet() {
            List<string> input = new List<string> { "a", "b", "c", "d" };
            List<List<string>> power_set = PowerSet.generate(input);
            Console.WriteLine("PowerSet: ");
            foreach(List<string> subset in power_set)
                Console.WriteLine("{" + System.String.Join(", ", subset) + "}");
        }

        static void testKnapsack() {
            int[] values = { 60, 700, 820, 1000 };
            int[] weights = { 10, 20, 30, 100 };
            int max_weight = 150;
            Console.WriteLine(
                "Max Knapsack value for values: {" + System.String.Join(", ", values) + 
                "} with weights: {" + System.String.Join(", ", weights) + "} for max_weight: " + 
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

        static void testAVLTree() {
            AVLTree tree = new AVLTree();
            int[] insert_values = { 10, 20, 30, 40, 50, 25 };
            foreach(int insert_value in insert_values)
                tree.insert(insert_value);
            tree.print();
        }

        static void testKnightPath() {
            KnightPath kp = new KnightPath(6);
            kp.solve();
        }

        static void testSubStringCount() {
            string str = "frajawwfrajaterfrajatwraj";
            string sub_str = "rajat";
            int count = CSharp.Strings.StringProblems.countSubString(str, sub_str);
            Console.WriteLine("Substring: " + sub_str + " is found " + count + " times in " + str);
        }

        static void testExpressionBalanced() {
            string expression = "[()]{}{[()()]()}";
            bool is_balanced = CSharp.Strings.StringProblems.isExpressionBalanced(expression);
            Console.WriteLine("Expression: " + expression + " is_balanced: " + is_balanced);
        }

        public static void Main(string[] args) {
            Console.WriteLine("Starting Test Suite!!");
            //testStack();
            //testKStacksInArray();
            //testDoublyLinkedList();
            //testZeroOneArraySegregation();
            //testZeroOneTwoArraySegregation();
            //testWordOccurencesCount();
            //testDetectAndRemoveLoop();
            //testLinkedListReversal();
            //testLinkedListIntersection();
            //testPowerSet();
            //testKnapsack();
            //testLRU();
            //testAVLTree();
            //testKnightPath();
            //testSubStringCount();
            testExpressionBalanced();
        }
    }
}