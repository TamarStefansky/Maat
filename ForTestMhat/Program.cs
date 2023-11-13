using ForTestMhat;

//binary tree
//post
static void PrintPost(BInNode<int> head)
{
    if (head == null)
        return;
    PrintPost(head.GetLeft());
    PrintPost(head.GetRight());
    Console.Write(head.GetValue() + " ");

}
static void PrintPrev(BInNode<int> head)
{
    if (head == null)
        return;
    Console.Write(head.GetValue() + " ");
    PrintPrev(head.GetLeft());
    PrintPrev(head.GetRight());


}
static void PrintIn(BInNode<int> head)
{
    if (head == null)
        return;
    PrintIn(head.GetLeft());
    Console.Write(head.GetValue() + " ");
    PrintIn(head.GetRight());


}
static void PrintLevel(BInNode<int> head)
{
    ForTestMhat.Queue<BInNode<int>> queue = new ForTestMhat.Queue<BInNode<int>>();
    queue.Insert(head);
    while (!queue.IsEmpty())
    {
        BInNode<int> temp = queue.Remove();
        Console.WriteLine(temp.GetValue());
        if (temp.HasLeft())
            queue.Insert(temp.GetLeft());
        if (temp.HasRight())
            queue.Insert(temp.GetRight());
    }

}
static void AddNode(BInNode<int> node, int value)
{
    if (value < node.GetValue())
    {
        if (!node.HasLeft())
        {
            node.SetLeft(new BInNode<int>(value));
            return;
        }
        else
            AddNode(node.GetLeft(), value);
    }
    else
    if (!node.HasRight())
    {
        node.SetRight(new BInNode<int>(value));
        return;
    }
    else
        AddNode(node.GetRight(), value);

}

static Node<int> AddStart(Node<int> head, int value) => new Node<int>(value, head);

static Node<int> AddAEnd(Node<int> head, int value)
{
    if (head == null)
        return new Node<int>(value, head);
    Node<int> temp = head;
    for (; temp.HasNext(); temp = temp.Getnext()) ;
    temp.SetNext(new Node<int>(value));
    return head;
}
static void Print(Node<int> head)
{
    for (; head != null; Console.Write(head + " "), head = head.Getnext()) ;
    Console.WriteLine();
}
static void PrintReverse(Node<int> head)
{
    if (head == null) return;
    PrintReverse(head.Getnext());
    Console.Write(head + " ");
}

//---------queue
static ForTestMhat.Queue<int> QueueOver2(ForTestMhat.Queue<int> q)//2,5,4,2,4,5,3,2,1,2,4,5,45;
{
    int count = 0;
    ForTestMhat.Queue<int> temp = new ForTestMhat.Queue<int>();
    while (!q.IsEmpty())
    {
        count++;
        temp.Insert(q.Remove());
    }
    int[] arr = new int[count];
    int i = 0;
    while (!temp.IsEmpty())
    {
        arr[i] = temp.Remove();
        q.Insert(arr[i++]);
    }
    Array.Sort(arr);

    for (i = 0, count = 1; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1])
        {
            count++;
            if (count == 3)
                temp.Insert(arr[i]);
        }
        else count = 1;

    }
    return temp;

}
//------------------main--------------------------------
//Node<int>head=null;
//for (int i = 1; i <=10; i++)
//{
//    head = AddAEnd(head,i);
//}
////[=;]
//Print(head);
//Console.WriteLine();
//PrintReverse(head);
//ForTestMhat.Queue<int> q = new ForTestMhat.Queue<int>();
//ForTestMhat.Queue<int> q1 = new ForTestMhat.Queue<int>();
//q.Insert(2);
//q.Insert(5);
//q.Insert(4);
//q.Insert(5);
//q.Insert(2);
//q.Insert(2);
//q.Insert(8);
//q.Insert(5);
//q1 = QueueOver2(q);
//Console.WriteLine(q1);


void SortStack(ForTestMhat.Stack<int> stack)
{
    ForTestMhat.Queue<int> temp = new ForTestMhat.Queue<int>();
    int count = 0, sum = 0;
    while (stack.IsEmpty())
    {
        count++;
        sum += stack.Top();
        temp.Insert(stack.Pop());
    }
    int avg = sum / count;

    while (count >= 0)
    {
        int z = temp.Remove();
        if (z <= avg)
        {
            stack.Push(z);
        }
        count--;
    }
    while (temp.IsEmpty())
    {
        stack.Push(temp.Remove());
    }
}

static bool IsExist(double num, BInNode<double> t)
{
    if (num == t.GetValue())
        return true;
    if (num < t.GetValue())
    {
        if (t.HasLeft() == false)
        {
            return false;
        }
        return IsExist(num, t.GetLeft());
    }
    if (t.HasRight() == false)
    {
        return false;
    }
    
        return IsExist(num, t.GetRight());
}


static bool IsMatch(BInNode<Power> power, BInNode<double> doubl)
{

    if (power == null)
        return true;
    if (!IsExist(Math.Pow(power.GetValue().GetBasic(), power.GetValue().GetExp()), doubl))
    {
        return false;
    }

    return IsMatch(power.GetLeft(), doubl)&& IsMatch(power.GetRight(), doubl);
    
    
}
//The complexity time is: n^2logn Because for every node in t1
//We over all tree t2

