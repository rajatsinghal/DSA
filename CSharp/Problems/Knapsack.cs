using System.Collections.Generic;

namespace CSharp.Problems {

    // Given weights and values of n items, put these items in a knapsack of capacity W to get the maximum total value in the knapsack. In other words, given two integer arrays val[0..n-1] and wt[0..n-1] which represent values and weights associated with n items respectively. Also given an integer W which represents knapsack capacity, find out the maximum value subset of val[] such that sum of the weights of this subset is smaller than or equal to W. You cannot break an item, either pick the complete item, or don’t pick it (0-1 property).

    public class Knapsack {

        public static int solve(int[] values, int[] weights, int max_weight) {
            return solveForItems(values, weights, max_weight, values.Length - 1);
        }

        static int solveForItems(int[] values, int[] weights, int max_weight, int limit) {
            if(limit == 0 || max_weight == 0)
                return 0;
            if(weights[limit] > max_weight)
                return solveForItems(values, weights, max_weight, limit - 1);
            else {
                int including_item = solveForItems(values, weights, max_weight - weights[limit], limit - 1) + values[limit];
                int excluding_item = solveForItems(values, weights, max_weight, limit - 1);
                return System.Math.Max(including_item, excluding_item);
            }
        }

    }

}