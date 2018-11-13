import java.util.ArrayList;
import java.util.List;

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

    public List<Integer> traverseDepthFirstInorder() { // Left-Root-Right
        List<Integer> traversed_items = new ArrayList<>();
        if(this.left_child != null)
            traversed_items.addAll(this.left_child.traverseDepthFirstInorder());
        traversed_items.add(this.item);
        if (this.right_child != null)
            traversed_items.addAll(this.right_child.traverseDepthFirstInorder());
        return traversed_items;
    }

    public List<Integer> traverseDepthFirstPreorder() { // Root-Left-Right
        List<Integer> traversed_items = new ArrayList<>();
        traversed_items.add(this.item);
        if (this.left_child != null)
            traversed_items.addAll(this.left_child.traverseDepthFirstInorder());
        if (this.right_child != null)
            traversed_items.addAll(this.right_child.traverseDepthFirstInorder());
        return traversed_items;
    }

    public List<Integer> traverseDepthFirstPostorder() { // Left-Right-Root
        List<Integer> traversed_items = new ArrayList<>();
        if (this.left_child != null)
            traversed_items.addAll(this.left_child.traverseDepthFirstInorder());
        if (this.right_child != null)
            traversed_items.addAll(this.right_child.traverseDepthFirstInorder());
        traversed_items.add(this.item);
        return traversed_items;
    }

    public int calculateHeight() {
        int left_child_height = this.left_child == null ? 0 : this.left_child.calculateHeight();
        int right_child_height = this.right_child == null ? 0 : this.right_child.calculateHeight();
        return Math.max(left_child_height, right_child_height) + 1;
    }

    public void mirror() {

    }

}

class BinarySearchTree extends BinaryTree {

    public BinarySearchTree(int item) {
        super(item);
    }

    void insert(int item) {
        if (item > this.item) {
            if (this.right_child == null) {
                this.right_child = new BinarySearchTree(item);
            } else {
                ((BinarySearchTree) this.right_child).insert(item);
            }
        } else if (item < this.item) {
            if (this.left_child == null) {
                this.left_child = new BinarySearchTree(item);
            } else {
                ((BinarySearchTree) this.left_child).insert(item);
            }
        } else {
            this.number_of_items++;
        }
    }

    boolean search(int item) {
        if (item > this.item) {
            if (this.right_child != null)
                return ((BinarySearchTree) this.right_child).search(item);
            else
                return false;
        } else if (item < this.item) {
            if (this.left_child != null)
                return ((BinarySearchTree) this.left_child).search(item);
            else
                return false;
        } else {
            return true;
        }
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

    public static void main(String[] args) {
        BinarySearchTree bst = new BinarySearchTree(5);
        int[] items = {2, 4, 10, 7};
        
        for(int item : items)
            bst.insert(item);

        for(int item : items)
            if(!bst.search(item))
                System.out.println("Item " + item + " was inserted but is not found!!");
        
        System.out.println("Height of resultant tree:" + bst.calculateHeight());
    }

}