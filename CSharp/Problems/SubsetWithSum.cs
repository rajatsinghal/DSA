namespace CSharp.Problems {
    public class SubsetWithSum {

        public static bool existsForRange(int[] set, int starting_index, int sum) {
            if(sum == 0 || set[starting_index] == sum)
                return true;
            if(starting_index == set.Length - 1)
                return false;
            
            bool exists_including_first_item = set[starting_index] < sum ? existsForRange(set, starting_index + 1, sum-set[starting_index]) : false;
            if(exists_including_first_item)
                return true;
            bool exists_escluding_first_item = existsForRange(set, starting_index + 1, sum);
            return exists_escluding_first_item;
        }

        public static bool exists(int[] set, int sum) {
            return existsForRange(set, 0, sum);
        }

    }
}