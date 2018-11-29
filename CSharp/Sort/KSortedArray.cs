using System.Collections.Generic;
using CSharp.Heap;

namespace CSharp.Sort {
    class KSortedArray {

        public static int[] sort(int[] items, int k) {
            int[] sorted_items = new int[items.Length];
            MinHeap min_heap = new MinHeap(k+1);
            int[] heap_items = new int[k+1];
            for(int i=0; i < (k+1); i++) {
                heap_items[i] = items[i];
            }
            min_heap.insertMultiple(heap_items);

            int result_index = 0;
            int heap_index = k+1;

            while(result_index < items.Length) {
                if(heap_index >= items.Length)
                    sorted_items[result_index] = min_heap.extractRoot();
                else {
                    sorted_items[result_index] = min_heap.swapRoot(heap_index);
                    heap_index++;
                }
                result_index++;
            }

            return sorted_items;
        }

    }
}