using System;

namespace CSharp.Problems {
    //https://codeforces.com/problemset/problem/812/B
    class TurnOffLights {

        int[,] floor_plan;
        int[] left_most_lights;
        int[] right_most_lights;

        public TurnOffLights(int[,] floor_plan) {
            this.floor_plan = floor_plan;
            this.left_most_lights = new int[floor_plan.GetLength(0)];
            this.right_most_lights = new int[floor_plan.GetLength(0)];
        }

        public int solve() {
            for(int i = 0; i < floor_plan.GetLength(0); i++) {
                left_most_lights[i] = 0;
                right_most_lights[i] = 0;
                for(int j = 1; j < floor_plan.GetLength(1) - 1; j++) { //First and Last column are staris
                    if(floor_plan[i, j] == 1) {
                        if(left_most_lights[i] == 0) {
                            left_most_lights[i] = j;
                        }
                        right_most_lights[i] = j;
                    }
                }
            }
            return solveFromFloorIndex(0, 'L');
        }

        public int solveFromFloorIndex(int floor_index, char enter_direction) {
            if(floor_index == (floor_plan.GetLength(0) - 1)) {
                return enter_direction == 'L' ? right_most_lights[floor_index] : (floor_plan.GetLength(1) - left_most_lights[floor_index] - 1);
            }

            int left_exit_time;
            int right_exit_time;
            if(enter_direction == 'L') {
                left_exit_time = right_most_lights[floor_index] * 2;
                right_exit_time = (floor_plan.GetLength(1) - 1);
            } else {
                right_exit_time = (floor_plan.GetLength(1) - left_most_lights[floor_index] - 1) * 2;
                left_exit_time = (floor_plan.GetLength(1) - 1);
            }

            return Math.Min(
                (left_exit_time + 1 + solveFromFloorIndex(floor_index + 1, 'L')), 
                (right_exit_time + 1 + solveFromFloorIndex(floor_index + 1, 'R'))
            );
        }
    }
}