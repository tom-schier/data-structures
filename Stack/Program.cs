using System;


//Simple Stack implementation to reverse the spelling of a word LIFO

namespace Stack
{
    class Program
    {
        //read in a word and return the word in reverse spelling
        //using the Stack data structure
        static void Main(string[] args) 
        {
            var st = args.Length==0? "": args[0];            
            while (st == "")
            {
                Console.WriteLine("Must enter an argument");
                st = Console.ReadLine();
                
            }

            Stack stack = new Stack();
            for(int i = 0; i < st.Length; i++)
            {
                if (stack.Push(st[i]) == false)
                {
                    Console.WriteLine("Word is too long");
                    return;
                }
            }

            Console.WriteLine($"You entered {st}");
            Console.Write("The revers string is ");
            stack.PrintStack();
        }
    }

    public class Stack
    {
        char[] stack;
        private int maximumSize = 15;
        int top;

        public Stack()
        {
            stack = new char[maximumSize];
            top = -1;
        }

        public bool IsFull()
        {
            return top+1 >= maximumSize;
        }

        public bool IsEmpty()
        {
            return stack.Length == 0;
        }

        public bool Push(char c)
        {
            if (IsFull())
                return false;
            stack[++top] = c;
            return true;
        }

        public char Pop()
        {
            var ret = stack[top];
            top--;
            return ret;
        }

        public void PrintStack()
        {
            while(top >= 0)
            {
                var c = Pop();
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
