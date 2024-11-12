using System.Collections;
using Microsoft.Extensions.DependencyInjection;

namespace PlayGround
{
    public class CustomDI : Microsoft.Extensions.DependencyInjection.IServiceCollection
    {
        public ServiceDescriptor this[int index] { get => this[index]; set => this[index] = this[index]; }

        public int Count => this.Count;

        public bool IsReadOnly => true;

        public void Add(ServiceDescriptor item)
        {
            this.Add(item);
        }

        public void Clear()
        {
            this.Clear();
        }

        public bool Contains(ServiceDescriptor item)
        {
            return this.Contains(item);
        }

        public void CopyTo(ServiceDescriptor[] array, int arrayIndex)
        {
            this.CopyTo(array, arrayIndex);
        }

        public IEnumerator<ServiceDescriptor> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int IndexOf(ServiceDescriptor item)
        {
            return this.IndexOf(item);
        }

        public void Insert(int index, ServiceDescriptor item)
        {
            this.Insert(index, item);
        }

        public bool Remove(ServiceDescriptor item)
        {
            return this.Remove(item);
        }

        public void RemoveAt(int index)
        {
            this.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}