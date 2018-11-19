namespace CSharp.Strings {
    class StringProblems {

        public static int countSubString(string str, string sub_str) {
            int count = 0;
            int next_sub_str_index = 0;
            for(int i=0; i<str.Length; i++) {
                if(str[i] != sub_str[next_sub_str_index]) {
                    next_sub_str_index = 0;
                } else {
                    next_sub_str_index++;
                    if(next_sub_str_index == sub_str.Length) {
                        count++;
                        next_sub_str_index = 0;
                    }
                }
            }
            return count;
        }

        public static bool isExpressionBalances(string expression) {
            return false;
        }

        public static string reverseWordsInString(string str) {
            return "";
        } 

    }
}