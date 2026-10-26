using System;

class Program
{
    static int CountNumArray(int[] array, int num)
    {
        int lastIndex = array.Length-1;

        int Count(int[] array, int num, int index, int lastIndex)
        {
            int count = 0;

            if(index > lastIndex) return 0;

            if(num == array[index]) count = 1;

            return count + Count(array,num,index+1,lastIndex);
        }

        return Count(array,num,0,lastIndex);
    }
    static void Main()
    {
        Console.WriteLine(CountNumArray(new int[] {1,5,3,4,5,6,7,8}, 8));
    }
}