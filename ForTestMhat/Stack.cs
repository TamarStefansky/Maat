using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTestMhat
{
    internal class Stack<T>//lifo= last in first out 
    {
        private Node<T> head;
        public Stack()
        {

        }
        public void Push(T value) => head = new Node<T>(value, head);
        public T Pop()
        {
            T temp=head.GetValue();
            head=head.Getnext();
            return temp;
        }
        public T Top() => head.GetValue();
        public override string ToString()//הדפסת כל המחסנית 
        {
            string str = "";
            Node<T> node = head;
            while(node != null)
            {
                str+=node.ToString();
                node = node.Getnext();
            }
       return str;
        }
        public bool IsEmpty() => head == null;
    }
}
