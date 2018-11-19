namespace CSharp.String {
    class SubStringCount {

        string str;
        string sub_str;

        public SubStringCount(string str, string sub_str) {
            this.str = str;
            this.sub_str = sub_str;
        }

        public int countSubString() {
            int count = 0;
            int next_sub_str_index = 0;
            for(int i=0; i<str.Length; i++) {
                if(str[next_sub_str_index] != sub_str[next_sub_str_index]) {
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

    }
}