using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTestMhat
{
    internal class BInNode<T>
    {
        T value;
        BInNode<T> right;
        BInNode<T> left;

        public BInNode(T value, BInNode<T> left, BInNode<T> right)
        {
            this.value = value;
            this.right = right;
            this.left = left;
        }

        public BInNode(T value)
        {
            this.value = value;
            left = right = null;
        }

        public T GetValue() => value;
        public BInNode<T> GetRight() => right;
        public BInNode<T> GetLeft() => left;

        public void SetValue(T value) => this.value = value;
        public void SetRight(BInNode<T> right) => this.right = right;
        public void SetLeft(BInNode<T> left) => this.left = left;

        public bool HasRight() => right != null;
        public bool HasLeft() => left != null;


    }
}
