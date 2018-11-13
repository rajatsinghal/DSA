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

    }

    public void mirror() {

    }

}

class BinarySearchTree extends BinaryTree {

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

    bool search(int item) {

    }

    void delete(int item) {

    }
}

class BalancedBinarySearchTree extends BinarySearchTree {
    
}