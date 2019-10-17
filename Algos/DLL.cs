public class Node {
    public Integer value;
    public Node previous;
    public Node next;

    public Node(Integer val) {
        this.value = val;
        this.previous = null;
        this.next = null;
    }
}

public class DLL {
    public Node head;
    public Node tail;

    public DLL(){
        this.head = null;
        this.tail = null;
    }

    public v0id push(Node newNode) {
        if(this.head == null) {
            this.head = newNode;
            this.tail = newNode;
            return;
        }

        Node lastNode = this.tail;
        lastNode.next = newNode;
        newNode.previous = lastNode;
        this.tail = newNode;
    }

    public void printValForward(){
        Node runner = this.head;

        while(runner != null) {
            System.Console.WriteLine(runner.value);
            runner = runner.next;
        }
    }

    public void PrintValBackward(){
        Node runner = this.tail;

        while(runner !=null) {
            System.Console.WriteLine(runner.previous);
            runner = runner.previous;
        }
    }

    public Node pop() {
        Node current = this.tail;

        this.tail = current.previous;
        current.previous.next = null;
        current.previous = null;

        return current;

    }

    public Boolean contains(Integer value) {
        Node runner = this.head;

        while(runner != null) {
            if(runner.value == value) {
                return true;
            }
            runner = runner.next;
        }
        return false;
    }

    public int size(){
        Node runner = this.head;
        int counter = 0;

        while(runner != null) {
            counter++;
            runner = runner.next;
        }
        return counter;
    }

    public void insertAt(Node newNode, int index) {
        if(this.head == null) {
            this.head = newNode;
            this.tail = newNode;
            return;
        }

        Node runner = this.head;

        if(index == 0) {
            runner.previous = newNode;
            newNode.next = runner;
            this.head = newNode;
            return;
        }

        int counter = 1;
        while(counter != index) {
            counter++;
            runner = runner.next;
            if(runner == null) {
                System.Console.WriteLine("Insert Failed");
                return;
            }
        }

        if(runner.next != null){
            Node temp = runner.next;
            newNode.previous = runner;
            Node.next = temp;
            temp.previous = newNode;
            return;
        }

        runner.next = newNode;
        newNode.previous = runner;
        this.tail = newNode;
    }
    public void removeAt(int index) {
		if(this.head == null) {
			return;
		}
		
		if(index == 0) {
			if(this.head.next == null) {
				this.head = null;
				return;
			}
			Node temp = this.head.next;
			temp.previous = null;
			this.head = temp;
			return;
		}
		
		Node runner = this.head;
		
		int counter = 1;
		
		while(counter != index) {
			counter++;
			runner = runner.next;
			if(runner == null) {
                System.Console.WriteLine("Remove Failed");
				return;
			}
		}
				
		if(runner.next.next != null) {
			Node temp = runner.next.next;
			runner.next = temp;
			temp.previous = runner;
			return;
		}
	
		runner.next = null;
	}
	
	public Boolean isPalindrome() {
		Node forward = this.head;
		Node backward = this.tail;
		
		while(forward != null) {
			if(forward.value != backward.value) {
				return false;
			}
			forward = forward.next;
			backward = backward.previous;
		}
		return true;
	}
}