using JetBrains.Annotations;
using log4net;

namespace MyLib
{
    public class LinkedList
    {
    //Get logger
    [NotNull]
    private static readonly ILog log = LogManager.GetLogger(typeof(LinkedList));

        private Node tail;
        private Node head;

        public LinkedList()
        {
            tail = null;
            head = null;
        }

        public void AddNode(int value)
        {
            if (head is null)
            {
                tail = new Node();
                tail.Item = value;
                tail.Next = null;
                head = tail;
            }
            else
            {
                var tempNode = new Node();
                tempNode.Item = value;
                tempNode.Next = null;
                tail.Next = tempNode;
                tail = tail.Next;
            }
        }

        public void AddAtStart(int value){
            var temp = new Node();
            temp.Item = value;
            temp.Next = null;
            if(head == null){
                head = temp;
                tail = temp;
            }
            else{
                temp.Next = head;
                head = temp;
            }
        }


        public void AddInMiddle(int value){
            
            //Empty
            if(head == null)
            {
                AddNode(value);
                return;
            }

            //Only 1 node
            if(head == tail){
             
                AddNode(value);
            }

            var temp = new Node();
            temp.Item = value;
            temp.Next = head.Next;
            head.Next = temp;            
        }

        public void PrintList()
        {
            if(head is null){
                log.Warn("List is empty");
            }
            var temp = head;
            while (temp is not null)
            {
                Console.WriteLine(temp.Item);
                temp = temp.Next;
            }
        }

        public int DeleteFirst()
        {
            Node temp = null;

            if (head is not null)
            {   
                temp = head;
                if(head == tail){    
                    head = tail = null;    
                    return temp.Item;
                }
                head = head.Next;
                return temp.Item;
            } else {
                log.Warn("List is empty.");
                return 0;
            }
        }

        public int DeleteLast()
        {
            Node temp = null;

            if(head is not null){
                temp = head;
                if(head == tail){
                    head = tail = null;
                    return temp.Item;
                }     
                
                while(temp.Next != tail){
                    temp = temp.Next;
                }

                var deleteVal = temp.Next.Item;    
                temp.Next = null;
                tail = temp;
                return deleteVal;
            }
            else{
                log.Warn("List is empty.");
                return 0;
            }
        }
    }
}