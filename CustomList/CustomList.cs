using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        T[] items = new T[4]; // generic array called items, instantiating and sets 4 spaces in arrray == null
        public T[] items2;
        bool capacityQuestion;
        int capacity;
        int arrayCounter;
        int lengthCounter;
        int items2Counter;        
        int arraySpecificCounter;
        string collection;
        public int Count { get { return arrayCounter; } }
        public int currentlyOccupiedArray { get { return arrayCounter-1; } }
        public int Capacity { get { return capacity; } }
        int counter;
        


        public CustomList()
        {
           capacityQuestion = false;
            capacity = 4;
            arrayCounter = 0;
            items2Counter = 0;
            arraySpecificCounter = 0;
            collection = null;
            
           
            
        }
        public int Length()
        {
            lengthCounter = 0;
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
            items[arrayCounter] = value;
            ResetItems2Counter();
            AddArrayCounter();
            ResetCapacityQuestion();

        }
        
        public void Remove(T value)
        {
            CheckCapacity();
            IncreaseCapacity();
            CreateNewArray();
            CopyContents();
            RenameArray();
            ResetCapacityQuestion();
            ResetItems2Counter();
            Length();
            FindingSpecificValue(value);
            VariableShift();
            ResetArraySpecificCounter();
            RemoveArrayCounter();
            
        }

        public override string ToString()
        {
            ResetCollection();
            for(int i = 0; i < arrayCounter; i++)
            {
                if(collection == null)
                {
                    collection += items[i].ToString();
                }
                else
                {
                    collection += string.Format(", {0}", items[i]);
                }
            }
            return collection;
                      
        }

        
        //----------------------------------------------------------------------------------------------------
        private void CheckCapacity()
        {  
            if(arrayCounter==capacity)
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
                items2 = new T[capacity];
            }
        }
        
        private void CopyContents()
        {
            if (capacityQuestion == true)
            {
                foreach (T value in items)
                {
                    
                    items2[items2Counter] = items[items2Counter];
                    items2Counter++;
                }
            }
        }

        public void RenameArray()
        {   if (capacityQuestion == true)
            {
                items = items2;
            }
        }

        private void ResetCapacityQuestion()
        {
            capacityQuestion = false;
        }


        public void AddArrayCounter()
        {
            arrayCounter++;
        }

        public void AddArrayRemoveCounter()
        {
            arrayCounter++;
        }

        public void ResetItems2Counter()
        {
            items2Counter = 0;
        }
        public void ResetArraySpecificCounter()
        {
            arraySpecificCounter = 0;
        }

        public void RemoveArrayCounter()
        {
            arrayCounter--;
        }

        public void FindingSpecificValue(T value)
        {
            for (int i = 0; i <= arraySpecificCounter; i++, arraySpecificCounter++)
            {
                if (items[i].Equals(value) == true)
                {                   
                    break;
                }
            }            
        }

        public void VariableShift()
        {
            for(int i =(arraySpecificCounter + 2); i <= lengthCounter;i++, arraySpecificCounter++)
            {
                items[arraySpecificCounter] = items[arraySpecificCounter + 1];
            }
        }
        
        public void ResetCollection()
        {
            collection = null;
        }

        public IEnumerator GetEnumerator()
        {
            for(int index = 0; index < currentlyOccupiedArray; index++)
            {
                yield return items[index];
            }
        }

        public static CustomList<T> operator +(CustomList<T> FirstList, CustomList<T> SecondList)
        {
            CustomList<T> ThirdList = new CustomList<T>();            
            for (int i = 0; i < (FirstList.arrayCounter & SecondList.arrayCounter); i++)
            {
                if (i < FirstList.arrayCounter)
                {
                    ThirdList.Add(FirstList[i]);
                    
                }

                if (i < SecondList.arrayCounter)
                {
                    ThirdList.Add(SecondList[i]);
                    
                }
            }
            return ThirdList;
        }

        public static CustomList<T> operator -(CustomList<T> FirstList, CustomList<T> SecondList)
        {
            CustomList<T> ThirdList = new CustomList<T>();

            foreach(T value in FirstList)
            {
                ThirdList.Add(value);
                for (int i = 0; i <= (SecondList.currentlyOccupiedArray); i++) { 

                    if (value.Equals(SecondList[i])){
                        ThirdList.Remove(value);
                        break;
                    }
            
                 }
                
            }
            return ThirdList;
        }


    }
}
