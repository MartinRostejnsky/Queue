using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class CustomerQueue
    {
        protected Queue<int> q = new Queue<int>();
        public int QueueLength { get { return q.Count; } }
        public int QueueCapacity { get; set; } = 1000;

        public int Arrive()
        {
            if (QueueLength == 1000)
            {
                throw new Exception("Queue is full!");
            }

            int num;
            do
            {
                num = Random.Shared.Next(0, 1000);
            } while (q.Contains(num));

            q.Enqueue(num);
            return num;
        }

        public int Serve()
        {
            if (QueueLength == 0)
            {
                throw new Exception("Queue is empty!");
            }
            else
            {
                return q.Dequeue();
            }
        }
    }
}
