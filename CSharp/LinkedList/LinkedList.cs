using System.Collections.Generic;

namespace CSharp.LinkedList {

    public class LinkedList {

        public Node head;

        class Node {
            
            int item { public get; }

            public Node next;

            public Node(int item) {
                this.item = item;
            }

        }

        public void insert(int item) {
            Node new_node = new Node(item);
            new_node.next = head;
            head = new_node;
        }

        public void detectAndRemoveLoop() {
            
        }

    }

}