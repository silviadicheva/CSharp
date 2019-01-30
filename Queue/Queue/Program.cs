using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        public class Number
        {
            public int value;
            public Number next;

            public Number(int value)
            {
                this.value = value;
                this.next = null;
            }
        }
        public class Queue
        {
            Number basis;
            Number continued;

            public Queue()
            {
            }
            public void EnQueue(int value)
            {
                Number n = new Number(value);
                if (basis == null)
                {
                    basis = n;
                    continued = n;
                }
                else
                {
                    continued.next = n;
                    continued = n;
                }
            }
            public int DeQueue()
            {
                if (basis == null)
                {
                    Exception e = new Exception();
                    throw e;
                }
                else
                {
                    int value = basis.value;
                    basis = basis.next;
                    return value;
                }
            }
            public int Peek()
            {
                if (basis == null)
                {
                    Exception c = new Exception();
                    throw c;
                }
                else
                {
                    return basis.value;
                }
            }
        }
        static void Main(string[] args)
        {
            Queue q = new Queue();
            for (int i = 0; i <= 10; i++)
            {
                q.EnQueue(i);
            }
            
            Console.WriteLine(q.DeQueue());
            

        }
    }
        
}
