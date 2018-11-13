class BinaryTree {

    int item;
    int number_of_items = 0;
    BinaryTree left_child;
    BinaryTree right_child;
    
    public BinaryTree(int item) {
        this.item = item;
    }

    public void traverseBreadthFirst() {

    }

    public void traverseDepthFirstInorder() { //Left-Root-Right

    }

    public void traverseDepthFirstPreorder() { // Root-Left-Right

    }

    public void traverseDepthFirstPostorder() { // Left-Right-Root

    }

    public int calculateHeight() {
        return -1;
    }

    public void mirror() {

    }

}

class BinarySearchTree extends BinaryTree {

    public BinarySearchTree(int item) {
        super(item);
    }

    void insert(int item) {
        if(this.item < item) {
            if(this.left_child == null) {
                this.left_child = new BinaryTree(item);
            } else {
                ((BinarySearchTree) this.left_child).insert(item);
            }
        } else if(this.item > item) {
            if(this.right_child == null) {
                this.right_child = new BinaryTree(item);
            } else {
                ((BinarySearchTree) this.right_child).insert(item);
            }
        } else {
            this.number_of_items++;
        }
    }

    boolean search(int item) {
        return false;
    }

    void delete(int item) {

    }
}

class BalancedBinarySearchTree extends BinarySearchTree {
    
    public BalancedBinarySearchTree(int item) {
        super(item);
    }

}

class TestProject {
    public static void main() {
        BinarySearchTree bst = new BinarySearchTree(5);
        bst.insert(2);
        bst.insert(4);
        bst.insert(10);
        bst.insert(7);
    }
}