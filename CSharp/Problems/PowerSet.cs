using System;
using System.Collections.Generic;

namespace CSharp.Problems {
    public class PowerSet {

        public static List<List<string>> generate(List<string> set) {
            List <List<string>> power_set = new List<List<string>>();
            int set_size = set.Count;
            int powerset_size = (int) Math.Pow(2, set_size);
            for(int powerset_index = 0; powerset_index < powerset_size; powerset_index++) {
                List<string> subset = new List<string>();
                string subset_binary = Convert.ToString(powerset_index, 2).PadLeft(set_size);
                for(int binary_index = 0; binary_index < subset_binary.Length; binary_index++) {
                    if(subset_binary[binary_index] == '1')
                        subset.Add(set[binary_index]);
                }
                power_set.Add(subset);
            }
            return power_set;
        }

        public static List<List<string>> generateUsingBitwise(List<string> set) {
            
        }
        
    }
}