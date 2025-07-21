using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.ArrayExamples
{
    public class ArrayPractice
    {
        int[] array= { 45,85,35,4,65,25,42,65,415,8};
        int i;
        int sh;
        //wap to accept 10 numbers in Array and Display
        public void Pro1Array()
        {
            Console.WriteLine("Enter 10 numbers in Array");
            for(i=0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Stored Value in Array");

            foreach(int num in array)
            {
                Console.Write(num+"\t");
            }
        }

        //wap to accept 10 numbers in Array and Display only even
        public void Pro2Array()
        {
            Console.WriteLine("Enter 10 numbers in Array");
            for (i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Stored Value in Array");

            foreach (int num in array)
            {
                if(num%2==0)
                    Console.Write(num + "\t");
            }
        }
        //wap to display greatest in array
        public void MaxinArray()
        {
            int max = array[0];
            foreach(int num in array)
            {
                if(num>max)
                {
                    max = num;
                }
            }
            Console.WriteLine("Greatest in Array is " + max);
        }

        //wap to sort an array using bubble /selection 

        public void BubbleSortArray()
        {
            int len = array.Length;
            int temp;
            Console.WriteLine("Array before sorting");
            foreach (int num in array)
            {
                Console.Write(num+"\t");
            }
           
            //bubble sort logic

            for(int i=0;i<len-1;i++)
            {
                for(int j=0;j<len-1-i;j++)
                {
                    if(array[j]>array[j+1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nArray After sorting");
            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }
        }

        public void SelectionSortArray()
        {
            int len = array.Length;
            int temp;
            Console.WriteLine("Array before sorting");
            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }

            //selction sort logic
            
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = i+1; j < len ; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nArray After sorting");
            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }
        }

        public void LinearSearch()
        {
            Console.WriteLine("enter a number which you want to search");
            sh = Convert.ToInt32(Console.ReadLine());

            bool found=false;

            for(int i=0;i<array.Length;i++)
            {
                if (array[i]==sh)
                {
                    Console.WriteLine("Elent fount at Index " + i);
                    found=true;
                    break;
                }
            }

            if(!found)
            {
                Console.WriteLine("Element not found");
            }
        }

        public void BinarySearch()
        {
            int[] arr = { 10, 15, 25, 35, 45 };
            int min = 0;
            int max = arr.Length - 1;
            bool found = false;

            Console.WriteLine("Enter a number you want to search");
            sh = Convert.ToInt32(Console.ReadLine());
            while(min<=max)
            {
                int mid = (min + max) / 2;
                if (arr[mid]==sh)
                {
                    Console.WriteLine("Elent fount at Index " + mid);
                    found = true;
                    break;
                }
                else if (arr[mid]<sh)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            if(!found)
            {
                Console.WriteLine("Element not found");
            }
        }
        public void InbuildArcrayFunction()
        {
            Console.WriteLine("Orignal Array");
            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }
            Array.Reverse(array);

            Console.WriteLine("\n Array After Reverse");
            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }

            Array.Sort(array);
            Console.WriteLine("\n Array After Sort");
            foreach (int num in array)
            {
                Console.Write(num + "\t");
            }

           int res= Array.BinarySearch(array,85);
            Console.WriteLine("\n Value found at index  " +res);

          
        }
    }
}
