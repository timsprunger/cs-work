public class Node {
	public char data;
	public Node next;
	
	public Node() {
		data = '?';
		next = null;
	}
	
	public Node(char value, Node n) {
		data = value;
		next = n;
	}
}
