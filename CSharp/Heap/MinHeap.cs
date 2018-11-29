using System;

namespace CSharp.Heap {
    class MinHeap {

        int max_size;

        int length = 0;

        int[] items;

        public MinHeap(int max_size) {
            this.max_size = max_size;
            this.items = new int[max_size];
        }

        public void insertMultiple(int[] new_items) {
            if(this.max_size < this.length + new_items.Length) {
                throw new Exception("Can't insert more items than capacity!!");
            }
            foreach(int new_item in new_items) {
                items[length] = new_item;
                length++;
            }
            heapify();
        }

        public int getParentIndex(int node_index) {
            if(node_index <= 1)
                return -1;
            else
                return node_index / 2;
        }

        public int getLeftChildIndex(int node_index) {
            int left_child_index = node_index * 2;
            return left_child_index <= this.length ? left_child_index : -1;
        }

        public int getRightChildIndex(int node_index) {
            int right_child_index = (node_index * 2) + 1;
            return right_child_index <= this.length ? right_child_index : -1;
        }

        public int getLastNodeIndex() {
            return this.length;
        }

        public int getLastParentIndex() {
            return getParentIndex(getLastNodeIndex());
        }

        public void swapNodes(int node_1_index, int node_2_index) {
            int temp = items[node_1_index - 1];
            items[node_1_index - 1] = items[node_2_index - 1];
            items[node_2_index - 1] = temp;
        }

        public void heapify() {
            int i = getLastParentIndex();
            while (i > 0) {
                heapifyNode(i);
                i--;
            }
        }

        public void heapifyNode(int root_index) {
            int left_child_index = getLeftChildIndex(root_index);
            int right_child_index = getRightChildIndex(root_index);


            if(left_child_index != -1 || right_child_index != -1) {
                int min_child_index;
                if(left_child_index != -1 && right_child_index != -1)
                    min_child_index = items[left_child_index - 1] < items[right_child_index - 1] ? left_child_index : right_child_index;
                else
                    min_child_index = left_child_index != -1 ? left_child_index : right_child_index;
                
                if(items[root_index - 1] > items[min_child_index - 1]) {
                    swapNodes(root_index, min_child_index);
                    heapifyNode(min_child_index);
                }
            }
        }

        public int extractRoot() {
            int current_root_item = items[0];
            items[0] = items[getLastNodeIndex() - 1];
            this.length--;
            heapify();
            return current_root_item;
        }

        public int swapRoot(int new_root_item) {
            int current_root_item = items[0];
            items[0] = new_root_item;
            heapify();
            return current_root_item;
        }

    }
}