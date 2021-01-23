public class Node <T> {

    private T value;
    private Node<T> prev, next;

    public Node(T value) {
        this.value = value;
    }

}