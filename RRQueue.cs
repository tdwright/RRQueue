using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRQueue
{
    class RRQueue : Queue<double>
    {
        private int capacity;
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
                while (this.Count > this.capacity) this.Dequeue();
            }
        }

        public RRQueue(int _capacity)
        {
            this.capacity = _capacity;
        }

        public new void Enqueue(double item)
        {
            base.Enqueue(item);
            if (this.Count > this.capacity) this.Dequeue();
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
