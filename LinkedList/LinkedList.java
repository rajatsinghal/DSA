import java.util.List;
import java.util.ArrayList;

class LinkedList<T> {

    class Node<T> {

        private T item;
        private Node next_node;

        public Node(T item) {
            this.item = item;
        }

        public T getItem() {
            return item;
        }

        public Node getNextNode() {
            return this.next_node;
        }

        public void setNextNode(Node new_node) {
            this.next_node = new_node;
        }

        public void removeNextNode() {
            this.next_node = null;
        }

    }

    Node<T> head;

    public void addItem(T item) {
        Node new_node = new Node(item);
        new_node.setNextNode(this.head);
        this.head = new_node;
    }

    public void removeItem(T item) {
        if(this.head == null)
            return;
        if(this.head.getItem() == item) {
            this.head = null;
        } else {
            Node iterative_node = this.head;
            while(iterative_node.getNextNode() != null) {
                if(iterative_node.getNextNode().getItem() == item) {
                    iterative_node.setNextNode(iterative_node.getNextNode().getNextNode());
                    break;
                }
                iterative_node = iterative_node.getNextNode();
            }
        }
    }

    public List<T> getItems() {
        List<T> items = new ArrayList<T>();
        Node iterative_node = this.head;
        while(iterative_node != null) {
            items.add((T) iterative_node.getItem());
            iterative_node = iterative_node.getNextNode();
        }
        return items;
    }

}

class TestLinkedList {

    public static void main(String[] args) {
        LinkedList<Integer> ls = new LinkedList<Integer>();
        ls.addItem(4);
        ls.addItem(2);
        ls.addItem(6);
        ls.addItem(9);
        ls.addItem(11);
        System.out.println("Current list: " + ls.getItems().toString());
        ls.removeItem(6);
        System.out.println("After removing 6 list: " + ls.getItems().toString());
    }

}