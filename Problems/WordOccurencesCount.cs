namespace CSharp.Problems {
    public class WordOccurencesCount {

        public static int countWordOccurences(string str, string word) {
            int occurences_count = 0;
            int current_word_index = 0;
            for(int i = 0; i < str.Length; i++) {
                if(str[i] == word[current_word_index]) {
                    current_word_index++;
                    if(current_word_index == word.Length) {
                        occurences_count++;
                        current_word_index = 0;    
                    }
                } else {
                    current_word_index = 0;
                }
            }
            return occurences_count;
        }

    }
}