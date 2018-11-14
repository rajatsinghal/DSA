namespace CSharp.Problems {
    public class ZeroOneTwoArraySegregation {
        public static int[] segregate(int[] input) {
            int point1 = 0;
            int point2 = 0;
            int point3 = input.Length-1;
            while(point2 < point3) {
                if(input[point2] == 0) {
                    int temp = input[point1];
                    input[point1] = input[point2];
                    input[point2] = temp;
                    point1++;
                    point2++;
                } else if(input[point2] == 1) {
                    point2++;
                } else if (input[point2] == 2) {
                    int temp = input[point2];
                    input[point2] = input[point3];
                    input[point3] = temp;
                    point3--;
                }
            }
            return input;
        }
    }
}