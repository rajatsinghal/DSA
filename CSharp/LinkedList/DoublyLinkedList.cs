using System.Collections.Generic;

namespace CSharp.LinkedList {
    public class DoublyLinkedList<T> {
        class Node<T> {

            public T item { get; private set; }
            public Node<T> prev_node;
            public Node<T> next_node;

            public Node(T item) {
                this.item = item;
            }

        }

        Node<T> head;

        public void insert(T item) {
            Node<T> new_node = new Node<T>(item);
            if(head != null) {
                head.prev_node = new_node;
                new_node.next_node = head;
            }
            head = new_node;
        }

        public void deleteHead() {
            if(head != null) {
                head.next_node.prev_node = null;
                head = head.next_node;
            }
        }

        public void delete(T item, bool delete_all_occurrences=true) {
            Node<T> iterative_node = head;
            while(iterative_node != null) {
                if(iterative_node.item == item) {
                    if(iterative_node.prev_node != null) {
                        iterative_node.prev_node.next_node = iterative_node.next_node;
                    }
                    if(iterative_node.next_node != null) {
                        iterative_node.next_node.prev_node = iterative_node.prev_node;
                    }

                    if(!delete_all_occurrences)
                        break;
                }
                iterative_node = iterative_node.next_node;
            }
        }

        public List<T> traverse() {
            List<T> items = new List<T>();
            Node<T> iterative_node = head;
            while (iterative_node != null) {
                items.Add(iterative_node.item);
            }
            return items;
        }

        public int getSize() {
            int size = 0;
            Node<T> iterative_node = head;
            while (iterative_node != null) {
                size++;
            }
            return size;
        }
    }
}