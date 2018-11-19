using System.Collections.Generic;

namespace CSharp.Problems {
    class KnightPath {

        int board_size;
        int[] x_moves;
        int[] y_moves;

        public KnightPath(int board_size) {
            this.board_size = board_size;
        }

        bool isMoveValid(int x, int y, int[,] solution) {
            return (x >= 0 && x < board_size && y >= 0 && y < board_size && solution[x, y] == -1);
        }

        void printSolution(int[,] solution) {
            for(int i = 0; i < board_size; i++) {
                for(int j = 0; j < board_size; j++) {
                    System.Console.Write(solution[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }

        public void solve() {
            int[,] solution = new int[8, 8];
            for (int i = 0; i < board_size; i++)
                for (int j = 0; j < board_size; j++)
                    solution[i, j] = -1;
            x_moves = new int[] { -2, -2, -1, -1, 1, 1, 2, 2 };
            y_moves = new int[] { -1, 1, -2, 2, -2, 2, -1, 1 };
            solution[0, 0] = 0;
            bool is_solved = solveForMove(0, 0, 1, solution);
            if(is_solved) {
                printSolution(solution);
            } else {
                System.Console.WriteLine("No solution found!!");
            }
        }

        /*
        When this function is called, it means that the Knight is sitting on [x, y] and needs to make move_number th move next
         */
        bool solveForMove(int x, int y, int move_number, int[,] solution) {
            if(move_number == board_size * board_size)
                return true;

            for (int i = 0; i < 8; i++) {
                int next_x = x + x_moves[i];
                int next_y = y + y_moves[i];
                if(isMoveValid(next_x, next_y, solution)) {
                    solution[next_x, next_y] = move_number;
                    if(solveForMove(next_x, next_y, move_number+1, solution))
                        return true;
                    else
                        solution[next_x, next_y] = -1;
                }
            }
            return false;
        }

    }
}