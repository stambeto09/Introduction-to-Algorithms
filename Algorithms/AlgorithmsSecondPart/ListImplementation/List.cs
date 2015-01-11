using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresReview
{
    public class List<T> : IEnumerable where T : IComparable
    {
        private const int InitialSize = 4;
        public int tail;
        private T[] array;

        public List()
        {
            this.array = new T[InitialSize];
            this.tail = -1;
        }

        public int Count
        {
            get
            {
                return this.tail;
            }        
        }

        public int Capacity
        {
            get
            {
                return this.array.Length;
            }
        }

        public void Add(T item)
        {
            
            if (this.tail == this.array.Length - 1)
            {
                T[] newArray = new T[this.array.Length * 2];
                for (int index = 0; index < this.array.Length; index++)
                {
                    newArray[index] = this.array[index];
                }

                this.array = newArray;
            }

            this.array[this.tail + 1] = item;
            this.tail++;
        }

        public void Remove(T item)
        {
            for (int index = 0; index < this.array.Length; index++)
            {
                if (this.array[index].CompareTo(item) == 0)
                {
                    T[] newArray = new T[this.array.Length - 1];
                    int newArrayIndex = 0;
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        if (this.array[i].CompareTo(item) != 0)
                        {
                            newArray[newArrayIndex] = this.array[i];
                            newArrayIndex++;
                        }
                    }

                    this.array = newArray;
                    this.tail--;
                }
            }
        }

        public void RemoveAll(T item)
        {
            int occurencesCount = 0;
            for (int index = 0; index < this.array.Length; index++)
            {
                if (this.array[index].CompareTo(item) == 0)
                {
                    occurencesCount++;
                }
            }

            if (occurencesCount != 0)
            {
                T[] newArray = new T[this.array.Length - occurencesCount];
                int newArrayIndex = 0;
                for (int i = 0; i < this.array.Length; i++)
                {
                    if (this.array[i].CompareTo(item) != 0)
                    {
                        newArray[newArrayIndex] = this.array[i];
                        newArrayIndex++;
                    }
                }

                this.array = newArray;
                this.tail -= occurencesCount;
            }
        }

        public bool Contains(T item)
        {
            for (int index = 0; index < this.array.Length; index++)
            {
                if (this.array[index].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void Reverse()
        {
            // for (int index = 0; index <= (array.Length - 1) / 2; index++)
            for (int index = 0; index <= this.tail / 2; index++)
            {
                //T swapValue;
                //swapValue = array[array.Length - 1 - index];
                //array[array.Length - 1 - index] = array[index];
                //array[index] = swapValue;
                T swapValue;
                swapValue = array[this.tail - index];
                array[this.tail - index] = array[index];
                array[index] = swapValue;
            }

        }

        public void Clear()
        {
            this.array = new T[InitialSize];
            this.tail = 0;
        }

        public override string ToString()
        {
            return string.Join(", ", this.array);
        }


        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index <= tail; index++)
            {
                yield return this.array[index];
            }
        }
    }
}
