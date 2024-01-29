using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Path_Dj
{
    class MinHeap<X> where X : IComparable<X>
    {
        List<X> heap;

        public MinHeap()
        {
            heap = new List<X>();
        }

        public int Size
        {
            get
            {
                return heap.Count;
            }
        }
        public void Add(X value)
        {
            heap.Add(value);
            HeapUp();
        }

        public void Swap(int indx1, int indx2)
        {
            X t = heap[indx1];
            heap[indx1] = heap[indx2];
            heap[indx2] = t;
        }
        public void HeapUp()
        {
            int lastIndex = heap.Count - 1;
            while (lastIndex > 0)    //0 is the index of the root
            {
                int parentIndex = (lastIndex - 1) / 2;
                if (heap[lastIndex].CompareTo(heap[parentIndex]) >= 0)
                    break;
                Swap(lastIndex, parentIndex);
                lastIndex = parentIndex;

            }
        }

        public X GetMin() 
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Error: Heap is empty");

            X minItem = heap[0];
            heap[0] = heap[heap.Count - 1]; //heap.Count-1 is the index of the last item
            heap.RemoveAt(heap.Count - 1);

            HeapDown();

            return minItem;

        }

        public void HeapDown()
        {
            int cIndex = 0; 
            while(true)
            {
                int smallIndex = cIndex;
                int leftChildIndex = (smallIndex * 2) + 1; 
                int rightChildIndex = (smallIndex * 2) + 2;

                if (leftChildIndex < heap.Count && heap[smallIndex].CompareTo(heap[leftChildIndex])>0)
                    smallIndex = leftChildIndex;
                if (rightChildIndex < heap.Count && heap[smallIndex].CompareTo(heap[rightChildIndex])>0)
                    smallIndex = rightChildIndex;

                if (smallIndex == cIndex)
                    break;

                Swap(cIndex, smallIndex);
                cIndex = smallIndex;


            }
        }
    }
}
