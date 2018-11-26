using System.Collections.Generic;

namespace CSharp.Sort {
    class QuickSort {

        public static List<int> sort(List<int> items) {
            if(items.Count <= 1)
                return items;
            
            List<int> smaller_items = new List<int>();
            List<int> bigger_items = new List<int>();

            for(int i = 1; i < items.Count; i++) {
                if(items[i] < items[0])
                    smaller_items.Add(items[i]);
                else
                    bigger_items.Add(items[i]);
            }
            
            smaller_items = sort(smaller_items);
            bigger_items = sort(bigger_items);

            List<int> result_items = new List<int>();
            for(int j = 0; j < smaller_items.Count; j++)
                result_items.Add(smaller_items[j]);
            
            result_items.Add(items[0]);

            for(int k = 0; k < bigger_items.Count; k++)
                result_items.Add(bigger_items[k]);
            
            return result_items;
        }

        public static int[] sort(int[] items) {
            return items;
        }

    }
}