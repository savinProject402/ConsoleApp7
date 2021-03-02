using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   public class ClassList<Person> : IEnumerable
        where Person : IComparable<Person>
    {
        private Person[] people = new Person[' '];
        private int count = 0;

        public int Count => this.count;
        public void Add(Person item)
        {
            if (this.count == this.people.Length)
            {
                Array.Resize(ref this.people, this.people.Length + 1);
            }

            this.people[this.count] = item;
            this.count++;
        }
        public void AddRange(ICollection<Person> collection)
        {
            foreach (var item in collection)
            {
                this.Add(item);
            }
        }



        public int IndexOf(Person item)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.people[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }
        public void Insert(int index, Person item)
        {
            if (index < 0 || index >= this.count)
            {
                return;
            }

            var arr = new Person[this.people.Length + 1];
            Array.Copy(this.people, arr, index);
            arr[index] = item;

            for (int i = index; i < this.people.Length; i++)
            {
                arr[i + 1] = this.people[i];
            }

            this.people = arr;
        }
        public bool Remove(Person item)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.people[i].Equals(item))
                {
                    var arr = new Person[this.people.Length - 1];
                    Array.Copy(this.people, arr, i);
                    for (int j = i; i < arr.Length; i++)
                    {
                        arr[i] = this.people[i + 1];
                    }

                    this.people = arr;
                    return true;
                }
            }

            return false;
        }
        public void RemoveAt(int index)
        {
            if (index <= this.count && index > -1)
            {
                var arr = new Person[index];
                Array.Copy(this.people, arr, index);
                this.people = arr;
                this.count = arr.Length;
            }
        }
        public void Sort()
        {
            Array.Sort(this.people);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.people.GetEnumerator();
        }
    }
}
