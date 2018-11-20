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
            return result_str;
        }

    }
}