namespace CSharp.Problems {
    public class ZeroOneArraySegregation {
        
        //public static int[] input = { 0, 1, 0, 1, 0, 0, 1, 1, 1, 0 };

        public static int[] segregate(int[] input) {
            int next_rear_index = input.Length - 1;
            for(int loop_index = 0; loop_index < input.Length; loop_index++) {
                if(input[loop_index] == 1) {
                    while(input[next_rear_index] == 1) {
                        next_rear_index--;
                        if(next_rear_index == loop_index)
                            break;
                    }
                    if (next_rear_index == loop_index)
                        break;
                    input[next_rear_index] = 1;
                    input[loop_index] = 0;
                }
            }
            return input;
        }

    }
}