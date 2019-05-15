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
        T[] items2;
        bool capacityQuestion;
        int capacity;
        int capacityCounter;
        int lengthCounter;




        public CustomList()
        {
           capacityQuestion = false;
            capacity = 4;
            capacityCounter = 0;
        }
        public int Length()
        {
            foreach (T value in items)
            {
                lengthCounter++;

            }
            return lengthCounter;
        }

        public T this[int i] // generic THIS instance of array with an int variable labeled i
        {
            get { return items[i]; } // returning the item at said index
            set { items[i] = value; } // setting value and said index
        }
        
        public void Add(T value)
        {
            CheckCapacity();
            IncreaseCapacity();
            CreateNewArray();
            CopyContents();
            RenameArray();


            for (int i = 0; i < Length(); i++)
            {
                CheckCapacity();
                if (items[i] == null)
                {
                    items[i] = value;
                    break;
                }
            }                 
           
        }
        //----------------------------------------------------------------------------------------------------
        private void CheckCapacity()
        {  
            if(items[Length()] != null)
            {
                capacityQuestion = true;
            }
        }
        private void IncreaseCapacity()
        {
            if(capacityQuestion == true)
            {
                capacity *= 2;
            }
        }
        public void CreateNewArray()
        {
            if(capacityQuestion == true)
            {
                T[] items2 = new T[capacity];
            }
        }
        
        private void CopyContents()
        {
            foreach (T value in items)
            {
                int items2Counter = 0;
                items2[items2Counter] = items[items2Counter];
                items2Counter++;
            }
        }

        public void RenameArray()
        {
            items = items2;
        }
    }
}
