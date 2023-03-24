namespace MyLib
{
    public class CircularLinkedListNode
    {
        public int Item { get; set; }
        public CircularLinkedListNode next { get; set; }
    }

    public class CircularLinkedList
    {
        CircularLinkedListNode current;
        public CircularLinkedList()
        {
            current = null;
        }

        public void AddBefore(int item)
        {
            var temp = new CircularLinkedListNode();
            temp.Item = item;

            if (current == null)
            {
                current = temp;
                current.next = current;
            }

            temp.next = current;
            current.next = temp;
            current = temp;
        }

        public void AddAfter(int item)
        {
            var temp = new CircularLinkedListNode();
            temp.Item = item;

            if (current == null)
            {
                current = temp;
                current.next = current;
            }

            current.next = temp;
            temp.next = current;
            current = temp;
        }

        public void Delete()
        {
            if (current == null)
                return ; // empty

            //single node
            if (current == current.next)
            {
                current = null;
            }
            //1 -2 -3 -1
            var temp = current;
            while (temp.next.next != current)
            {
                temp = temp.next;
            }
            temp.next = current;


        }

    }

}