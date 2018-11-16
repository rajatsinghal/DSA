namespace CSharp.Stack {
    class Stack<T> {

        T[] items;
        int top = -1;
        int max_size;

        public Stack(int max_size) {
            this.max_size = max_size;
            this.items = new T[max_size];
        }

        public void push(T item) {
            if(items.Length == max_size)
                throw System.Exception("Stack overflow!!");
            this.top++;
            items[this.top] = item;
        }

        public T pop() {
            if(this.top == -1)
                throw System.Exception("Stack is empty!!");
            T item = items[this.top];
            this.top--;
            return item;
        }

        public T peek() {
            if(this.top == -1)
                throw System.Exception("Stack is empty!!");
            return items[this.top];
        }

    }
}