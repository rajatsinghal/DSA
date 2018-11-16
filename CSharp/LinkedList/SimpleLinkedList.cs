using System.Collections.Generic;

namespace CSharp.LinkedList {

    public class SimpleLinkedList {

        Node head;

        class Node {
            
            public int item;

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

        public List<int> read() {
            List<int> items = new List<int>();
            Node iterative_head = head;
            while(iterative_head != null) {
                items.Add(iterative_head.item);
                iterative_head = iterative_head.next;
            }
            return items;
        }

        public void createLoopForTest() { //Need to improve
            head.next.next.next.next.next = head.next.next;
        }

        public bool detectAndRemoveLoop() {
            Node fast_node = head;
            Node slow_node = head;
            bool has_loop = false;
            while(fast_node != null && fast_node.next != null) {
                slow_node = slow_node.next;
                fast_node = fast_node.next.next;
                if(slow_node == fast_node) {
                    has_loop = true;
                    break;
                }
            }
            if(!has_loop) {
                return false;
            } else { //Remove loop
                HashSet<Node> loop_nodes = new HashSet<Node>();
                Node iterative_loop_node = slow_node;
                loop_nodes.Add(iterative_loop_node);
                while(iterative_loop_node.next != slow_node) {
                    iterative_loop_node = iterative_loop_node.next;
                    loop_nodes.Add(iterative_loop_node);
                }
                Node iterative_head = head;
                while(!loop_nodes.Contains(iterative_head)) {
                    iterative_head = iterative_head.next;
                }
                Node loop_start_node = iterative_head;
                while(iterative_head.next != loop_start_node) {
                    iterative_head = iterative_head.next;
                }
                Node loop_end_node = iterative_head;
                loop_end_node.next = null; //Loop removed
                return true;
            }
        }

        public void reverse() {
            if(head == null || head.next == null)
                return;
            
            Node iterative_head = head.next;
            head.next = null;
            while(iterative_head != null) {
                Node iterative_head_copy = iterative_head;
                iterative_head = iterative_head.next;
                iterative_head_copy.next = this.head;
                this.head = iterative_head_copy;
            }
        }

        public static void findIntersection(LinkedList<T> llist_1, LinkedList<T> llist_2) {
            
        }

    }

}