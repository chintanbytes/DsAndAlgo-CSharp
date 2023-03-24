namespace MyLib
{
    class ListNode
    {
        public int Item { get; set; }
        public ListNode Next { get; set; }
        public ListNode Previous { get; set; }
    }

    class DoublyLinkedList
    {
        public ListNode head;
        public DoublyLinkedList()
        {
            head = null;
        }

        public void AddNode(int item)
        {
            if (head == null)
            {
                head = new ListNode();
                head.Item = item;
                head.Next = null;
                head.Previous = null;
            }

            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new ListNode();
            current.Next.Item = item;
            current.Next.Next = null;
            current.Next.Previous = current;
        }

        public void AddFirst(int item)
        {
            if (head == null)
            {
                head = new ListNode();
                head.Item = item;
                head.Next = null;
                head.Previous = null;
            }

            var temp = new ListNode();
            temp.Item = item;
            temp.Next = head;
            temp.Previous = null;
            head.Previous = temp;
            head = temp;
        }

        public int DeleteFirst()
        {
            if (head == null)
                return 0; //empty

            //Single node
            var ret = head.Item;
            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }
            return ret;
        }

        public int DeleteLast()
        {
            if (head == null)
                return 0; //empty

            //Single node
            var ret = head.Item;
            if (head.Next == null)
            {
                head = null;
            }

            var current = head;
            while(current.Next.Next != null){
                current = current.Next;
            } 
            ret = current.Next.Item;    
            current.Next = null;

            return ret;
        }

    }
}