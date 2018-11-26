using System.Collections.Generic;

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

        public static bool isExpressionBalanced(string expression) {
            CSharp.Stack.Stack<char> stack = new CSharp.Stack.Stack<char>(1000);
            
            Dictionary<char, char> mapping = new Dictionary<char, char>();
            mapping.Add('{', '}');
            mapping.Add('[', ']');
            mapping.Add('(', ')');

            foreach(char letter in expression) {
                if(letter == '{' || letter == '(' || letter == '[') {
                    stack.push(letter);
                } else if(letter == '}' || letter == ')' || letter == ']') {
                    char last_keyword = stack.pop();
                    if(mapping[last_keyword] != letter) {
                        return false;
                    }
                }
            }
            return stack.isEmpty();
        }

        public static string reverseWordsInString(string str) {
            string result_str = "";
            CSharp.Stack.Stack<char> stack = new CSharp.Stack.Stack<char>(1000);
            for(int i = 0; i < str.Length; i++) {
                char letter = str[i];
                if(letter != ' ')
                    stack.push(letter);

                if(letter == ' ' || i == str.Length - 1) {
                    while (!stack.isEmpty()) {
                        result_str += stack.pop();
                    }
                    if(letter == ' ')
                        result_str += ' ';
                }
            }
            return result_str;
        }

        public static string reverseStringWords(string str) {
            string result_str = "";
            List<string> words = new List<string>();
            string current_word = "";
            for(int i = 0; i < str.Length; i++) {
                char letter = str[i];
                if(letter != ' ')
                    current_word += letter;
                if((letter == ' ' && i != 0) || i == str.Length - 1) {
                    words.Add(current_word);
                    current_word = "";
                }
            }
            for(int j = words.Count - 1; j >= 0; j--) {
                result_str += words[j];
                if(j != 0)
                    result_str += " ";
            }
            return result_str;
        }

        public static List<string> getAllSubstrings(string str) {
            List<string> substrings = new List<string>() { };
            if(str.Length > 0) {
                string child_str = str.Substring(1);
                List<string> child_substrings = getAllSubstrings(child_str);
                foreach(string s in child_substrings) {
                    substrings.Add(s);
                    substrings.Add(str[0] + s);
                }
            } else {
                substrings.Add("");
            }
            return substrings;
        }

        public static string getLongestCommonSubsequence(string str1, string str2) {
            
        }

    }
}