using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ForTestMhat
{
    internal class Queue<T>
    {
        Node<T> head;
        Node<T> tail;
        public Queue()
        {
        }
  public bool IsEmpty() => head == null;
        public void Insert(T value)
        {
            if (IsEmpty())
                head = tail = new Node<T>(value);
            else
            {
                tail.SetNext(new Node<T>(value));
                tail = tail.Getnext();
            }
        }
        public T Head()=>head.GetValue();   
        public T Remove()
        {
            T temp = head.GetValue();
            head = head.Getnext();
            return temp;
        }
        public override string ToString()//הדפסת כל המחסנית 
        {
            string str = "";
            Node<T> node = head;
            while (node != null)
            {
                str += node.ToString();
                node = node.Getnext();
            }
            return str;
        }
    }
}
