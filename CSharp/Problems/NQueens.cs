using System;

namespace CSharp.Problems {
    class NQueens {

        public static void solve(int board_size) {
            int[,] board = new int[board_size, board_size];
            for(int i=0; i<board_size; i++)
                for (int j=0; j<board_size; j++)
                    board[i, j] = 0;
            bool is_solved = solveFromRow(0, board);
            if(!is_solved) {
                Console.WriteLine("No solution found!!");
            } else {
                for (int i = 0; i < board_size; i++) {
                    for (int j = 0; j < board_size; j++) {
                        Console.Write(board[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static bool canPlaceAtPosition(int[,] board, int row, int col) {
            for(int i = 0; i < row; i++) {
                if(board[i, col] == 1)
                    return false;
            }
            for(int diag_i = row, diag_j = col; (diag_i >= 0 && diag_j >= 0); diag_i--, diag_j--) {
                if (board[diag_i, diag_j] == 1)
                    return false;
            }
            for(int diag_i = row, diag_j = col; (diag_i >= 0 && diag_j < board.GetLength(1)); diag_i--, diag_j++) {
                if (board[diag_i, diag_j] == 1)
                    return false;
            }
            return true;
        }

        public static bool solveFromRow(int row, int[,] board) {
            if(row == board.GetLength(0))
                return true;
            
            for(int col = 0; col < board.GetLength(1); col++) {
                if(canPlaceAtPosition(board, row, col)) {
                    board[row, col] = 1;
                    if(!solveFromRow(row+1, board)) {
                        board[row, col] = 0;
                    } else {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}