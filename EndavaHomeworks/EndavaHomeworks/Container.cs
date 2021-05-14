
using System;

namespace HomeWork
{
    public class Container<T>: IComparable<T>
    {
        public Container(T data)
        {
            this.Data = data;
        }

        public Container()
        {
        }

        public T Data { get; set; }
        public override string ToString()
        {
            return $"{typeof(T)}: {this.Data} ";
        }

        public int CompareTo(T other)
        {
            int result = 1;
            if (!other.Equals(this.Data))
            {
                result = 0;
            }
            return result;
        }
    }
}
