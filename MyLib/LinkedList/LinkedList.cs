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

        public void AddAtStart(int value)
        {
            var temp = new Node();
            temp.Item = value;
            temp.Next = null;
            if (head == null)
            {
                head = temp;
                tail = temp;
            }
            else
            {
                temp.Next = head;
                head = temp;
            }
        }


        public void AddInMiddle(int value)
        {

            //Empty
            if (head == null)
            {
                AddNode(value);
                return;
            }

            //Only 1 node
            if (head == tail)
            {

                AddNode(value);
            }

            var temp = new Node();
            temp.Item = value;
            temp.Next = head.Next;
            head.Next = temp;
        }

        public void PrintList()
        {
            if (head is null)
            {
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
                if (head == tail)
                {
                    head = tail = null;
                    return temp.Item;
                }
                head = head.Next;
                return temp.Item;
            }
            else
            {
                log.Warn("List is empty.");
                return 0;
            }
        }

        public int DeleteLast()
        {
            Node temp = null;

            if (head is not null)
            {
                temp = head;
                if (head == tail)
                {
                    head = tail = null;
                    return temp.Item;
                }

                while (temp.Next != tail)
                {
                    temp = temp.Next;
                }

                var deleteVal = temp.Next.Item;
                temp.Next = null;
                tail = temp;
                return deleteVal;
            }
            else
            {
                log.Warn("List is empty.");
                return 0;
            }
        }

        public void TakeInputAndAddToTail()
        {
            int intValue = GetUserInput();

            head = null;
            tail = null;

            while (intValue != -1)
            {
                Node node = new Node();
                node.Item = intValue;
                node.Next = null;

                if (head == null)
                {
                    head = node;
                    tail = node;
                }
                else
                {
                    tail.Next = node;
                    tail = node;
                }
                intValue = GetUserInput();
            }
        }

        public void TakeInputAndAddToHead()
        {
            int intValue = GetUserInput();

            head = null;
            tail = null;

            while (intValue != -1)
            {
                Node node = new Node();
                node.Item = intValue;
                node.Next = null;

                if (head == null)
                {
                    head = node;
                    tail = node;
                }
                else
                {
                    node.Next = head;
                    head = node;
                }
                intValue = GetUserInput();
            }
        }

        private static int GetUserInput()
        {
            Console.WriteLine("Enter valid integer number to add to linked list. Enter -1 to terminate the list.");
            var item = Console.ReadLine();
            int intValue;
            while (!int.TryParse(item, out intValue))
            {
                Console.WriteLine("Not a valid number. Please try again");
                item = Console.ReadLine();
            }

            return intValue;
        }

        public void Print()
        {
            while (head != null)
            {
                Console.Write(head.Item + " -> ");
                head = head.Next;
            }
            Console.WriteLine("NULL");
        }

        public int DeleteIth(int position)
        {
            //Can't delete index less than 0, also can't delete from empty list
            if (position < 0 || head == null)
                return 0;
            else if (position == 0)
            {
                //Delete head
                var temp = head;
                head = head.Next;
                return temp.Item;
            }
            else
            {
                var beforeIth = head;
                int count = 1;

                //Get node bfore Ith node, if exists
                while (count <= position - 1 && beforeIth != null)
                {
                    beforeIth = beforeIth.Next;
                    count++;
                }

                if (beforeIth != null && beforeIth.Next != null)
                {
                    var returnValue = beforeIth.Next.Item;
                    beforeIth.Next = beforeIth.Next.Next; ;
                    return returnValue;
                }

                return 0;
            }

        }
    }
}
