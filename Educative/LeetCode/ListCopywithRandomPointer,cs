
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}


public class ListCopywithRandomPointer 
{
    public Node CopyRandomList(Node head) 
    {
        if(head==null) return null;

        Dictionary<Node,Node> nodeMap= new Dictionary<Node,Node>();
        Node newHead =new Node(head.val);
        Node current=head;
        nodeMap[head]=newHead;

        while(current!=null)
        {
            newHead.next=GetNodeFromMap(current.next,nodeMap);
            newHead.random=GetNodeFromMap(current.random,nodeMap);
            current=current.next;            
            newHead=newHead.next;
        }

        return nodeMap[head];            
        
    }

    private Node GetNodeFromMap(Node source,Dictionary<Node,Node> nodeMap)
    {
        if(source!=null)
        {
            if(!nodeMap.ContainsKey(source))
            {
                Node node = new Node(source.val);
                nodeMap[source]=node;          
                return node;
            }
            else
            {
                return nodeMap[source];
            }
        }
        return null;

    }
}