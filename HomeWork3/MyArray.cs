using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class MyArray : IOutput, IMath ,ISort
    {
        public int[] Arr { get; set; }

        public MyArray(int[] arr) { Arr = arr; }
        public void show()
        {
            foreach (var a in Arr)
            {
                Console.WriteLine(a);
            }
        }

        public void show(string info)
        {
            foreach (var a in Arr)
            {
                Console.WriteLine(info + " " + a.ToString());
            }
        }

        public int Max()
        {
            int temp = 0;
            foreach(int a in Arr)
            {
                if (temp < a)
                    temp = a;
            }
            return temp;

        }
        public int Min()
        {
            int temp = 0;
            foreach (int a in Arr)
            {
                if (temp > a)
                    temp = a;
            }
            return temp;
        }
        public float Avg()
        {
            int av = 0;
            int i = 0;

            foreach(int a in Arr)
            {
                av += a;
                i++;
            }

            return av/i;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int a in Arr)
            {
                if (valueToSearch == a)
                    return true;
            }
            
            return false;
        }

        public void SortAsc()
        { 
            int index;
            int current_number;
            for (int i = 0; i < Arr.Length; i++)
            {
                index = i;
                current_number = Arr[i];
                while(index > 0 && current_number < Arr[index - 1])
                {
                    Arr[index] = Arr[index - 1];
                    index--;
                }
                Arr[index] = current_number;
            }    
        }
        public void SortDesc()
        {
            int index;
            int current_number;
            for (int i = 0; i < Arr.Length; i++)
            {
                index = i;
                current_number = Arr[i];
                while (index > 0 && current_number > Arr[index - 1])
                {
                    Arr[index] = Arr[index - 1];
                    index--;
                }
                Arr[index] = current_number;
            }
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
                this.SortAsc();
            else
                this.SortDesc();
                    
        }



    }
}
