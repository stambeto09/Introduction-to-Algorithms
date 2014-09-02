namespace _6._5_7.QueueUsingPriorityQueue
{
    using PriorityQueue;
    using System;

    /// <summary>
    /// 6.5-7 Show how to implement a first-in, first out queue with a priority queue...
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Queue<T> : PriorityQueue<T>
    {
        public Queue()
        {
        }

        // Dequeue
        public override int ExtractMax()
        {
            
            if (base.tree.HeapSize <= 0)
            {
                throw new ArgumentException("Heap underflow");
            }

            int maxValue = base.tree.Nodes[0].Value;
            base.tree.Nodes[0].Value = base.tree.Nodes[base.tree.HeapSize - 1].Value;
            base.tree.Nodes.RemoveAt(0);

            return maxValue;
        }

        public override void IncreaseKey(int index, int value)
        {
            base.tree.Nodes[index].Value = value;
        }
    }
}
