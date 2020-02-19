/*
 * CircularQueue.java
 * Fall 2019
 * Tim Sprunger
 * This program demonstrates how an efficient circular queue works, using only one back pointer.
 */

public class CircularQueue {
	//variables
	public Node back;
	public int size;
	
	//constructor
	public CircularQueue() {
		back = null;
		size = 0;
	}
	
	//methods
	public char back() {
		if (back != null) {
			return back.data;
		}
		else {
			return '?';
		}
	}
	
	public void dequeue() {
		if (size == 0){
			System.out.println("Cannot Remove Item. Queue is Empty.");
		}
		else if (size == 1) {
			back = null;
			size--;
		}
		else {
			back.next = back.next.next;
			size--;
		}
	}
	
	public void enqueue(char c) {
		if (size == 0) {
			back = new Node();
			back.data = c;
			back.next = back;
			size++;
		}
		else {
			Node temp = new Node();
			temp.data = c;
			temp.next = null;
			temp.next = back.next;
			back.next = temp;
			back = temp;
			size++;
		}
	}
	
	public char front() {
		if (back != null) {
			return back.next.data;
		}
		else {
			return '?';
		}
	}
	
	public boolean isEmpty() {
		if (size == 0){
			return true;
		}
		else {
			return false;
		}
	}
	
	public void next() {
		back = back.next;
	}
	
	public int size() {
		return size;
	}
	
	public String toString() {
		if (size == 0) {
			return "Q: ";
		}
		else {
			String result = "Q: ";
			Node n = back.next;

			for (int x=0; x<size; x++) {
				result += n.data + " ";
				n = n.next;	
			}
			return result;
		}
	}
}
