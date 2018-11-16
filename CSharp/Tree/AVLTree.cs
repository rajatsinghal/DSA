using System.Collections.Generic;

namespace CSharp.Tree {

    class Node {

        int item;
        Node left_child;
        Node right_child;
        int height;

        public Node(int item) {
            this.item = item;
        }

        int left_child_height {
            get {
                return left_child != null ? left_child.height : 0;
            }
        }

        int right_child_height {
            get {
                return right_child != null ? right_child.height : 0;
            }
        }

        int balance {
            get {
                return left_child_height - right_child_height;
            }
        }

        public void updateHeight() {
            this.height = System.Math.Max(left_child_height, right_child_height) + 1;
        }

    }

    class AVLTree {

        Node root;

        public void insert(int item) {
            root = insertItemAtNode(root, item);
        }

        Node insertItemAtNode(Node node, int item) {
            if(node == null) { //reached leaf level (Actual insertion)
                Node node = new Node(item);
            }
            if(item < node.item) {
                node.left_child = insertItemAtNode(node.left_child, item);
            } else if(item > node.item) {
                node.right_child = insertItemAtNode(node.right_child, item);
            } else {
                throw new System.Exception("Duplicate items not supported!");
            }
            node.updateHeight();
            
            int balance = node.balance;
            if(balance > 1) { //Left > Right
                if(item > node.left_child.item) {
                    node.left_child = leftRotateNode(node.left_child);
                }
                return rightRotateNode(node);
            } else if(balance < -1) { //Right > Left
                if(item < node.right_child.item) {
                    node.right_child = rightRotateNode(node.right_child);
                }
                return leftRotateNode(node);
            } else {
                return node;
            }
        }

        public Node leftRotateNode(Node node) {
            Node right_child = node.right_child;
            if(right_child == null)
                throw new System.Exception("Can't rotate left from a node that doesn't have right child");
            Node grand_child = right_child.left_child;
            
            right_child.left_child = node;
            node.right_child = grand_child;
            
            node.updateHeight();
            right_child.updateHeight();

            return right_child;
        }

        public Node rightRotateNode(Node node) {
            Node left_child = node.left_child;
            if(left_child == null)
                throw new System.Exception("Can't rotate right from a node that doesn't have left child");
            Node grand_child = left_child.right_child;
            
            left_child.right_child = node;
            node.left_child = grand_child;
            
            node.updateHeight();
            left_child.updateHeight();

            return left_child;
        }

        public List<int> traversePreOrder() {
            return null;
        }

    }
}