namespace CSharp.Sort {
    class QuickSort {

        public static int[] sort(int[] items) {
            if(items.Length <= 1)
                return items;
            
            int[] smaller_items = new int[items.Length - 1];
            int[] bigger_items = new int[items.Length - 1];

            int smaller_items_index = 0;
            int bigger_items_index = 0;
            for(int i = 1; i < items.Length; i++) {
                if(items[i] < items[0])
                    smaller_items[++smaller_items_index] = items[i];
                else
                    bigger_items[++bigger_items_index] = items[i];
            }

            smaller_items = sort(smaller_items);
            bigger_items = sort(bigger_items);

            int[] result_items = new int[items.Length];
            int result_index = 0;
            for(int j = 0; j < smaller_items.Length - 1; j++)
                result_items[++result_index] = smaller_items[j];
            
            result_items[++result_index] = items[0];

            for(int k = 0; k < bigger_items.Length - 1; k++)
                result_items[++result_index] = bigger_items[k];
            
            return result_items;
        }

    }
}