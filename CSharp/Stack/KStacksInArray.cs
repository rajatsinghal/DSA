namespace CSharp.Stack {
    class KStacksInArray {

        int max_stacks_count;
        int max_size;

        int[] items;
        int[] next_item_indexes;
        int[] stack_top_indexes;
        int free_start_index;

        public KStacksInArray(int max_stacks_count, int max_size) {
            this.max_stacks_count = max_stacks_count;
            this.max_size = max_size;
            
            this.items = new int[max_size];
            this.next_item_indexes = new int[max_size];
            this.stack_top_indexes = new int[max_stacks_count];

            this.free_start_index = 0;

            for(int i=0; i<max_stacks_count; i++)
                this.stack_top_indexes[i] = -1;
            for(int j=0; j<max_size; j++) {
                this.next_item_indexes[j] = j+1;
            }
            this.next_item_indexes[max_size - 1] = -1; 
        }

        public void push(int item, int stack_index) {
            if(free_start_index == -1)
                throw new System.Exception("Ran out of size!!");
            
            int insert_index = free_start_index;
            free_start_index = next_item_indexes[insert_index];
            
            items[insert_index] = item;
            
            next_item_indexes[insert_index] = stack_top_indexes[stack_index];
            stack_top_indexes[stack_index] = insert_index;
        }

        public int pop(int stack_index) {
            int item_index = stack_top_indexes[stack_index];
            if(item_index == -1)
                throw new System.Exception("Given stack is empty!!");
            
            stack_top_indexes[stack_index] = next_item_indexes[item_index];
            
            next_item_indexes[stack_index] = free_start_index;
            free_start_index = item_index;

            return items[item_index];
        }

    }
}