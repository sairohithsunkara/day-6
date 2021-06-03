using System;
using System.Collections;
class Collections1
{
  public static void Main ()
  {
    // ArrayList alist = new ArrayList();
    // alist.Add("Hello");
    // alist.Add(101);
    // alist.Add(10.00);
    // for(int i=0;i<alist.Count;i++) {
    //     Console.WriteLine(alist[i]);
    // }
    // Hashtable htable = new Hashtable();
    // htable.Add(101,"hi");
    // htable.Add(102,"hash");
    // htable.Add(103,1001);
    // ICollection keys = htable.Keys;
    // foreach(var item in keys) {
    //     Console.WriteLine(item+":-"+htable[item]);
    // }
    // Queue queue = new Queue ();
    //   queue.Enqueue ("C#");
    //   queue.Enqueue ("PHP");
    //   queue.Enqueue ("JAVA");
    //   queue.Dequeue ();
    //   Console.WriteLine (queue.Peek ());
    Stack stack = new Stack ();
      stack.Push ("C#");
      stack.Push ("PHP");
      stack.Push ("JAVA");
      stack.Pop ();
      Console.WriteLine (stack.Peek ());
  }
}
