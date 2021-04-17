using System;
using System.Collections.Generic;
using System.Text;
using Algorithms_ReWritten.Intrerfaces;

namespace Algorithms_ReWritten.HelperClasses
{
    class ArrayDataStructure : ArrayInterface
    {
    //array of oject
        Object[] array;

    //size of array
        int sizeOfArray;

    //Total Values in an array
        int noOfValues;

    //cosntructor to initialize the array
        public ArrayDataStructure( int size)
        {
            array = new Object[size];
            sizeOfArray = size;
        }


    //Implemented methods
        public void addValue(object val, int index)
        {
            //check if the values
            if(noOfValues == array.Length)
            {
                Console.WriteLine("Array FULL!");
            }
            else
            {
                if(array[index] == null)
                {
                    array[index] = val;
                    noOfValues++;

                }
                else
                {
                    for(int i=noOfValues-1; noOfValues> index; i--)
                    {
                        //move the elements forward to make space
                        array[i + 1] = array[i];
                    }
                 
                    //Add value at index
                    array[index] = val;
                 
                    //increment the counter
                    noOfValues++;

                }
            }
        }

        public object caclculateSum()
        {
            object Sum=null;
                foreach (var item in array)
                {
                    if(item is int)
                    {
                        Sum =+ (int)item;
                    }
                }
            return Sum;
        }

        public void deleteAValue(int index)
        {
            /*
             * Before Deleting suppose
             * [0,1,2,3,,4,5,6,7,8,9]
             * 
             * After Deleting
             * [0,1,2,3,,4,5,[EMPTY],7,8,9]
             * 
             * WE Need
             * [0,1,2,3,,4,5,7,8,9,[EMPTY]]
             */

            //TODO

            if(noOfValues == 0)
            {
               Console.WriteLine("Empty Array Exception");
            }
            else
            {
              //shift array values back to the epty index
                for(int i= index; i <= noOfValues-2; i++)
                {
                    array[i] = array[i + 1];
                }
                noOfValues--;
            }

        }

        public object findMaxValue()
        {
            //check for null
            if (noOfValues == 0) { return -1; }
            //local var for MAX
            object Max = null; ;
            for (int i = 0; i < noOfValues; i++)
            {
                Max = ((int)array[i] < (int)array[i + 1]) ? array[i + 1] : array[i];
            }
            return Max;
        }

        public object getValue(int i)
        {
            return array[i];
        }

        public void outputAllValues()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public int searchValue(object v)
        {
           if(noOfValues < 0) return -1;

            foreach (var item in array)
            {
                if(item == v)
                {
                    return (int)item;
                }
            }
            return -1;
        }
    }
}
