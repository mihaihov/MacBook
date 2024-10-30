using CustomExceptions;

namespace Entities
{
    public class Node<T>
    {
        public T Data {get;set;}
        public Node<T> Next {get;set;}
        
        public Node(T data)
        {
            Data = data;
        }

        public Node()
        {
            
        }
    }

    public class CustomLinkedList<T> where T: IComparable<T>
    {
        public Node<T> Head {get;set;}

        public CustomLinkedList()
        {
            
        }

        public CustomLinkedList(T data)
        {
            Head = new Node<T>(data);
        }

        public CustomLinkedList(Node<T> h)
        {
            Head = h;
        }

        public Node<T> Append(T data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
                Head.Next = null;
                return Head;
            }

            Node<T> n = Head;
            while(n.Next != null)
            {
                n = n.Next;
            }
            n.Next = new Node<T>(data);
            n.Next.Next = null;
            return Head;
        }

        public void Show()
        {
            if(Head == null)    throw new EmptyCustomLinkedListException("Custom LinkedList is empty!");

            Node<T> n = Head;
            while(n != null)
            {
                Console.Write(n.Data + " ");
                n = n.Next;
            }
            Console.WriteLine();
        }

        public Node<T> RemoveDuplicatesUsingHashSet()
        {
            if(Head == null) throw new EmptyCustomLinkedListException("Custom LinkedList is empty");
            if(Head.Next == null)   return Head;

            HashSet<T> mySet = new HashSet<T>();
            Node<T> i = Head;
            while(i.Next != null)
            {
                mySet.Add(i.Data);
                i = i.Next;
            }

            Head = null;
            foreach(T t in mySet)
            {
                Append(t);
            }

            return Head;
        }

        public void RemoveInTheMiddle(T x)
        {
            if(Head == null || Head.Next == null) return;
            Node<T> n = Head.Next;
            Node<T> previous = Head;
            while(n.Next != null)
            {
                if(n.Data.CompareTo(x) == 0)
                {
                    previous.Next = n.Next;
                    n = n.Next;
                }
                else
                {
                    previous = n;
                    n = n.Next;
                }                
            }
        }

        public void Partition(T x)
        {
            if(Head == null || Head.Next == null) return;
            if(Head.Next.Next == null)
            {
                if(Head.Data.CompareTo(x) < 0)
                {
                    Node<T> temp = Head;
                    Head = Head.Next;
                    Head.Next = temp;
                    return;
                }
                return;
            }

            Node<T> GreaterOrX = null;
            Node<T> iterator = Head;
            while(iterator != null)
            {
                if(iterator.Data.CompareTo(x) == 0)
                {
                    GreaterOrX = iterator;
                    break;
                }
                if(iterator.Data.CompareTo(x) > 0)
                {
                    if(GreaterOrX == null)
                        GreaterOrX = iterator;
                }
                iterator = iterator.Next;
            }

            Node<T> previous1 = null;
            Node<T> previous2 = null;
            Node<T> current = Head;

            while(current.Next != null)
            {
                if(current.Data.CompareTo(x) < 0)
                {
                    if(previous1 != null)
                    {
                        previous1.Next = current;
                        previous2.Next = current.Next;
                        current.Next = iterator;
                        previous1 = previous1.Next;
                        previous2 = previous2.Next;
                        current = current.Next;
                    }
                    else
                    {
                        previous2.Next = current.Next;
                        current.Next = iterator;
                        Head = current;
                        previous1 = Head;
                        previous2 = previous2.Next;
                        current = current.Next;
                    }
                }
            }
        }

            public static CustomLinkedList<T> operator +(CustomLinkedList<T> l1, CustomLinkedList<T> l2)
            {
                CustomLinkedList<T> result = new CustomLinkedList<T>();
                int rem = 0;
                Node<T> n = l1.Head;
                Node<T> m = l2.Head;

                while(n is not null && m is not null)
                {
                    T sum = (dynamic)n.Data + (dynamic)m.Data + rem;
                    result.Append((dynamic)sum % 10);
                    rem = (dynamic)sum / 10;
                    n = n.Next; m = m.Next;
                }

                while(n is not null){
                    T sum = (dynamic)n.Data + rem;
                    result.Append((dynamic)sum % 10);
                    rem = (dynamic)sum / 10;
                    n=n.Next;
                }

                while(m is not null){
                    T sum = (dynamic)m.Data + rem;
                    result.Append((dynamic)sum % 10);
                    rem = (dynamic)sum / 10;
                    m=m.Next;
                }

                return result;
            }

        }
    }