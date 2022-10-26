using System;
using System.Collections;

namespace ITEC104_ENGAGING_ACTIVITY__STACK_VENANCIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");

            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            st.Push('V');
            st.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.Write("Current stack: ");

            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Removing Values");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.Write("Current stack:");           

            foreach (char c in st)
            {
                Console.WriteLine(c + " ");
            }
            Console.ReadKey(true);


        }
    }
}
