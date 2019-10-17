public class Sll{
    public Node head; 
    public Sll(){
        head = null;
    }

    public void add(int value){
        Node newNode = new Node(value);
        if(head == null){
            head = newNode;
        }
        else {
            Node runner = head;
            while(runner.next != null){
                runner = runner.next;
            }
            runner.next = newNode;
        }
    }
    public void Remove(){
        Node runner = head;
        if(runner.next == null) {
            head = null;
        }
        else {
            while(runner.next.next != null) {
                runner = runner.next;
            }
            runner.next = null;
        }
    }
    public void printValues(){
        Node runner = head;
        if(runner != null){
            System.Console.WriteLine(runner.value);
            while(runner.next != null) {
                System.Console.WriteLine(runner.next.value);
                runner = runner.next;
            }
        }
    }
}
