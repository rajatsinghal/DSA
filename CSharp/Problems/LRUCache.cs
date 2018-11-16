using CSharp.LinkedList;
using System.Collections.Generic;

namespace CSharp.Problems {

    public class LRUCache {
        
        class ListNode {
            int key;
            int item;
            ListNode next;
            ListNode prev;

            public ListNode(int key, int item) {
                this.item = item;
            }
        }

        int capacity;
        Dictionary<int, ListNode> items;
        ListNode head;
        ListNode tail;
        int current_size;

        public LRUCache(int capacity) {
            if(capacity == 0) {
                throw new Exception("Cache can't be of zero capaciy!");
            }
            this.capacity = capacity;
            this.items = new Dictionary<int, ListNode>();
            this.current_size = 0;
        }

        public int get(int key) {
            if(!items.ContainsKey(key))
                return -1;
            else {
                ListNode item_node = items[key];
                moveNodeToFront(item_node);
                return item_node.item;
            }
        }

        public void set(int key, int value) {
            if(items.ContainsKey(key)) {
                ListNode item_node = items[key];
                item_node.item = value;
                moveNodeToFront(item_node);
            } else {
                if(this.current_size == this.capacity) {
                    removeLastNode();
                }
                addItemAtFront(key, value);
            }
        }

        void moveNodeToFront(Node item_node) {
            ListNode prev_node = item_node.prev;
            ListNode next_node = item_node.next;
            if(prev_node != null)
                prev_node.next = next_node;
            if(next_node != null)
                next_node.prev = prev_node;

            item_node.prev = null;
            item_node.next = head;
            head.prev = item_node;
            head = item_node;
        }

        void addItemAtFront(int key, int item) {
            ListNode new_node = new ListNode(key, item);
            new_node.next = this.head;
            if (this.head != null)
                this.head.prev = new_node;
            this.head = new_node;
            if (this.tail == null)
                this.tail = this.head;
            items.Add(key, this.head);
            this.current_size++;
        }

        void removeLastNode() {
            this.items.Remove(this.tail.key);
            this.tail = this.tail.prev;
            if(this.tail != null)
                this.tail.next = null;
            this.current_size--;
        }

    }

}