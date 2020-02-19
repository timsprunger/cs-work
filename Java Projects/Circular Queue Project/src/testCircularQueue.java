/*
 * testCircularQueue
 * Fall 2019
 * Tim Sprunger
 * sample test program for CircularQueue
 */
public class testCircularQueue {
	public static void main(String[] args) {
		CircularQueue q = new CircularQueue();
		
		System.out.println( q ); //CQ: empty queue
		
		q.enqueue('A');
		System.out.println( q ); //CQ: A
		System.out.println( "Front: " + q.front() ); //Front: A
		System.out.println( "Back: " + q.back() ); //Back A
		System.out.println( "size: " + q.size() ); //size: 1
		
		q.enqueue('B');
		q.enqueue('C');
		q.enqueue('D');
		q.enqueue('E');
		System.out.println( q ); //CQ: A B C D E
		System.out.println( "Front: " + q.front() ); //Front: A
		System.out.println( "Back: " + q.back() ); //Back E
		System.out.println( "size: " + q.size() ); //size: 5
		
		//display all values in queue 
		int count = 0;
		while (count < q.size())
		{
			System.out.println( "Front: " + q.front() );
			q.next();
			count++;
		}
		
		q.next();
		System.out.println( q ); //CQ: B C D E A
		q.enqueue('X');
		
		System.out.println( q ); //CQ: B C D E A X
		q.next();
		System.out.println( q ); //CQ: C D E A X B
		
		System.out.println( "Front: " + q.front() ); //Front: C
		System.out.println( "Back: " + q.back() ); //Back B
		
		q.dequeue();
		System.out.println( q ); //CQ: D E A X B
		
		System.out.println( "size: " + q.size() ); //size: 5
		
		while (!q.isEmpty())
		{
			System.out.println( q ); 
			q.dequeue();
		}
		
		System.out.println( q ); 
		System.out.println( "size: " + q.size() ); //size: 0
		
		q.enqueue('A');
		System.out.println( q ); //CQ: A
		System.out.println( "Front: " + q.front() ); //Front: A
		System.out.println( "Back: " + q.back() ); //Back A
		System.out.println( "size: " + q.size() ); //size: 1
	}//main


}//class