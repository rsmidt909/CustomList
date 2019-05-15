using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] items = new T[4]; // generic array called items, instantiating and sets 4 spaces in arrray == null

        bool capacityQuestion;
        public CustomList()
        {
           capacityQuestion = false;
        }

        public T this[int i] // generic THIS instance of array with an int variable labeled i
        {
            get { return items[i]; } // returning the item at said index
            set { items[i] = value; } // setting value and said index
        }
        
        public void Add(T value)
        {

            for (int i = 0; i < items.Length; i++)
            {
                CheckCapacity();
                if (items[i] == null)
                {
                    items[i] = value;
                    break;
                }
            }                 
           
        }

        private void CheckCapacity()
        {
            if(items[items.Length] != null)
            {
                capacityQuestion = true;
            }
        }
        
        private void ExpandCapaciity()
        {
            if()
        }
        

    }
}
