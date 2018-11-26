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
            return sortArrayBetweenIndices(items, 0, items.Length-1);
        }

        public static int[] sortArrayBetweenIndices(int[] items, int start_index, int end_index) {
            //System.Console.WriteLine("sortArrayBetweenIndices called start_index: " + start_index + " end_index: " + end_index + " Items: " + System.String.Join(", ", items));
            int pivot_item = items[end_index];
            int correct_pivot_pos = start_index;
            for(int i = start_index; i <= end_index; i++) {
                if(items[i] <= pivot_item) {
                    if(correct_pivot_pos != i) {
                        int temp = items[correct_pivot_pos];
                        items[correct_pivot_pos] = items[i];
                        items[i] = temp;
                    }
                    if(i < end_index)
                        correct_pivot_pos++;
                }
            }
            if(correct_pivot_pos - start_index > 1)
                items = sortArrayBetweenIndices(items, start_index, correct_pivot_pos - 1);
            if(end_index - correct_pivot_pos > 1)
                items = sortArrayBetweenIndices(items, correct_pivot_pos - 1, end_index);
            return items;
        }

    }
}