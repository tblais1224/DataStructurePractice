using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHomework
{
    class Program
    {
        public class Stack
        {
            public ArrayList MyStack = new ArrayList();
            public void Push(char element)
            {
                MyStack.Add(element);
            }
            public char Top()
            {
                return (char)MyStack[Size() - 1];
            }
            public void Pop()
            {
                MyStack.RemoveAt(Size() - 1);
            }
            public int Size()
            {
                return MyStack.Count;
            }
        }
        static void Main(string[] args)
        {
            var newStack = new Stack();
            var word = "reverse me";
            foreach (var c in word)
            {
                newStack.Push(c);
            }

            var newWord = "";
            var sizeOfStack = newStack.Size();
            for (int i = 0; i < sizeOfStack; i++)
            {
                newWord = newWord + newStack.Top();
                newStack.Pop();
            }

            Console.WriteLine(newWord);
        }
    }
}
