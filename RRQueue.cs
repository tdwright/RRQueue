using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRQueue
{
    class RRQueue : Queue<double>
    {

        public int capacity;

        public RRQueue(int _capacity)
        {
            capacity = _capacity;
        }

        public new void Enqueue(double item)
        {
            base.Enqueue(item);
            if (this.Count > capacity) this.Dequeue();
        }

        public double Average
        {
            get
            {
                return this.Average();
            }
        }
    }
}
