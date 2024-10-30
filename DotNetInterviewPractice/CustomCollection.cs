using System.Collections;

namespace CustomCollections {
    public class CustomCollection<T> : IEnumerable<T>
    {
        private List<T> Elements {get;set;}

        public CustomCollection()
        {
            Elements = new List<T>();
        }

        public void Dsiplay() {
            if(Elements.Any())
            {
                foreach(var element in Elements)
                {
                    Console.Write(element + " ");
                }
            }
        }

        public void AddElement(T element)
        {
            Elements.Add(element);
        }

        public void RemoveElementAtInted(int index)
        {
            if(index <0 || index > Elements.Count - 1)
                throw new ArgumentOutOfRangeException("Index is out of range");
            
            Elements.RemoveAt(index);
        }

        public void Remove(T element)
        {
            if(!Elements.Contains(element))
                throw new ArgumentException("CustomCollection does not contain such an element");
            Elements.Remove(element);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
