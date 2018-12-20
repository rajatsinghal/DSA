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

            public bool findAncestors(int search_item, CSharp.Stack.Stack<int> ancestry) {
                if(search_item == this.item) {
                    ancestry.push(this.item);
                    return true;
                } else {
                    if(this.left_child != null && this.left_child.findAncestors(search_item, ancestry)) {
                        ancestry.push(this.item);
                        return true;
                    } else if(this.right_child != null && this.right_child.findAncestors(search_item, ancestry)) {
                        ancestry.push(this.item);
                        return true;
                    } else {
                        return false;
                    }
                }
            }
        }

        public Node root;

        public int getMinDepth() {
            return this.root.getMinDepth();
        }

        public void convertIntoSumTree() {
            this.root.convertIntoSumTree();
        }

        public int getDistanceBetweenNodes(int node_1_item, int node_2_item) {
            CSharp.Stack.Stack<int> node_1_ancestry = new CSharp.Stack.Stack<int>(1000);
            this.root.findAncestors(node_1_item, node_1_ancestry);
            CSharp.Stack.Stack<int> node_2_ancestry = new CSharp.Stack.Stack<int>(1000);
            this.root.findAncestors(node_2_item, node_2_ancestry);

            int min_distance = 0;
            while(true) {
                if(!node_1_ancestry.isEmpty() && !node_2_ancestry.isEmpty()) {
                    if(node_1_ancestry.pop() != node_2_ancestry.pop())
                        min_distance += 2;
                } else if(!node_1_ancestry.isEmpty()) {
                    node_1_ancestry.pop();
                    min_distance++;
                } else if(!node_2_ancestry.isEmpty()) {
                    node_2_ancestry.pop();
                    min_distance++;
                } else {
                    break;
                }
            }
            return min_distance;
        }

        public void print() {
            root.PrintPretty("", TreePrinter.NodePosition.center, true, false);

            //root.printInPreOrder();
        }

    }
}