namespace CSharp.Problems {
    class SwapAllZerosToRight {

        public static int[] solve(int[] input) {
            int next_pos_from_right = input.Length - 1;
            for(int i = 0; i < next_pos_from_right; i++) {
                if(input[i] == 0) {
                    while(input[next_pos_from_right] == 0 && next_pos_from_right > i)
                        next_pos_from_right--;
                    int temp = input[i];
                    input[i] = input[next_pos_from_right];
                    input[next_pos_from_right] = temp;
                }
            }
            return input;
        }

    }
}