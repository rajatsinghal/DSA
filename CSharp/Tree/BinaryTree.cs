using System;

namespace CSharp.Tree {
    public class BinaryTree {

        public class Node : TreePrinter.PrintableNode {
            public int item;
            public Node left_child;
            public Node right_child;

            public Node(int item) {
                this.item = item;
            }

            public override TreePrinter.PrintableNode getLeft() {
                return left_child;
            }

            public override TreePrinter.PrintableNode getRight() {
                return right_child;
            }

            public override string getText() {
                return "" + item;
            }

            public void printInPreOrder() {
                System.Console.WriteLine(item + "");
                if (left_child != null)
                    left_child.printInPreOrder();
                if (right_child != null)
                    right_child.printInPreOrder();
            }

            public int getMinDepth() {
                int left_child_depth = this.left_child != null ? this.left_child.getMinDepth() : 0;
                int right_child_depth = this.right_child != null ? this.right_child.getMinDepth() : 0;
                return Math.Min(left_child_depth, right_child_depth) + 1;
            }

            public int convertIntoSumTree() {
                int self_item = this.item;
                int left_child_sum = this.left_child != null ? this.left_child.convertIntoSumTree() : 0;
                int right_child_sum = this.right_child != null ? this.right_child.convertIntoSumTree() : 0;
                this.item = left_child_sum + right_child_sum;
                return this.item + self_item;
            }
        }

        public Node root;

        public int getMinDepth() {
            return this.root.getMinDepth();
        }

        public void convertIntoSumTree() {
            this.root.convertIntoSumTree();
        }

    }
}